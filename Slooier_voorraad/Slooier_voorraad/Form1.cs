using Equin.ApplicationFramework;
using Npgsql;
using Slooier_voorraad.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;



namespace Slooier_voorraad
{
	public partial class MainPage : Form
	{
		int[] numbers = new int[] { 5, 8, 9, 12, 8, 2, 96, 8, 1, 5 };

		string CurrentDir = AppDomain.CurrentDomain.BaseDirectory;
		string path = "..\\..\\Voorbeeld_Data\\TrialData.csv";
		List<MagazijnItems> items = new List<MagazijnItems>();

		string ConnString = string.Format("Server=localhost; User Id=postgres; Database=Slooier_VoorraadSysteem; Port=5432; Password=2761");

		public MainPage()
		{
			InitializeComponent();

			GetData();
		}

		private void BtnSearch_Click(object sender, EventArgs e)
		{
			string searchValue = textBox1.Text.ToLower();
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
					MessageBox.Show("Unable to find " + searchValue, "Not Found");
					return;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void DgvLoadData<T>(DataGridView gridView, BindingListView<T> data)
		{
			gridView.EndEdit();
			gridView.DataSource = data;
			gridView.Refresh();
		}

		private void BtnVoorraadVerlagen_Click(object sender, EventArgs e)
		{
			try
			{
				int rPos = DgvData.CurrentCell.RowIndex;
				var res = items.ElementAt(rPos);
				int amount = Convert.ToInt32(TxbVoorraad.Text);
				if (amount > 50)
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

		private void TxbVoorraad_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void InsertData()
		{
			try
			{
				var File = string.Concat(CurrentDir, path);
				string afdelingNaam = "";
				using (var reader = new StreamReader(File))
				{
					while (!reader.EndOfStream)
					{
						var line = reader.ReadLine();
						var values = line.Split(';');
						if (values[0] != "")
						{
							afdelingNaam = values[0];
							using (var conn = new NpgsqlConnection(ConnString))
							{
								conn.Open();
								using (var cmd = new NpgsqlCommand())
								{
									cmd.Connection = conn;
									cmd.CommandText = string.Format(@"INSERT INTO afdelingen(afdelingnaam) VALUES('{0}');", values[0]);
									cmd.ExecuteNonQuery();
								}
							}
						}
						if (values[1] != "" || values[3] != "")
						{
							using (var conn = new NpgsqlConnection(ConnString))
							{
								conn.Open();
								using (var cmd = new NpgsqlCommand())
								{
									cmd.Connection = conn;
									cmd.CommandText = string.Format(@"SELECT id FROM afdelingen WHERE afdelingnaam = '{0}';", afdelingNaam);
									int reference = int.MinValue;
									using (var SqLReader = cmd.ExecuteReader())
									{
										while (SqLReader.Read())
										{

											reference = SqLReader.GetInt32(0);

										}
									}
									if (reference != int.MinValue)
									{
										using (var command = new NpgsqlCommand())
										{
											command.Connection = conn;
											command.CommandText = string.Format(@"INSERT INTO voorraad(nummer, omschrijving, voorraad, afdeling) VALUES ('{0}','{1}',{2},{3})", values[1], values[3], 0, reference);
											command.ExecuteNonQuery();
										}
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void BtnDB_Click(object sender, EventArgs e)
		{
			// https://docs.microsoft.com/en-us/azure/postgresql/connect-csharp
			// Link om met de DB te werken!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
			InsertData();
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
						BindingListView<MagazijnItems> view = new BindingListView<MagazijnItems>(items);
						DgvLoadData(DgvData, view);
						//DgvData.DataSource = items;
					}
				}
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

		List<BestelItems> BestelItemsList = new List<BestelItems>();
		private void AddOrderItem()
		{
			foreach (DataGridViewRow row in DgvData.Rows)
			{
				if (Convert.ToBoolean(row.Cells[0].Value))
				{
					var temp = items.ElementAt(row.Index);
					var temp2 = new BestelItems()
					{
						Benaming = temp.Benaming,
						Nummer = temp.Nummer,
						Omschrijving = temp.Omschrijving,
						Voorraad = temp.Voorraad
					};
					BestelItemsComparer comparer = new BestelItemsComparer();
					if (!BestelItemsList.Contains(temp2, comparer))
					{
						BestelItemsList.Add(temp2);
					}
				}
			}
			BindingListView<BestelItems> view = new BindingListView<BestelItems>(BestelItemsList);
			DgvLoadData(DgvBestellen, view);
		}

		private void DgvData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			AddOrderItem();
		}
	}
}
