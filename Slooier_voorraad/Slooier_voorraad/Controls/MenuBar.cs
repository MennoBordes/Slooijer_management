using Slooier_voorraad.Classes.CustomMessageBox;
using Slooier_voorraad.Classes.StartingScreenFunctions;
using Slooier_voorraad.Forms;
using Slooier_voorraad.Forms.AddDataPopup;
using Slooier_voorraad.Forms.AlterDataPopup;
using Slooier_voorraad.Forms.DeleteDataPopup;
using System;
using System.Windows.Forms;

namespace Slooier_voorraad.Controls
{
	public partial class MenuBar : UserControl
	{
		public MenuBar()
		{
			InitializeComponent();
		}

		private string ConnString = Properties.Settings.Default.DBConnectionString;

		StartingScreenFunctions.GenericFormOpener<SettingForm> mSettingForm;
		StartingScreenFunctions.GenericFormOpener<AddAfdelingPopup> mAddAfdelingForm;
		StartingScreenFunctions.GenericFormOpener<AddItemPopup> mAddItemForm;
		StartingScreenFunctions.GenericFormOpener<Voorraad> mVoorraadForm;
		StartingScreenFunctions.GenericFormOpener<AlterAfdelingPopup> mAlterAfdelingForm;
		//StartingScreenFunctions.GenericFormOpener<AlterItemPopup> mAlterItemForm;
		StartingScreenFunctions.GenericFormOpener<DeleteAfdelingPopup> mDeleteAfdelingForm;
		StartingScreenFunctions.GenericFormOpener<DeleteItemPopup> mDeleteItemForm;

		private void VoorraadBekijkenToolStripMenuBar_Click(object sender, EventArgs e)
		{
			mVoorraadForm.Show(ParentForm);
		}

		private void AfdelingToevoegenToolStripMenuBar_Click(object sender, EventArgs e)
		{
			mAddAfdelingForm.Show(ParentForm);
		}

		private void ArtikelToevoegenToolStripMenuBar_Click(object sender, EventArgs e)
		{
			mAddItemForm.Show(ParentForm);
		}

		private void BestandToevoegenToolStripMenuBar_Click(object sender, EventArgs e)
		{
			StartingScreenFunctions.SelectExcelFile();
		}

		private void ArtikelAanpassenToolStripMenuBar_Click(object sender, EventArgs e)
		{
			mVoorraadForm.Show(ParentForm);
			FlexibleMessageBox.Show("Klik dubbel op het artikel dat u aan wilt passen.");
		}

		private void AfdelingAanpassenToolStripMenuBar_Click(object sender, EventArgs e)
		{
			mAlterAfdelingForm.Show(ParentForm);
		}

		private void ArtikelVerwijderenToolStripMenuBar_Click(object sender, EventArgs e)
		{
			mDeleteItemForm.Show(ParentForm);
		}

		private void AfdelingVerwijderenToolStripMenuBar_Click(object sender, EventArgs e)
		{
			mDeleteAfdelingForm.Show(ParentForm);
		}

		private void InstellingenToolStripMenuBar_Click(object sender, EventArgs e)
		{
			mSettingForm.Show(ParentForm);
		}

		private void SluitenToolStripMenuBar_Click(object sender, EventArgs e)
		{
			foreach (Form frm in ParentForm.MdiChildren)
			{
				frm.Visible = false;
				frm.Dispose();
			}
		}
	}
}
