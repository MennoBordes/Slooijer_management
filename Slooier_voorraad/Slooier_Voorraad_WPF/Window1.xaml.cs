using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Controls;

namespace Slooier_Voorraad_WPF
{
	/// <summary>
	/// Interaction logic for Window1.xaml
	/// </summary>
	public partial class Window1 : Window
	{
		#region Constructor
		public Window1()
		{
			InitializeComponent();

			this.DataContext = new DirectoryStructureViewModel();			
		}

		#endregion
	}
}
