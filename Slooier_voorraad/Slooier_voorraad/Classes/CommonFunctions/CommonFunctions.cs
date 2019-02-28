using ExcelDataReader;
using Npgsql;
using NpgsqlTypes;
using Slooier_voorraad.Classes.CustomMessageBox;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Slooier_voorraad.Classes.CommonFunctions
{
	public class CommonFunctions
	{
		public static List<MagazijnItems> GetMagazijnItems(List<MagazijnItems> items, string ConnString)
		{
			items.Clear();
			try
			{
				using (var conn = new NpgsqlConnection(ConnString))
				{
					conn.Open();
					using (var cmd = new NpgsqlCommand())
					{
						cmd.Connection = conn;
						cmd.CommandText = string.Format("SELECT voorraad.id, afdelingnaam, nummer, omschrijving, voorraad, prijs " +
													"FROM voorraad INNER JOIN afdelingen ON (voorraad.afdeling = afdelingen.id) ORDER BY afdelingnaam, omschrijving;");

						using (var reader = cmd.ExecuteReader())
						{
							while (reader.Read())
							{
								var res = new MagazijnItems()
								{
									Id = reader.GetInt32(0),
									Benaming = reader.GetString(1),
									Nummer = reader.GetString(2),
									Omschrijving = reader.GetString(3),
									Voorraad = reader.GetInt32(4),
									Prijs = reader.GetDouble(5)
								};
								items.Add(res);
							}
						}
						items = items.OrderBy(item => item.Benaming).ToList();
						return items;
					}
				}
			}
			catch (Exception ex)
			{
				FlexibleMessageBox.Show(ex.Message);
				return items;
			}
		}

		public static void SetPanelDimensions(Panel Child, Panel Parent)
		{
			Child.Left = (Parent.Width - Child.Width) / 2;
			Child.Top = (Parent.Height - Child.Height) / 2;
		}
		public static void SetPanelDimensions(Panel Child, System.Drawing.Size Parent)
		{
			Child.Left = (Parent.Width - Child.Width) / 2;
			Child.Top = (Parent.Height - Child.Height) / 2;
		}
	}
}

namespace Slooier_voorraad.Classes.StartingScreenFunctions
{
	public class StartingScreenFunctions
	{
		public static double GetDouble(string value, double defaultValue)
		{
			if (!double.TryParse(value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.CurrentCulture, out double result) &&
				!double.TryParse(value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.GetCultureInfo("en-US"), out result) &&
				!double.TryParse(value, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out result))
			{
				result = defaultValue;
			}
			return result;
		}

		public static DataSet ReadExcelFile(string FilePath)
		{
			try
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
			catch (Exception)
			{
				return new DataSet();
			}
		}

		public static (int, int) AddExcelToDB(DataSet NewdataSet, string ConnString)
		{
			DataTable usableDataset = NewdataSet.Tables[0];
			int AfdelingenAdded = 0;
			int ItemsAdded = 0;
			try
			{
				if (usableDataset.Columns.Count != 5 || usableDataset.TableName != "Artikelen" || usableDataset.Columns[0].ColumnName != "Benaming" || usableDataset.Columns[1].ColumnName != "Nummer" || usableDataset.Columns[2].ColumnName != "Omschrijving" || usableDataset.Columns[3].ColumnName != "Prijs" || usableDataset.Columns[4].ColumnName != "Voorraad")
				{
					return (int.MinValue, int.MinValue);
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
								Int32.TryParse(Rows.ItemArray[4].ToString(), out int ItemVoorraad);
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
	}
}
