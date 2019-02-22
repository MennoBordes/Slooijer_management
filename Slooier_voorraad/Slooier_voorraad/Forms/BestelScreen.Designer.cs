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
			this.TxbZoekInput = new System.Windows.Forms.TextBox();
			this.BtnVoorraadVerlagen = new System.Windows.Forms.Button();
			this.TxbVoorraad = new System.Windows.Forms.TextBox();
			this.BtnRefresh = new System.Windows.Forms.Button();
			this.DgvBestellen = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.BtnPDF = new System.Windows.Forms.Button();
			this.PMain = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.PboxLogo)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DgvBestellen)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.PMain.SuspendLayout();
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
			this.PboxLogo.Size = new System.Drawing.Size(1391, 108);
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
			this.DgvData.Location = new System.Drawing.Point(0, 19);
			this.DgvData.MultiSelect = false;
			this.DgvData.Name = "DgvData";
			this.DgvData.RowHeadersVisible = false;
			this.DgvData.Size = new System.Drawing.Size(640, 500);
			this.DgvData.TabIndex = 2;
			this.DgvData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvData_CellValueChanged);
			this.DgvData.CurrentCellDirtyStateChanged += new System.EventHandler(this.DgvData_CurrentCellDirtyStateChanged);
			this.DgvData.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvData_DataBindingComplete);
			// 
			// BtnSearch
			// 
			this.BtnSearch.Location = new System.Drawing.Point(256, 29);
			this.BtnSearch.Name = "BtnSearch";
			this.BtnSearch.Size = new System.Drawing.Size(178, 23);
			this.BtnSearch.TabIndex = 3;
			this.BtnSearch.Text = "Zoeken";
			this.BtnSearch.UseVisualStyleBackColor = true;
			this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
			// 
			// TxbZoekInput
			// 
			this.TxbZoekInput.Location = new System.Drawing.Point(255, 59);
			this.TxbZoekInput.Name = "TxbZoekInput";
			this.TxbZoekInput.Size = new System.Drawing.Size(179, 20);
			this.TxbZoekInput.TabIndex = 4;
			this.TxbZoekInput.Text = "Zoekopdracht";
			this.TxbZoekInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxbZoekInput_KeyDown);
			// 
			// BtnVoorraadVerlagen
			// 
			this.BtnVoorraadVerlagen.Location = new System.Drawing.Point(846, 51);
			this.BtnVoorraadVerlagen.Name = "BtnVoorraadVerlagen";
			this.BtnVoorraadVerlagen.Size = new System.Drawing.Size(133, 25);
			this.BtnVoorraadVerlagen.TabIndex = 6;
			this.BtnVoorraadVerlagen.Text = "Voorraad verlagen met:";
			this.BtnVoorraadVerlagen.UseVisualStyleBackColor = true;
			this.BtnVoorraadVerlagen.Click += new System.EventHandler(this.BtnVoorraadVerlagen_Click);
			// 
			// TxbVoorraad
			// 
			this.TxbVoorraad.Location = new System.Drawing.Point(985, 54);
			this.TxbVoorraad.Name = "TxbVoorraad";
			this.TxbVoorraad.Size = new System.Drawing.Size(39, 20);
			this.TxbVoorraad.TabIndex = 9;
			this.TxbVoorraad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxbVoorraad_KeyPress);
			// 
			// BtnRefresh
			// 
			this.BtnRefresh.Location = new System.Drawing.Point(26, 59);
			this.BtnRefresh.Name = "BtnRefresh";
			this.BtnRefresh.Size = new System.Drawing.Size(133, 23);
			this.BtnRefresh.TabIndex = 11;
			this.BtnRefresh.Text = "Vernieuwen";
			this.BtnRefresh.UseVisualStyleBackColor = true;
			this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
			// 
			// DgvBestellen
			// 
			this.DgvBestellen.AllowUserToAddRows = false;
			this.DgvBestellen.AllowUserToDeleteRows = false;
			this.DgvBestellen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.DgvBestellen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.DgvBestellen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvBestellen.Location = new System.Drawing.Point(6, 18);
			this.DgvBestellen.Name = "DgvBestellen";
			this.DgvBestellen.RowHeadersVisible = false;
			this.DgvBestellen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.DgvBestellen.Size = new System.Drawing.Size(704, 500);
			this.DgvBestellen.TabIndex = 14;
			this.DgvBestellen.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvBestellen_DataBindingComplete);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.DgvData);
			this.groupBox1.Location = new System.Drawing.Point(6, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(646, 528);
			this.groupBox1.TabIndex = 15;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Huidige gegevens";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.DgvBestellen);
			this.groupBox2.Location = new System.Drawing.Point(658, 3);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(716, 528);
			this.groupBox2.TabIndex = 16;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Bestellen";
			// 
			// BtnPDF
			// 
			this.BtnPDF.Location = new System.Drawing.Point(560, 28);
			this.BtnPDF.Name = "BtnPDF";
			this.BtnPDF.Size = new System.Drawing.Size(113, 23);
			this.BtnPDF.TabIndex = 17;
			this.BtnPDF.Text = "Generate PDF";
			this.BtnPDF.UseVisualStyleBackColor = true;
			this.BtnPDF.Click += new System.EventHandler(this.BtnPDF_Click);
			// 
			// PMain
			// 
			this.PMain.Controls.Add(this.groupBox1);
			this.PMain.Controls.Add(this.groupBox2);
			this.PMain.Location = new System.Drawing.Point(0, 111);
			this.PMain.Name = "PMain";
			this.PMain.Size = new System.Drawing.Size(1391, 533);
			this.PMain.TabIndex = 3;
			// 
			// BestelScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(980, 537);
			this.Controls.Add(this.PMain);
			this.Controls.Add(this.BtnPDF);
			this.Controls.Add(this.BtnRefresh);
			this.Controls.Add(this.TxbVoorraad);
			this.Controls.Add(this.BtnVoorraadVerlagen);
			this.Controls.Add(this.TxbZoekInput);
			this.Controls.Add(this.BtnSearch);
			this.Controls.Add(this.PboxLogo);
			this.Name = "BestelScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.BestelScreen_Load);
			this.Shown += new System.EventHandler(this.BestelScreen_Shown);
			this.SizeChanged += new System.EventHandler(this.BestelScreen_SizeChanged);
			((System.ComponentModel.ISupportInitialize)(this.PboxLogo)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DgvBestellen)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.PMain.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox PboxLogo;
		private System.Windows.Forms.DataGridView DgvData;
		private System.Windows.Forms.Button BtnSearch;
		private System.Windows.Forms.TextBox TxbZoekInput;
		private System.Windows.Forms.Button BtnVoorraadVerlagen;
		private System.Windows.Forms.TextBox TxbVoorraad;
		private System.Windows.Forms.Button BtnRefresh;
		private System.Windows.Forms.DataGridView DgvBestellen;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button BtnPDF;
		private System.Windows.Forms.Panel PMain;
	}
}

