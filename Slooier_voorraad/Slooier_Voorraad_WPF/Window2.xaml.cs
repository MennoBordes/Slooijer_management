using Npgsql;
using System.Data;
using System.Windows;

namespace Slooier_Voorraad_WPF
{
	/// <summary>
	/// Interaction logic for Window2.xaml
	/// </summary>
	public partial class Window2 : Window
	{
		public Window2()
		{
			InitializeComponent();
		}
		public string ConnString = string.Format($"Server=localhost; User Id=postgres; Database =Slooier_VoorraadSysteem; Port=5432; Password=2761");
		private void ButtonTester_Click(object sender, RoutedEventArgs e)
		{
			using (var conn = new NpgsqlConnection(ConnString))
			{
				conn.Open();
				string command = string.Format("SELECT voorraad.id, afdelingnaam, nummer, omschrijving, voorraad, prijs " +
													"FROM voorraad INNER JOIN afdelingen ON (voorraad.afdeling = afdelingen.id) ORDER BY afdelingnaam, omschrijving;");
				using (var cmd = new NpgsqlCommand(command, conn))
				{
					cmd.ExecuteNonQuery();

					NpgsqlDataAdapter dataAdp = new NpgsqlDataAdapter(cmd);
					DataTable dt = new DataTable("afdelingen");
					dataAdp.Fill(dt);
					DataGridTester.ItemsSource = dt.DefaultView;
					dataAdp.Update(dt);
				}
			}
		}
	}
}
