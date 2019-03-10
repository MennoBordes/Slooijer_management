using Slooier_voorraad.Classes.CommonFunctions;
using System;
using System.Windows.Forms;

namespace Slooier_voorraad.Forms.AlterDataPopup
{
	public partial class AlterItemPopup : FormInheriter
	{
		string ConnString;

		public AlterItemPopup()
		{
			InitializeComponent();
      Tester();
			this.ConnString = Properties.Settings.Default.DBConnectionString;
		}
    public void Tester()
    {
      Console.WriteLine("***********************************");
    }

    public int IdRef = 0;

    public void Initializer<U>((string PropertyName, U PropertyValue) variable)
    {
      //label15.Text = IdRef.ToString();
    }

		private void AlterItemPopup_Load(object sender, EventArgs e)
		{
			BackColor = Properties.Settings.Default.BackGroundColor;
			// Set panels to center of the Form
			//CommonFunctions.SetPanelDimensions(PMain, ClientSize);
		}

		private void LblMain_SizeChanged(object sender, EventArgs e)
		{
			// Set panels to center of the Form
			//CommonFunctions.SetPanelDimensions(PMain, ClientSize);
		}
	}
}
