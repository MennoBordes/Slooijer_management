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
			this.DgvData = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.BtnAddOwnData = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.PboxLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
			this.groupBox1.SuspendLayout();
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
			this.PboxLogo.Size = new System.Drawing.Size(1380, 108);
			this.PboxLogo.TabIndex = 4;
			this.PboxLogo.TabStop = false;
			// 
			// BtnAddFileToDb
			// 
			this.BtnAddFileToDb.Location = new System.Drawing.Point(12, 578);
			this.BtnAddFileToDb.Name = "BtnAddFileToDb";
			this.BtnAddFileToDb.Size = new System.Drawing.Size(178, 23);
			this.BtnAddFileToDb.TabIndex = 16;
			this.BtnAddFileToDb.Text = "Gegevens uit bestand toevoegen";
			this.BtnAddFileToDb.UseVisualStyleBackColor = true;
			this.BtnAddFileToDb.Click += new System.EventHandler(this.BtnAddFileToDb_Click);
			// 
			// DgvData
			// 
			this.DgvData.AllowUserToAddRows = false;
			this.DgvData.AllowUserToDeleteRows = false;
			this.DgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.DgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvData.Location = new System.Drawing.Point(6, 19);
			this.DgvData.MultiSelect = false;
			this.DgvData.Name = "DgvData";
			this.DgvData.RowHeadersVisible = false;
			this.DgvData.Size = new System.Drawing.Size(668, 401);
			this.DgvData.TabIndex = 19;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.DgvData);
			this.groupBox1.Location = new System.Drawing.Point(0, 111);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(681, 423);
			this.groupBox1.TabIndex = 20;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Huidige gegevens";
			// 
			// BtnAddOwnData
			// 
			this.BtnAddOwnData.Location = new System.Drawing.Point(688, 112);
			this.BtnAddOwnData.Name = "BtnAddOwnData";
			this.BtnAddOwnData.Size = new System.Drawing.Size(122, 23);
			this.BtnAddOwnData.TabIndex = 21;
			this.BtnAddOwnData.Text = "Gegevens toevoegen";
			this.BtnAddOwnData.UseVisualStyleBackColor = true;
			this.BtnAddOwnData.Click += new System.EventHandler(this.BtnAddOwnData_Click);
			// 
			// AddOrRemoveItems
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1380, 757);
			this.Controls.Add(this.BtnAddOwnData);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.BtnAddFileToDb);
			this.Controls.Add(this.PboxLogo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "AddOrRemoveItems";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddOrRemoveItems";
			this.Shown += new System.EventHandler(this.AddOrRemoveItems_Shown);
			((System.ComponentModel.ISupportInitialize)(this.PboxLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox PboxLogo;
		private System.Windows.Forms.Button BtnAddFileToDb;
		private System.Windows.Forms.DataGridView DgvData;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button BtnAddOwnData;
	}
}