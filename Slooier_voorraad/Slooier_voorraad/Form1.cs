using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
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
				//List<BestelItems> items = new List<BestelItems>();
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
				//dataGridView1.DataSource = items;				
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
					for (int i = 0; i < row.Cells.Count; i++)
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
				res.Voorraad = res.Voorraad - Convert.ToInt32(TxbVoorraad.Text);
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
	}
}
