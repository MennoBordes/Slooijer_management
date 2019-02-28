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
			this.CbbBenaming = new System.Windows.Forms.ComboBox();
			this.LblMain = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.TxbNummer = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.TxbOmschrijving = new System.Windows.Forms.TextBox();
			this.BtnAddToDb = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.TxbPrijs = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.TxbVoorraad = new System.Windows.Forms.TextBox();
			this.PMain = new System.Windows.Forms.Panel();
			this.PSecundary = new System.Windows.Forms.Panel();
			this.FlpMain = new System.Windows.Forms.FlowLayoutPanel();
			this.PMain.SuspendLayout();
			this.PSecundary.SuspendLayout();
			this.FlpMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// CbbBenaming
			// 
			this.CbbBenaming.FormattingEnabled = true;
			this.CbbBenaming.Location = new System.Drawing.Point(3, 29);
			this.CbbBenaming.MaxDropDownItems = 20;
			this.CbbBenaming.Name = "CbbBenaming";
			this.CbbBenaming.Size = new System.Drawing.Size(171, 21);
			this.CbbBenaming.TabIndex = 1;
			this.CbbBenaming.Text = "Afdeling:";
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
			this.label2.Text = "Onder welke afdeling valt het item?";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(145, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Welk nummer heeft het item?";
			// 
			// TxbNummer
			// 
			this.TxbNummer.Location = new System.Drawing.Point(3, 69);
			this.TxbNummer.Name = "TxbNummer";
			this.TxbNummer.Size = new System.Drawing.Size(171, 20);
			this.TxbNummer.TabIndex = 2;
			this.TxbNummer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbNummer_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 183);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(147, 26);
			this.label4.TabIndex = 9;
			this.label4.Text = "Welke omschrijving heeft het item?";
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
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 144);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(132, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Welke prijs heeft het item?";
			// 
			// TxbPrijs
			// 
			this.TxbPrijs.Location = new System.Drawing.Point(3, 160);
			this.TxbPrijs.Name = "TxbPrijs";
			this.TxbPrijs.Size = new System.Drawing.Size(171, 20);
			this.TxbPrijs.TabIndex = 4;
			this.TxbPrijs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbPrijs_KeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 92);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(164, 26);
			this.label6.TabIndex = 14;
			this.label6.Text = "Is er reeds een voorraad van het item?";
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
			this.PMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PMain.Location = new System.Drawing.Point(0, 0);
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
			this.FlpMain.Controls.Add(this.CbbBenaming);
			this.FlpMain.Controls.Add(this.label3);
			this.FlpMain.Controls.Add(this.TxbNummer);
			this.FlpMain.Controls.Add(this.label6);
			this.FlpMain.Controls.Add(this.TxbVoorraad);
			this.FlpMain.Controls.Add(this.label5);
			this.FlpMain.Controls.Add(this.TxbPrijs);
			this.FlpMain.Controls.Add(this.label4);
			this.FlpMain.Controls.Add(this.TxbOmschrijving);
			this.FlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FlpMain.Location = new System.Drawing.Point(0, 0);
			this.FlpMain.Name = "FlpMain";
			this.FlpMain.Size = new System.Drawing.Size(177, 294);
			this.FlpMain.TabIndex = 15;
			// 
			// AddItemPopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(470, 366);
			this.Controls.Add(this.PMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AddItemPopup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Item toevoegen";
			this.Load += new System.EventHandler(this.AddItemPopup_Load);
			this.Shown += new System.EventHandler(this.AddItemPopup_Shown);
			this.SizeChanged += new System.EventHandler(this.AddItemPopup_SizeChanged);
			this.PMain.ResumeLayout(false);
			this.PSecundary.ResumeLayout(false);
			this.FlpMain.ResumeLayout(false);
			this.FlpMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.ComboBox CbbBenaming;
		private System.Windows.Forms.Label LblMain;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TxbNummer;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TxbOmschrijving;
		private System.Windows.Forms.Button BtnAddToDb;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TxbPrijs;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox TxbVoorraad;
		private System.Windows.Forms.Panel PMain;
		private System.Windows.Forms.FlowLayoutPanel FlpMain;
		private System.Windows.Forms.Panel PSecundary;
	}
}