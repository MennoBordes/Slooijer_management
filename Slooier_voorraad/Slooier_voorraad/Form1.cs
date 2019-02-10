﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
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
			try
			{
				string ConnString = "Data Source=localhost:5432;Initial Catalog=Slooier_Management;User ID=postgres;Password=1234";
				SqlConnection DB = new SqlConnection(ConnString);
				try
				{
					DB.Open();
					MessageBox.Show("Connections Open!");
					DB.Close();
				}
				catch (Exception ex1)
				{
					MessageBox.Show("Can not open connection!");
					throw;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				throw;
			}
		}
	}
}
