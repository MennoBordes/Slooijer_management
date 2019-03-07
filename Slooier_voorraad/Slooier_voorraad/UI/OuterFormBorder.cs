using System.Drawing;
using System.Windows.Forms;

namespace Slooier_voorraad.UI
{
	class OuterFormBorder : Panel
	{
		private Color BorderColor = Properties.Settings.Default.OuterBorderColor;
		private readonly int m_minSize = 105;
		private readonly int m_minCheck = 100;

		public Color OutBackColor
		{
			get { return BorderColor; }
			set { BorderColor = value; Invalidate(); }
		}

		#region Initializer

		public OuterFormBorder()
		{
			BackColor = BorderColor;
		}

		#endregion

		#region Resize functionality

		private bool IsPannelDragged = false;

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);

			// Check whether the left mouse is clicked or not
			if (e.Button != MouseButtons.Left) { return; }

			// A click is registered on the border
			IsPannelDragged = true;
		}

		/// <summary>
		/// Execute the click is 
		/// </summary>
		/// <param name="e"></param>
		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);

			// The button has been released of of the border
			IsPannelDragged = false;
		}

		/// <summary>
		/// Execute when the mouse is moved over the panel
		/// </summary>
		/// <param name="e"></param>
		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			

			// Check if the there has been a click registerd on the border
			if (!IsPannelDragged) { return; }

			switch (Dock)
			{
				// only run if the parent has been docked to the left border
				case DockStyle.Left:
					if (Parent.Width <= m_minCheck)
					{
						IsPannelDragged = false;
						Parent.Width = m_minSize;
						break;
					}
					// needed in order to move right
					Parent.Location = new Point(Parent.Location.X + e.X, Parent.Location.Y);

					Parent.Width = Parent.Width - e.X;
					break;

				// only run if the parent has been docked to the bottom border
				case DockStyle.Bottom:
					if(Parent.Height <= m_minCheck)
					{
						IsPannelDragged = false;
						Parent.Height = m_minSize;
					}
					Parent.Height = Parent.Height + e.Y;
					break;

				// only run if the parent has been docked to the right border
				case DockStyle.Right:
					if (Parent.Width <= m_minCheck)
					{
						IsPannelDragged = false;
						Parent.Width = m_minSize;
						break;
					}
					Parent.Width = Parent.Width + e.X;
					break;
			}
		}

		#endregion
	}
}
