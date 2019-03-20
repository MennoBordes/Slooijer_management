using Slooier_voorraad.Classes;
using Slooier_voorraad.Classes.CommonFunctions;
using System;
using System.Globalization;
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

			CurrentId = CurrentItem.Id;

			LblNewNummer.Text = lblNummer;
			LblNewOmschrijving.Text = lblOmschrijving;
			LblNewPrijs.Text = lblPrijs;
			LblNewVoorraad.Text = lblVoorraad;
		}

		#region Alter Artikel in the Database

		#region Private Variables		

		private int CurrentId;
		private string NewAfdeling;
		private string NewNummer;
		private string NewOmschrijving;
		private int NewVoorraad;
		private double NewPrijs;

		#endregion

		private void BtnAlterArtikel_Click(object sender, EventArgs e)
		{
			CheckFilled();

			// Save to the database
		}

		/// <summary>
		/// get and store all new/altered values
		/// </summary>
		private void CheckFilled()
		{
			// Get the currently selected afdeling
			NewAfdeling = CbbNewAfdeling.SelectedItem.ToString();

			// Get the description of the item
			if (TxbNewOmschrijving.Text.Length == 0)
				NewOmschrijving = CurrentItem.Omschrijving;
			else
				NewOmschrijving = TxbNewOmschrijving.Text.ToString();

			// Get the price of the item
			if (TxbNewPrijs.Text.Length == 0)
				NewPrijs = CurrentItem.Prijs;
			else
			{
				// Convert from string to double
				var clone = (CultureInfo)CultureInfo.InvariantCulture.Clone();
				clone.NumberFormat.NumberDecimalSeparator = ",";
				clone.NumberFormat.NumberGroupSeparator = ".";
				string value = TxbNewPrijs.Text;
				double Prijs = double.Parse(value, clone);
				NewPrijs = Prijs;
			}

			// Get the nummer of the item
			if (TxbNewNummer.Text.Length == 0)
				NewNummer = CurrentItem.Nummer;
			else
				NewNummer = TxbNewNummer.Text;

			// Get the stock of the item
			if (TxbNewVoorraad.Text.Length == 0)
				NewVoorraad = CurrentItem.Voorraad;
			else
				NewVoorraad = int.Parse(TxbNewVoorraad.Text);
		}

		#region Regex

		/// <summary>
		/// Checks whether a given string is valid for the given allowed characters
		/// </summary>
		/// <param name="StringToCheck">The string to check</param>
		/// <param name="AllowedCharacters">The allowed characters to check against</param>
		/// <returns></returns>
		private bool IsStringValid(string StringToCheck, string AllowedCharacters)
		{
			Regex regexItem = new Regex(AllowedCharacters);

			if (regexItem.IsMatch(StringToCheck))
			{
				return true;
			}
			return false;
		}

		#endregion

		#region Validate user input
		private void TxbNewOmschrijving_TextChanged(object sender, EventArgs e)
		{
			// If there is no text
			if (TxbNewOmschrijving.Text.Length <= 0)
			{
				LblNewOmschrijving.ForeColor = System.Drawing.Color.Black;
				LblNewOmschrijving.Text = lblOmschrijving;
				return;
			}

			// Defining the allowed characters
			string AllowedCharacters;

			// \p{L} allows all normal text
			// \w\ allows all numbers
			// .,/-+ allows those characters to be used
			AllowedCharacters = @"^[\p{L}\w\.,+/ -]+$";

			if (!IsStringValid(TxbNewOmschrijving.Text, AllowedCharacters))
			{
				LblNewOmschrijving.ForeColor = System.Drawing.Color.Red;
				LblNewOmschrijving.Text = lblOmschrijving + "\nDe volgende tekens mogen niet gebruikt worden: " +
					"(!@#$%^&*()=[]{};:'<>?)";
				return;
			}
			LblNewOmschrijving.ForeColor = System.Drawing.Color.Black;
			LblNewOmschrijving.Text = lblOmschrijving;
		}

		private void TxbNewPrijs_TextChanged(object sender, EventArgs e)
		{
			// If there is no text
			if (TxbNewPrijs.Text.Length <= 0)
			{
				LblNewPrijs.ForeColor = System.Drawing.Color.Black;
				LblNewPrijs.Text = lblPrijs;
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

			if (!IsStringValid(TxbNewPrijs.Text, AllowedCharacters))
			{
				LblNewPrijs.ForeColor = System.Drawing.Color.Red;
				LblNewPrijs.Text = lblPrijs + "\nAlleen getallen (0-9) en de komma(,) zijn toegestaan";
				return;
			}
			LblNewPrijs.ForeColor = System.Drawing.Color.Black;
			LblNewPrijs.Text = lblPrijs;
		}

		private void TxbNewVoorraad_TextChanged(object sender, EventArgs e)
		{
			// If there is no text
			if (TxbNewVoorraad.Text.Length <= 0)
			{
				LblNewVoorraad.ForeColor = System.Drawing.Color.Black;
				LblNewVoorraad.Text = lblVoorraad;
				return;
			}

			// Defining the allowed characters
			string AllowedCharacters;

			// \p{L} allows all normal text
			// \w\ allows all numbers
			// .,/-+ allows those characters to be used
			AllowedCharacters = @"^[0-9]+$";

			if (!IsStringValid(TxbNewVoorraad.Text, AllowedCharacters))
			{
				LblNewVoorraad.ForeColor = System.Drawing.Color.Red;
				LblNewVoorraad.Text = lblVoorraad + "\nAlleen getallen (0-9) zijn toegestaan";
				return;
			}
			LblNewVoorraad.ForeColor = System.Drawing.Color.Black;
			LblNewVoorraad.Text = lblVoorraad;
		}

		private void TxbNewNummer_TextChanged(object sender, EventArgs e)
		{
			// If there is no text
			if (TxbNewNummer.Text.Length <= 0)
			{
				LblNewNummer.ForeColor = System.Drawing.Color.Black;
				LblNewNummer.Text = lblNummer;
				return;
			}

			// Defining the allowed characters
			string AllowedCharacters;

			// \p{L} allows all normal text
			// \w\ allows all numbers
			// .,/-+ allows those characters to be used
			AllowedCharacters = @"^[A-Za-z0-9]+$";

			if (!IsStringValid(TxbNewNummer.Text, AllowedCharacters))
			{
				LblNewNummer.ForeColor = System.Drawing.Color.Red;
				LblNewNummer.Text = lblNummer + "\nAlleen letters (a-zA-Z) en getallen (0-9) zijn toegestaan";
				return;
			}
			LblNewNummer.ForeColor = System.Drawing.Color.Black;
			LblNewNummer.Text = lblNummer;
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

		#endregion
	}
}
