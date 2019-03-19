using ExcelDataReader;
using Npgsql;
using NpgsqlTypes;
using Slooier_voorraad.Classes.CustomMessageBox;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Windows.Forms;

namespace Slooier_voorraad.Classes.CommonFunctions
{
	/// <summary>
	/// A class that contains a number of common functions, which are called from multiple places
	/// </summary>
	public class CommonFunctions
  {
		/// <summary>
		/// Returns a list of items, as returned from the database
		/// </summary>
		/// <param name="items"> The list in which the items should return </param>
		/// <param name="ConnString"> The connection string to the DataBase </param>
		/// <returns> Returns a list of MagazijnItems </returns>
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
                  Afdeling = reader.GetString(1),
                  Nummer = reader.GetString(2),
                  Omschrijving = reader.GetString(3),
                  Voorraad = reader.GetInt32(4),
                  Prijs = reader.GetDouble(5)
                };
                items.Add(res);
              }
            }
            items = items.OrderBy(item => item.Afdeling).ToList();
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

		/// <summary>
		/// Set a panel to the center of the parent
		/// </summary>
		/// <param name="Child"> The element whose location should be set </param>
		/// <param name="Parent"> The element whose size will be used to center the child </param>
    public static void SetPanelDimensions(Panel Child, Panel Parent)
    {
      Child.Left = (Parent.Width - Child.Width) / 2;
      Child.Top = (Parent.Height - Child.Height) / 2;
    }

		/// <summary>
		/// Set a panel to the center of the parent, in case the parent is the main form
		/// </summary>
		/// <param name="Child"> The element whose location should be set </param>
		/// <param name="Parent"> The element whose size will be used to center the child </param>
		public static void SetPanelDimensions(Panel Child, System.Drawing.Size Parent)
    {
      Child.Left = (Parent.Width - Child.Width) / 2;
      Child.Top = (Parent.Height - Child.Height) / 2;
    }

		/// <summary>
		/// A number of children, who should all be given an equal part of the parent
		/// </summary>
		/// <param name="Children"> The element whose location should be set </param>
		/// <param name="parent"> The element whose size will be used to center the child </param>
		public static void SetPanelDimensions(Panel[] Children, Panel parent)
    {
      // set childs to each take a portion of the parent
    }

		/// <summary>
		/// A function which checks whether the connection with the DataBase still works
		/// </summary>
		/// <param name="ConnectionString"> The connection parameters to the database </param>
		/// <returns> Returns a boolean </returns>
    public static bool CheckDBConnection(string ConnectionString)
    {
      try
      {
        using (var conn = new NpgsqlConnection(ConnectionString))
        {
          conn.Open();
          conn.Close();
        }
        return true;
      }
      catch (NpgsqlException ex)
      {
        FlexibleMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      catch (SocketException ex)
      {
        FlexibleMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
      catch (Exception ex)
      {
        FlexibleMessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return false;
      }
    }

		/// <summary>
		/// A timer function which periodically checks for database availability
		/// </summary>
		/// <returns> Returns a boolean </returns>
    public static bool TimedChecker()
    {
      bool current = Properties.Settings.Default.DBConnectionValid;
      bool check = CheckDBConnection(Properties.Settings.Default.DBConnectionString);
      if (current != check)
      {
        Properties.Settings.Default.DBConnectionValid = check;
      }
      return Properties.Settings.Default.DBConnectionValid;
    }

		/// <summary>
		/// Gets all afdelingen from the database
		/// </summary>
		/// <returns></returns>
		public static List<string> GetAfdelingen()
		{
			string ConnString = Properties.Settings.Default.DBConnectionString;
			List<string> Result = new List<string>();
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
								Result.Add(reader.GetString(0));
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				FlexibleMessageBox.Show(ex.Message, "An Error Occured");
				return new List<string>();
			}
			return Result;
		}
	}
}

namespace Slooier_voorraad.Classes.StartingScreenFunctions
{
	public class StartingScreenFunctions
  {
		/// <summary>
		/// A Structure which is used to open forms as Mdi children
		/// </summary>
		/// <typeparam name="T"></typeparam>
		public struct GenericFormOpener<T> where T : Form, new()
    {
			/// <summary>
			/// The internal reference to the form
			/// </summary>
			public T TheForm { get; private set; }

      /// <summary>
      /// Checks whether the given form is already open
      /// </summary>
      /// <returns></returns>
      private bool IsFormOpen()
      {
        // Execute for each open form
        foreach (Form form in Application.OpenForms)
        {
          // If the type of the open form matches the type of the form that is being checked
          if (form.GetType() == typeof(T))
          {
            // Set form to first visible form
            form.WindowState = FormWindowState.Normal;
            form.Focus();
            return true;
          }
        }
        return false;
      }

