using Equin.ApplicationFramework;
using Npgsql;
using Slooier_voorraad.Classes;
using Slooier_voorraad.Classes.CommonFunctions;
using Slooier_voorraad.Classes.CustomMessageBox;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Slooier_voorraad.Forms
{
	public partial class AddOrRemoveItems : Form
	{
		string ConnString;
		//string InitialDir = "C:\\";
		string InitialDir = "A:\\Red Darkness\\Documents\\Documenten\\Github\\Repositories\\Slooier_management\\Slooier_voorraad\\Slooier_voorraad\\Voorbeeld_Data";
		List<MagazijnItems> items = new List<MagazijnItems>();

		public AddOrRemoveItems(string ConnString)
		{
			InitializeComponent();
			this.ConnString = ConnString;
		}

		private void AddOrRemoveItems_Shown(object sender, EventArgs e)
		{
			GetData();
		}

		private void BtnAddFileToDb_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
			{
				openFileDialog1.InitialDirectory = InitialDir;
				openFileDialog1.Filter = "csv files(*.csv)|*.csv";
				openFileDialog1.RestoreDirectory = true;
				if (openFileDialog1.ShowDialog() == DialogResult.OK)
				{
					var added = AddDataToExistingDB(openFileDialog1.FileName);
					string res = string.Empty;
					DataTable dt = new DataTable();
					dt.Columns.Add(new DataColumn("Toegevoegde gegevens:"));
					foreach (var item in added)
					{
						dt.Rows.Add(item);
						res = res + item + "\n";
					}
					DgvData.DataSource = dt;
				}
				else
				{
					DataTable dt = new DataTable();
					dt.Columns.Add(new DataColumn("Toegevoegde gegevens:"));
					dt.Rows.Add("Er was geen bestand geselecteerd");
					DgvData.DataSource = dt;
				}
			}
		}

		private List<string> AddDataToExistingDB(string filePath)
		{
			List<string> addedData = new List<string>();
			try
			{
				var File = filePath;
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
								bool exists = false;
								using (var cmd = new NpgsqlCommand())
								{
									cmd.Connection = conn;
									cmd.CommandText = string.Format(@"SELECT afdelingnaam FROM afdelingen WHERE afdelingnaam = '{0}';", afdelingNaam.ToLower());
									using (var SqLReader = cmd.ExecuteReader())
									{
										while (SqLReader.Read())
										{
											if (SqLReader.GetString(0).ToLower() == afdelingNaam.ToLower())
											{
												exists = true;
											}
										}
									}
								}
								if (!exists)
								{
									using (var cmd = new NpgsqlCommand())
									{
										cmd.Connection = conn;
										cmd.CommandText = string.Format(@"INSERT INTO afdelingen(afdelingnaam) VALUES('{0}');", values[0]);
										cmd.ExecuteNonQuery();
									}
									addedData.Add(values[0]);
								}
							}
						}
						if (values[1] != "" || values[3] != "")
						{
							using (var conn = new NpgsqlConnection(ConnString))
							{
								conn.Open();
								bool exists = false;
								using (var cmd = new NpgsqlCommand())
								{
									cmd.Connection = conn;
									cmd.CommandText = string.Format(@"SELECT nummer, omschrijving FROM voorraad WHERE nummer = '{0}' AND omschrijving = '{1}';", values[1], values[3]);
									using (var SqLReader = cmd.ExecuteReader())
									{
										while (SqLReader.Read())
										{
											string res = SqLReader.GetString(0).ToLower() + SqLReader.GetString(1).ToLower();

											if (SqLReader.GetString(0).ToLower() == values[1].ToLower() && SqLReader.GetString(1).ToLower() == values[3].ToLower())
											{
												exists = true;
											}
										}
									}
								}
								if (!exists)
								{
									int IdRef = int.MinValue;
									using (var cmd = new NpgsqlCommand())
									{
										cmd.Connection = conn;
										cmd.CommandText = string.Format(@"SELECT id FROM afdelingen WHERE afdelingnaam = '{0}';", afdelingNaam);
										using (var SqlReader = cmd.ExecuteReader())
										{
											while (SqlReader.Read())
											{
												IdRef = SqlReader.GetInt32(0);
											}
										}
									}
									if (IdRef != int.MinValue)
									{
										using (var cmd = new NpgsqlCommand())
										{
											cmd.Connection = conn;
											cmd.CommandText = string.Format(@"INSERT INTO voorraad(nummer, omschrijving, voorraad, afdeling) VALUES ('{0}', '{1}', {2}, {3});", values[1], values[3], 0, IdRef);
											cmd.ExecuteNonQuery();
										}
										addedData.Add((values[1], values[3]).ToString());
									}
								}
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				FlexibleMessageBox.Show(ex.Message, "An Error Occured");
			}
			return addedData;
		}

		private void GetData()
		{
			items = CommonFunctions.GetMagazijnItems(items, ConnString);
			BindingListView<MagazijnItems> view = new BindingListView<MagazijnItems>(items);
			DgvLoadData(DgvData, view);
		}

		private void DgvLoadData<T>(DataGridView gridView, BindingListView<T> data)
		{
			gridView.EndEdit();
			gridView.DataSource = data;
			gridView.Refresh();
		}

		private void BtnAddOwnData_Click(object sender, EventArgs e)
		{
			AddItemPopup popup = new AddItemPopup(ConnString);
			popup.Show();
		}


	}
}
