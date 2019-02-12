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
		List<BestelItems> items = new List<BestelItems>();
		string ConnString = String.Format("Server=localhost; User Id=postgres; Database=Slooier_VoorraadSysteem; Port=5432; Password=2761");
		public MainPage()
		{
			InitializeComponent();

			Loader(path);
		}

		public void Loader(string Filepath)
		{
			items.Clear();
			var File = string.Concat(CurrentDir, Filepath);
			using (var reader = new StreamReader(File))
			{
				while (!reader.EndOfStream)
				{
					var line = reader.ReadLine();
					var values = line.Split(';');
					if (values[0] != "" || values[1] != "" || values[3] != "")
					{
						if (values[0] != "")
						{
							var res = new BestelItems()
							{
								Benaming = values[0]
							};
							items.Add(res);
						}
						else
						{
							var res = new BestelItems()
							{
								Benaming = values[0],
								Nummer = values[1],
								Omschrijving = values[3],
								Voorraad = 100
							};
							items.Add(res);
						}
					}
				}
				DgvLoadData<BestelItems>(dataGridView1, items);
			}
		}


		private void BtnSearch_Click(object sender, EventArgs e)
		{
			string searchValue = textBox1.Text.ToLower();
			dataGridView1.ClearSelection();
			try
			{
				bool valueResult = false;
				foreach (DataGridViewRow row in dataGridView1.Rows)
				{
					for (int i = 0; i < row.Cells.Count - 1; i++)
					{
						if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().ToLower().Contains(searchValue))
						{
							int rowIndex = row.Index;
							dataGridView1.Rows[rowIndex].Selected = true;
							dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index;
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

		private void BtnReload_Click(object sender, EventArgs e)
		{
			Loader(path);
		}
		private void DgvLoadData<T>(DataGridView gridView, List<T> data)
		{
			gridView.DataSource = data;
			dataGridView1.Refresh();
		}

		private void BtnVoorraadVerlagen_Click(object sender, EventArgs e)
		{
			try
			{
				int rPos = dataGridView1.CurrentCell.RowIndex;
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
				DgvLoadData<BestelItems>(dataGridView1, items);
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

		private void BtnGet_Click(object sender, EventArgs e)
		{
			try
			{
				var conn = new NpgsqlConnection(ConnString);
				try
				{
					conn.Open();
					var command = conn.CreateCommand();
					command.CommandText = "SELECT * FROM voorraad";
					var reader = command.ExecuteReader();
					List<BestelItems> temp = new List<BestelItems>();
					while (reader.Read())
					{
						var res = new BestelItems()
						{
							Nummer = reader.GetString(0),
							Omschrijving = reader.GetString(2),
							Voorraad = reader.GetInt32(3),
							Benaming = reader.GetString(4)
						};
						temp.Add(res);
					}
					dataGridView1.DataSource = temp;
					conn.Close();
				}
				catch (Exception eex)
				{
					MessageBox.Show(eex.Message);
					throw;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