			/// <summary>
			/// Checks whether the database connection is still working
			/// </summary>
			/// <returns></returns>
      private bool IsDbConnValid()
      {
        bool DbConVal = Properties.Settings.Default.DBConnectionValid;
        if (!DbConVal)
        {
          string message = "Het is niet gelukt om een verbinding met de Database tot stand te brengen.\n\nIndien u wijzigingen heeft gemaakt in de verbindingsinstellingen kan het zijn dat deze niet goed werken.\nIndien dit niet het geval is, controleer dan uw internetverbinding.";
          string header = "Geen Verbinding";
          FlexibleMessageBox.Show(message, header, MessageBoxButtons.OK, MessageBoxIcon.Error);
          return false;
        }
        // Connection is valid
        return true;
      }

      /// <summary>
      /// Opens the instance of the T form
      /// </summary>
      /// <param name="parent"> Will be the parent of the form </param>
      public void Show(Form parent)
      {
        // Check whether the current form is open or not
        if (IsFormOpen())
        {
          // The current form is already open
          return;
        }

        // Create an instance of the Form
        TheForm = new T();

        // Check for Database Connection
        // If there is no Db connection and the form to be opened isn't the settings form
        if (!IsDbConnValid() && TheForm.Text != "Instellingen")
        {
          return;
        }

        // Set the form parent
        TheForm.MdiParent = parent;

        // Open the form
        TheForm.Show();
      }
    }

		/// <summary>
		/// Returns a double from a string
		/// </summary>
		/// <param name="value"> The string which contains a double </param>
		/// <param name="defaultValue"> The default return type, in case the string couldn't be converted </param>
		/// <returns> Returns a double </returns>
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

		/// <summary>
		/// A function which takes the path to a excel file, and reads all content
		/// </summary>
		/// <param name="FilePath"> The path to the excel file </param>
		/// <returns> Returns a dataset containing all read data </returns>
    private static DataSet ReadExcelFile(string FilePath)
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

		/// <summary>
		/// Takes a dataset and adds it to the database
		/// </summary>
		/// <param name="NewdataSet"> The dataset containing the new data which should be inserted </param>
		/// <returns> Returns a integer tuple, in which the first stands for the amount of afdelingen added, and the latter stand for the amount of artikelen added. </returns>
		private static (int, int) AddExcelToDB(DataSet NewdataSet)
    {
			string ConnString = Properties.Settings.Default.DBConnectionString;
      DataTable usableDataset = NewdataSet.Tables[0];
      int AfdelingenAdded = 0;
      int ItemsAdded = 0;
      try
      {
        if (usableDataset.Columns.Count != 5 || usableDataset.TableName != "Artikelen" || usableDataset.Columns[0].ColumnName != "Benaming" || 
					usableDataset.Columns[1].ColumnName != "Nummer" || usableDataset.Columns[2].ColumnName != "Omschrijving" || 
					usableDataset.Columns[3].ColumnName != "Prijs" || usableDataset.Columns[4].ColumnName != "Voorraad")
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

		/// <summary>
		/// Opens a window in which the user can select an Excel file
		/// </summary>
    public static void SelectExcelFile()
    {
      using (OpenFileDialog FileReader = new OpenFileDialog())
      {
        FileReader.InitialDirectory = Properties.Settings.Default.InitialDir;
        FileReader.Filter = "Excel files(*.xlsx)|*.xlsx";
        FileReader.RestoreDirectory = true;
        if (FileReader.ShowDialog() == DialogResult.OK)
        {
          DataSet ExcelDataSet = ReadExcelFile(FileReader.FileName);
          if (ExcelDataSet.Tables.Count < 1 || ExcelDataSet.Tables[0].Rows.Count < 1)
          {
            string mess = "Er is iets fout gegaan bij het openen van het geselecteerde bestand.\nIndien het bestand al open is in een ander programma dient u dat proggramma eerst te sluiten.\n\nProbeer het daarna opnieuw.";
            string head = "An Error Occured";
            FlexibleMessageBox.Show(mess, head, MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }
          (int Afdelingen, int Artikelen) = AddExcelToDB(ExcelDataSet);
          // the following will result if the selected file isn't according to the format.
          if (Afdelingen == int.MinValue && Artikelen == int.MinValue)
          {
            DialogResult result = FlexibleMessageBox.Show("Het geselecteerde Bestand voldoet niet aan de eisen!", "Verkeerd Bestand", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            if (result == DialogResult.Cancel)
            {
              return;
            }
            else if (result == DialogResult.Retry)
            {
              SelectExcelFile();
              return;
            }
          }
          string message = $"Er zijn ({Afdelingen}) afdelingen toegevoegd.\nEr zijn ({Artikelen}) artikelen toegevoegd.";
          string header = "Toegevoegd:";
          FlexibleMessageBox.Show(message, header);
        }
      }
    }
  }
}
