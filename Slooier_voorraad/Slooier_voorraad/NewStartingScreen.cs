using Slooier_voorraad.Classes.CommonFunctions;
using Slooier_voorraad.Classes.CustomMessageBox;
using System;
using System.Windows.Forms;

namespace Slooier_voorraad
{
	public partial class NewStartingScreen : Form
	{
		#region Initializers
		public string ConnString = string.Format($"Server={Properties.Settings.Default.Server}; " +
			$"User Id={Properties.Settings.Default.UserName}; " +
			$"Database={Properties.Settings.Default.Database}; " +
			$"Port={Properties.Settings.Default.Port}; " +
			$"Password={Properties.Settings.Default.password};");

		public NewStartingScreen()
		{
			InitializeComponent();
		}

		private void NewStartingScreen_Load(object sender, EventArgs e)
		{
			BackColor = Properties.Settings.Default.BackGroundColor;

			Properties.Settings.Default.DBConnectionValid = CommonFunctions.CheckDBConnection(ConnString);
			Properties.Settings.Default.DBConnectionString = ConnString;
		}

		private void NewStartingScreen_FormClosing(object sender, FormClosingEventArgs e)
		{
			Properties.Settings.Default.Save();
		}
		#endregion

		private void TmrDbCheck_Tick(object sender, EventArgs e)
		{
			bool currentStatus = Properties.Settings.Default.DBConnectionValid;
			bool CheckResult = CommonFunctions.TimedChecker();
			if (CheckResult == false && CheckResult != currentStatus)
			{
				string message = "Het is niet gelukt om een verbinding met de Database in stand te brengen.\n\nControlleer uw internetverbinding!";
				string header = "DataBase Connectie";
				FlexibleMessageBox.Show(message, header, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
	}
}
