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
			this.PMain = new System.Windows.Forms.Panel();
			this.PSecundary = new System.Windows.Forms.Panel();
			this.FlpNew = new System.Windows.Forms.FlowLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.CbbHuidigeNaam = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TxbNewName = new System.Windows.Forms.TextBox();
			this.BtnAlterAfdeling = new System.Windows.Forms.Button();
			this.LblMain = new System.Windows.Forms.Label();
			this.PMain.SuspendLayout();
			this.PSecundary.SuspendLayout();
			this.FlpNew.SuspendLayout();
			this.SuspendLayout();
			// 
			// PMain
			// 
			this.PMain.Controls.Add(this.PSecundary);
			this.PMain.Controls.Add(this.LblMain);
			this.PMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PMain.Location = new System.Drawing.Point(0, 0);
			this.PMain.Name = "PMain";
			this.PMain.Size = new System.Drawing.Size(800, 450);
			this.PMain.TabIndex = 16;
			// 
			// PSecundary
			// 
			this.PSecundary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PSecundary.Controls.Add(this.FlpNew);
			this.PSecundary.Controls.Add(this.BtnAlterAfdeling);
			this.PSecundary.Location = new System.Drawing.Point(165, 35);
			this.PSecundary.Name = "PSecundary";
			this.PSecundary.Size = new System.Drawing.Size(179, 319);
			this.PSecundary.TabIndex = 16;
			// 
			// FlpNew
			// 
			this.FlpNew.Controls.Add(this.label2);
			this.FlpNew.Controls.Add(this.CbbHuidigeNaam);
			this.FlpNew.Controls.Add(this.label3);
			this.FlpNew.Controls.Add(this.TxbNewName);
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
			this.label2.Size = new System.Drawing.Size(171, 26);
			this.label2.TabIndex = 6;
			this.label2.Text = "Van welke afdeling wilt u de naam aanpassen?";
			// 
			// CbbHuidigeNaam
			// 
			this.CbbHuidigeNaam.FormattingEnabled = true;
			this.CbbHuidigeNaam.Location = new System.Drawing.Point(3, 29);
			this.CbbHuidigeNaam.MaxDropDownItems = 20;
			this.CbbHuidigeNaam.Name = "CbbHuidigeNaam";
			this.CbbHuidigeNaam.Size = new System.Drawing.Size(171, 21);
			this.CbbHuidigeNaam.TabIndex = 1;
			this.CbbHuidigeNaam.Text = "Afdeling:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(155, 26);
			this.label3.TabIndex = 7;
			this.label3.Text = "Welke naam moet de gekozen afdeling krijgen?";
			// 
			// TxbNewName
			// 
			this.TxbNewName.Location = new System.Drawing.Point(3, 82);
			this.TxbNewName.Name = "TxbNewName";
			this.TxbNewName.Size = new System.Drawing.Size(171, 20);
			this.TxbNewName.TabIndex = 2;
			// 
			// BtnAlterAfdeling
			// 
			this.BtnAlterAfdeling.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BtnAlterAfdeling.Location = new System.Drawing.Point(0, 294);
			this.BtnAlterAfdeling.Name = "BtnAlterAfdeling";
			this.BtnAlterAfdeling.Size = new System.Drawing.Size(177, 23);
			this.BtnAlterAfdeling.TabIndex = 6;
			this.BtnAlterAfdeling.Text = "Aanpassen";
			this.BtnAlterAfdeling.UseVisualStyleBackColor = true;
			// 
			// LblMain
			// 
			this.LblMain.Dock = System.Windows.Forms.DockStyle.Top;
			this.LblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblMain.Location = new System.Drawing.Point(0, 0);
			this.LblMain.Name = "LblMain";
			this.LblMain.Size = new System.Drawing.Size(800, 16);
			this.LblMain.TabIndex = 2;
			this.LblMain.Text = "Verander de naam van een afdeling";
			this.LblMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// AlterAfdelingPopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.PMain);
			this.Name = "AlterAfdelingPopup";
			this.Text = "AlterAfdelingPopup";
			this.Load += new System.EventHandler(this.AlterAfdelingPopup_Load);
			this.SizeChanged += new System.EventHandler(this.AlterAfdelingPopup_SizeChanged);
			this.PMain.ResumeLayout(false);
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
		private System.Windows.Forms.ComboBox CbbHuidigeNaam;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TxbNewName;
		private System.Windows.Forms.Button BtnAlterAfdeling;
		private System.Windows.Forms.Label LblMain;
	}
}