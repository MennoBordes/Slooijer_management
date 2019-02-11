using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Npgsql;

using Slooier_voorraad.Classes;



namespace Slooier_voorraad
{
	public partial class MainPage : Form
	{
		int[] numbers = new int[] { 5, 8, 9, 12, 8, 2, 96, 8, 1, 5 };

		string CurrentDir = AppDomain.CurrentDomain.BaseDirectory;
		string path = "..\\..\\Voorbeeld_Data\\TrialData.csv";
		List<BestelItems> items = new List<BestelItems>();
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
					if (values[0] != "" || values[1] !="" || values[3] != "")
					{
						if(values[0] != "")
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
					for (int i = 0; i < row.Cells.Count -1; i++)
					{
						if(row.Cells[i].Value != null && row.Cells[i].Value.ToString().ToLower().Contains(searchValue))
						{
							int rowIndex = row.Index;
							dataGridView1.Rows[rowIndex].Selected = true;
							dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index;
							valueResult = true;
							return;
						}
					}
				}
				if(!valueResult)
				{
					MessageBox.Show("Unable to find " + searchValue, "Not Found");
					return;
				}
			}
			catch(Exception ex)
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
				if(amount > 50) {
					string message = "Weet je zeker dat je " + amount + " wilt aftrekken van de voorraad?";
					var result = MessageBox.Show(message,"Warning", MessageBoxButtons.YesNo);
					if(result == DialogResult.No)
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
			if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void BtnDB_Click(object sender, EventArgs e)
		{
			// https://docs.microsoft.com/en-us/azure/postgresql/connect-csharp
			// Link om met de DB te werken!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
			try
			{
				string Host = "localhost";
				string DBName = "Slooier_VoorraadSysteem";
				string User = "postgres";
				string Password = "2761";
				string Port = "5432";

				string ConnString =
					String.Format(
						"Server={0}; User Id={1}; Database={2}; Port={3}; Password={4}",
						Host,
						User,
						DBName,
						Port,
						Password);
				
				var conn = new NpgsqlConnection(ConnString);
				try
				{
					conn.Open();
					// de benamingen toevoegen
					//var File = string.Concat(CurrentDir, path);
					//using (var reader = new StreamReader(File))
					//{
					//	while (!reader.EndOfStream)
					//	{
					//		var line = reader.ReadLine();
					//		var values = line.Split(';');
					//		if (values[0] != "")
					//		{
					//			var command = conn.CreateCommand();
					//			command.CommandText =
					//				String.Format(
					//					@"INSERT INTO afdelingen(benaming) VALUES ('{0}');", values[0]
					//					);
					//			int nRows = command.ExecuteNonQuery();
					//			Console.WriteLine("Number of rows inserted={0}", nRows);
					//		}							
					//	}
					//}
					
					// de data toevoegen
					//string afdeling = "";
					//var File = string.Concat(CurrentDir, path);
					//using (var reader = new StreamReader(File))
					//{
					//	while (!reader.EndOfStream)
					//	{
					//		var line = reader.ReadLine();
					//		var values = line.Split(';');
					//		if (values[0] != "")
					//		{
					//			afdeling = values[0];								
					//		}
					//		if(values[1] != "" || values[3] != "")
					//		{
					//			var command = conn.CreateCommand();
					//			command.CommandText =
					//				String.Format(
					//					@"INSERT INTO voorraad(nummer, omschrijving, voorraad, afdeling) VALUES ('{0}','{1}',{2},'{3}');", values[1], values[3], 100, afdeling
					//					);
					//			int nRows = command.ExecuteNonQuery();
					//			Console.WriteLine("Number of rows inserted={0}", nRows);
					//		}
					//	}
					//}
					conn.Close();
				}
				catch (Exception)
				{
					MessageBox.Show("Can not open connection!");
					throw;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void BtnGet_Click(object sender, EventArgs e)
		{
			try
			{
				string Host = "localhost";
				string DBName = "Slooier_VoorraadSysteem";
				string User = "postgres";
				string Password = "2761";
				string Port = "5432";

				string ConnString =
					String.Format(
						"Server={0}; User Id={1}; Database={2}; Port={3}; Password={4}",
						Host,
						User,
						DBName,
						Port,
						Password);

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
