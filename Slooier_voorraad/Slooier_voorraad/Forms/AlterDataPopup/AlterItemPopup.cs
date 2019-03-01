using Slooier_voorraad.Classes.CommonFunctions;
using System;
using System.Windows.Forms;

namespace Slooier_voorraad.Forms.AlterDataPopup
{
	public partial class AlterItemPopup : Form
	{
		string ConnString;
		public AlterItemPopup()
		{
			InitializeComponent();
			this.ConnString = Properties.Settings.Default.DBConnectionString;
		}

		private void AlterItemPopup_Load(object sender, EventArgs e)
		{
			BackColor = Properties.Settings.Default.BackGroundColor;
			// Set panels to center of the Form
			CommonFunctions.SetPanelDimensions(PMain, ClientSize);
		}

		private void LblMain_SizeChanged(object sender, EventArgs e)
		{
			// Set panels to center of the Form
			CommonFunctions.SetPanelDimensions(PMain, ClientSize);
			//CommonFunctions.SetPanelDimensions(FlpNew, PSecundary);
		}
	}
}
