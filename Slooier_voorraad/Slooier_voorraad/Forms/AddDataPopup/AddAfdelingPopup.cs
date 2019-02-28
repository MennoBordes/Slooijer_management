using Npgsql;
using NpgsqlTypes;
using Slooier_voorraad.Classes.CommonFunctions;
using Slooier_voorraad.Classes.CustomMessageBox;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Slooier_voorraad.Forms.AddDataPopup
{
	public partial class AddAfdelingPopup : Form
	{
		string ConnString;
		public AddAfdelingPopup()
		{
			InitializeComponent();
			ConnString = Properties.Settings.Default.DBConnectionString;
		}

		private void AddAfdelingPopup_Load(object sender, EventArgs e)
		{
			CommonFunctions.SetPanelDimensions(PMain, ClientSize);
			CommonFunctions.SetPanelDimensions(PSecundary, PMain);
			BackColor = Properties.Settings.Default.BackGroundColor;
		}

		private void AddAfdelingPopup_SizeChanged(object sender, EventArgs e)
		{
			CommonFunctions.SetPanelDimensions(PMain, ClientSize);
			CommonFunctions.SetPanelDimensions(PSecundary, PMain);
		}

		private void BtnAddToDb_Click(object sender, EventArgs e)
		{
			try
			{
				var afdelingNaam = TxbAfdeling.Text;
				var regexItem = new Regex("^[a-z A-Z]");
				bool wierdLetter = regexItem.IsMatch(afdelingNaam);
				if (!wierdLetter)
				{
					string message = $"De opgegeven waarde in afdeling mag geen andere tekens bevatten dan:\n(a-z A-Z)";
					string header = "Verkeerd teken gevonden";
					FlexibleMessageBox.Show(message, header, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
				else
				{
					// Check the amount of characters in the string
					int aantalTekens = 0;
					foreach (char letter in afdelingNaam)
					{
						// Ignore all white spaces
						if (!char.IsWhiteSpace(letter))
						{
							aantalTekens++;
						}
						// If characteramount is greater than 3
						if (aantalTekens >= 3)
						{
							break;
						}
					}
					if (aantalTekens < 3)
					{
						string message = "De opgegeven naam voor de afdeling is te kort.\n";
						string header = "Naam te kort";
						FlexibleMessageBox.Show(message, header, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						return;
					}
					using (var conn = new NpgsqlConnection(ConnString))
					{
						// Check wheter the given name already exists or not
						conn.Open();
						bool AfdelingExists = false;
						string query = "SELECT afdelingnaam FROM afdelingen WHERE afdelingnaam = @Afdeling;";
						using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
						{
							var ParAfd = new NpgsqlParameter("Afdeling", NpgsqlDbType.Text)
							{
								Value = afdelingNaam
							};
							cmd.Parameters.Add(ParAfd);
							cmd.Prepare();
							using (var SqlReader = cmd.ExecuteReader())
							{
								if (SqlReader.HasRows)
								{
									AfdelingExists = true;
								}
							}
						}
						if (AfdelingExists)
						{
							string message = $"De opgegeven afdeling naam ({afdelingNaam}) bestaat al.\n\nKies een andere naam voor de afdeling!";
							string header = "Afdeling Bestaat";
							FlexibleMessageBox.Show(message, header);
							return;
						}
						else
						{
							// Insert into DB
							query = "INSERT INTO afdelingen(afdelingnaam) VALUES (@Afdeling);";
							using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
							{
								var ParAfd = new NpgsqlParameter("Afdeling", NpgsqlDbType.Text)
								{
									Value = afdelingNaam
								};
								cmd.Parameters.Add(ParAfd);
								cmd.Prepare();
								cmd.ExecuteNonQuery();
							}
							FlexibleMessageBox.Show("De afdeling is toegevoegd", "Succes");
							TxbAfdeling.Clear();
						}
					}
				}
			}
			catch (Exception ex)
			{
				FlexibleMessageBox.Show(ex.Message);
				throw;
			}
		}
	}
}
