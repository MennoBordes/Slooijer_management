namespace Slooier_voorraad.Forms.AlterDataPopup
{
	partial class AlterAfdelingPopup
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
			this.FlpNew = new System.Windows.Forms.FlowLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.CbbHuidigeNaam = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TxbNewName = new System.Windows.Forms.TextBox();
			this.BtnAlterAfdeling = new System.Windows.Forms.Button();
			this.LblMain = new System.Windows.Forms.Label();
			this.BottomBorder = new Slooier_voorraad.UI.OuterFormBorder();
			this.RightBorder = new Slooier_voorraad.UI.OuterFormBorder();
			this.LeftBorder = new Slooier_voorraad.UI.OuterFormBorder();
			this.defaultBackground1 = new Slooier_voorraad.Controls.DefaultHeaderBar();
			this.defaultBackGround2 = new Slooier_voorraad.UI.DefaultBackGround();
			this.FlpNew.SuspendLayout();
			this.defaultBackGround2.SuspendLayout();
			this.SuspendLayout();
			// 
			// FlpNew
			// 
			this.FlpNew.BackColor = System.Drawing.Color.Transparent;
			this.FlpNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.FlpNew.Controls.Add(this.label2);
			this.FlpNew.Controls.Add(this.CbbHuidigeNaam);
			this.FlpNew.Controls.Add(this.label3);
			this.FlpNew.Controls.Add(this.TxbNewName);
			this.FlpNew.Controls.Add(this.BtnAlterAfdeling);
			this.FlpNew.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.FlpNew.Location = new System.Drawing.Point(103, 81);
			this.FlpNew.Name = "FlpNew";
			this.FlpNew.Size = new System.Drawing.Size(242, 111);
			this.FlpNew.TabIndex = 15;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(232, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Van welke afdeling wilt u de naam aanpassen?";
			// 
			// CbbHuidigeNaam
			// 
			this.CbbHuidigeNaam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.CbbHuidigeNaam.FormattingEnabled = true;
			this.CbbHuidigeNaam.Location = new System.Drawing.Point(3, 16);
			this.CbbHuidigeNaam.MaxDropDownItems = 20;
			this.CbbHuidigeNaam.Name = "CbbHuidigeNaam";
			this.CbbHuidigeNaam.Size = new System.Drawing.Size(232, 21);
			this.CbbHuidigeNaam.TabIndex = 1;
			this.CbbHuidigeNaam.Text = "Afdeling:";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 40);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(232, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Welke naam moet de gekozen afdeling krijgen?";
			// 
			// TxbNewName
			// 
			this.TxbNewName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TxbNewName.Location = new System.Drawing.Point(3, 56);
			this.TxbNewName.Name = "TxbNewName";
			this.TxbNewName.Size = new System.Drawing.Size(232, 20);
			this.TxbNewName.TabIndex = 2;
			// 
			// BtnAlterAfdeling
			// 
			this.BtnAlterAfdeling.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnAlterAfdeling.Location = new System.Drawing.Point(3, 82);
			this.BtnAlterAfdeling.Name = "BtnAlterAfdeling";
			this.BtnAlterAfdeling.Size = new System.Drawing.Size(232, 23);
			this.BtnAlterAfdeling.TabIndex = 6;
			this.BtnAlterAfdeling.Text = "Aanpassen";
			this.BtnAlterAfdeling.UseVisualStyleBackColor = true;
			// 
			// LblMain
			// 
			this.LblMain.BackColor = System.Drawing.Color.Transparent;
			this.LblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblMain.Location = new System.Drawing.Point(100, 62);
			this.LblMain.Name = "LblMain";
			this.LblMain.Size = new System.Drawing.Size(255, 16);
			this.LblMain.TabIndex = 2;
			this.LblMain.Text = "Verander de naam van een afdeling";
			this.LblMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// BottomBorder
			// 
			this.BottomBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.BottomBorder.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.BottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BottomBorder.Location = new System.Drawing.Point(8, 340);
			this.BottomBorder.Name = "BottomBorder";
			this.BottomBorder.OutBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.BottomBorder.Size = new System.Drawing.Size(435, 8);
			this.BottomBorder.TabIndex = 19;
			// 
			// RightBorder
			// 
			this.RightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.RightBorder.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.RightBorder.Dock = System.Windows.Forms.DockStyle.Right;
			this.RightBorder.Location = new System.Drawing.Point(443, 0);
			this.RightBorder.Name = "RightBorder";
			this.RightBorder.OutBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.RightBorder.Size = new System.Drawing.Size(8, 348);
			this.RightBorder.TabIndex = 18;
			// 
			// LeftBorder
			// 
			this.LeftBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.LeftBorder.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.LeftBorder.Dock = System.Windows.Forms.DockStyle.Left;
			this.LeftBorder.Location = new System.Drawing.Point(0, 0);
			this.LeftBorder.Name = "LeftBorder";
			this.LeftBorder.OutBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.LeftBorder.Size = new System.Drawing.Size(8, 348);
			this.LeftBorder.TabIndex = 17;
			// 
			// defaultBackground1
			// 
			this.defaultBackground1.AutoSize = true;
			this.defaultBackground1.BackColor = System.Drawing.Color.Gainsboro;
			this.defaultBackground1.Dock = System.Windows.Forms.DockStyle.Top;
			this.defaultBackground1.Location = new System.Drawing.Point(8, 0);
			this.defaultBackground1.Name = "defaultBackground1";
			this.defaultBackground1.Size = new System.Drawing.Size(435, 27);
			this.defaultBackground1.TabIndex = 16;
			// 
			// defaultBackGround2
			// 
			this.defaultBackGround2.BackColor = System.Drawing.Color.Gainsboro;
			this.defaultBackGround2.Controls.Add(this.FlpNew);
			this.defaultBackGround2.Controls.Add(this.LblMain);
			this.defaultBackGround2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.defaultBackGround2.Location = new System.Drawing.Point(8, 27);
			this.defaultBackGround2.Name = "defaultBackGround2";
			this.defaultBackGround2.Size = new System.Drawing.Size(435, 313);
			this.defaultBackGround2.TabIndex = 20;
			// 
			// AlterAfdelingPopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(451, 348);
			this.Controls.Add(this.defaultBackGround2);
			this.Controls.Add(this.defaultBackground1);
			this.Controls.Add(this.BottomBorder);
			this.Controls.Add(this.LeftBorder);
			this.Controls.Add(this.RightBorder);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AlterAfdelingPopup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Afdeling Aanpassen";
			this.FlpNew.ResumeLayout(false);
			this.FlpNew.PerformLayout();
			this.defaultBackGround2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox CbbHuidigeNaam;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TxbNewName;
		private System.Windows.Forms.Label LblMain;
		private System.Windows.Forms.FlowLayoutPanel FlpNew;
		private System.Windows.Forms.Button BtnAlterAfdeling;
		private Controls.DefaultHeaderBar defaultBackground1;
		private UI.OuterFormBorder LeftBorder;
		private UI.OuterFormBorder RightBorder;
		private UI.OuterFormBorder BottomBorder;
		private UI.DefaultBackGround defaultBackGround2;
	}
}