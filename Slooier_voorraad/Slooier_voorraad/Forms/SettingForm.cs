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
			//// Set panels to center of the Form
			//PMain.Left = (ClientSize.Width - PMain.Width) / 2;
			//PMain.Top = (ClientSize.Height - PMain.Height) / 2;
		}

		private void SettingForm_Load(object sender, EventArgs e)
		{
			// Set minimumsize
			//MinimumSize = new System.Drawing.Size(Properties.Settings.Default.MinimumSizeX, Properties.Settings.Default.MinimumSizeY);
			//Location = new System.Drawing.Point(Properties.Settings.Default.PX, Properties.Settings.Default.PY);
			BackColor = Properties.Settings.Default.BackGroundColor;
		}
	}
}
