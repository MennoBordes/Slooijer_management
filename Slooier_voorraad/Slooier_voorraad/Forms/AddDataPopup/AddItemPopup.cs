using Npgsql;
using NpgsqlTypes;
using Slooier_voorraad.Classes.CommonFunctions;
using Slooier_voorraad.Classes.CustomMessageBox;
using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Slooier_voorraad.Forms.AddDataPopup
{
	public partial class AddItemPopup : Form
	{
		string ConnString;
		public AddItemPopup()
		{
			InitializeComponent();
			ConnString = Properties.Settings.Default.DBConnectionString;
		}

		private void AddItemPopup_Shown(object sender, EventArgs e)
		{
			GetBenamingen();
		}

		private void AddItemPopup_SizeChanged(object sender, EventArgs e)
		{
			// Set panels to center of the Form
			CommonFunctions.SetPanelDimensions(PMain, ClientSize);
			CommonFunctions.SetPanelDimensions(PSecundary, PMain);
			CommonFunctions.SetPanelDimensions(FlpMain, PSecundary);
		}

		private void AddItemPopup_Load(object sender, EventArgs e)
		{
			// Set panels to center of the Form
			CommonFunctions.SetPanelDimensions(PMain, ClientSize);
			CommonFunctions.SetPanelDimensions(PSecundary, PMain);
			CommonFunctions.SetPanelDimensions(FlpMain, PSecundary);
			BackColor = Properties.Settings.Default.BackGroundColor;
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

				string Nummer = TxbNummer.Text;
				if (IsStringValid(Nummer))
				{
					if (Nummer.Length == 0)
					{
						string TekstToDisplay = "Let op!\nEr is geen nummer ingevuld.\nWeet u zeker dat er geen nummer ingevuld hoeft te worden?\n\nJa om door te gaan, Nee om een nummer in te vullen";
						DialogResult result = FlexibleMessageBox.Show(TekstToDisplay, "Geen nummer ingevuld", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
						if (result == DialogResult.No) { return; }
					}
				}
				else
				{
					StringInValidDisplay("Nummer");
					return;
				}

				string Omschrijving = TxbOmschrijving.Text;
				if (IsStringValid(Omschrijving))
				{
					if (Omschrijving.Length == 0)
					{
						string TekstToDisplay = "Let op!\nEr is geen omschrijving ingevuld.\nWeet u zeker dat er geen omschrijving ingevuld hoeft te worden?\n\nJa om door te gaan, Nee om een omschrijving in te vullen";
						DialogResult result = FlexibleMessageBox.Show(TekstToDisplay, "Geen omschrijving ingevuld", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
						if (result == DialogResult.No) { return; }
					}
				}
				else
				{
					StringInValidDisplay("Omschrijving");
					return;
				}


				if (TxbPrijs.Text.Length < 4)
				{
						string TekstToDisplay = "Er is geen geldige prijs ingevuld. Vul een geldige prijs in.\nBijvoorbeeld:\t120,00\t0,99\t25,22\t220,0\t18,20";
						FlexibleMessageBox.Show(TekstToDisplay, "Geen prijs ingevuld", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
				}
				var regexItem = new Regex("^[0-9,]*$");
				if (!regexItem.IsMatch(TxbPrijs.Text))
				{
					string message = $"De opgegeven waarde in Prijs mag geen andere tekens bevatten dan:\n(0-9 ,)";
					string header = "Verkeerd teken gevonden";
					FlexibleMessageBox.Show(message, header, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					return;
				}

				var clone = (CultureInfo)CultureInfo.InvariantCulture.Clone();
				clone.NumberFormat.NumberDecimalSeparator = ",";
				clone.NumberFormat.NumberGroupSeparator = ".";
				string value = TxbPrijs.Text;
				double Prijs = double.Parse(value, clone);

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
					int AfdelingId = int.MinValue;
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
								AfdelingId = SqlReader.GetInt32(0);
							}
						}
					}
					try
					{
						if (AfdelingId != int.MinValue)
						{
							string queryInsert = "INSERT INTO voorraad(nummer, omschrijving, voorraad, afdeling, prijs) VALUES (@Nummer, @Omschrijving, @Voorraad, @AfdelingId, @Prijs);";
							using (var cmd = new NpgsqlCommand(queryInsert, conn))
							{
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
							}
							FlexibleMessageBox.Show("Het artikel is toegevoegd", "Succes");
							TxbNummer.Clear();
							TxbOmschrijving.Clear();
							TxbPrijs.Clear();
							TxbVoorraad.Clear();
							CbbBenaming.SelectedIndex = -1;
						}
					}
					catch (Exception ex)
					{
						FlexibleMessageBox.Show(ex.Message, "ER IS IETS FOUT GEGAAN!");
					}
				}
			}
			catch (Exception ex)
			{
				FlexibleMessageBox.Show(ex.Message, "ER IS IETS FOUT GEGAAN!");
			}
		}

		private void TxbPrijs_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Is the key pressed an number or a comma?
			if (e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
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
			bool res = char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back;
			if (!res)
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

		private void StringInValidDisplay(string WhereFrom)
		{
			string message = $"De opgegeven waarde in {WhereFrom} mag geen andere tekens bevatten dan:\n(a-z A-Z 0-9)";
			string header = "Verkeerd teken gevonden";
			FlexibleMessageBox.Show(message, header, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		private bool IsStringValid(string StringToCheck)
		{
			var regexItem = new Regex("^[a-zA-Z0-9 ]*$");

			if (regexItem.IsMatch(StringToCheck))
			{
				return true;
			}
			return false;
		}
	}
}
