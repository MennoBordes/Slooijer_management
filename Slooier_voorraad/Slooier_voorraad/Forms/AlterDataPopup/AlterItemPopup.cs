using Slooier_voorraad.Classes;
using System;

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

		#endregion

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
	}
}
