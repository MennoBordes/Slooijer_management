namespace Slooier_voorraad.Forms.AddDataPopup
{
	partial class AddAfdelingPopup
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
			this.FlpMain = new System.Windows.Forms.FlowLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.TxbAfdeling = new System.Windows.Forms.TextBox();
			this.BtnAddToDb = new System.Windows.Forms.Button();
			this.LblMain = new System.Windows.Forms.Label();
			this.PMain.SuspendLayout();
			this.PSecundary.SuspendLayout();
			this.FlpMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// PMain
			// 
			this.PMain.Controls.Add(this.PSecundary);
			this.PMain.Controls.Add(this.LblMain);
			this.PMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PMain.Location = new System.Drawing.Point(0, 0);
			this.PMain.Name = "PMain";
			this.PMain.Size = new System.Drawing.Size(499, 367);
			this.PMain.TabIndex = 16;
			// 
			// PSecundary
			// 
			this.PSecundary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PSecundary.Controls.Add(this.FlpMain);
			this.PSecundary.Controls.Add(this.BtnAddToDb);
			this.PSecundary.Location = new System.Drawing.Point(123, 88);
			this.PSecundary.Name = "PSecundary";
			this.PSecundary.Size = new System.Drawing.Size(241, 142);
			this.PSecundary.TabIndex = 16;
			// 
			// FlpMain
			// 
			this.FlpMain.Controls.Add(this.label3);
			this.FlpMain.Controls.Add(this.TxbAfdeling);
			this.FlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.FlpMain.Location = new System.Drawing.Point(0, 0);
			this.FlpMain.Name = "FlpMain";
			this.FlpMain.Size = new System.Drawing.Size(239, 117);
			this.FlpMain.TabIndex = 15;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(224, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Welke naam heeft de toe te voegen afdeling?";
			// 
			// TxbAfdeling
			// 
			this.TxbAfdeling.Location = new System.Drawing.Point(3, 16);
			this.TxbAfdeling.Name = "TxbAfdeling";
			this.TxbAfdeling.Size = new System.Drawing.Size(235, 20);
			this.TxbAfdeling.TabIndex = 2;
			// 
			// BtnAddToDb
			// 
			this.BtnAddToDb.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BtnAddToDb.Location = new System.Drawing.Point(0, 117);
			this.BtnAddToDb.Name = "BtnAddToDb";
			this.BtnAddToDb.Size = new System.Drawing.Size(239, 23);
			this.BtnAddToDb.TabIndex = 6;
			this.BtnAddToDb.Text = "Toevoegen";
			this.BtnAddToDb.UseVisualStyleBackColor = true;
			this.BtnAddToDb.Click += new System.EventHandler(this.BtnAddToDb_Click);
			// 
			// LblMain
			// 
			this.LblMain.Dock = System.Windows.Forms.DockStyle.Top;
			this.LblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblMain.Location = new System.Drawing.Point(0, 0);
			this.LblMain.Name = "LblMain";
			this.LblMain.Size = new System.Drawing.Size(499, 16);
			this.LblMain.TabIndex = 2;
			this.LblMain.Text = "Hier kan één afdeling per keer toegevoegd worden aan de Database.";
			this.LblMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// AddAfdelingPopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(499, 367);
			this.Controls.Add(this.PMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "AddAfdelingPopup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Afdeling toevoegen";
			this.Load += new System.EventHandler(this.AddAfdelingPopup_Load);
			this.SizeChanged += new System.EventHandler(this.AddAfdelingPopup_SizeChanged);
			this.PMain.ResumeLayout(false);
			this.PSecundary.ResumeLayout(false);
			this.FlpMain.ResumeLayout(false);
			this.FlpMain.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PMain;
		private System.Windows.Forms.Panel PSecundary;
		private System.Windows.Forms.FlowLayoutPanel FlpMain;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TxbAfdeling;
		private System.Windows.Forms.Button BtnAddToDb;
		private System.Windows.Forms.Label LblMain;
	}
}