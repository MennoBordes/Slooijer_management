using Npgsql;
using Slooier_voorraad.Classes.CustomMessageBox;
using System;
using System.Collections.Generic;
using System.Linq;


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
													"FROM voorraad INNER JOIN afdelingen ON (voorraad.afdeling = afdelingen.id);");

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
	}
}
