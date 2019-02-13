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
			// 
			// BtnAlterStock
			// 
			this.BtnAlterStock.Location = new System.Drawing.Point(269, 248);
			this.BtnAlterStock.Name = "BtnAlterStock";
			this.BtnAlterStock.Size = new System.Drawing.Size(223, 23);
			this.BtnAlterStock.TabIndex = 1;
			this.BtnAlterStock.Text = "Voorraad Aanpassen";
			this.BtnAlterStock.UseVisualStyleBackColor = true;
			// 
			// BtnBestellen
			// 
			this.BtnBestellen.Location = new System.Drawing.Point(269, 295);
			this.BtnBestellen.Name = "BtnBestellen";
			this.BtnBestellen.Size = new System.Drawing.Size(223, 23);
			this.BtnBestellen.TabIndex = 2;
			this.BtnBestellen.Text = "Bestellen";
			this.BtnBestellen.UseVisualStyleBackColor = true;
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
			// StartingScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
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
	}
}