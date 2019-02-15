using Npgsql;
using Slooier_voorraad.Classes.CustomMessageBox;
using System;
using System.Windows.Forms;

namespace Slooier_voorraad.Forms
{
	public partial class AddItemPopup : Form
	{
		string ConnString;
		public AddItemPopup(string ConnString)
		{
			InitializeComponent();
			this.ConnString = ConnString;
		}

		private void AddItemPopup_Shown(object sender, EventArgs e)
		{
			GetBenamingen();
		}

		private void GetBenamingen()
		{
			CbbBenaming.Items.Clear();
			try
			{
				using (var conn = new NpgsqlConnection(ConnString))
				{
					conn.Open();
					string SelectQuery = "SELECT afdelingnaam FROM afdelingen";
					using (var cmd = new NpgsqlCommand(SelectQuery, conn))
					{
						using (var reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								CbbBenaming.Items.Add(reader.GetString(0));
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				FlexibleMessageBox.Show(ex.Message);
			}
		}

		private void BtnAddToDb_Click(object sender, EventArgs e)
		{
			if (CbbBenaming.SelectedIndex > -1)
			{
				Console.WriteLine(CbbBenaming.SelectedIndex);
			}
			else
			{
				FlexibleMessageBox.Show("Geen Afdeling geselecteerd.\nSelecteer een afdeling!");
			}
		}

		private void TxbPrijs_KeyPress(object sender, KeyPressEventArgs e)
		{
			// Is the key pressed an number or a comma?
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
			{
				e.Handled = true;
			}
			// Only allow one comma 
			if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
			{
				e.Handled = true;
			}
		}
	}
}
