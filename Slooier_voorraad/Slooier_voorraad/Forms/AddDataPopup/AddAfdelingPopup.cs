using System.Windows.Forms;

namespace Slooier_voorraad.Forms.AddDataPopup
{
	public partial class AddAfdelingPopup : Form
	{
		string ConnString;
		public AddAfdelingPopup()
		{
			InitializeComponent();
			this.ConnString = Properties.Settings.Default.DBConnectionString;
		}

		private void AddAfdelingPopup_Load(object sender, System.EventArgs e)
		{
			BackColor = Properties.Settings.Default.BackGroundColor;
		}
	}
}
