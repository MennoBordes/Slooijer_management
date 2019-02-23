using Slooier_voorraad.Classes.CommonFunctions;
using Slooier_voorraad.Classes.CustomMessageBox;
using System;
using System.Windows.Forms;

namespace Slooier_voorraad.Forms
{
	public partial class DefaultForm : Form
	{
		string ConnString;
		public DefaultForm(string ConnString)
		{
			InitializeComponent();
			this.ConnString = ConnString;
		}

		private void PMain_SizeChanged(object sender, EventArgs e)
		{
			//CommonFunctions.SetPanelDimensions(PMain, ClientSize);
		}

		private void openOneToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			bool IsOpen = false;
			foreach (Form f in Application.OpenForms)
			{
				if (f.Text == "Instellingen")
				{
					IsOpen = true;
					f.Focus();
					break;
				}
			}
			if (IsOpen == false)
			{
				SettingForm f = new SettingForm();
				f.MdiParent = this;
				f.Show();
			}
		}

		private void openMultipleToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			SettingForm f = new SettingForm();
			f.MdiParent = this;
			f.Show();
		}

		private void closeAllToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			foreach (Form frm in MdiChildren)
			{
				if (!frm.Focused)
				{
					frm.Visible = false;
					frm.Dispose();
				}
			}
		}

		
	}
}
