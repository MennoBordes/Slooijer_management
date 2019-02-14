using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Slooier_voorraad.Classes.MigraDoc;
using Slooier_voorraad.Forms;

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
			AddOrRemoveItems addOrRemove = new AddOrRemoveItems(ConnString);
			addOrRemove.Show();
		}

		private void BtnBestellen_Click(object sender, EventArgs e)
		{
			BestelScreen Bestel = new BestelScreen();
			Bestel.Show();
		}

		private void BtnAlterStock_Click(object sender, EventArgs e)
		{
			VoorraadCorrectie voorraad = new VoorraadCorrectie();
			voorraad.Show();
		}

		private void BtnPdFTester_Click(object sender, EventArgs e)
		{
			// Proberen om een PDF bestand aan te maken
			MigraDocFunctions.MigraDocBeginning();
		}
	}
}
