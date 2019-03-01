using Slooier_voorraad.Classes.CommonFunctions;
using System;
using System.Windows.Forms;

namespace Slooier_voorraad.Forms.AlterDataPopup
{
	public partial class AlterAfdelingPopup : Form
	{
		string ConnString;
		public AlterAfdelingPopup()
		{
			InitializeComponent();
			ConnString = Properties.Settings.Default.DBConnectionString;
		}

		private void AlterAfdelingPopup_Load(object sender, EventArgs e)
		{
			BackColor = Properties.Settings.Default.BackGroundColor;
			CommonFunctions.SetPanelDimensions(PMain, ClientSize);
			CommonFunctions.SetPanelDimensions(FlpNew, PMain);
		}

		private void AlterAfdelingPopup_SizeChanged(object sender, EventArgs e)
		{
			// Set panels to center of the Form
			CommonFunctions.SetPanelDimensions(PMain, ClientSize);
			CommonFunctions.SetPanelDimensions(FlpNew, PMain);
		}
	}
}
