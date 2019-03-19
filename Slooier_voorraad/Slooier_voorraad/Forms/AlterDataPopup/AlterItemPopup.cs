using Slooier_voorraad.Classes;
using Slooier_voorraad.Classes.CommonFunctions;
using System;
using System.Windows.Forms;

namespace Slooier_voorraad.Forms.AlterDataPopup
{
	public partial class AlterItemPopup : FormInheriter
	{
		string ConnString;
		MagazijnItems CurrentItem;

		#region Initializers

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
			CurrentItem = Global.AlterItem;
			CurrentSetter();
		}

		private void AlterItemPopup_Shown(object sender, EventArgs e)
		{
			GetBenamingen();
		}

		#endregion

		/// <summary>
		/// Retrieve and store all afdelingen to a combobox
		/// </summary>
		private void GetBenamingen()
		{
			var result = CommonFunctions.GetAfdelingen();
			CbbNewAfdeling.Items.Clear();
			foreach (string item in result)
			{
				CbbNewAfdeling.Items.Add(item);
			}
			// Automatically select the current afdeling
			CbbNewAfdeling.SelectedIndex = CbbNewAfdeling.FindStringExact(CurrentItem.Afdeling);
		}
		
		/// <summary>
		/// Sets the textboxes displaying the current status
		/// </summary>
		private void CurrentSetter()
		{
			TxbCurrentAfdeling.Text = CurrentItem.Afdeling;
			TxbCurrentNummer.Text = CurrentItem.Nummer;
			TxbCurrentOmschrijving.Text = CurrentItem.Omschrijving;
			TxbCurrentPrijs.Text = CurrentItem.Prijs.ToString();
			TxbCurrentVoorraad.Text = CurrentItem.Voorraad.ToString();
		}

		private void TxbNewVoorraad_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Is the key pressed a number?
			bool res = char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back;
			if (!res)
			{
				e.Handled = true;
			}
		}

		private void TxbNewNummer_KeyPress(object sender, KeyPressEventArgs e)
		{
			bool res = char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back;
			if (!res)
			{
				e.Handled = true;
			}
		}

		private void TxbNewPrijs_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Is the key pressed an number or a comma?
			if (e.KeyChar != (char)Keys.Back && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
			{
				e.Handled = true;
			}
			// Only allow one comma 
			if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
			{
				e.Handled = true;
			}
		}

		#region Alter Artikel in the database

		private void BtnAlterArtikel_Click(object sender, EventArgs e)
		{
		}

		private void CheckFilled()
		{
		}

		#endregion
	}
}
