using Npgsql;
using NpgsqlTypes;
using Slooier_voorraad.Classes.CommonFunctions;
using Slooier_voorraad.Classes.CustomMessageBox;
using Slooier_voorraad.Classes.UserInput;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Slooier_voorraad.Forms.AddDataPopup
{
	public partial class AddItemPopup : Form
	{
		#region Variables

		string ConnString;

		private const string lblOmschrijving = "Welke omschrijving heeft het artikel?";
		private const string lblPrijs = "Welke prijs heeft het artikel?";
		private const string lblVoorraad = "Wat is de voorraad van het artikel?";
		private const string lblNummer = "Welk nummer moet het artikel krijgen?";

		#endregion

		#region Initializers

		public AddItemPopup()
		{
			InitializeComponent();
			ConnString = Properties.Settings.Default.DBConnectionString;
		}

		private void AddItemPopup_Shown(object sender, EventArgs e)
		{
			GetBenamingen();
		}

		private void AddItemPopup_Load(object sender, EventArgs e)
		{
			// Set panels to center of the Form
			CommonFunctions.SetPanelDimensions(PMain, ClientSize);
			CommonFunctions.SetPanelDimensions(PSecundary, PMain);
			CommonFunctions.SetPanelDimensions(FlpMain, PSecundary);
			BackColor = Properties.Settings.Default.BackGroundColor;
		}

		#endregion

		private void AddItemPopup_SizeChanged(object sender, EventArgs e)
		{
			// Set panels to center of the Form
			CommonFunctions.SetPanelDimensions(PMain, ClientSize);
			CommonFunctions.SetPanelDimensions(PSecundary, PMain);
			CommonFunctions.SetPanelDimensions(FlpMain, PSecundary);
		}

		/// <summary>
		/// Retrieve and store all afdelingen to a combobox
		/// </summary>
		private void GetBenamingen()
		{
			var result = CommonFunctions.GetAfdelingen();
			CbbAfdeling.Items.Clear();
			foreach (string item in result)
			{
				CbbAfdeling.Items.Add(item);
			}
		}

		private void BtnAddToDb_Click(object sender, EventArgs e)
		{
			try
			{
				if (CbbAfdeling.SelectedIndex < 0)
				{
					FlexibleMessageBox.Show("Geen Afdeling geselecteerd.\nSelecteer A.U.B. een afdeling!", "Selecteer een afdeling!");
					return;
				}
				string Afdeling = CbbAfdeling.GetItemText(CbbAfdeling.SelectedItem);

				string AllowedCharacters = "^[a-zA-Z0-9 ]*$";
				string Nummer = TxbNummer.Text;
				if (CommonFunctions.IsStringValid(Nummer, AllowedCharacters))
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
				if (CommonFunctions.IsStringValid(Omschrijving, AllowedCharacters))
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

				AllowedCharacters = "^[0-9,]*$";
				if (!CommonFunctions.IsStringValid(TxbPrijs.Text, AllowedCharacters))
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
								break;
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
							CbbAfdeling.SelectedIndex = -1;
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

		private void StringInValidDisplay(string WhereFrom)
		{
			string message = $"De opgegeven waarde in {WhereFrom} mag geen andere tekens bevatten dan:\n(a-z A-Z 0-9)";
			string header = "Verkeerd teken gevonden";
			FlexibleMessageBox.Show(message, header, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		#region Private Variables		

		private int _CurrentId;
		private string _Afdeling;
		private int _AfdelingId;
		private string _NewNummer;
		private string _NewOmschrijving;
		private int _NewVoorraad;
		private double _NewPrijs;

		private bool _IsNummerCorrect = true;
		private bool _IsVoorraadCorrect = true;
		private bool _IsPrijsCorrect = true;
		private bool _IsOmschrijvingCorrect = true;

		#endregion

		#region Validate User Input

		private void TxbOmschrijving_TextChanged(object sender, EventArgs e)
		{
			var InputResult = UserInputChecker.UserOmschrijvingInput(TxbOmschrijving.Text);

			switch (InputResult)
			{
				case UserInputChecker.InputResult.Valid:
					LblOmschrijving.ForeColor = System.Drawing.Color.Black;
					LblOmschrijving.Text = lblOmschrijving;
					_IsOmschrijvingCorrect = true;
					return;
				case UserInputChecker.InputResult.NoText:
					LblOmschrijving.ForeColor = System.Drawing.Color.Black;
					LblOmschrijving.Text = lblOmschrijving;
					_IsOmschrijvingCorrect = true;
					return;
				case UserInputChecker.InputResult.InValidChar:
					LblOmschrijving.ForeColor = System.Drawing.Color.Red;
					string ErrorDisplay = lblOmschrijving + "\nDe volgende tekens mogen niet gebruikt worden: " +
						"(!@#$%^&*()=[]{};:'<>?)";
					LblOmschrijving.Text = ErrorDisplay;
					_IsOmschrijvingCorrect = false;
					return;
			}
		}

		private void TxbPrijs_TextChanged(object sender, EventArgs e)
		{
			var InputResult = UserInputChecker.UserPrijsInput(TxbPrijs.Text);

			switch (InputResult)
			{
				case UserInputChecker.InputResult.Valid:
					LblPrijs.ForeColor = System.Drawing.Color.Black;
					LblPrijs.Text = lblPrijs;
					_IsPrijsCorrect = true;
					return;
				case UserInputChecker.InputResult.NoText:
					LblPrijs.ForeColor = System.Drawing.Color.Black;
					LblPrijs.Text = lblPrijs;
					_IsPrijsCorrect = true;
					return;
				case UserInputChecker.InputResult.InValidChar:
					LblPrijs.ForeColor = System.Drawing.Color.Red;
					string ErrorDisplay = lblPrijs +
						"\nAlleen getallen (0-9) en de komma(,) zijn toegestaan." +
						"\nPrijzen behoren te bestaan uit minimaal 2 getallen, " +
						"of één getal en 2 getallen na de komma.";
					LblPrijs.Text = ErrorDisplay;
					_IsPrijsCorrect = false;
					return;
			}
		}

		private void TxbVoorraad_TextChanged(object sender, EventArgs e)
		{
			var InputResult = UserInputChecker.UserVoorraadInput(TxbVoorraad.Text);

			switch (InputResult)
			{
				case UserInputChecker.InputResult.Valid:
					LblVoorraad.ForeColor = System.Drawing.Color.Black;
					LblVoorraad.Text = lblVoorraad;
					_IsVoorraadCorrect = true;
					return;
				case UserInputChecker.InputResult.NoText:
					LblVoorraad.ForeColor = System.Drawing.Color.Black;
					LblVoorraad.Text = lblVoorraad;
					_IsVoorraadCorrect = false;
					return;
				case UserInputChecker.InputResult.InValidChar:
					LblVoorraad.ForeColor = System.Drawing.Color.Red;
					LblVoorraad.Text = lblVoorraad + "\nAlleen getallen (0-9) zijn toegestaan";
					_IsVoorraadCorrect = false;
					return;
			}
		}

		private void TxbNummer_TextChanged(object sender, EventArgs e)
		{
			var InputResult = UserInputChecker.UserNummerInput(TxbNummer.Text);

			switch (InputResult)
			{
				case UserInputChecker.InputResult.Valid:
					LblNummer.ForeColor = System.Drawing.Color.Black;
					LblNummer.Text = lblNummer;
					_IsNummerCorrect = true;
					return;
				case UserInputChecker.InputResult.NoText:
					LblNummer.ForeColor = System.Drawing.Color.Black;
					LblNummer.Text = lblNummer;
					_IsNummerCorrect = false;
					return;
				case UserInputChecker.InputResult.InValidChar:
					LblNummer.ForeColor = System.Drawing.Color.Red;
					LblNummer.Text = lblNummer + "\nAlleen letters (a-zA-Z) en getallen (0-9) zijn toegestaan";
					_IsNummerCorrect = false;
					return;
			}
		}

		#endregion

		#region Check If Button Should Be Enabled

		/// <summary>
		/// Checks whether the button should be enabled or not.
		/// </summary>
		private void IsAlterButtonEnabled()
		{
			if (!_IsNummerCorrect || !_IsOmschrijvingCorrect || !_IsPrijsCorrect || !_IsVoorraadCorrect)
				BtnAddToDb.Enabled = false;
			else
				BtnAddToDb.Enabled = true;
		}

		private void TxbOmschrijving_KeyUp(object sender, KeyEventArgs e)
		{
			IsAlterButtonEnabled();
		}

		private void TxbPrijs_KeyUp(object sender, KeyEventArgs e)
		{
			IsAlterButtonEnabled();
		}

		private void TxbVoorraad_KeyUp(object sender, KeyEventArgs e)
		{
			IsAlterButtonEnabled();
		}

		private void TxbNummer_KeyUp(object sender, KeyEventArgs e)
		{
			IsAlterButtonEnabled();
		}
		#endregion
	}
}
