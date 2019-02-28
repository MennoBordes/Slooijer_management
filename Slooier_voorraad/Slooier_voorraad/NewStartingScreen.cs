using ExcelDataReader;
using Npgsql;
using NpgsqlTypes;
using Slooier_voorraad.Classes.CustomMessageBox;
using Slooier_voorraad.Forms;
using Slooier_voorraad.Forms.AddDataPopup;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Slooier_voorraad
{
	public partial class NewStartingScreen : Form
	{
		public string ConnString = string.Format($"Server={Properties.Settings.Default.Server}; " +
			$"User Id={Properties.Settings.Default.UserName}; " +
			$"Database={Properties.Settings.Default.Database}; " +
			$"Port={Properties.Settings.Default.Port}; " +
			$"Password={Properties.Settings.Default.password}");
		public NewStartingScreen()
		{
			InitializeComponent();
		}

		private void instellingenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool IsOpen = false;
			foreach (Form f in Application.OpenForms)
			{
				if (f.Text == "Instellingen")
				{
					IsOpen = true;
					f.Focus();
					break;
				}
			}
			if (IsOpen == false)
			{
				SettingForm f = new SettingForm
				{
					MdiParent = this
				};
				f.Show();
			}
		}

		private void sluitenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			foreach (Form frm in MdiChildren)
			{
				frm.Visible = false;
				frm.Dispose();
			}
		}

		private void afdelingToevoegenToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			bool IsOpen = false;
			foreach (Form f in Application.OpenForms)
			{
				if (f.Text == "Afdeling toevoegen")
				{
					IsOpen = true;
					f.Focus();
					break;
				}
			}
			if (!IsOpen)
			{
				AddAfdelingPopup popup = new AddAfdelingPopup(ConnString)
				{
					MdiParent = this
				};
				popup.Show();
			}
		}

		private void artikelToevoegenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool IsOpen = false;
			foreach (Form f in Application.OpenForms)
			{
				if (f.Text == "Item toevoegen")
				{
					IsOpen = true;
					f.Focus();
					break;
				}
			}
			if (!IsOpen)
			{
				AddItemPopup popup = new AddItemPopup(ConnString)
				{
					MdiParent = this
				};
				popup.Show();
			}
		}

		private void bestandToevoegenToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			SelectExcelFile();
		}

		private void SelectExcelFile()
		{
			using (OpenFileDialog FileReader = new OpenFileDialog())
			{
				FileReader.InitialDirectory = Properties.Settings.Default.InitialDir;
				FileReader.Filter = "Excel files(*.xlsx)|*.xlsx";
				FileReader.RestoreDirectory = true;
				if (FileReader.ShowDialog() == DialogResult.OK)
				{
					DataSet ExcelDataFile = ReadExcelFile(FileReader.FileName);
					(int Afdelingen, int Artikelen) = AddExcelToDB(ExcelDataFile);
					string message = $"Er zijn ({Afdelingen}) afdelingen toegevoegd.\nEr zijn ({Artikelen}) artikelen toegevoegd.";
					string header = "Toegevoegd:";
					FlexibleMessageBox.Show(message, header);
				}
			}
		}

		private DataSet ReadExcelFile(string FilePath)
		{
			using (var stream = File.Open(FilePath, FileMode.Open, FileAccess.Read))
			{
				using (var reader = ExcelReaderFactory.CreateReader(stream))
				{
					var result = reader.AsDataSet(new ExcelDataSetConfiguration()
					{
						UseColumnDataType = true,
						ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
						{
							EmptyColumnNamePrefix = "Column",
							UseHeaderRow = true,
							FilterColumn = (rowReader, columnIndex) =>
							{
								return true;
							}
						}
					});
					return result;
				}
			}
		}

		private (int, int) AddExcelToDB(DataSet NewdataSet)
		{
			DataTable usableDataset = NewdataSet.Tables[0];
			int AfdelingenAdded = 0;
			int ItemsAdded = 0;
			try
			{
				if (usableDataset.Columns.Count != 5 || usableDataset.TableName != "Artikelen" || usableDataset.Columns[0].ColumnName != "Benaming" || usableDataset.Columns[1].ColumnName != "Nummer" || usableDataset.Columns[2].ColumnName != "Omschrijving" || usableDataset.Columns[3].ColumnName != "Prijs" || usableDataset.Columns[4].ColumnName != "Voorraad")
				{
					DialogResult result = FlexibleMessageBox.Show("Het geselecteerde Bestand voldoet niet aan de eisen!", "Verkeerd Bestand", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
					if (result == DialogResult.Cancel)
					{
						return (0, 0);
					}
					else if (result == DialogResult.Retry)
					{
						SelectExcelFile();
					}
				}

				using (NpgsqlConnection conn = new NpgsqlConnection(ConnString))
				{
					conn.Open();
					string afdelingNaam = string.Empty;
					bool currentAfdelingExists = false;
					int CurrentAfdelingId = int.MinValue;
					foreach (DataRow Rows in usableDataset.Rows)
					{
						// First check whether the afdeling given in the dataset already exists in the DB
						string possibleNewAfdeling = Rows.ItemArray[0].ToString();
						if (possibleNewAfdeling != "" && possibleNewAfdeling != afdelingNaam)
						{
							currentAfdelingExists = false;
							CurrentAfdelingId = int.MinValue;
							afdelingNaam = Rows.ItemArray[0].ToString().ToLower();
							string command = "SELECT afdelingnaam, id FROM afdelingen WHERE afdelingnaam = @Afdelingnaam;";
							using (NpgsqlCommand cmd = new NpgsqlCommand(command, conn))
							{
								var ParAfd = new NpgsqlParameter("Afdelingnaam", NpgsqlDbType.Text) { Value = afdelingNaam };
								cmd.Parameters.Add(ParAfd);
								cmd.Prepare();
								using (var SqlReader = cmd.ExecuteReader())
								{
									while (SqlReader.Read())
									{
										if (SqlReader.GetString(0).ToLower() == afdelingNaam)
										{
											currentAfdelingExists = true;
											CurrentAfdelingId = SqlReader.GetInt32(1);
										}
									}
								}
							}
							// If the afdeling doesn't exist yet, add it
							if (!currentAfdelingExists)
							{
								command = "INSERT INTO afdelingen(afdelingnaam) VALUES (@Afdelingnaam) RETURNING id;";
								using (NpgsqlCommand cmd = new NpgsqlCommand(command, conn))
								{
									var ParAfd = new NpgsqlParameter("Afdelingnaam", NpgsqlDbType.Text)
									{
										Value = afdelingNaam
									};
									cmd.Parameters.Add(ParAfd);
									cmd.Prepare();
									cmd.ExecuteNonQuery();

								}
								// Get the row at which the new afdeling has been inserted

								AfdelingenAdded++;
							}
						}
						// Check if afdeling exists
						string Tcommand = "SELECT afdelingnaam, id FROM afdelingen WHERE afdelingnaam = @Afdelingnaam;";
						using (NpgsqlCommand cmd = new NpgsqlCommand(Tcommand, conn))
						{
							var ParAfd = new NpgsqlParameter("Afdelingnaam", NpgsqlDbType.Text) { Value = afdelingNaam };
							cmd.Parameters.Add(ParAfd);
							cmd.Prepare();
							using (var SqlReader = cmd.ExecuteReader())
							{
								while (SqlReader.Read())
								{
									if (SqlReader.GetString(0).ToLower() == afdelingNaam)
									{
										currentAfdelingExists = true;
										CurrentAfdelingId = SqlReader.GetInt32(1);
									}
								}
							}
						}
						// Check whether the row contains a number for the item
						bool CurrentItemExists = false;
						string Nummer = Rows.ItemArray[1].ToString();
						string Omschrijving = Rows.ItemArray[2].ToString();
						if (Nummer != "" || Omschrijving != "")
						{
							string command = "SELECT nummer, omschrijving FROM voorraad WHERE nummer = @Nummer AND omschrijving = @Omschrijving;";
							using (NpgsqlCommand cmd = new NpgsqlCommand(command, conn))
							{
								var ParNum = new NpgsqlParameter("Nummer", NpgsqlDbType.Text)
								{
									Value = Nummer
								};
								var ParOms = new NpgsqlParameter("Omschrijving", NpgsqlDbType.Text)
								{
									Value = Omschrijving
								};
								cmd.Parameters.Add(ParNum);
								cmd.Parameters.Add(ParOms);
								cmd.Prepare();
								using (var SqlReader = cmd.ExecuteReader())
								{
									while (SqlReader.Read())
									{
										CurrentItemExists = true;
									}
								}
							}
							if (!CurrentItemExists)
							{
								string ItemOmschrijving = Omschrijving;
								int ItemVoorraad = 0;
								Int32.TryParse(Rows.ItemArray[4].ToString(), out ItemVoorraad);
								double temp = 0.0;
								double Prijs = GetDouble(Rows.ItemArray[3].ToString(), temp);
								command = "INSERT INTO voorraad(nummer, omschrijving, voorraad, afdeling, prijs) VALUES(@Nummer, @Omschrijving, @Voorraad, @AfdelingId, @Prijs);";
								using (NpgsqlCommand cmd = new NpgsqlCommand(command, conn))
								{
									var ParNum = new NpgsqlParameter("Nummer", NpgsqlDbType.Text) { Value = Nummer };
									cmd.Parameters.Add(ParNum);
									var ParOms = new NpgsqlParameter("Omschrijving", NpgsqlDbType.Text) { Value = ItemOmschrijving };
									cmd.Parameters.Add(ParOms);
									var ParVoo = new NpgsqlParameter("Voorraad", NpgsqlDbType.Integer) { Value = ItemVoorraad };
									cmd.Parameters.Add(ParVoo);
									var ParAfd = new NpgsqlParameter("AfdelingId", NpgsqlDbType.Integer) { Value = CurrentAfdelingId };
									cmd.Parameters.Add(ParAfd);
									var ParPri = new NpgsqlParameter("Prijs", NpgsqlDbType.Double) { Value = Prijs };
									cmd.Parameters.Add(ParPri);
									cmd.Prepare();
									cmd.ExecuteNonQuery();
								}
								ItemsAdded++;
							}
						}
					} // Foreach Row
				} // DB connection
			} // Try
			catch (Exception ex)
			{
				FlexibleMessageBox.Show(ex.Message);
			}
			return (AfdelingenAdded, ItemsAdded);
		}

		private static double GetDouble(string value, double defaultValue)
		{
			if (!double.TryParse(value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture, out double result) &&
				!double.TryParse(value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.GetCultureInfo("en-US"), out result) &&
				!double.TryParse(value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out result))
			{
				result = defaultValue;
			}
			return result;
		}

		private void NewStartingScreen_Load(object sender, EventArgs e)
		{
			BackColor = Properties.Settings.Default.BackGroundColor;
			MenuBar.Items.OfType<ToolStripMenuItem>().ToList().ForEach(x =>
			{
				x.MouseHover += (obj, arg) => ((ToolStripDropDownItem)obj).ShowDropDown();
			});
		}

		private void voorraadBekijkenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			bool IsOpen = false;
			foreach (Form f in Application.OpenForms)
			{
				if (f.Text == "Voorraad")
				{
					IsOpen = true;
					f.Focus();
					break;
				}
			}
			if (!IsOpen)
			{
				Voorraad popup = new Voorraad(ConnString)
				{
					MdiParent = this
				};
				popup.Show();
			}
		}
	}
}
