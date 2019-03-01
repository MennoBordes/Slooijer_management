namespace Slooier_voorraad.Forms.AlterDataPopup
{
	partial class AlterItemPopup
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
			this.FlpCurrent = new System.Windows.Forms.Panel();
			this.FlpOld = new System.Windows.Forms.FlowLayoutPanel();
			this.label11 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.TxbCurrentAfdeling = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.TxbCurrentNummer = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.TxbCurrentVoorraad = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.TxbCurrentPrijs = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.TxbCurrentOmschrijving = new System.Windows.Forms.TextBox();
			this.PSecundary = new System.Windows.Forms.Panel();
			this.FlpNew = new System.Windows.Forms.FlowLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.CbbNewAfdeling = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TxbNewNummer = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.TxbNewVoorraad = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.TxbNewPrijs = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.TxbNewOmschrijving = new System.Windows.Forms.TextBox();
			this.BtnAlterArtikel = new System.Windows.Forms.Button();
			this.LblMain = new System.Windows.Forms.Label();
			this.PMain.SuspendLayout();
			this.FlpCurrent.SuspendLayout();
			this.FlpOld.SuspendLayout();
			this.PSecundary.SuspendLayout();
			this.FlpNew.SuspendLayout();
			this.SuspendLayout();
			// 
			// PMain
			// 
			this.PMain.Controls.Add(this.FlpCurrent);
			this.PMain.Controls.Add(this.PSecundary);
			this.PMain.Controls.Add(this.LblMain);
			this.PMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PMain.Location = new System.Drawing.Point(0, 0);
			this.PMain.Name = "PMain";
			this.PMain.Size = new System.Drawing.Size(403, 367);
			this.PMain.TabIndex = 16;
			// 
			// FlpCurrent
			// 
			this.FlpCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.FlpCurrent.Controls.Add(this.FlpOld);
			this.FlpCurrent.Location = new System.Drawing.Point(12, 40);
			this.FlpCurrent.Name = "FlpCurrent";
			this.FlpCurrent.Size = new System.Drawing.Size(179, 319);
			this.FlpCurrent.TabIndex = 17;
			// 
			// FlpOld
			// 
			this.FlpOld.Controls.Add(this.label11);
			this.FlpOld.Controls.Add(this.label7);
			this.FlpOld.Controls.Add(this.TxbCurrentAfdeling);
			this.FlpOld.Controls.Add(this.label1);
			this.FlpOld.Controls.Add(this.TxbCurrentNummer);
			this.FlpOld.Controls.Add(this.label8);
			this.FlpOld.Controls.Add(this.TxbCurrentVoorraad);
			this.FlpOld.Controls.Add(this.label9);
			this.FlpOld.Controls.Add(this.TxbCurrentPrijs);
			this.FlpOld.Controls.Add(this.label10);
			this.FlpOld.Controls.Add(this.TxbCurrentOmschrijving);
			this.FlpOld.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FlpOld.Location = new System.Drawing.Point(0, 0);
			this.FlpOld.Name = "FlpOld";
			this.FlpOld.Size = new System.Drawing.Size(177, 317);
			this.FlpOld.TabIndex = 15;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label11.Dock = System.Windows.Forms.DockStyle.Top;
			this.label11.Location = new System.Drawing.Point(3, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(169, 41);
			this.label11.TabIndex = 15;
			this.label11.Text = "Hier zijn de huidige gegevens van het geselecteerde artikel zichtbaar. Dit is ter" +
    " referentie.";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(3, 41);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(101, 13);
			this.label7.TabIndex = 7;
			this.label7.Text = "De huidige afdeling:";
			// 
			// TxbCurrentAfdeling
			// 
			this.TxbCurrentAfdeling.Location = new System.Drawing.Point(3, 57);
			this.TxbCurrentAfdeling.Name = "TxbCurrentAfdeling";
			this.TxbCurrentAfdeling.ReadOnly = true;
			this.TxbCurrentAfdeling.Size = new System.Drawing.Size(171, 20);
			this.TxbCurrentAfdeling.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 13);
			this.label1.TabIndex = 16;
			this.label1.Text = "Het huidige nummer:";
			// 
			// TxbCurrentNummer
			// 
			this.TxbCurrentNummer.Location = new System.Drawing.Point(3, 96);
			this.TxbCurrentNummer.Name = "TxbCurrentNummer";
			this.TxbCurrentNummer.ReadOnly = true;
			this.TxbCurrentNummer.Size = new System.Drawing.Size(171, 20);
			this.TxbCurrentNummer.TabIndex = 17;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 119);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(106, 13);
			this.label8.TabIndex = 18;
			this.label8.Text = "De huidige voorraad:";
			// 
			// TxbCurrentVoorraad
			// 
			this.TxbCurrentVoorraad.Location = new System.Drawing.Point(3, 135);
			this.TxbCurrentVoorraad.Name = "TxbCurrentVoorraad";
			this.TxbCurrentVoorraad.ReadOnly = true;
			this.TxbCurrentVoorraad.Size = new System.Drawing.Size(171, 20);
			this.TxbCurrentVoorraad.TabIndex = 19;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 158);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(82, 13);
			this.label9.TabIndex = 20;
			this.label9.Text = "De huidige prijs:";
			// 
			// TxbCurrentPrijs
			// 
			this.TxbCurrentPrijs.Location = new System.Drawing.Point(3, 174);
			this.TxbCurrentPrijs.Name = "TxbCurrentPrijs";
			this.TxbCurrentPrijs.ReadOnly = true;
			this.TxbCurrentPrijs.Size = new System.Drawing.Size(171, 20);
			this.TxbCurrentPrijs.TabIndex = 21;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(3, 197);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(122, 13);
			this.label10.TabIndex = 22;
			this.label10.Text = "De huidige omschrijving:";
			// 
			// TxbCurrentOmschrijving
			// 
			this.TxbCurrentOmschrijving.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.TxbCurrentOmschrijving.Location = new System.Drawing.Point(3, 213);
			this.TxbCurrentOmschrijving.Multiline = true;
			this.TxbCurrentOmschrijving.Name = "TxbCurrentOmschrijving";
			this.TxbCurrentOmschrijving.ReadOnly = true;
			this.TxbCurrentOmschrijving.Size = new System.Drawing.Size(171, 101);
			this.TxbCurrentOmschrijving.TabIndex = 23;
			// 
			// PSecundary
			// 
			this.PSecundary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PSecundary.Controls.Add(this.FlpNew);
			this.PSecundary.Controls.Add(this.BtnAlterArtikel);
			this.PSecundary.Location = new System.Drawing.Point(209, 40);
			this.PSecundary.Name = "PSecundary";
			this.PSecundary.Size = new System.Drawing.Size(179, 319);
			this.PSecundary.TabIndex = 16;
			// 
			// FlpNew
			// 
			this.FlpNew.Controls.Add(this.label2);
			this.FlpNew.Controls.Add(this.CbbNewAfdeling);
			this.FlpNew.Controls.Add(this.label3);
			this.FlpNew.Controls.Add(this.TxbNewNummer);
			this.FlpNew.Controls.Add(this.label6);
			this.FlpNew.Controls.Add(this.TxbNewVoorraad);
			this.FlpNew.Controls.Add(this.label5);
			this.FlpNew.Controls.Add(this.TxbNewPrijs);
			this.FlpNew.Controls.Add(this.label4);
			this.FlpNew.Controls.Add(this.TxbNewOmschrijving);
			this.FlpNew.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FlpNew.Location = new System.Drawing.Point(0, 0);
			this.FlpNew.Name = "FlpNew";
			this.FlpNew.Size = new System.Drawing.Size(177, 294);
			this.FlpNew.TabIndex = 15;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(163, 26);
			this.label2.TabIndex = 6;
			this.label2.Text = "Selecteer de afdeling waaronder het artikel hoort.";
			// 
			// CbbNewAfdeling
			// 
			this.CbbNewAfdeling.FormattingEnabled = true;
			this.CbbNewAfdeling.Location = new System.Drawing.Point(3, 29);
			this.CbbNewAfdeling.MaxDropDownItems = 20;
			this.CbbNewAfdeling.Name = "CbbNewAfdeling";
			this.CbbNewAfdeling.Size = new System.Drawing.Size(171, 21);
			this.CbbNewAfdeling.TabIndex = 1;
			this.CbbNewAfdeling.Text = "Afdeling:";
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
			// TxbNewNummer
			// 
			this.TxbNewNummer.Location = new System.Drawing.Point(3, 69);
			this.TxbNewNummer.Name = "TxbNewNummer";
			this.TxbNewNummer.Size = new System.Drawing.Size(171, 20);
			this.TxbNewNummer.TabIndex = 2;
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
			// TxbNewVoorraad
			// 
			this.TxbNewVoorraad.Location = new System.Drawing.Point(3, 121);
			this.TxbNewVoorraad.Name = "TxbNewVoorraad";
			this.TxbNewVoorraad.Size = new System.Drawing.Size(171, 20);
			this.TxbNewVoorraad.TabIndex = 3;
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
			// TxbNewPrijs
			// 
			this.TxbNewPrijs.Location = new System.Drawing.Point(3, 160);
			this.TxbNewPrijs.Name = "TxbNewPrijs";
			this.TxbNewPrijs.Size = new System.Drawing.Size(171, 20);
			this.TxbNewPrijs.TabIndex = 4;
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
			// TxbNewOmschrijving
			// 
			this.TxbNewOmschrijving.Location = new System.Drawing.Point(3, 212);
			this.TxbNewOmschrijving.Multiline = true;
			this.TxbNewOmschrijving.Name = "TxbNewOmschrijving";
			this.TxbNewOmschrijving.Size = new System.Drawing.Size(171, 68);
			this.TxbNewOmschrijving.TabIndex = 5;
			// 
			// BtnAlterArtikel
			// 
			this.BtnAlterArtikel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BtnAlterArtikel.Location = new System.Drawing.Point(0, 294);
			this.BtnAlterArtikel.Name = "BtnAlterArtikel";
			this.BtnAlterArtikel.Size = new System.Drawing.Size(177, 23);
			this.BtnAlterArtikel.TabIndex = 6;
			this.BtnAlterArtikel.Text = "Aanpassen";
			this.BtnAlterArtikel.UseVisualStyleBackColor = true;
			// 
			// LblMain
			// 
			this.LblMain.Dock = System.Windows.Forms.DockStyle.Top;
			this.LblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblMain.Location = new System.Drawing.Point(0, 0);
			this.LblMain.Name = "LblMain";
			this.LblMain.Size = new System.Drawing.Size(403, 16);
			this.LblMain.TabIndex = 2;
			this.LblMain.Text = "verander de inhoud van artikelen";
			this.LblMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.LblMain.SizeChanged += new System.EventHandler(this.LblMain_SizeChanged);
			// 
			// AlterItemPopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(403, 367);
			this.Controls.Add(this.PMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "AlterItemPopup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AlterItemPopup";
			this.Load += new System.EventHandler(this.AlterItemPopup_Load);
			this.PMain.ResumeLayout(false);
			this.FlpCurrent.ResumeLayout(false);
			this.FlpOld.ResumeLayout(false);
			this.FlpOld.PerformLayout();
			this.PSecundary.ResumeLayout(false);
			this.FlpNew.ResumeLayout(false);
			this.FlpNew.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PMain;
		private System.Windows.Forms.Panel PSecundary;
		private System.Windows.Forms.FlowLayoutPanel FlpNew;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox CbbNewAfdeling;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TxbNewNummer;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox TxbNewVoorraad;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox TxbNewPrijs;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox TxbNewOmschrijving;
		private System.Windows.Forms.Button BtnAlterArtikel;
		private System.Windows.Forms.Label LblMain;
		private System.Windows.Forms.Panel FlpCurrent;
		private System.Windows.Forms.FlowLayoutPanel FlpOld;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox TxbCurrentAfdeling;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxbCurrentNummer;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox TxbCurrentVoorraad;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox TxbCurrentPrijs;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox TxbCurrentOmschrijving;
	}
}