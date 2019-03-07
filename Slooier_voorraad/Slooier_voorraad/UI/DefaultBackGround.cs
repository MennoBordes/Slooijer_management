using System.Windows.Forms;

namespace Slooier_voorraad.UI
{
	class DefaultBackGround : Panel
	{
		public DefaultBackGround()
		{
			BackColor = Properties.Settings.Default.BackGroundColor;
		}
	}
}
