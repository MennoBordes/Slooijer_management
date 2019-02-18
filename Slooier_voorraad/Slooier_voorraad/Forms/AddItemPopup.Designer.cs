namespace Slooier_voorraad.Forms
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemPopup));
			this.CbbBenaming = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.PboxLogo = new System.Windows.Forms.PictureBox();
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
			((System.ComponentModel.ISupportInitialize)(this.PboxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// CbbBenaming
			// 
			this.CbbBenaming.FormattingEnabled = true;
			this.CbbBenaming.Location = new System.Drawing.Point(360, 159);
			this.CbbBenaming.MaxDropDownItems = 20;
			this.CbbBenaming.Name = "CbbBenaming";
			this.CbbBenaming.Size = new System.Drawing.Size(142, 21);
			this.CbbBenaming.TabIndex = 1;
			this.CbbBenaming.Text = "Afdeling:";
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(197, 108);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(461, 16);
			this.label1.TabIndex = 2;
			this.label1.Text = "Hier kan één item per keer toegevoegd worden aan de Database.";
			// 
			// PboxLogo
			// 
			this.PboxLogo.BackColor = System.Drawing.Color.White;
			this.PboxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PboxLogo.BackgroundImage")));
			this.PboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PboxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PboxLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.PboxLogo.Location = new System.Drawing.Point(0, 0);
			this.PboxLogo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this.PboxLogo.Name = "PboxLogo";
			this.PboxLogo.Size = new System.Drawing.Size(874, 108);
			this.PboxLogo.TabIndex = 5;
			this.PboxLogo.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(361, 140);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(170, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Onder welke afdeling val het item?";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(361, 193);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(145, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Welk nummer heeft het item?";
			// 
			// TxbNummer
			// 
			this.TxbNummer.Location = new System.Drawing.Point(360, 209);
			this.TxbNummer.Name = "TxbNummer";
			this.TxbNummer.Size = new System.Drawing.Size(142, 20);
			this.TxbNummer.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(361, 339);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(172, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Welke omschrijving heeft het item?";
			// 
			// TxbOmschrijving
			// 
			this.TxbOmschrijving.Location = new System.Drawing.Point(360, 355);
			this.TxbOmschrijving.Multiline = true;
			this.TxbOmschrijving.Name = "TxbOmschrijving";
			this.TxbOmschrijving.Size = new System.Drawing.Size(142, 68);
			this.TxbOmschrijving.TabIndex = 10;
			// 
			// BtnAddToDb
			// 
			this.BtnAddToDb.Location = new System.Drawing.Point(360, 446);
			this.BtnAddToDb.Name = "BtnAddToDb";
			this.BtnAddToDb.Size = new System.Drawing.Size(142, 23);
			this.BtnAddToDb.TabIndex = 11;
			this.BtnAddToDb.Text = "Toevoegen";
			this.BtnAddToDb.UseVisualStyleBackColor = true;
			this.BtnAddToDb.Click += new System.EventHandler(this.BtnAddToDb_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(361, 290);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(132, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Welke prijs heeft het item?";
			// 
			// TxbPrijs
			// 
			this.TxbPrijs.Location = new System.Drawing.Point(360, 306);
			this.TxbPrijs.Name = "TxbPrijs";
			this.TxbPrijs.Size = new System.Drawing.Size(142, 20);
			this.TxbPrijs.TabIndex = 13;
			this.TxbPrijs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbPrijs_KeyPress);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(361, 242);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(189, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "Is er reeds een voorraad van het item?";
			// 
			// TxbVoorraad
			// 
			this.TxbVoorraad.Location = new System.Drawing.Point(360, 258);
			this.TxbVoorraad.Name = "TxbVoorraad";
			this.TxbVoorraad.Size = new System.Drawing.Size(142, 20);
			this.TxbVoorraad.TabIndex = 15;
			this.TxbVoorraad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbVoorraad_KeyPress);
			// 
			// AddItemPopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(874, 552);
			this.Controls.Add(this.TxbVoorraad);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.TxbPrijs);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.BtnAddToDb);
			this.Controls.Add(this.TxbOmschrijving);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.TxbNummer);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.PboxLogo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CbbBenaming);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "AddItemPopup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddItemPopup";
			this.Shown += new System.EventHandler(this.AddItemPopup_Shown);
			((System.ComponentModel.ISupportInitialize)(this.PboxLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ComboBox CbbBenaming;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox PboxLogo;
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
	}
}