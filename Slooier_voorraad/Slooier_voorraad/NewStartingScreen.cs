using Slooier_voorraad.Forms;
using Slooier_voorraad.Forms.AddDataPopup;
using System;
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
      }
      catch (Exception ex)
      {
        FlexibleMessageBox.Show(ex.Message);
      }
      return addedData;
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
