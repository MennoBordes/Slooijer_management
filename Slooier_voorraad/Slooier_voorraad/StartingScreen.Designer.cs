namespace Slooier_voorraad
{
	partial class StartingScreen
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartingScreen));
			this.BtnAddOrRemove = new System.Windows.Forms.Button();
			this.BtnAlterStock = new System.Windows.Forms.Button();
			this.BtnBestellen = new System.Windows.Forms.Button();
			this.PboxLogo = new System.Windows.Forms.PictureBox();
			this.BtnPdFTester = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.PboxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnAddOrRemove
			// 
			this.BtnAddOrRemove.Location = new System.Drawing.Point(269, 200);
			this.BtnAddOrRemove.Name = "BtnAddOrRemove";
			this.BtnAddOrRemove.Size = new System.Drawing.Size(223, 23);
			this.BtnAddOrRemove.TabIndex = 0;
			this.BtnAddOrRemove.Text = "Materialen Toevoegen of verwijderen";
			this.BtnAddOrRemove.UseVisualStyleBackColor = true;
			this.BtnAddOrRemove.Click += new System.EventHandler(this.BtnAddOrRemove_Click);
			// 
			// BtnAlterStock
			// 
			this.BtnAlterStock.Location = new System.Drawing.Point(269, 248);
			this.BtnAlterStock.Name = "BtnAlterStock";
			this.BtnAlterStock.Size = new System.Drawing.Size(223, 23);
			this.BtnAlterStock.TabIndex = 1;
			this.BtnAlterStock.Text = "Voorraad Aanpassen";
			this.BtnAlterStock.UseVisualStyleBackColor = true;
			this.BtnAlterStock.Click += new System.EventHandler(this.BtnAlterStock_Click);
			// 
			// BtnBestellen
			// 
			this.BtnBestellen.Location = new System.Drawing.Point(269, 295);
			this.BtnBestellen.Name = "BtnBestellen";
			this.BtnBestellen.Size = new System.Drawing.Size(223, 23);
			this.BtnBestellen.TabIndex = 2;
			this.BtnBestellen.Text = "Bestellen";
			this.BtnBestellen.UseVisualStyleBackColor = true;
			this.BtnBestellen.Click += new System.EventHandler(this.BtnBestellen_Click);
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
			this.PboxLogo.Size = new System.Drawing.Size(800, 108);
			this.PboxLogo.TabIndex = 3;
			this.PboxLogo.TabStop = false;
			// 
			// BtnPdFTester
			// 
			this.BtnPdFTester.Location = new System.Drawing.Point(269, 383);
			this.BtnPdFTester.Name = "BtnPdFTester";
			this.BtnPdFTester.Size = new System.Drawing.Size(75, 23);
			this.BtnPdFTester.TabIndex = 4;
			this.BtnPdFTester.Text = "PdFTester";
			this.BtnPdFTester.UseVisualStyleBackColor = true;
			this.BtnPdFTester.Click += new System.EventHandler(this.BtnPdFTester_Click);
			// 
			// StartingScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.BtnPdFTester);
			this.Controls.Add(this.PboxLogo);
			this.Controls.Add(this.BtnBestellen);
			this.Controls.Add(this.BtnAlterStock);
			this.Controls.Add(this.BtnAddOrRemove);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "StartingScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "StartingScreen";
			((System.ComponentModel.ISupportInitialize)(this.PboxLogo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BtnAddOrRemove;
		private System.Windows.Forms.Button BtnAlterStock;
		private System.Windows.Forms.Button BtnBestellen;
		private System.Windows.Forms.PictureBox PboxLogo;
		private System.Windows.Forms.Button BtnPdFTester;
	}
}