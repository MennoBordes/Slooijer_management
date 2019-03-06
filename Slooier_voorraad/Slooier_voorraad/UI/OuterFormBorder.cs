using System.Drawing;
using System.Windows.Forms;

namespace Slooier_voorraad.UI
{
	class OuterFormBorder : Panel
	{
		private Color BorderColor = Properties.Settings.Default.OuterBorderColor;

		public Color OutBackColor
		{
			get { return BorderColor; }
			set { BorderColor = value; Invalidate(); }
		}

		public OuterFormBorder()
		{
			BackColor = BorderColor;
		}
	}
}
