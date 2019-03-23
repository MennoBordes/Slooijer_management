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
		private const string NotFilledIn = "\nNiet alle gegevens zijn ingevuld. \r Vul alle benodigde velden in!";

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
		/// Retrieve and store all departments in a combobox.
		/// </summary>
		private void GetBenamingen()
		{
			var result = CommonFunctions.GetAfdelingen();
			CbbAfdeling.Items.Clear();
			foreach (string item in result)
			{
				CbbAfdeling.Items.Add(item);
			}
			// Automatically select the top most afdeling
			CbbAfdeling.SelectedItem = CbbAfdeling.Items[0];
		}

		private void BtnAddToDb_Click(object sender, EventArgs e)
		{
			// Check if all required inputs are filled
			if (!CheckAllFilled())
			{
				string message = "Niet alle gegevens zijn ingevuld. \rVul alle benodigde velden in!";
				string header = "Niet Ingevuld";
				FlexibleMessageBox.Show(message, header, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}

			// Check whether the given item already exists
			if (DoesItemExist())
			{
				string message = "Het opgegeven nummer bestaat al. \rHeeft u het juiste nummer ingevuld?";
				string header = "Artikel bestaat al!";
				FlexibleMessageBox.Show(message, header, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			// Add the item to the database
			if (AddItemToDB())
			{
				FlexibleMessageBox.Show("Het artikel is toegevoegd", "Succes");
				// Reset user input
				TxbNummer.Clear();
				TxbOmschrijving.Clear();
				TxbPrijs.Clear();
				TxbVoorraad.Clear();
				CbbAfdeling.SelectedIndex = 0;
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
		/// Checks whether the nummer of the item already exists in the database.
		/// </summary>
		/// <returns></returns>
		private bool DoesItemExist()
		{
			using (var conn = new NpgsqlConnection(ConnString))
			{
				conn.Open();

				string QuerySelect = "SELECT nummer FROM voorraad WHERE nummer LIKE @Nummer;";
				using (var cmd = new NpgsqlCommand(QuerySelect, conn))
				{
					var ParNum = new NpgsqlParameter("Nummer", NpgsqlDbType.Integer) { Value = _Nummer };
					cmd.Parameters.Add(ParNum);
					cmd.Prepare();

					using (var reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							return true;
						}
					}
				}
			}
			return false;
		}

		#region Private Variables		

		private string _Afdeling;
		private int _AfdelingId;
		private string _Nummer;
		private string _Omschrijving;
		private int _Voorraad;
		private double _Prijs;

		private bool _IsNummerCorrect = true;
		private bool _IsVoorraadCorrect = true;
		private bool _IsPrijsCorrect = true;
		private bool _IsOmschrijvingCorrect = true;

		#endregion

		/// <summary>
		/// Alters the item's content in the database, returns true if succesfull
		/// </summary>
		/// <returns></returns>
		private bool AddItemToDB()
		{
			using (var conn = new NpgsqlConnection(ConnString))
			{
				conn.Open();

				// Retrieve the id of the department in which the item will be placed
				_AfdelingId = int.MinValue;
				string QuerySelect = "SELECT id FROM afdelingen WHERE afdelingnaam = @Afdeling;";
				using (var cmd = new NpgsqlCommand(QuerySelect, conn))
				{
					var ParAfd = new NpgsqlParameter("Afdeling", NpgsqlDbType.Text) { Value = _Afdeling };
					cmd.Parameters.Add(ParAfd);
					cmd.Prepare();
					using (var SqlReader = cmd.ExecuteReader())
					{
						while (SqlReader.Read())
						{
							_AfdelingId = SqlReader.GetInt32(0);
							break;
						}
					}
				}

				if (_AfdelingId == int.MinValue)
				{
					return false;
				}

				string QueryInsert = "INSERT INTO voorraad(nummer, omschrijving, voorraad, afdeling, prijs) VALUES (@Nummer, @Omschrijving, @Voorraad, @AfdelingId, @Prijs);";
				using (var cmd = new NpgsqlCommand(QueryInsert, conn))
				{
					var ParNum = new NpgsqlParameter("Nummer", NpgsqlDbType.Text) { Value = _Nummer };
					cmd.Parameters.Add(ParNum);
					var ParOms = new NpgsqlParameter("Omschrijving", NpgsqlDbType.Text) { Value = _Omschrijving };
					cmd.Parameters.Add(ParOms);
					var ParVoo = new NpgsqlParameter("Voorraad", NpgsqlDbType.Integer) { Value = _Voorraad };
					cmd.Parameters.Add(ParVoo);
					var ParAfd = new NpgsqlParameter("AfdelingId", NpgsqlDbType.Integer) { Value = _AfdelingId };
					cmd.Parameters.Add(ParAfd);
					var ParPri = new NpgsqlParameter("Prijs", NpgsqlDbType.Double) { Value = _Prijs };
					cmd.Parameters.Add(ParPri);
					cmd.Prepare();
					cmd.ExecuteNonQuery();
				}
			}
			return true;
		}

		/// <summary>
		/// Get and store all new/altered values. Returns true if all are filled in.
		/// </summary>
		/// <returns></returns>
		private bool CheckAllFilled()
		{
			// Keeps track of whether all boxes have been filled
			bool OneNotFilledIn = false;

			// Get the currently selected afdeling
			_Afdeling = CbbAfdeling.SelectedItem.ToString();

			// Get the description of the item
			if (TxbOmschrijving.Text.Length == 0)
			{
				LblOmschrijving.ForeColor = System.Drawing.Color.Red;
				LblOmschrijving.Text = lblOmschrijving + NotFilledIn;
				OneNotFilledIn = true;
			}
			else
			{
				LblOmschrijving.ForeColor = System.Drawing.Color.Black;
				LblOmschrijving.Text = lblOmschrijving;
				_Omschrijving = TxbOmschrijving.Text.ToString();
			}

			// Get the price of the item
			if (TxbPrijs.Text.Length == 0)
			{
				LblPrijs.ForeColor = System.Drawing.Color.Red;
				LblPrijs.Text = lblPrijs + NotFilledIn;
				OneNotFilledIn = true;
			}
			else
			{
				LblPrijs.ForeColor = System.Drawing.Color.Black;
				LblPrijs.Text = lblPrijs;
				// Convert from string to double
				var clone = (CultureInfo)CultureInfo.InvariantCulture.Clone();
				clone.NumberFormat.NumberDecimalSeparator = ",";
				clone.NumberFormat.NumberGroupSeparator = ".";
				string value = TxbPrijs.Text;
				double Prijs = double.Parse(value, clone);
				_Prijs = Prijs;
			}

			// Get the nummer of the item
			if (TxbNummer.Text.Length == 0)
			{
				LblNummer.ForeColor = System.Drawing.Color.Red;
				LblNummer.Text = lblNummer + NotFilledIn;
				OneNotFilledIn = true;
			}
			else
			{
				LblNummer.ForeColor = System.Drawing.Color.Black;
				LblNummer.Text = lblNummer;
				_Nummer = TxbNummer.Text;
			}

			// Get the stock of the item
			if (TxbVoorraad.Text.Length == 0)
			{
				LblVoorraad.ForeColor = System.Drawing.Color.Red;
				LblVoorraad.Text = lblVoorraad + NotFilledIn;
				OneNotFilledIn = true;
			}
			else
			{
				LblVoorraad.ForeColor = System.Drawing.Color.Black;
				LblVoorraad.Text = lblVoorraad;
				_Voorraad = int.Parse(TxbVoorraad.Text);
			}

			if (OneNotFilledIn)
				return false;
			else
				return true;
		}

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
