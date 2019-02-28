using Slooier_voorraad.Classes.CommonFunctions;
using Slooier_voorraad.Classes.CustomMessageBox;
using Slooier_voorraad.Classes.StartingScreenFunctions;
using Slooier_voorraad.Forms;
using Slooier_voorraad.Forms.AddDataPopup;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Slooier_voorraad
{
	public partial class NewStartingScreen : Form
	{
		#region Initializers
		public string ConnString = string.Format($"Server={Properties.Settings.Default.Server}; " +
			$"User Id={Properties.Settings.Default.UserName}; " +
			$"Database={Properties.Settings.Default.Database}; " +
			$"Port={Properties.Settings.Default.Port}; " +
			$"Password={Properties.Settings.Default.password};");

		public NewStartingScreen()
		{
			InitializeComponent();
		}

		private void NewStartingScreen_Load(object sender, EventArgs e)
		{
			BackColor = Properties.Settings.Default.BackGroundColor;
			MenuBar.Items.OfType<ToolStripMenuItem>().ToList().ForEach(x =>
			{
				x.MouseHover += (obj, arg) => ((ToolStripDropDownItem)obj).ShowDropDown();
			});

			Properties.Settings.Default.DBConnectionValid = CommonFunctions.CheckDBConnection(ConnString);
			Properties.Settings.Default.DBConnectionString = ConnString;
		}

		private void NewStartingScreen_FormClosing(object sender, FormClosingEventArgs e)
		{
			Properties.Settings.Default.Save();
		}
		#endregion

		private void SelectExcelFile()
		{
			using (OpenFileDialog FileReader = new OpenFileDialog())
			{
				FileReader.InitialDirectory = Properties.Settings.Default.InitialDir;
				FileReader.Filter = "Excel files(*.xlsx)|*.xlsx";
				FileReader.RestoreDirectory = true;
				if (FileReader.ShowDialog() == DialogResult.OK)
				{
					DataSet ExcelDataSet = StartingScreenFunctions.ReadExcelFile(FileReader.FileName);
					if (ExcelDataSet.Tables.Count < 1 || ExcelDataSet.Tables[0].Rows.Count < 1)
					{
						string mess = "Er is iets fout gegaan bij het openen van het geselecteerde bestand.\nIndien het bestand al open is in een ander programma dient u dat proggramma eerst te sluiten.\n\nProbeer het daarna opnieuw.";
						string head = "An Error Occured";
						FlexibleMessageBox.Show(mess, head, MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
					(int Afdelingen, int Artikelen) = StartingScreenFunctions.AddExcelToDB(ExcelDataSet, ConnString);
					// the following will result if the selected file isn't according to the format.
					if (Afdelingen == int.MinValue && Artikelen == int.MinValue)
					{
						DialogResult result = FlexibleMessageBox.Show("Het geselecteerde Bestand voldoet niet aan de eisen!", "Verkeerd Bestand", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
						if (result == DialogResult.Cancel)
						{
							return;
						}
						else if (result == DialogResult.Retry)
						{
							SelectExcelFile();
							return;
						}
					}
					string message = $"Er zijn ({Afdelingen}) afdelingen toegevoegd.\nEr zijn ({Artikelen}) artikelen toegevoegd.";
					string header = "Toegevoegd:";
					FlexibleMessageBox.Show(message, header);
				}
			}
		}

		//struct GenericFormOpener<T> where T : Form, new()
		//{
		//	public T TheForm { get; private set; }
		//	public void Show(Form parent)
		//	{
		//		foreach (Form form in Application.OpenForms)
		//		{
		//			if (form.GetType() == typeof(T))
		//			{
		//				form.WindowState = FormWindowState.Normal;
		//				form.Focus();
		//				return;
		//			}
		//		}
		//		TheForm = new T
		//		{
		//			MdiParent = parent
		//		};
		//		TheForm.Show();
		//	}
		//}

		#region MenuBar
		private void SluitenToolStripMenuBar_Click(object sender, EventArgs e)
		{
			foreach (Form frm in MdiChildren)
			{
				frm.Visible = false;
				frm.Dispose();
			}
		}

		StartingScreenFunctions.GenericFormOpener<SettingForm> mSettingForm;
		StartingScreenFunctions.GenericFormOpener<AddAfdelingPopup> mAddAfdelingForm;
		StartingScreenFunctions.GenericFormOpener<AddItemPopup> mAddItemForm;
		StartingScreenFunctions.GenericFormOpener<Voorraad> mVoorraadForm;

		private void InstellingenToolStripMenuBar_Click(object sender, EventArgs e)
		{
			mSettingForm.Show(this);
		}

		private void AfdelingToevoegenToolStripMenuBar_Click(object sender, EventArgs e)
		{
			mAddAfdelingForm.Show(this);
		}

		private void ArtikelToevoegenToolStripMenuBar_Click(object sender, EventArgs e)
		{
			mAddItemForm.Show(this);
		}

		private void BestandToevoegenToolStripMenuBar_Click(object sender, EventArgs e)
		{
			SelectExcelFile();
		}

		private void VoorraadBekijkenToolStripMenuBar_Click(object sender, EventArgs e)
		{
			mVoorraadForm.Show(this);
		}
		#endregion

		private void TmrDbCheck_Tick(object sender, EventArgs e)
		{
			bool current = Properties.Settings.Default.DBConnectionValid;
			bool check = CommonFunctions.CheckDBConnection(ConnString);
			if (current != check)
			{
				Properties.Settings.Default.DBConnectionValid = check;
			}
		}
	}
}
