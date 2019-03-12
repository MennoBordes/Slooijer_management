using System;
using System.Drawing;
using System.Windows.Forms;

namespace Slooier_voorraad.UI
{
	class CloseButton : Button
	{
		Color clr1;
		private Color color = Color.FromArgb(180, 20, 40);
		private Color m_hoverColor = Color.Red;
		private Color clickColor = Color.FromArgb(238, 73, 73);
		private int textX = 5;
		private int textY = -2;
		private string text = "X";

		public string DisplayText
		{
			get { return text; }
			set { text = value; Invalidate(); }
		}

		public Color BCBackColor
		{
			get { return color; }
			set { color = value; Invalidate(); }
		}

		public Color MouseHoverColor
		{
			get { return m_hoverColor; }
			set { m_hoverColor = value; Invalidate(); }
		}

		public Color MouseClickColor1
		{
			get { return clickColor; }
			set { clickColor = value; Invalidate(); }
		}

		public int TextLocation_X
		{
			get { return textX; }
			set { textX = value; Invalidate(); }
		}

		public int TextLocation_Y
		{
			get { return textY; }
			set { textY = value; Invalidate(); }
		}

		public CloseButton()
		{
			Size = new Size(31, 24);
			ForeColor = Color.White;
			FlatStyle = FlatStyle.Flat;
			Font = new Font("Microsoft YaHei UI", 20.2F, FontStyle.Bold, GraphicsUnit.Point, (byte)(0));
			Text = "X";
			text = Text;
		}

		protected override void OnMouseEnter(EventArgs e)
		{
			base.OnMouseEnter(e);
			clr1 = color;
			color = m_hoverColor;
		}

		protected override void OnMouseLeave(EventArgs e)
		{
			base.OnMouseLeave(e);
			color = clr1;
		}

		protected override void OnMouseDown(MouseEventArgs mevent)
		{
			base.OnMouseDown(mevent);
			color = clickColor;
		}

		protected override void OnMouseUp(MouseEventArgs mevent)
		{
			base.OnMouseUp(mevent);
			color = clr1;
		}

		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);
			text = Text;
			if (textX == 100 && textY == 25)
			{
				textX = Width / 3 + 10;
				textY = Height / 2 - 1;
			}

			Point p = new Point(textX, textY);
			pevent.Graphics.FillRectangle(new SolidBrush(color), ClientRectangle);
			pevent.Graphics.DrawString(text, Font, new SolidBrush(ForeColor), p);
		}

		//protected override void OnClick(EventArgs e)
		//{
		//	base.OnClick(e);
		//	Parent.Parent.Parent.Dispose();
		//}
	}
}
