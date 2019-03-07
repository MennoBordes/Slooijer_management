namespace Slooier_voorraad.Forms.DeleteDataPopup
{
	partial class DeleteAfdelingPopup
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
			this.LeftBorder = new Slooier_voorraad.UI.OuterFormBorder();
			this.RightBorder = new Slooier_voorraad.UI.OuterFormBorder();
			this.BottomBorder = new Slooier_voorraad.UI.OuterFormBorder();
			this.defaultBackGround2 = new Slooier_voorraad.UI.DefaultBackGround();
			this.SuspendLayout();
			// 
			// defaultBackground1
			// 
			this.defaultBackground1.AutoSize = true;
			this.defaultBackground1.BackColor = System.Drawing.Color.Gainsboro;
			this.defaultBackground1.Dock = System.Windows.Forms.DockStyle.Top;
			this.defaultBackground1.Location = new System.Drawing.Point(0, 0);
			this.defaultBackground1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.defaultBackground1.Name = "defaultBackground1";
			this.defaultBackground1.Size = new System.Drawing.Size(800, 27);
			this.defaultBackground1.TabIndex = 0;
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
			this.LeftBorder.TabIndex = 4;
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
			this.RightBorder.TabIndex = 6;
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
			this.BottomBorder.TabIndex = 7;
			// 
			// defaultBackGround2
			// 
			this.defaultBackGround2.BackColor = System.Drawing.Color.Gainsboro;
			this.defaultBackGround2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.defaultBackGround2.Location = new System.Drawing.Point(8, 27);
			this.defaultBackGround2.Name = "defaultBackGround2";
			this.defaultBackGround2.Size = new System.Drawing.Size(784, 415);
			this.defaultBackGround2.TabIndex = 8;
			// 
			// DeleteAfdelingPopup
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
			this.Name = "DeleteAfdelingPopup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Afdeling Verwijderen";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Controls.DefaultHeaderBar defaultBackground1;
		private UI.OuterFormBorder LeftBorder;
		private UI.OuterFormBorder RightBorder;
		private UI.OuterFormBorder BottomBorder;
		private UI.DefaultBackGround defaultBackGround2;
	}
}