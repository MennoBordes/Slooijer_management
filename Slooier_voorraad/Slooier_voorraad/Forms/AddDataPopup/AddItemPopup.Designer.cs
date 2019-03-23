namespace Slooier_voorraad.Forms.AddDataPopup
{
	partial class AddItemPopup
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
			this.CbbAfdeling = new System.Windows.Forms.ComboBox();
			this.LblMain = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.LblNummer = new System.Windows.Forms.Label();
			this.TxbNummer = new System.Windows.Forms.TextBox();
			this.LblOmschrijving = new System.Windows.Forms.Label();
			this.TxbOmschrijving = new System.Windows.Forms.TextBox();
			this.BtnAddToDb = new System.Windows.Forms.Button();
			this.LblPrijs = new System.Windows.Forms.Label();
			this.TxbPrijs = new System.Windows.Forms.TextBox();
			this.LblVoorraad = new System.Windows.Forms.Label();
			this.TxbVoorraad = new System.Windows.Forms.TextBox();
			this.PMain = new System.Windows.Forms.Panel();
			this.PSecundary = new System.Windows.Forms.Panel();
			this.FlpMain = new System.Windows.Forms.FlowLayoutPanel();
			this.HeaderBar = new Slooier_voorraad.Controls.DefaultHeaderBar();
			this.LeftBorder = new Slooier_voorraad.UI.OuterFormBorder();
			this.RigthBorder = new Slooier_voorraad.UI.OuterFormBorder();
			this.BottomBorder = new Slooier_voorraad.UI.OuterFormBorder();
			this.defaultBackGround1 = new Slooier_voorraad.UI.DefaultBackGround();
			this.PMain.SuspendLayout();
			this.PSecundary.SuspendLayout();
			this.FlpMain.SuspendLayout();
			this.defaultBackGround1.SuspendLayout();
			this.SuspendLayout();
			// 
			// CbbAfdeling
			// 
			this.CbbAfdeling.FormattingEnabled = true;
			this.CbbAfdeling.Location = new System.Drawing.Point(3, 29);
			this.CbbAfdeling.MaxDropDownItems = 20;
			this.CbbAfdeling.Name = "CbbAfdeling";
			this.CbbAfdeling.Size = new System.Drawing.Size(171, 21);
			this.CbbAfdeling.TabIndex = 1;
			this.CbbAfdeling.Text = "Afdeling:";
			// 
			// LblMain
			// 
			this.LblMain.Dock = System.Windows.Forms.DockStyle.Top;
			this.LblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblMain.Location = new System.Drawing.Point(0, 0);
			this.LblMain.Name = "LblMain";
			this.LblMain.Size = new System.Drawing.Size(470, 16);
			this.LblMain.TabIndex = 2;
			this.LblMain.Text = "Hier kan één item per keer toegevoegd worden aan de Database.";
			this.LblMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(148, 26);
			this.label2.TabIndex = 6;
			this.label2.Text = "Onder welke afdeling valt het artikel?";
			// 
			// LblNummer
			// 
			this.LblNummer.AutoSize = true;
			this.LblNummer.Location = new System.Drawing.Point(3, 53);
			this.LblNummer.Name = "LblNummer";
			this.LblNummer.Size = new System.Drawing.Size(154, 13);
			this.LblNummer.TabIndex = 7;
			this.LblNummer.Text = "Welk nummer heeft het artikel?";
			// 
			// TxbNummer
			// 
			this.TxbNummer.Location = new System.Drawing.Point(3, 69);
			this.TxbNummer.Name = "TxbNummer";
			this.TxbNummer.Size = new System.Drawing.Size(171, 20);
			this.TxbNummer.TabIndex = 2;
			this.TxbNummer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbNummer_KeyPress);
			// 
			// LblOmschrijving
			// 
			this.LblOmschrijving.AutoSize = true;
			this.LblOmschrijving.Location = new System.Drawing.Point(3, 183);
			this.LblOmschrijving.Name = "LblOmschrijving";
			this.LblOmschrijving.Size = new System.Drawing.Size(147, 26);
			this.LblOmschrijving.TabIndex = 9;
			this.LblOmschrijving.Text = "Welke omschrijving heeft het artikel?";
			// 
			// TxbOmschrijving
			// 
			this.TxbOmschrijving.Location = new System.Drawing.Point(3, 212);
			this.TxbOmschrijving.Multiline = true;
			this.TxbOmschrijving.Name = "TxbOmschrijving";
			this.TxbOmschrijving.Size = new System.Drawing.Size(171, 68);
			this.TxbOmschrijving.TabIndex = 5;
			// 
			// BtnAddToDb
			// 
			this.BtnAddToDb.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BtnAddToDb.Location = new System.Drawing.Point(0, 294);
			this.BtnAddToDb.Name = "BtnAddToDb";
			this.BtnAddToDb.Size = new System.Drawing.Size(177, 23);
			this.BtnAddToDb.TabIndex = 6;
			this.BtnAddToDb.Text = "Toevoegen";
			this.BtnAddToDb.UseVisualStyleBackColor = true;
			this.BtnAddToDb.Click += new System.EventHandler(this.BtnAddToDb_Click);
			// 
			// LblPrijs
			// 
			this.LblPrijs.AutoSize = true;
			this.LblPrijs.Location = new System.Drawing.Point(3, 144);
			this.LblPrijs.Name = "LblPrijs";
			this.LblPrijs.Size = new System.Drawing.Size(141, 13);
			this.LblPrijs.TabIndex = 12;
			this.LblPrijs.Text = "Welke prijs heeft het artikel?";
			// 
			// TxbPrijs
			// 
			this.TxbPrijs.Location = new System.Drawing.Point(3, 160);
			this.TxbPrijs.Name = "TxbPrijs";
			this.TxbPrijs.Size = new System.Drawing.Size(171, 20);
			this.TxbPrijs.TabIndex = 4;
			this.TxbPrijs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbPrijs_KeyPress);
			// 
			// LblVoorraad
			// 
			this.LblVoorraad.AutoSize = true;
			this.LblVoorraad.Location = new System.Drawing.Point(3, 92);
			this.LblVoorraad.Name = "LblVoorraad";
			this.LblVoorraad.Size = new System.Drawing.Size(139, 26);
			this.LblVoorraad.TabIndex = 14;
			this.LblVoorraad.Text = "Wat is de voorraad van het artikel?";
			// 
			// TxbVoorraad
			// 
			this.TxbVoorraad.Location = new System.Drawing.Point(3, 121);
			this.TxbVoorraad.Name = "TxbVoorraad";
			this.TxbVoorraad.Size = new System.Drawing.Size(171, 20);
			this.TxbVoorraad.TabIndex = 3;
			this.TxbVoorraad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbVoorraad_KeyPress);
			// 
			// PMain
			// 
			this.PMain.Controls.Add(this.PSecundary);
			this.PMain.Controls.Add(this.LblMain);
			this.PMain.Location = new System.Drawing.Point(6, 6);
			this.PMain.Name = "PMain";
			this.PMain.Size = new System.Drawing.Size(470, 366);
			this.PMain.TabIndex = 15;
			// 
			// PSecundary
			// 
			this.PSecundary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PSecundary.Controls.Add(this.FlpMain);
			this.PSecundary.Controls.Add(this.BtnAddToDb);
			this.PSecundary.Location = new System.Drawing.Point(165, 35);
			this.PSecundary.Name = "PSecundary";
			this.PSecundary.Size = new System.Drawing.Size(179, 319);
			this.PSecundary.TabIndex = 16;
			// 
			// FlpMain
			// 
			this.FlpMain.Controls.Add(this.label2);
			this.FlpMain.Controls.Add(this.CbbAfdeling);
			this.FlpMain.Controls.Add(this.LblNummer);
			this.FlpMain.Controls.Add(this.TxbNummer);
			this.FlpMain.Controls.Add(this.LblVoorraad);
			this.FlpMain.Controls.Add(this.TxbVoorraad);
			this.FlpMain.Controls.Add(this.LblPrijs);
			this.FlpMain.Controls.Add(this.TxbPrijs);
			this.FlpMain.Controls.Add(this.LblOmschrijving);
			this.FlpMain.Controls.Add(this.TxbOmschrijving);
			this.FlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FlpMain.Location = new System.Drawing.Point(0, 0);
			this.FlpMain.Name = "FlpMain";
			this.FlpMain.Size = new System.Drawing.Size(177, 294);
			this.FlpMain.TabIndex = 15;
			// 
			// HeaderBar
			// 
			this.HeaderBar.AutoSize = true;
			this.HeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.HeaderBar.Location = new System.Drawing.Point(0, 0);
			this.HeaderBar.Name = "HeaderBar";
			this.HeaderBar.Size = new System.Drawing.Size(498, 27);
			this.HeaderBar.TabIndex = 16;
			// 
			// LeftBorder
			// 
			this.LeftBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.LeftBorder.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.LeftBorder.Dock = System.Windows.Forms.DockStyle.Left;
			this.LeftBorder.Location = new System.Drawing.Point(0, 27);
			this.LeftBorder.Name = "LeftBorder";
			this.LeftBorder.OutBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.LeftBorder.Size = new System.Drawing.Size(8, 387);
			this.LeftBorder.TabIndex = 17;
			// 
			// RigthBorder
			// 
			this.RigthBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.RigthBorder.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.RigthBorder.Dock = System.Windows.Forms.DockStyle.Right;
			this.RigthBorder.Location = new System.Drawing.Point(490, 27);
			this.RigthBorder.Name = "RigthBorder";
			this.RigthBorder.OutBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.RigthBorder.Size = new System.Drawing.Size(8, 387);
			this.RigthBorder.TabIndex = 18;
			// 
			// BottomBorder
			// 
			this.BottomBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.BottomBorder.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.BottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BottomBorder.Location = new System.Drawing.Point(8, 406);
			this.BottomBorder.Name = "BottomBorder";
			this.BottomBorder.OutBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.BottomBorder.Size = new System.Drawing.Size(482, 8);
			this.BottomBorder.TabIndex = 19;
			// 
			// defaultBackGround1
			// 
			this.defaultBackGround1.BackColor = System.Drawing.Color.Gainsboro;
			this.defaultBackGround1.Controls.Add(this.PMain);
			this.defaultBackGround1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.defaultBackGround1.Location = new System.Drawing.Point(8, 27);
			this.defaultBackGround1.Name = "defaultBackGround1";
			this.defaultBackGround1.Size = new System.Drawing.Size(482, 379);
			this.defaultBackGround1.TabIndex = 20;
			// 
			// AddItemPopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(498, 414);
			this.Controls.Add(this.defaultBackGround1);
			this.Controls.Add(this.BottomBorder);
			this.Controls.Add(this.RigthBorder);
			this.Controls.Add(this.LeftBorder);
			this.Controls.Add(this.HeaderBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddItemPopup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Artikel toevoegen";
			this.Load += new System.EventHandler(this.AddItemPopup_Load);
			this.Shown += new System.EventHandler(this.AddItemPopup_Shown);
			this.SizeChanged += new System.EventHandler(this.AddItemPopup_SizeChanged);
			this.PMain.ResumeLayout(false);
			this.PSecundary.ResumeLayout(false);
			this.FlpMain.ResumeLayout(false);
			this.FlpMain.PerformLayout();
			this.defaultBackGround1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ComboBox CbbAfdeling;
		private System.Windows.Forms.Label LblMain;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label LblNummer;
		private System.Windows.Forms.TextBox TxbNummer;
		private System.Windows.Forms.Label LblOmschrijving;
		private System.Windows.Forms.TextBox TxbOmschrijving;
		private System.Windows.Forms.Button BtnAddToDb;
		private System.Windows.Forms.Label LblPrijs;
		private System.Windows.Forms.TextBox TxbPrijs;
		private System.Windows.Forms.Label LblVoorraad;
		private System.Windows.Forms.TextBox TxbVoorraad;
		private System.Windows.Forms.Panel PMain;
		private System.Windows.Forms.FlowLayoutPanel FlpMain;
		private System.Windows.Forms.Panel PSecundary;
		private Controls.DefaultHeaderBar HeaderBar;
		private UI.OuterFormBorder LeftBorder;
		private UI.OuterFormBorder RigthBorder;
		private UI.OuterFormBorder BottomBorder;
		private UI.DefaultBackGround defaultBackGround1;
	}
}