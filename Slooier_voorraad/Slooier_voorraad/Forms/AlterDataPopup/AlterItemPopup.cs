using Npgsql;
using NpgsqlTypes;
using Slooier_voorraad.Classes;
using Slooier_voorraad.Classes.CommonFunctions;
using Slooier_voorraad.Classes.CustomMessageBox;
using Slooier_voorraad.Classes.UserInput;
using System;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Slooier_voorraad.Forms.AlterDataPopup
{
	public partial class AlterItemPopup : Form
	{
		#region Variables
		string ConnString;
		MagazijnItems CurrentItem;

		private const string lblOmschrijving = "Welke omschrijving heeft het artikel?";
		private const string lblPrijs = "Welke prijs heeft het artikel?";
		private const string lblVoorraad = "Wat is de voorraad van het artikel?";
		private const string lblNummer = "Welk nummer moet het artikel krijgen?";

		#endregion

		#region Initializers

		public AlterItemPopup()
		{
			InitializeComponent();
			ConnString = Properties.Settings.Default.DBConnectionString;
		}

		private void AlterItemPopup_Load(object sender, EventArgs e)
		{
			BackColor = Properties.Settings.Default.BackGroundColor;
			// Set panels to center of the Form
			//CommonFunctions.SetPanelDimensions(PMain, ClientSize);
			CurrentItem = Global.AlterItem;

			// Sets the currently selected element
			CurrentSetter();

			// Sets the combobox to have all afdelingen from the database
			GetBenamingen();
		}

		#endregion

		/// <summary>
		/// Retrieve and store all afdelingen to a combobox
		/// </summary>
		private void GetBenamingen()
		{
			var result = CommonFunctions.GetAfdelingen();
			CbbNewAfdeling.Items.Clear();
			foreach (string item in result)
			{
				CbbNewAfdeling.Items.Add(item);
			}
			// Automatically select the current afdeling
			CbbNewAfdeling.SelectedIndex = CbbNewAfdeling.FindStringExact(CurrentItem.Afdeling);
		}

		/// <summary>
		/// Sets the textboxes displaying the current status
		/// </summary>
		private void CurrentSetter()
		{
			TxbCurrentAfdeling.Text = CurrentItem.Afdeling;
			TxbCurrentNummer.Text = CurrentItem.Nummer;
			TxbCurrentOmschrijving.Text = CurrentItem.Omschrijving;
			TxbCurrentPrijs.Text = CurrentItem.Prijs.ToString();
			TxbCurrentVoorraad.Text = CurrentItem.Voorraad.ToString();

			_CurrentId = CurrentItem.Id;

			LblNewNummer.Text = lblNummer;
			LblNewOmschrijving.Text = lblOmschrijving;
			LblNewPrijs.Text = lblPrijs;
			LblNewVoorraad.Text = lblVoorraad;
		}

		#region Alter Artikel in the Database

		#region Private Variables		

		private int _CurrentId;
		private string _NewAfdeling;
		private int _NewAfdelingId;
		private string _NewNummer;
		private string _NewOmschrijving;
		private int _NewVoorraad;
		private double _NewPrijs;

		private bool _IsNummerCorrect = true;
		private bool _IsVoorraadCorrect = true;
		private bool _IsPrijsCorrect = true;
		private bool _IsOmschrijvingCorrect = true;

		#endregion

		private void BtnAlterArtikel_Click(object sender, EventArgs e)
		{
			CheckFilled();

			// Save to the database
			if (AlterItemInDB())
			{
				FlexibleMessageBox.Show("Het artikel is aangepast", "Succes");
				Dispose();
			}
			else
			{
				string message = "Er is iets fout gegaan, probeer het opnieuw.\r" +
					"Neem contact op met de helpdesk indien dit probleem zich blijft voordoen";
				string header = "An Error Occured";
				FlexibleMessageBox.Show(message, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		/// <summary>
		/// get and store all new/altered values
		/// </summary>
		private void CheckFilled()
		{
			// Get the currently selected afdeling
			_NewAfdeling = CbbNewAfdeling.SelectedItem.ToString();

			// Get the description of the item
			if (TxbNewOmschrijving.Text.Length == 0)
				_NewOmschrijving = CurrentItem.Omschrijving;
			else
				_NewOmschrijving = TxbNewOmschrijving.Text.ToString();

			// Get the price of the item
			if (TxbNewPrijs.Text.Length == 0)
				_NewPrijs = CurrentItem.Prijs;
			else
			{
				// Convert from string to double
				var clone = (CultureInfo)CultureInfo.InvariantCulture.Clone();
				clone.NumberFormat.NumberDecimalSeparator = ",";
				clone.NumberFormat.NumberGroupSeparator = ".";
				string value = TxbNewPrijs.Text;
				double Prijs = double.Parse(value, clone);
				_NewPrijs = Prijs;
			}

			// Get the nummer of the item
			if (TxbNewNummer.Text.Length == 0)
				_NewNummer = CurrentItem.Nummer;
			else
				_NewNummer = TxbNewNummer.Text;

			// Get the stock of the item
			if (TxbNewVoorraad.Text.Length == 0)
				_NewVoorraad = CurrentItem.Voorraad;
			else
				_NewVoorraad = int.Parse(TxbNewVoorraad.Text);
		}

		/// <summary>
		/// Alters the item's content in the database, returns true if succesfull
		/// </summary>
		/// <returns></returns>
		private bool AlterItemInDB()
		{
			int ItemId = CurrentItem.Id;
			using (var conn = new NpgsqlConnection(ConnString))
			{
				conn.Open();

				// Retrieves the id of the selected department
				_NewAfdelingId = int.MinValue;
				string querySelect = "SELECT id FROM afdelingen WHERE afdelingnaam = @Afdeling;";
				using (var cmd = new NpgsqlCommand(querySelect, conn))
				{
					var ParAfd = new NpgsqlParameter("Afdeling", NpgsqlDbType.Text) { Value = _NewAfdeling };
					cmd.Parameters.Add(ParAfd);
					cmd.Prepare();
					using (var SqlReader = cmd.ExecuteReader())
					{
						while (SqlReader.Read())
						{
							_NewAfdelingId = SqlReader.GetInt32(0);
							break;
						}
					}
				}

				if (_NewAfdelingId == int.MinValue)
				{
					return false;
				}
				// Updates the content of the database to the provided input
				string query = "UPDATE voorraad SET nummer = @Nummer, omschrijving = @Omschrijving, " +
												"voorraad = @Voorraad, afdeling = @Afdeling, prijs = @Prijs " +
												"WHERE id = @Id;";
				using (var cmd = new NpgsqlCommand(query, conn))
				{
					var ParNum = new NpgsqlParameter("Nummer", NpgsqlDbType.Text) { Value = _NewNummer };
					cmd.Parameters.Add(ParNum);
					var ParOms = new NpgsqlParameter("Omschrijving", NpgsqlDbType.Text) { Value = _NewOmschrijving };
					cmd.Parameters.Add(ParOms);
					var parVoo = new NpgsqlParameter("Voorraad", NpgsqlDbType.Integer) { Value = _NewVoorraad };
					cmd.Parameters.Add(parVoo);
					var parAfd = new NpgsqlParameter("Afdeling", NpgsqlDbType.Integer) { Value = _NewAfdelingId };
					cmd.Parameters.Add(parAfd);
					var parPri = new NpgsqlParameter("Prijs", NpgsqlDbType.Double) { Value = _NewPrijs };
					cmd.Parameters.Add(parPri);
					var parId = new NpgsqlParameter("Id", NpgsqlDbType.Integer) { Value = ItemId };
					cmd.Parameters.Add(parId);
					cmd.Prepare();
					cmd.ExecuteNonQuery();
				}
			}
			return true;
		}

		#endregion

		#region Validate User Input

		private void TxbNewOmschrijving_TextChanged(object sender, EventArgs e)
		{
			var InputResult = UserInputChecker.UserOmschrijvingInput(TxbNewOmschrijving.Text);

			switch (InputResult)
			{
				case UserInputChecker.InputResult.Valid:
					LblNewOmschrijving.ForeColor = System.Drawing.Color.Black;
					LblNewOmschrijving.Text = lblOmschrijving;
					_IsOmschrijvingCorrect = true;
					return;
				case UserInputChecker.InputResult.NoText:
					LblNewOmschrijving.ForeColor = System.Drawing.Color.Black;
					LblNewOmschrijving.Text = lblOmschrijving;
					_IsOmschrijvingCorrect = true;
					return;
				case UserInputChecker.InputResult.InValidChar:
					LblNewOmschrijving.ForeColor = System.Drawing.Color.Red;
					string ErrorDisplay = lblOmschrijving + "\nDe volgende tekens mogen niet gebruikt worden: " +
						"(!@#$%^&*()=[]{};:'<>?)";
					LblNewOmschrijving.Text = ErrorDisplay;
					_IsOmschrijvingCorrect = false;
					return;
			}
		}

		private void TxbNewPrijs_TextChanged(object sender, EventArgs e)
		{
			// If there is no text
			if (TxbNewPrijs.Text.Length <= 0)
			{
				LblNewPrijs.ForeColor = System.Drawing.Color.Black;
				LblNewPrijs.Text = lblPrijs;
				_IsPrijsCorrect = true;
				return;
			}

			// Get the current NumberFormatInfo object to build the regular expression pattern dynamically.
			NumberFormatInfo nfi = NumberFormatInfo.CurrentInfo;

			// Define the regular expression pattern.
			string AllowedCharacters;
			AllowedCharacters = @"^\s*[";
			// Get the positive and negative sign symbols.
			AllowedCharacters += Regex.Escape(nfi.PositiveSign + nfi.NegativeSign) + @"]?\s?";
			// Get the currency symbol.
			AllowedCharacters += Regex.Escape(nfi.CurrencySymbol) + @"?\s?";
			// Add integral digits to the pattern.
			AllowedCharacters += @"(\d*";
			// Add the decimal separator.
			AllowedCharacters += Regex.Escape(nfi.CurrencyDecimalSeparator) + "?";
			// Add the fractional digits.
			AllowedCharacters += @"\d{";
			// Determine the number of fractional digits in currency values.
			AllowedCharacters += nfi.CurrencyDecimalDigits.ToString() + "}?){1}$";

			string text = TxbNewPrijs.Text;
			if (!CommonFunctions.IsStringValid(text, AllowedCharacters))
			{
				// Check amount of characters in the string after the ','
				char CharacterToCheck = ',';
				int index = text.IndexOf(CharacterToCheck);
				if (index == -1)
				{
					// Check how many numbers are in the text
					int AmountOfNumbers = text.Count(c => char.IsDigit(c));
					LblNewPrijs.ForeColor = System.Drawing.Color.Red;

					// Check whether the amount of numbers is 1
					if (AmountOfNumbers == 1)
						LblNewPrijs.Text = lblPrijs + "\nPrijzen behoren te bestaan uit minimaal 2 getallen, of één getal en 2 getallen na de komma.";
					else
						LblNewPrijs.Text = lblPrijs + "\nAlleen getallen (0-9) en de komma(,) zijn toegestaan.";
					_IsPrijsCorrect = false;
					return;
				}
				var CharsAfterIndex = text.Substring(index + 1).Length;
				Console.WriteLine(CharsAfterIndex > 1);
				if (CharsAfterIndex != 2)
				{
					LblNewPrijs.ForeColor = System.Drawing.Color.Red;
					LblNewPrijs.Text = lblPrijs + "\nPrijzen behoren te bestaan uit minimaal 2 getallen, of één getal en 2 getallen na de komma.";
					_IsPrijsCorrect = false;
					return;
				}

			}
			LblNewPrijs.ForeColor = System.Drawing.Color.Black;
			LblNewPrijs.Text = lblPrijs;
			_IsPrijsCorrect = true;
		}

		private void TxbNewVoorraad_TextChanged(object sender, EventArgs e)
		{
			var InputResult = UserInputChecker.UserVoorraadInput(TxbNewVoorraad.Text);

			switch (InputResult)
			{
				case UserInputChecker.InputResult.Valid:
					LblNewVoorraad.ForeColor = System.Drawing.Color.Black;
					LblNewVoorraad.Text = lblVoorraad;
					_IsVoorraadCorrect = true;
					return;
				case UserInputChecker.InputResult.NoText:
					LblNewVoorraad.ForeColor = System.Drawing.Color.Black;
					LblNewVoorraad.Text = lblVoorraad;
					_IsVoorraadCorrect = false;
					return;
				case UserInputChecker.InputResult.InValidChar:
					LblNewVoorraad.ForeColor = System.Drawing.Color.Red;
					LblNewVoorraad.Text = lblVoorraad + "\nAlleen getallen (0-9) zijn toegestaan";
					_IsVoorraadCorrect = false;
					return;
			}
		}

		private void TxbNewNummer_TextChanged(object sender, EventArgs e)
		{
			var InputResult = UserInputChecker.UserNummerInput(TxbNewNummer.Text);

			switch (InputResult)
			{
				case UserInputChecker.InputResult.Valid:
					LblNewNummer.ForeColor = System.Drawing.Color.Black;
					LblNewNummer.Text = lblNummer;
					_IsNummerCorrect = true;
					return;
				case UserInputChecker.InputResult.NoText:
					LblNewNummer.ForeColor = System.Drawing.Color.Black;
					LblNewNummer.Text = lblNummer;
					_IsNummerCorrect = false;
					return;
				case UserInputChecker.InputResult.InValidChar:
					LblNewNummer.ForeColor = System.Drawing.Color.Red;
					LblNewNummer.Text = lblNummer + "\nAlleen letters (a-zA-Z) en getallen (0-9) zijn toegestaan";
					_IsNummerCorrect = false;
					return;
			}
		}

		private void CbbNewAfdeling_TextChanged(object sender, EventArgs e)
		{
			// Check if the selected element is outside of the list
			if (CbbNewAfdeling.SelectedIndex < 0)
			{
				// Set the selected element to the original element
				CbbNewAfdeling.SelectedIndex = CbbNewAfdeling.FindStringExact(CurrentItem.Afdeling);
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
				BtnAlterArtikel.Enabled = false;
			else
				BtnAlterArtikel.Enabled = true;
		}

		private void TxbNewOmschrijving_KeyUp(object sender, KeyEventArgs e)
		{
			IsAlterButtonEnabled();
		}

		private void TxbNewPrijs_KeyUp(object sender, KeyEventArgs e)
		{
			IsAlterButtonEnabled();
		}

		private void TxbNewVoorraad_KeyUp(object sender, KeyEventArgs e)
		{
			IsAlterButtonEnabled();
		}

		private void TxbNewNummer_KeyUp(object sender, KeyEventArgs e)
		{
			IsAlterButtonEnabled();
		}

		#endregion
	}
}
