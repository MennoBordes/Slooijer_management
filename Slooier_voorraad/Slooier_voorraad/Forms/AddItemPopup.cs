using Npgsql;
using NpgsqlTypes;
using Slooier_voorraad.Classes.CustomMessageBox;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Slooier_voorraad.Forms
{
	public partial class AddItemPopup : Form
	{
		string ConnString;
		public AddItemPopup(string ConnString)
		{
			InitializeComponent();
			this.ConnString = ConnString;
		}

		private void AddItemPopup_Shown(object sender, EventArgs e)
		{
			GetBenamingen();
		}

		private void GetBenamingen()
		{
			CbbBenaming.Items.Clear();
			try
			{
				using (var conn = new NpgsqlConnection(ConnString))
				{
					conn.Open();
					string SelectQuery = "SELECT afdelingnaam FROM afdelingen";
					using (var cmd = new NpgsqlCommand(SelectQuery, conn))
					{
						using (var reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								CbbBenaming.Items.Add(reader.GetString(0));
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				FlexibleMessageBox.Show(ex.Message, "An Error Occured");
			}
		}

		private void BtnAddToDb_Click(object sender, EventArgs e)
		{
			try
			{
				if (CbbBenaming.SelectedIndex < 0)
				{
					FlexibleMessageBox.Show("Geen Afdeling geselecteerd.\nSelecteer A.U.B. een afdeling!", "Selecteer een afdeling!");
					return;
				}

				string Afdeling = CbbBenaming.GetItemText(CbbBenaming.SelectedItem);
				if (TxbNummer.Text.Length == 0)
				{
					string TekstToDisplay = "Let op!\nEr is geen nummer ingevuld.\nWeet u zeker dat er geen nummer ingevuld hoeft te worden?\n\nJa om door te gaan, Nee om een nummer in te vullen";
					DialogResult result = FlexibleMessageBox.Show(TekstToDisplay, "Geen nummer ingevuld", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if (result == DialogResult.No) { return; }
				}
				string Nummer = TxbNummer.Text;

				if (TxbOmschrijving.Text.Length == 0)
				{
					string TekstToDisplay = "Let op!\nEr is geen omschrijving ingevuld.\nWeet u zeker dat er geen omschrijving ingevuld hoeft te worden?\n\nJa om door te gaan, Nee om een omschrijving in te vullen";
					DialogResult result = FlexibleMessageBox.Show(TekstToDisplay, "Geen omschrijving ingevuld", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
					if (result == DialogResult.No) { return; }
				}
				string Omschrijving = TxbOmschrijving.Text;

				if (TxbPrijs.Text.Length < 4)
				{
					string TekstToDisplay = "Let op!\nEr is geen geldige prijs ingevuld.\nVul een geldige prijs in bijv:\n120,00\t0,99\t25,22\t220,0\t22,20";
					FlexibleMessageBox.Show(TekstToDisplay, "Geen prijs ingevuld", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}
				var clone = (CultureInfo)CultureInfo.InvariantCulture.Clone();
				clone.NumberFormat.NumberDecimalSeparator = ",";
				clone.NumberFormat.NumberGroupSeparator = ".";
				string value = TxbPrijs.Text;
				decimal Prijs = decimal.Parse(value, clone);

				double Voorraad = 0;
				if (TxbVoorraad.Text.Length > 0)
				{
					Voorraad = int.Parse(TxbVoorraad.Text);
				}

				using (var conn = new NpgsqlConnection(ConnString))
				{
					conn.Open();
					using (var cmd = new NpgsqlCommand())
					{
						cmd.Connection = conn;
						cmd.CommandText = string.Format(@"SELECT nummer FROM voorraad WHERE nummer LIKE @nummer");
						cmd.Parameters.AddWithValue("nummer", Nummer);
						cmd.Prepare();
						using (var reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								string text = $"Het opgegeven nummer bestaat al: {Nummer}";
								string header = $"{Nummer} bestaat al";
								FlexibleMessageBox.Show(text, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
								return;
							}
						}
					}
					int IdRef = int.MinValue;
					string querySelect = "SELECT id FROM afdelingen WHERE afdelingnaam = @Afdeling;";
					using (var cmd = new NpgsqlCommand(querySelect, conn))
					{
						var ParAfd = new NpgsqlParameter("Afdeling", NpgsqlDbType.Text)
						{
							Value = Afdeling
						};
						cmd.Parameters.Add(ParAfd);
						cmd.Prepare();
						using (var SqlReader = cmd.ExecuteReader())
						{
							while (SqlReader.Read())
							{
								IdRef = SqlReader.GetInt32(0);
							}
						}
					}
					try
					{
						if (IdRef != int.MinValue)
						{
							string queryInsert = "INSERT INTO voorraad(nummer, omschrijving, voorraad, afdeling, prijs) VALUES (@Nummer, @Omschrijving, @Voorraad, @Afdeling, @Prijs);";
							using (var cmd = new NpgsqlCommand(queryInsert, conn))
							{
								// TODO
								// GAAT NOT NIET HELEMAAL LEKKER
								var ParNum = new NpgsqlParameter("Nummer", NpgsqlDbType.Text) { Value = Nummer };
								cmd.Parameters.Add(ParNum);
								var ParOms = new NpgsqlParameter("Omschrijving", NpgsqlDbType.Text) { Value = Omschrijving };
								cmd.Parameters.Add(ParOms);
								var ParVoo = new NpgsqlParameter("Voorraad", NpgsqlDbType.Integer) { Value = Voorraad };
								cmd.Parameters.Add(ParVoo);
								var ParAfd = new NpgsqlParameter("Afdeling", NpgsqlDbType.Integer) { Value = IdRef };
								cmd.Parameters.Add(ParAfd);
								var ParPri = new NpgsqlParameter("Prijs", NpgsqlDbType.Integer) { Value = Prijs };
								cmd.Parameters.Add(ParPri);
								cmd.Prepare();
								cmd.ExecuteNonQuery();
							}
							FlexibleMessageBox.Show("Toegevoegd");
						}
					}
					catch (Exception ex)
					{
						FlexibleMessageBox.Show("OEPS\n" + ex.Message, "An Error Occured");
					}
				}
			}
			catch (Exception ex)
			{
				FlexibleMessageBox.Show(ex.Message, "An Error Occured");
			}
		}


		private void TxbPrijs_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Is the key pressed an number or a comma?
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
			{
				e.Handled = true;
			}
			// Only allow one comma 
			if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
			{
				e.Handled = true;
			}
		}

		private void TxbVoorraad_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Is the key pressed a number?
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void TxbNummer_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool res = char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back;
			if (!res)
			{
				e.Handled = true;
			}
		}
	}
}
