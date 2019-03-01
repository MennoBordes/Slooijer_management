using System.Windows;
using System.Windows.Controls;

namespace Slooier_Voorraad_WPF
{
	//https://www.youtube.com/watch?v=6OwyNiLPDNw&list=PLrW43fNmjaQVYF4zgsD0oL9Iv6u23PI6M&index=2
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void Window_Loaded(object sender, RoutedEventArgs e)
		{
			FinishDropDown_SelectionChanged(this.FinishDropDown, null);
		}

		private void ApplyButton_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show($"The description is: {DescriptionText.Text}");
		}

		private void ResetButton_Click(object sender, RoutedEventArgs e)
		{
			WeldCheckbox.IsChecked = AssemblyCheckbox.IsChecked = PlasmaCheckbox.IsChecked = LaserCheckbox.IsChecked = PurchaseCheckbox.IsChecked = LatheCheckbox.IsChecked = DrillCheckbox.IsChecked = FoldCheckbox.IsChecked = RollCheckbox.IsChecked = SawCheckbox.IsChecked = false;
		}

		private void Checkbox_Checked(object sender, RoutedEventArgs e)
		{
			LengthText.Text += ((CheckBox)sender).Content;
		}

		private void FinishDropDown_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (NoteText == null)
				return;

			var combo = (ComboBox)sender;
			var value = (ComboBoxItem)combo.SelectedValue;

			NoteText.Text = (string)value.Content;
		}

		private void SupplierNameText_TextChanged(object sender, TextChangedEventArgs e)
		{
			this.MassText.Text = this.SupplierNameText.Text;
		}
	}
}
