using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Slooier_voorraad.Forms;

namespace Slooier_voorraad
{
	public partial class StartingScreen : Form
	{
		public StartingScreen()
		{
			InitializeComponent();
		}

		private void BtnAddOrRemove_Click(object sender, EventArgs e)
		{
			AddOrRemoveItems addOrRemove = new AddOrRemoveItems();
			addOrRemove.Show();
		}

		private void BtnBestellen_Click(object sender, EventArgs e)
		{
			BestelScreen Bestel = new BestelScreen();
			Bestel.Show();
		}

		private void BtnAlterStock_Click(object sender, EventArgs e)
		{
			VoorraadCorrectie voorraad = new VoorraadCorrectie();
			voorraad.Show();
		}
	}
}
