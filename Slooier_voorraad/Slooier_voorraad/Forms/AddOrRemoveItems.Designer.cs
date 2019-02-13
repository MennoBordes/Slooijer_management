namespace Slooier_voorraad.Forms
{
	partial class AddOrRemoveItems
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrRemoveItems));
			this.PboxLogo = new System.Windows.Forms.PictureBox();
			this.BtnAddFileToDb = new System.Windows.Forms.Button();
			this.DgvDataDisplay = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.PboxLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DgvDataDisplay)).BeginInit();
			this.SuspendLayout();
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
			this.PboxLogo.TabIndex = 4;
			this.PboxLogo.TabStop = false;
			// 
			// BtnAddFileToDb
			// 
			this.BtnAddFileToDb.Location = new System.Drawing.Point(12, 122);
			this.BtnAddFileToDb.Name = "BtnAddFileToDb";
			this.BtnAddFileToDb.Size = new System.Drawing.Size(178, 23);
			this.BtnAddFileToDb.TabIndex = 16;
			this.BtnAddFileToDb.Text = "Gegevens uit bestand toevoegen";
			this.BtnAddFileToDb.UseVisualStyleBackColor = true;
			this.BtnAddFileToDb.Click += new System.EventHandler(this.BtnAddFileToDb_Click);
			// 
			// DgvDataDisplay
			// 
			this.DgvDataDisplay.AllowUserToAddRows = false;
			this.DgvDataDisplay.AllowUserToDeleteRows = false;
			this.DgvDataDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvDataDisplay.Location = new System.Drawing.Point(196, 122);
			this.DgvDataDisplay.MultiSelect = false;
			this.DgvDataDisplay.Name = "DgvDataDisplay";
			this.DgvDataDisplay.ReadOnly = true;
			this.DgvDataDisplay.RowHeadersVisible = false;
			this.DgvDataDisplay.Size = new System.Drawing.Size(592, 316);
			this.DgvDataDisplay.TabIndex = 18;
			// 
			// AddOrRemoveItems
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.DgvDataDisplay);
			this.Controls.Add(this.BtnAddFileToDb);
			this.Controls.Add(this.PboxLogo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "AddOrRemoveItems";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddOrRemoveItems";
			((System.ComponentModel.ISupportInitialize)(this.PboxLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DgvDataDisplay)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox PboxLogo;
		private System.Windows.Forms.Button BtnAddFileToDb;
		private System.Windows.Forms.DataGridView DgvDataDisplay;
	}
}