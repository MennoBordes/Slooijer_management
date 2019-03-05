namespace Slooier_voorraad
{
	partial class NewStartingScreen
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.TmrDbCheck = new System.Windows.Forms.Timer(this.components);
			this.menuBar1 = new Slooier_voorraad.Controls.MenuBar();
			this.header1 = new Slooier_voorraad.Controls.Header();
			this.SuspendLayout();
			// 
			// TmrDbCheck
			// 
			this.TmrDbCheck.Enabled = true;
			this.TmrDbCheck.Interval = 60000;
			this.TmrDbCheck.Tick += new System.EventHandler(this.TmrDbCheck_Tick);
			// 
			// menuBar1
			// 
			this.menuBar1.Dock = System.Windows.Forms.DockStyle.Left;
			this.menuBar1.Location = new System.Drawing.Point(0, 0);
			this.menuBar1.Name = "menuBar1";
			this.menuBar1.Size = new System.Drawing.Size(110, 710);
			this.menuBar1.TabIndex = 9;
			// 
			// header1
			// 
			this.header1.Dock = System.Windows.Forms.DockStyle.Top;
			this.header1.Location = new System.Drawing.Point(110, 0);
			this.header1.Name = "header1";
			this.header1.Size = new System.Drawing.Size(1149, 100);
			this.header1.TabIndex = 10;
			// 
			// NewStartingScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1259, 710);
			this.Controls.Add(this.header1);
			this.Controls.Add(this.menuBar1);
			this.IsMdiContainer = true;
			this.Name = "NewStartingScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NewStartingScreen";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewStartingScreen_FormClosing);
			this.Load += new System.EventHandler(this.NewStartingScreen_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Timer TmrDbCheck;
		private Controls.MenuBar menuBar1;
		private Controls.Header header1;
	}
}