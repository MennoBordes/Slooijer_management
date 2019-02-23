using Slooier_voorraad.Classes.CommonFunctions;
using System;
using System.Windows.Forms;

namespace Slooier_voorraad.Forms
{
	public partial class VoorraadCorrectie : Form
	{
		string ConnString;
		public VoorraadCorrectie(string ConnString, FormWindowState windowState)
		{
			InitializeComponent();
			this.ConnString = ConnString;
			WindowState = windowState;
		}

		private void PMain_SizeChanged(object sender, EventArgs e)
		{
			// Set panels to center of the Form
			CommonFunctions.SetPanelDimensions(PMain, ClientSize);
		}

		private void VoorraadCorrectie_Load(object sender, EventArgs e)
		{
			// Set minimumsize
			MinimumSize = new System.Drawing.Size(Properties.Settings.Default.MinimumSizeX, Properties.Settings.Default.MinimumSizeY);
			// Set panels to center of the Form
			CommonFunctions.SetPanelDimensions(PMain, ClientSize);
			BackColor = Properties.Settings.Default.BackGroundColor;
		}
	}
}
