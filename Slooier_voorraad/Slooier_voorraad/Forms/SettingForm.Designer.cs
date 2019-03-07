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
			this.defaultBackground1 = new Slooier_voorraad.Controls.DefaultHeaderBar();
			this.GbDB = new System.Windows.Forms.GroupBox();
			this.LblUserName = new System.Windows.Forms.Label();
			this.LblServer = new System.Windows.Forms.Label();
			this.LeftBorder = new Slooier_voorraad.UI.OuterFormBorder();
			this.RightBorder = new Slooier_voorraad.UI.OuterFormBorder();
			this.BottomBorder = new Slooier_voorraad.UI.OuterFormBorder();
			this.defaultBackGround2 = new Slooier_voorraad.UI.DefaultBackGround();
			this.GbDB.SuspendLayout();
			this.defaultBackGround2.SuspendLayout();
			this.SuspendLayout();
			// 
			// defaultBackground1
			// 
			this.defaultBackground1.AutoSize = true;
			this.defaultBackground1.BackColor = System.Drawing.Color.Gainsboro;
			this.defaultBackground1.Dock = System.Windows.Forms.DockStyle.Top;
			this.defaultBackground1.Location = new System.Drawing.Point(0, 0);
			this.defaultBackground1.Name = "defaultBackground1";
			this.defaultBackground1.Size = new System.Drawing.Size(800, 27);
			this.defaultBackground1.TabIndex = 1;
			// 
			// GbDB
			// 
			this.GbDB.BackColor = System.Drawing.Color.Transparent;
			this.GbDB.Controls.Add(this.LblUserName);
			this.GbDB.Controls.Add(this.LblServer);
			this.GbDB.Location = new System.Drawing.Point(6, 6);
			this.GbDB.Name = "GbDB";
			this.GbDB.Size = new System.Drawing.Size(234, 161);
			this.GbDB.TabIndex = 0;
			this.GbDB.TabStop = false;
			this.GbDB.Text = "Database connectie";
			// 
			// LblUserName
			// 
			this.LblUserName.AutoSize = true;
			this.LblUserName.Location = new System.Drawing.Point(7, 44);
			this.LblUserName.Name = "LblUserName";
			this.LblUserName.Size = new System.Drawing.Size(93, 13);
			this.LblUserName.TabIndex = 1;
			this.LblUserName.Text = "Gebruikers naam: ";
			// 
			// LblServer
			// 
			this.LblServer.AutoSize = true;
			this.LblServer.Location = new System.Drawing.Point(7, 20);
			this.LblServer.Name = "LblServer";
			this.LblServer.Size = new System.Drawing.Size(44, 13);
			this.LblServer.TabIndex = 0;
			this.LblServer.Text = "Server: ";
			// 
			// LeftBorder
			// 
			this.LeftBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.LeftBorder.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.LeftBorder.Dock = System.Windows.Forms.DockStyle.Left;
			this.LeftBorder.Location = new System.Drawing.Point(0, 27);
			this.LeftBorder.Name = "LeftBorder";
			this.LeftBorder.OutBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.LeftBorder.Size = new System.Drawing.Size(8, 423);
			this.LeftBorder.TabIndex = 2;
			// 
			// RightBorder
			// 
			this.RightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.RightBorder.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.RightBorder.Dock = System.Windows.Forms.DockStyle.Right;
			this.RightBorder.Location = new System.Drawing.Point(792, 27);
			this.RightBorder.Name = "RightBorder";
			this.RightBorder.OutBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.RightBorder.Size = new System.Drawing.Size(8, 423);
			this.RightBorder.TabIndex = 3;
			// 
			// BottomBorder
			// 
			this.BottomBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.BottomBorder.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.BottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BottomBorder.Location = new System.Drawing.Point(8, 442);
			this.BottomBorder.Name = "BottomBorder";
			this.BottomBorder.OutBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.BottomBorder.Size = new System.Drawing.Size(784, 8);
			this.BottomBorder.TabIndex = 4;
			// 
			// defaultBackGround2
			// 
			this.defaultBackGround2.BackColor = System.Drawing.Color.Gainsboro;
			this.defaultBackGround2.Controls.Add(this.GbDB);
			this.defaultBackGround2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.defaultBackGround2.Location = new System.Drawing.Point(8, 27);
			this.defaultBackGround2.Name = "defaultBackGround2";
			this.defaultBackGround2.Size = new System.Drawing.Size(784, 415);
			this.defaultBackGround2.TabIndex = 5;
			// 
			// SettingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.defaultBackGround2);
			this.Controls.Add(this.BottomBorder);
			this.Controls.Add(this.RightBorder);
			this.Controls.Add(this.LeftBorder);
			this.Controls.Add(this.defaultBackground1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SettingForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Instellingen";
			this.Load += new System.EventHandler(this.SettingForm_Load);
			this.SizeChanged += new System.EventHandler(this.SettingForm_SizeChanged);
			this.GbDB.ResumeLayout(false);
			this.GbDB.PerformLayout();
			this.defaultBackGround2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

    #endregion

    private Controls.DefaultHeaderBar defaultBackground1;
    private System.Windows.Forms.GroupBox GbDB;
    private System.Windows.Forms.Label LblUserName;
    private System.Windows.Forms.Label LblServer;
		private UI.OuterFormBorder LeftBorder;
		private UI.OuterFormBorder RightBorder;
		private UI.OuterFormBorder BottomBorder;
		private UI.DefaultBackGround defaultBackGround2;
	}
}