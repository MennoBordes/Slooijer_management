using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using Slooier_voorraad.Classes;


namespace Slooier_voorraad
{
	public partial class MainPage : Form
	{
		int[] numbers = new int[] { 5, 8, 9, 12, 8, 2, 96, 8, 1, 5 };

		string CurrentDir = AppDomain.CurrentDomain.BaseDirectory;
		//@"E:\TrialData.csv";
		string path = "..\\..\\Voorbeeld_Data\\TrialData.csv";
		public MainPage()
		{
			InitializeComponent();

			Loader(path);
		}
		
		public void Loader(string Filepath)
		{
			var File = string.Concat(CurrentDir, Filepath);
			using (var reader = new StreamReader(File))
			{
				List<BestelItems> items = new List<BestelItems>();
				while (!reader.EndOfStream)
				{
					var line = reader.ReadLine();
					var values = line.Split(';');
					if (values[0] != "" || values[1] !="" || values[3] != "")
					{
						var res = new BestelItems()
						{
							Benaming = values[0],
							Nummer = values[1],
							Omschrijving = values[3]
						};
						items.Add(res);
					}
				}
				dataGridView1.DataSource = items;

			}
		}
	}
}
