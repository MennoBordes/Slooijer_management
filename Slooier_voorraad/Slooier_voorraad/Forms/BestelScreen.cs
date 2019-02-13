using Equin.ApplicationFramework;
using Npgsql;
using Slooier_voorraad.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace Slooier_voorraad
{
	public partial class BestelScreen : Form
	{
		string ConnString = string.Format("Server=localhost; User Id=postgres; Database=Slooier_VoorraadSysteem; Port=5432; Password=2761");

		//Lists used
		List<MagazijnItems> items = new List<MagazijnItems>();
		List<BestelItems> BestelItemsList = new List<BestelItems>();

		public BestelScreen()
		{
			InitializeComponent();

			GetData();
		}


		#region Buttons
		private void BtnSearch_Click(object sender, EventArgs e)
		{
			Search();
		}

		private void BtnVoorraadVerlagen_Click(object sender, EventArgs e)
		{
			try
			{
				int rPos = DgvData.CurrentCell.RowIndex;
				var res = items.ElementAt(rPos);
				int amount = Convert.ToInt32(TxbVoorraad.Text);
				if (amount > 10)
				{
					string message = "Weet je zeker dat je " + amount + " wilt aftrekken van de voorraad?";
					var result = MessageBox.Show(message, "Warning", MessageBoxButtons.YesNo);
					if (result == DialogResult.No)
					{
						return;
					}
				}
				res.Voorraad = res.Voorraad - amount;
				BindingListView<MagazijnItems> view = new BindingListView<MagazijnItems>(items);
				DgvLoadData<MagazijnItems>(DgvData, view);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void BtnGet_Click(object sender, EventArgs e)
		{
			GetData();
		}
		#endregion


		#region TextBox
		private void TxbVoorraad_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void TxbZoekInput_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				Search();
			}
		}
		#endregion


		#region DatagridView
		private void DgvData_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			foreach (DataGridViewColumn dgvc in DgvData.Columns)
			{
				dgvc.ReadOnly = true;
			}
			DgvData.Columns["Bestellen"].ReadOnly = false;
		}

		private void DgvBestellen_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			foreach (DataGridViewColumn dgvc in DgvBestellen.Columns)
			{
				dgvc.ReadOnly = true;
			}
			DgvBestellen.Columns["Bestel_aantal"].ReadOnly = false;
		}

		private void DgvData_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (DgvData.IsCurrentCellDirty)
			{
				DgvData.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		private void DgvData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			AddOrderItem();
		}
		#endregion


		#region Functions
		private void DgvLoadData<T>(DataGridView gridView, BindingListView<T> data)
		{
			gridView.EndEdit();
			gridView.DataSource = data;
			gridView.Refresh();
		}

		private void GetData()
		{
			try
			{
				using (var conn = new NpgsqlConnection(ConnString))
				{
					conn.Open();
					using (var cmd = new NpgsqlCommand())
					{
						cmd.Connection = conn;
						cmd.CommandText = string.Format("SELECT afdelingnaam, nummer, omschrijving, voorraad " +
													"FROM voorraad INNER JOIN afdelingen ON (voorraad.afdeling = afdelingen.id);");

						using (var reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								var res = new MagazijnItems()
								{
									Benaming = reader.GetString(0),
									Nummer = reader.GetString(1),
									Omschrijving = reader.GetString(2),
									Voorraad = reader.GetInt32(3)
								};
								Console.WriteLine(res);
								items.Add(res);
							}
						}
						items = items.OrderBy(item => item.Benaming).ToList();
						BindingListView<MagazijnItems> view = new BindingListView<MagazijnItems>(items);
						DgvLoadData(DgvData, view);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void Search()
		{
			string searchValue = TxbZoekInput.Text.ToLower();
			DgvData.ClearSelection();
			try
			{
				bool valueResult = false;
				foreach (DataGridViewRow row in DgvData.Rows)
				{
					for (int i = 0; i < row.Cells.Count - 1; i++)
					{
						if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().ToLower().Contains(searchValue))
						{
							int rowIndex = row.Index;
							DgvData.Rows[rowIndex].Selected = true;
							DgvData.FirstDisplayedScrollingRowIndex = DgvData.SelectedRows[0].Index;
							valueResult = true;
							return;
						}
					}
				}
				if (!valueResult)
				{
					MessageBox.Show("De opgegeven waarde is niet gevonden:\n" + searchValue, "Not Found");
					return;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void AddOrderItem()
		{
			var checkedElements = new List<BestelItems>();
			foreach (DataGridViewRow row in DgvData.Rows)
			{
				if (Convert.ToBoolean(row.Cells[0].Value))
				{
					var currentIndex = items.ElementAt(row.Index);
					var newValue = new BestelItems()
					{
						Benaming = currentIndex.Benaming,
						Nummer = currentIndex.Nummer,
						Omschrijving = currentIndex.Omschrijving,
						Voorraad = currentIndex.Voorraad
					};
					checkedElements.Add(newValue);
					BestelItemsComparer comparer = new BestelItemsComparer();
					if (!BestelItemsList.Contains(newValue, comparer))
					{
						BestelItemsList.Add(newValue);
					}
				}
			}
			for (int i = 0; i < BestelItemsList.Count; i++)
			{
				bool Present = false;
				for (int j = 0; j < checkedElements.Count; j++)
				{
					BestelItemsComparer comparer = new BestelItemsComparer();
					if (comparer.Equals(BestelItemsList[i], checkedElements[j]))
					{
						Present = true;
					}
				}
				if (!Present)
				{
					BestelItemsList.RemoveAt(i);
				}
			}
			BestelItemsList = BestelItemsList.OrderBy(item => item.Benaming).ToList();
			BindingListView<BestelItems> view = new BindingListView<BestelItems>(BestelItemsList);
			DgvLoadData(DgvBestellen, view);
		}


		#endregion


	}
}
