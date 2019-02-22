using Slooier_voorraad.Classes.MigraDoc;
using Slooier_voorraad.Forms;
using System;
using System.Windows.Forms;

namespace Slooier_voorraad
{
	public partial class StartingScreen : Form
	{
		public string CurrentDir = AppDomain.CurrentDomain.BaseDirectory;
		//public string InitialDir = "C:\\";
		public string InitialDir = "A:\\Red Darkness\\Documents\\Documenten\\Github\\Repositories\\Slooier_management\\Slooier_voorraad\\Slooier_voorraad\\Voorbeeld_Data";
		public string ConnString = string.Format("Server=localhost; User Id=postgres; Database=Slooier_VoorraadSysteem; Port=5432; Password=2761");

		public StartingScreen()
		{
			InitializeComponent();
		}

		private void BtnAddOrRemove_Click(object sender, EventArgs e)
		{
			AddOrRemoveItems AddOrRemoveForm = new AddOrRemoveItems(ConnString, WindowState);
			Hide();
			AddOrRemoveForm.FormClosed += ReactivateWindow;
			AddOrRemoveForm.Show();
		}

		private void BtnBestellen_Click(object sender, EventArgs e)
		{
			BestelScreen BestelForm = new BestelScreen(ConnString, WindowState);
			Hide();
			BestelForm.FormClosed += ReactivateWindow;
			BestelForm.Show();
		}

		private void BtnAlterStock_Click(object sender, EventArgs e)
		{
			VoorraadCorrectie VoorraadForm = new VoorraadCorrectie(ConnString, WindowState);
			Hide();
			VoorraadForm.FormClosed += ReactivateWindow;
			VoorraadForm.Show();
		}

		private void BtnPdFTester_Click(object sender, EventArgs e)
		{
			// Proberen om een PDF bestand aan te maken
			MigraDocFunctions.MigraDocBeginning();
		}

		#region Forms
		private void ReactivateWindow(object sender, FormClosedEventArgs e)
		{
			Enabled = true;
			Show();
		}
		#endregion
		private void StartingScreen_SizeChanged(object sender, EventArgs e)
		{
			// Set minimumsize
			MinimumSize = new System.Drawing.Size(800, 600);
			// Set panels to center of the Form
			PMain.Left = (ClientSize.Width - PMain.Width) / 2;
			PMain.Top = (ClientSize.Height - PMain.Height) / 2;
		}

		private void StartingScreen_FormClosing(object sender, FormClosingEventArgs e)
		{
		}

		private void StartingScreen_Load(object sender, EventArgs e)
		{
			BackColor = Properties.Settings.Default.BackGroundColor;
		}

		private void BtnSettings_Click(object sender, EventArgs e)
		{
			SettingForm SettingForm = new SettingForm();
			//Hide();
			Enabled = false;
			SettingForm.FormClosed += ReactivateWindow;
			SettingForm.Show();
		}
	}
}
