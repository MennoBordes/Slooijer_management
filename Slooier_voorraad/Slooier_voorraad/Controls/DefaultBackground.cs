using Slooier_voorraad.UI;
using System.Drawing;
using System.Windows.Forms;

namespace Slooier_voorraad.Controls
{
	public partial class DefaultBackground : UserControl
	{
		#region Initializers
		public DefaultBackground()
		{
			InitializeComponent();
			BackColor = Properties.Settings.Default.BackGroundColor;
		}

		private void DefaultBackground_Load(object sender, System.EventArgs e)
		{
			HeaderText.Text = Parent.Text;
		}

		#endregion

		#region Header Bar
		private bool drag = false;
		private Point CurrentPoint;

		private void HeaderBar_MouseUp(object sender, MouseEventArgs e)
		{
			drag = false;
			if (e.Clicks == 2)
			{
				// Maximize the form
			}
		}

		private void HeaderBar_MouseDown(object sender, MouseEventArgs e)
		{
			drag = true;
			CurrentPoint = e.Location;
		}

		private void HeaderBar_MouseMove(object sender, MouseEventArgs e)
		{
			if (drag)
			{
				int curX = CurrentPoint.X - e.Location.X;
				int curY = CurrentPoint.Y - e.Location.Y;

				int x = Parent.Location.X - curX;
				int y = Parent.Location.Y - curY;
				Parent.Location = new Point(x, y);
			}
		}

		#region Header Buttons
		private bool isWindowMaximized = false;

		// To store the size and place of the normal window
		private Size _normalWindowSize;
		private Point _normalWindowLocation = Point.Empty;
		private void minMaxButton_Click(object sender, System.EventArgs e)
		{
			if (isWindowMaximized)
			{
				Parent.Location = _normalWindowLocation;
				Parent.Size = _normalWindowSize;
				toolTip1.SetToolTip(minMaxButton, "Maximize");
				minMaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
				isWindowMaximized = false;
			}
			else
			{
				_normalWindowSize = Parent.Size;
				_normalWindowLocation = Parent.Location;

				Size rect = Parent.Parent.ClientSize;
				Parent.Location = new Point(0, 0);
				Parent.Size = new Size(rect.Width, rect.Height);
				toolTip1.SetToolTip(minMaxButton, "Normal");
				minMaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
				isWindowMaximized = true;
			}
		}


		#endregion

		#endregion

		#region Side Panels
		#region Panel Variables

		private bool isLeftPanelDragged = false;
		private bool isRightPanelDragged = false;
		private bool isBottomPanelDragged = false;

		private Point offset;


		#endregion
		#region Left Side Panel

		private void LeftSide_MouseDown(object sender, MouseEventArgs e)
		{
			if (Parent.Location.X < 0 || e.X < 0)
			{
				isLeftPanelDragged = false;
				Parent.Location = new Point(10, Parent.Location.Y);
				return;
			}
			//else
			if (e.Button == MouseButtons.Left)
			{
				isLeftPanelDragged = true;
				return;
			}
			isLeftPanelDragged = false;
		}

		private void LeftSide_MouseUp(object sender, MouseEventArgs e)
		{
			isLeftPanelDragged = false;
		}

		private void LeftSide_MouseMove(object sender, MouseEventArgs e)
		{
			if (!isLeftPanelDragged) { return; }

			if (Parent.Width < 100)
			{
				Parent.Width = 100;
				isLeftPanelDragged = false;
				return;
			}
			// else
			Parent.Location = new Point(Parent.Location.X + e.X, Parent.Location.Y);
			Parent.Width = Width - e.X;
			return;
		}
		#endregion

		#region Bottom Side Panel

		private void BottomSide_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				isBottomPanelDragged = true;
				return;
			}
			//else
			isBottomPanelDragged = false;
		}

		private void BottomSide_MouseUp(object sender, MouseEventArgs e)
		{
			isBottomPanelDragged = false;
		}

		private void BottomSide_MouseMove(object sender, MouseEventArgs e)
		{
			if (!isBottomPanelDragged) { return; }

			if (Parent.Height < 100)
			{
				Parent.Height = 100;
				isBottomPanelDragged = false;
				return;
			}
			//else
			Parent.Height = Parent.Height + e.Y;
		}

		#endregion

		#region Right Side Panel

		private void RightSide_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				isRightPanelDragged = true;
				return;
			}
			isRightPanelDragged = false;
		}

		private void RightSide_MouseUp(object sender, MouseEventArgs e)
		{
			isRightPanelDragged = false;
		}

		private void RightSide_MouseMove(object sender, MouseEventArgs e)
		{
			if (!isRightPanelDragged) { return; }

			if (Parent.Width < 100)
			{
				Parent.Width = 100;
				isRightPanelDragged = false;
				return;
			}
			//else
			Parent.Width = Parent.Width + e.X;
		}

		#endregion

		#endregion

		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			Properties.Settings.Default.Save();
			Parent.Dispose();
		}

		
	}
}
