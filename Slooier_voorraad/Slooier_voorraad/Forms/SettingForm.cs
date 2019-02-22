using System;
using System.Windows.Forms;

namespace Slooier_voorraad.Forms
{
	public partial class SettingForm : Form
	{
		public SettingForm()
		{
			InitializeComponent();
		}

		private void SettingForm_SizeChanged(object sender, EventArgs e)
		{

			// Set panels to center of the Form
			PMain.Left = (ClientSize.Width - PMain.Width) / 2;
			PMain.Top = (ClientSize.Height - PMain.Height) / 2;
		}

		private void SettingForm_Load(object sender, EventArgs e)
		{
		}
	}
}
