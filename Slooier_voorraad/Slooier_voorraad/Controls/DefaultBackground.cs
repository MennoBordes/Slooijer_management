using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slooier_voorraad.Controls
{
	public partial class DefaultBackground : UserControl
	{
		public DefaultBackground()
		{
			InitializeComponent();
			this.BackColor = Properties.Settings.Default.BackGroundColor;
		}

		private void DefaultBackground_Load(object sender, EventArgs e)
		{
			//button1.Top = Parent.Height - button1.Height;
			button1.Left = Parent.Width - button1.Width;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Parent.Dispose();
		}
	}
}
