
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Slooier_voorraad.UI
{
	class MinMaxButton : Button
	{
		Color clr1;
		private Color color = Color.Gray;
		private Color m_hoverColor = Color.FromArgb(180, 200, 240);
		private Color clickColor = Color.FromArgb(160, 180, 200);
		private int textX = 5;
		private int textY = 10;
		private string text = "_KLJS";

		public enum CustomFormState
		{
			Normal,
			Maximize
		}

		CustomFormState _customFormState;

		public CustomFormState CFormState
		{
			get { return _customFormState; }
			set { _customFormState = value; Invalidate(); }
		}

		public string DisplayText
		{
			get { return text; }
			set { text = value; Invalidate(); }
		}

		public Color BmmBackColor
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

		public MinMaxButton()
		{
			Size = new Size(31, 24);
			ForeColor = Color.White;
			FlatStyle = FlatStyle.Flat;
			Text = "_KLJS";
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

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);
			
			switch (_customFormState)
			{
				case CustomFormState.Normal:
					pe.Graphics.FillRectangle(new SolidBrush(color), ClientRectangle);

					// draw and fill the rectangles of normal window
					for (int i = 0; i < 2; i++)
					{
						pe.Graphics.DrawRectangle(new Pen(ForeColor), textX + i + 1, textY, 10, 10);
						pe.Graphics.FillRectangle(new SolidBrush(ForeColor), textX + 1, textY - 1, 14, 4);
					}
					break;

				case CustomFormState.Maximize:
					pe.Graphics.FillRectangle(new SolidBrush(color), ClientRectangle);

					//draw and fill the rectangles of maximized window
					for (int i = 0; i < 2; i++)
					{
						pe.Graphics.DrawRectangle(new Pen(ForeColor), textX + 5, textY, 8, 8);
						pe.Graphics.FillRectangle(new SolidBrush(ForeColor), textX + 5, textY - 1, 9, 4);

						pe.Graphics.DrawRectangle(new Pen(ForeColor), textX + 2, textY + 5, 8, 8);
						pe.Graphics.FillRectangle(new SolidBrush(ForeColor), textX + 2, textY + 4, 9, 4);
					}
					break;
			}
		}

		protected override void OnClick(EventArgs e)
		{
			base.OnClick(e);

		}
	}
}
