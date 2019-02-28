using Npgsql;
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
	}
}
