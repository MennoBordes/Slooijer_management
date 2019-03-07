namespace Slooier_voorraad.Forms
{
	partial class SettingForm
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
      this.defaultBackground1 = new Slooier_voorraad.Controls.DefaultBackground();
      this.GbDB = new System.Windows.Forms.GroupBox();
      this.LblServer = new System.Windows.Forms.Label();
      this.LblUserName = new System.Windows.Forms.Label();
      this.GbDB.SuspendLayout();
      this.SuspendLayout();
      // 
      // defaultBackground1
      // 
      this.defaultBackground1.AutoSize = true;
      this.defaultBackground1.BackColor = System.Drawing.Color.Gainsboro;
      this.defaultBackground1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.defaultBackground1.Location = new System.Drawing.Point(0, 0);
      this.defaultBackground1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.defaultBackground1.Name = "defaultBackground1";
      this.defaultBackground1.Size = new System.Drawing.Size(1067, 554);
      this.defaultBackground1.TabIndex = 1;
      // 
      // GbDB
      // 
      this.GbDB.BackColor = System.Drawing.Color.Transparent;
      this.GbDB.Controls.Add(this.LblUserName);
      this.GbDB.Controls.Add(this.LblServer);
      this.GbDB.Location = new System.Drawing.Point(13, 33);
      this.GbDB.Margin = new System.Windows.Forms.Padding(4);
      this.GbDB.Name = "GbDB";
      this.GbDB.Padding = new System.Windows.Forms.Padding(4);
      this.GbDB.Size = new System.Drawing.Size(312, 198);
      this.GbDB.TabIndex = 0;
      this.GbDB.TabStop = false;
      this.GbDB.Text = "Database connectie";
      // 
      // LblServer
      // 
      this.LblServer.AutoSize = true;
      this.LblServer.Location = new System.Drawing.Point(9, 25);
      this.LblServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.LblServer.Name = "LblServer";
      this.LblServer.Size = new System.Drawing.Size(58, 17);
      this.LblServer.TabIndex = 0;
      this.LblServer.Text = "Server: ";
      // 
      // LblUserName
      // 
      this.LblUserName.AutoSize = true;
      this.LblUserName.Location = new System.Drawing.Point(9, 54);
      this.LblUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.LblUserName.Name = "LblUserName";
      this.LblUserName.Size = new System.Drawing.Size(125, 17);
      this.LblUserName.TabIndex = 1;
      this.LblUserName.Text = "Gebruikers naam: ";
      // 
      // SettingForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1067, 554);
      this.Controls.Add(this.GbDB);
      this.Controls.Add(this.defaultBackground1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "SettingForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Instellingen";
      this.Load += new System.EventHandler(this.SettingForm_Load);
      this.SizeChanged += new System.EventHandler(this.SettingForm_SizeChanged);
      this.GbDB.ResumeLayout(false);
      this.GbDB.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

		}

    #endregion

    private Controls.DefaultBackground defaultBackground1;
    private System.Windows.Forms.GroupBox GbDB;
    private System.Windows.Forms.Label LblUserName;
    private System.Windows.Forms.Label LblServer;
  }
}