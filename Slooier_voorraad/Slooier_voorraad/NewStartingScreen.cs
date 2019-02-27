using Npgsql;
using NpgsqlTypes;
using Slooier_voorraad.Classes.CustomMessageBox;
using Slooier_voorraad.Forms;
using Slooier_voorraad.Forms.AddDataPopup;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Slooier_voorraad
{
	public partial class NewStartingScreen : Form
	{
		public string ConnString = string.Format($"Server={Properties.Settings.Default.Server}; " +
			$"User Id={Properties.Settings.Default.UserName}; " +
			$"Database={Properties.Settings.Default.Database}; " +
			$"Port={Properties.Settings.Default.Port}; " +
			$"Password={Properties.Settings.Default.password}");
		public NewStartingScreen()
		{
			InitializeComponent();
		}

		private void instellingenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool IsOpen = false;
			foreach (Form f in Application.OpenForms)
			{
				if (f.Text == "Instellingen")
				{
					IsOpen = true;
					f.Focus();
					break;
				}
			}
			if (IsOpen == false)
			{
				SettingForm f = new SettingForm
				{
					MdiParent = this
				};
				f.Show();
			}
		}

		private void sluitenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foreach (Form frm in MdiChildren)
			{
				frm.Visible = false;
				frm.Dispose();
			}
		}

		private void afdelingToevoegenToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool IsOpen = false;
			foreach (Form f in Application.OpenForms)
			{
				if (f.Text == "Afdeling toevoegen")
				{
					IsOpen = true;
					f.Focus();
					break;
				}
			}
			if (!IsOpen)
			{
				AddAfdelingPopup popup = new AddAfdelingPopup(ConnString)
				{
					MdiParent = this
				};
				popup.Show();
			}
		}

		private void artikelToevoegenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool IsOpen = false;
			foreach (Form f in Application.OpenForms)
			{
				if (f.Text == "Item toevoegen")
				{
					IsOpen = true;
					f.Focus();
					break;
				}
			}
			if (!IsOpen)
			{
				AddItemPopup popup = new AddItemPopup(ConnString)
				{
					MdiParent = this
				};
				popup.Show();
			}
		}

		private void bestandToevoegenToolStripMenuItem1_Click(object sender, EventArgs e)
		{
      using (OpenFileDialog FileReader = new OpenFileDialog())
      {
        FileReader.InitialDirectory = Properties.Settings.Default.InitialDir;
        FileReader.Filter = "csv files(*.csv)|*.csv";
        FileReader.RestoreDirectory = true;
        if(FileReader.ShowDialog() == DialogResult.OK)
        {
          var added = AddDataToExistingDB(FileReader.FileName);
        }
        else
        {
          string text = "Er was geen bestand geselecteerd,\nProbeer het alstublieft opnieuw.";
          string header = "Geen bestand geselecteerd!";
          FlexibleMessageBox.Show(text, header);
        }
      }
		}

    private List<string> AddDataToExistingDB(string FilePath)
    {
      List<string> addedData = new List<string>();
      try
      {
        var File = FilePath;
        string afdelingNaam = string.Empty;
        using (var reader = new StreamReader(File))
        {
          while (!reader.EndOfStream)
          {
            var line = reader.ReadLine();
            var values = line.Split(';');
            if(values[0]!= "")
            {
              afdelingNaam = values[0].ToLower();
              using(var conn = new NpgsqlConnection(ConnString))
              {
                conn.Open();
                bool exists = false;
                using(var cmd = new NpgsqlCommand())
                {
                  cmd.Connection = conn;
                  cmd.CommandText = string.Format(@"SELECT afdelingnaam FROM afdelingen WHERE afdelingnaam = @naam");
                  cmd.Parameters.AddWithValue("naam", afdelingNaam);
                  using(var SqlReader = cmd.ExecuteReader())
                  {
                    while (SqlReader.Read())
                    {
                      if(SqlReader.GetString(0).ToLower() == afdelingNaam)
                      {
                        exists = true;
                        break;
                      }
                    }
                  }
                }
                if (!exists)
                {
                  using(var cmd = new NpgsqlCommand())
                  {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format(@"INSERT INTO afdelingen(afdelingnaam) VALUES(@NieuweNaam);");
                    cmd.Parameters.AddWithValue("NieuweNaam", afdelingNaam);
                    cmd.ExecuteNonQuery();
                  }
                  addedData.Add(afdelingNaam);
                }
              }
            }
            if(values[1] != "" || values[3] != "")
            {
              using(var conn = new NpgsqlConnection(ConnString))
              {
                conn.Open();
                bool exists = false;
                using(var cmd = new NpgsqlCommand())
                {
                  cmd.Connection = conn;
                  cmd.CommandText = string.Format(@"SELECT nummer, omschrijving FROM voorraad WHERE nummer = @nummer AND omschrijving = @omschrijving;");
                  cmd.Parameters.AddWithValue("nummer", values[1]);
                  cmd.Parameters.AddWithValue("omschrijving", values[3]);
                  using(var SqlReader = cmd.ExecuteReader())
                  {
                    while (SqlReader.Read())
                    {
                      string res1 = SqlReader.GetString(0).ToLower();
                      string res2 = SqlReader.GetString(1).ToLower();
                      if(res1 == values[1].ToLower() && res2 == values[3].ToLower())
                      {
                        exists = true;
                        break;
                      }
                    }
                  }
                }
                if (!exists)
                {
                  int AfdelingId = int.MinValue;
                  using(var cmd = new NpgsqlCommand())
                  {
                    cmd.Connection = conn;
                    cmd.CommandText = string.Format(@"SELECT id FROM afdelingen WHERE afdelingnaam = @afdelingnaam;");
                    cmd.Parameters.AddWithValue("afdelingnaam", afdelingNaam);
                    using (var SqlReader = cmd.ExecuteReader())
                    {
                      while (SqlReader.Read())
                      {
                        AfdelingId = SqlReader.GetInt32(0);
                      }
                    }
                  }
                  if(AfdelingId != int.MinValue)
                  {
                    string Nummer = values[1];
                    string Omschrijving = values[3];
                    int Voorraad = 0;

                    string PrijsInput = values[4];
                    
                    double temp = 0.0;
                    
                    // ############################
                    // TODO: Testen zonder bestaande DB
                    double Prijs = GetDouble(PrijsInput, temp);

                    //continue;

                    using (var cmd = new NpgsqlCommand())
                    {
                      cmd.Connection = conn;
                      cmd.CommandText = string.Format(@"INSERT INTO voorraad(nummer, omschrijving, voorraad, afdeling, prijs) VALUES(@Nummer, @Omschrijving, @Voorraad, @AfdelingId, @Prijs);");
                      var ParNum = new NpgsqlParameter("Nummer", NpgsqlDbType.Text) { Value = Nummer };
                      cmd.Parameters.Add(ParNum);
                      var ParOms = new NpgsqlParameter("Omschrijving", NpgsqlDbType.Text) { Value = Omschrijving };
                      cmd.Parameters.Add(ParOms);
                      var ParVoo = new NpgsqlParameter("Voorraad", NpgsqlDbType.Integer) { Value = Voorraad };
                      cmd.Parameters.Add(ParVoo);
                      var ParAfd = new NpgsqlParameter("AfdelingId", NpgsqlDbType.Integer) { Value = AfdelingId };
                      cmd.Parameters.Add(ParAfd);
                      var ParPri = new NpgsqlParameter("Prijs", NpgsqlDbType.Double) { Value = Prijs };
                      cmd.Parameters.Add(ParPri);
                      cmd.Prepare();
                      cmd.ExecuteNonQuery();
                      // TODO
                      // afmaken volgens AddItemPopup en AddOrRemoveItems
                    }
                    addedData.Add($"{values[1]} {values[3]}");
                  }
                }
              }
            }
          }
        }
      }
      catch (Exception ex)
      {
        FlexibleMessageBox.Show(ex.Message);
      }
      return addedData;
    }

    private static double GetDouble(string value, double defaultValue)
    {
      double result;

      if(!double.TryParse(value,System.Globalization.NumberStyles.Any,CultureInfo.CurrentCulture, out result) &&
        !double.TryParse(value, System.Globalization.NumberStyles.Any, CultureInfo.GetCultureInfo("en-US"), out result) &&
        !double.TryParse(value, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out result))
      {
        result = defaultValue;
      }
      return result;
    }

		private void NewStartingScreen_Load(object sender, EventArgs e)
		{
			BackColor = Properties.Settings.Default.BackGroundColor;
      this.MenuBar.Items.OfType<ToolStripMenuItem>().ToList().ForEach(x =>
      {
        x.MouseHover += (obj, arg) => ((ToolStripDropDownItem)obj).ShowDropDown();
      });
		}

		private void voorraadBekijkenToolStripMenuItem_Click(object sender, EventArgs e)
		{
      bool IsOpen = false;
      foreach (Form f in Application.OpenForms)
      {
        if (f.Text == "Voorraad")
        {
          IsOpen = true;
          f.Focus();
          break;
        }
      }
      if (!IsOpen)
      {
        Voorraad popup = new Voorraad(ConnString)
        {
          MdiParent = this
        };
        popup.Show();
      }
    }
	}
}
