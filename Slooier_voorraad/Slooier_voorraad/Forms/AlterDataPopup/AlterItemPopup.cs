using Slooier_voorraad.Classes;
using Slooier_voorraad.Classes.CommonFunctions;
using System;
using System.Windows.Forms;

namespace Slooier_voorraad.Forms.AlterDataPopup
{
	public partial class AlterItemPopup : FormInheriter
	{
		string ConnString;

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
		}

		{
		}
	}
}
