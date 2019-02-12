namespace Slooier_voorraad
{
	partial class MainPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
			this.PboxLogo = new System.Windows.Forms.PictureBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.BtnSearch = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.BtnReload = new System.Windows.Forms.Button();
			this.BtnVoorraadVerlagen = new System.Windows.Forms.Button();
			this.TxbVoorraad = new System.Windows.Forms.TextBox();
			this.BtnDB = new System.Windows.Forms.Button();
			this.BtnGet = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.PboxLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
			this.PboxLogo.Size = new System.Drawing.Size(1184, 108);
			this.PboxLogo.TabIndex = 1;
			this.PboxLogo.TabStop = false;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(262, 127);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(910, 622);
			this.dataGridView1.TabIndex = 2;
			this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
			// 
			// BtnSearch
			// 
			this.BtnSearch.Location = new System.Drawing.Point(13, 127);
			this.BtnSearch.Name = "BtnSearch";
			this.BtnSearch.Size = new System.Drawing.Size(178, 23);
			this.BtnSearch.TabIndex = 3;
			this.BtnSearch.Text = "Zoeken";
			this.BtnSearch.UseVisualStyleBackColor = true;
			this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 157);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(179, 20);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "Zoekopdracht";
			// 
			// BtnReload
			// 
			this.BtnReload.Location = new System.Drawing.Point(13, 197);
			this.BtnReload.Name = "BtnReload";
			this.BtnReload.Size = new System.Drawing.Size(75, 23);
			this.BtnReload.TabIndex = 5;
			this.BtnReload.Text = "Rerun Loader";
			this.BtnReload.UseVisualStyleBackColor = true;
			this.BtnReload.Click += new System.EventHandler(this.BtnReload_Click);
			// 
			// BtnVoorraadVerlagen
			// 
			this.BtnVoorraadVerlagen.Location = new System.Drawing.Point(13, 265);
			this.BtnVoorraadVerlagen.Name = "BtnVoorraadVerlagen";
			this.BtnVoorraadVerlagen.Size = new System.Drawing.Size(133, 25);
			this.BtnVoorraadVerlagen.TabIndex = 6;
			this.BtnVoorraadVerlagen.Text = "Voorraad verlagen met:";
			this.BtnVoorraadVerlagen.UseVisualStyleBackColor = true;
			this.BtnVoorraadVerlagen.Click += new System.EventHandler(this.BtnVoorraadVerlagen_Click);
			// 
			// TxbVoorraad
			// 
			this.TxbVoorraad.Location = new System.Drawing.Point(152, 268);
			this.TxbVoorraad.Name = "TxbVoorraad";
			this.TxbVoorraad.Size = new System.Drawing.Size(39, 20);
			this.TxbVoorraad.TabIndex = 9;
			this.TxbVoorraad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbVoorraad_KeyPress);
			// 
			// BtnDB
			// 
			this.BtnDB.Location = new System.Drawing.Point(13, 334);
			this.BtnDB.Name = "BtnDB";
			this.BtnDB.Size = new System.Drawing.Size(75, 23);
			this.BtnDB.TabIndex = 10;
			this.BtnDB.Text = "ConnectDB";
			this.BtnDB.UseVisualStyleBackColor = true;
			this.BtnDB.Click += new System.EventHandler(this.BtnDB_Click);
			// 
			// BtnGet
			// 
			this.BtnGet.Location = new System.Drawing.Point(13, 364);
			this.BtnGet.Name = "BtnGet";
			this.BtnGet.Size = new System.Drawing.Size(133, 23);
			this.BtnGet.TabIndex = 11;
			this.BtnGet.Text = "Gegevens ophalen";
			this.BtnGet.UseVisualStyleBackColor = true;
			this.BtnGet.Click += new System.EventHandler(this.BtnGet_Click);
			// 
			// MainPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 761);
			this.Controls.Add(this.BtnGet);
			this.Controls.Add(this.BtnDB);
			this.Controls.Add(this.TxbVoorraad);
			this.Controls.Add(this.BtnVoorraadVerlagen);
			this.Controls.Add(this.BtnReload);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.BtnSearch);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.PboxLogo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "MainPage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.PboxLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox PboxLogo;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button BtnSearch;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button BtnReload;
		private System.Windows.Forms.Button BtnVoorraadVerlagen;
		private System.Windows.Forms.TextBox TxbVoorraad;
		private System.Windows.Forms.Button BtnDB;
		private System.Windows.Forms.Button BtnGet;
	}
}

