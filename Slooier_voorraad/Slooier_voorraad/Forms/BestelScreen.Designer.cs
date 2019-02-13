namespace Slooier_voorraad
{
	partial class BestelScreen
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestelScreen));
			this.PboxLogo = new System.Windows.Forms.PictureBox();
			this.DgvData = new System.Windows.Forms.DataGridView();
			this.BtnSearch = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.BtnVoorraadVerlagen = new System.Windows.Forms.Button();
			this.TxbVoorraad = new System.Windows.Forms.TextBox();
			this.BtnGet = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.DgvBestellen = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.PboxLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DgvBestellen)).BeginInit();
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
			this.PboxLogo.Size = new System.Drawing.Size(1265, 108);
			this.PboxLogo.TabIndex = 1;
			this.PboxLogo.TabStop = false;
			// 
			// DgvData
			// 
			this.DgvData.AllowUserToAddRows = false;
			this.DgvData.AllowUserToDeleteRows = false;
			this.DgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.DgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvData.Location = new System.Drawing.Point(206, 127);
			this.DgvData.MultiSelect = false;
			this.DgvData.Name = "DgvData";
			this.DgvData.RowHeadersVisible = false;
			this.DgvData.Size = new System.Drawing.Size(700, 500);
			this.DgvData.TabIndex = 2;
			this.DgvData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellValueChanged);
			this.DgvData.CurrentCellDirtyStateChanged += new System.EventHandler(this.DgvData_CurrentCellDirtyStateChanged);
			this.DgvData.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvData_DataBindingComplete);
			// 
			// BtnSearch
			// 
			this.BtnSearch.Location = new System.Drawing.Point(13, 161);
			this.BtnSearch.Name = "BtnSearch";
			this.BtnSearch.Size = new System.Drawing.Size(178, 23);
			this.BtnSearch.TabIndex = 3;
			this.BtnSearch.Text = "Zoeken";
			this.BtnSearch.UseVisualStyleBackColor = true;
			this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 191);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(179, 20);
			this.textBox1.TabIndex = 4;
			this.textBox1.Text = "Zoekopdracht";
			this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
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
			// BtnGet
			// 
			this.BtnGet.Location = new System.Drawing.Point(12, 127);
			this.BtnGet.Name = "BtnGet";
			this.BtnGet.Size = new System.Drawing.Size(133, 23);
			this.BtnGet.TabIndex = 11;
			this.BtnGet.Text = "Vernieuwen";
			this.BtnGet.UseVisualStyleBackColor = true;
			this.BtnGet.Click += new System.EventHandler(this.BtnGet_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Coral;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 945);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1265, 50);
			this.panel1.TabIndex = 13;
			// 
			// DgvBestellen
			// 
			this.DgvBestellen.AllowUserToAddRows = false;
			this.DgvBestellen.AllowUserToDeleteRows = false;
			this.DgvBestellen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.DgvBestellen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.DgvBestellen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvBestellen.Location = new System.Drawing.Point(206, 645);
			this.DgvBestellen.Name = "DgvBestellen";
			this.DgvBestellen.RowHeadersVisible = false;
			this.DgvBestellen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.DgvBestellen.Size = new System.Drawing.Size(700, 300);
			this.DgvBestellen.TabIndex = 14;
			this.DgvBestellen.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvBestellen_DataBindingComplete);
			// 
			// BestelScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1282, 757);
			this.Controls.Add(this.DgvBestellen);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.BtnGet);
			this.Controls.Add(this.TxbVoorraad);
			this.Controls.Add(this.BtnVoorraadVerlagen);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.BtnSearch);
			this.Controls.Add(this.DgvData);
			this.Controls.Add(this.PboxLogo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "BestelScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.PboxLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DgvBestellen)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox PboxLogo;
		private System.Windows.Forms.DataGridView DgvData;
		private System.Windows.Forms.Button BtnSearch;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button BtnVoorraadVerlagen;
		private System.Windows.Forms.TextBox TxbVoorraad;
		private System.Windows.Forms.Button BtnGet;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView DgvBestellen;
	}
}

