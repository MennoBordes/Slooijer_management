using System.Windows.Forms;

namespace Slooier_voorraad.Forms.AddDataPopup
{
	public partial class AddAfdelingPopup : Form
	{
		string ConnString;
		public AddAfdelingPopup(string ConnString)
		{
			InitializeComponent();
			this.ConnString = ConnString;
		}
	}
}
