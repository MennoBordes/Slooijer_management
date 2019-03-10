using Slooier_voorraad.Classes.StartingScreenFunctions;
using Slooier_voorraad.Forms;
using Slooier_voorraad.Forms.AddDataPopup;
using Slooier_voorraad.Forms.AlterDataPopup;
using Slooier_voorraad.Forms.DeleteDataPopup;
using System;
using System.Collections.Generic;
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
    StartingScreenFunctions.GenericFormOpener<AlterItemPopup> mAlterItemForm;
    StartingScreenFunctions.GenericFormOpener<DeleteAfdelingPopup> mDeleteAfdelingForm;
		StartingScreenFunctions.GenericFormOpener<DeleteItemPopup> mDeleteItemForm;

		private void VoorraadBekijkenToolStripMenuBar_Click(object sender, EventArgs e)
		{
			mVoorraadForm.Show(this.ParentForm);
		}

		private void AfdelingToevoegenToolStripMenuBar_Click(object sender, EventArgs e)
		{
			mAddAfdelingForm.Show(this.ParentForm);
		}

		private void ArtikelToevoegenToolStripMenuBar_Click(object sender, EventArgs e)
		{
			mAddItemForm.Show(this.ParentForm);
		}

		private void BestandToevoegenToolStripMenuBar_Click(object sender, EventArgs e)
		{
			StartingScreenFunctions.SelectExcelFile(ConnString);
		}

		private void ArtikelAanpassenToolStripMenuBar_Click(object sender, EventArgs e)
		{
			//var t = new Tuple<string, int>[5];

			//t[0] = Tuple.Create("IdRef", 55);

			List<Tuple<string, int>> ls = new List<Tuple<string,int>>();
			ls.Add(new Tuple<string, int>("Test",55));

      mAlterItemForm.Show(this.ParentForm, true, ls);
      mAlterItemForm.Show(this.ParentForm);
    }

		private void AfdelingAanpassenToolStripMenuBar_Click(object sender, EventArgs e)
		{
			mAlterAfdelingForm.Show(this.ParentForm);
		}

		private void ArtikelVerwijderenToolStripMenuBar_Click(object sender, EventArgs e)
		{
			mDeleteItemForm.Show(this.ParentForm);
		}

		private void AfdelingVerwijderenToolStripMenuBar_Click(object sender, EventArgs e)
		{
			mDeleteAfdelingForm.Show(this.ParentForm);
		}

		private void InstellingenToolStripMenuBar_Click(object sender, EventArgs e)
		{
			mSettingForm.Show(this.ParentForm);
		}

		private void SluitenToolStripMenuBar_Click(object sender, EventArgs e)
		{
			foreach(Form frm in ParentForm.MdiChildren)
			{
				frm.Visible = false;
				frm.Dispose();
			}
		}
	}
}
