namespace Slooier_voorraad.Forms
{
	partial class VoorraadCorrectie
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
			this.PMain = new System.Windows.Forms.Panel();
			this.SuspendLayout();
			// 
			// PMain
			// 
			this.PMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PMain.Location = new System.Drawing.Point(0, 0);
			this.PMain.Name = "PMain";
			this.PMain.Size = new System.Drawing.Size(800, 450);
			this.PMain.TabIndex = 5;
			this.PMain.SizeChanged += new System.EventHandler(this.PMain_SizeChanged);
			// 
			// VoorraadCorrectie
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.PMain);
			this.Name = "VoorraadCorrectie";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "VoorradCorrectie";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.VoorraadCorrectie_Load);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel PMain;
	}
}