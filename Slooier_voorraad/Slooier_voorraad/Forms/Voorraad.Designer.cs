namespace Slooier_voorraad.Forms
{
	partial class Voorraad
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
			this.PSecRight = new System.Windows.Forms.Panel();
			this.GbVoorraad = new System.Windows.Forms.GroupBox();
			this.DgvVoorraad = new System.Windows.Forms.DataGridView();
			this.PSecLeft = new System.Windows.Forms.Panel();
			this.BtnSearch = new System.Windows.Forms.Button();
			this.BtnRefresh = new System.Windows.Forms.Button();
			this.TxbSearch = new System.Windows.Forms.TextBox();
			this.PMain.SuspendLayout();
			this.PSecRight.SuspendLayout();
			this.GbVoorraad.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DgvVoorraad)).BeginInit();
			this.PSecLeft.SuspendLayout();
			this.SuspendLayout();
			// 
			// PMain
			// 
			this.PMain.Controls.Add(this.PSecRight);
			this.PMain.Controls.Add(this.PSecLeft);
			this.PMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PMain.Location = new System.Drawing.Point(0, 0);
			this.PMain.Name = "PMain";
			this.PMain.Size = new System.Drawing.Size(849, 450);
			this.PMain.TabIndex = 0;
			// 
			// PSecRight
			// 
			this.PSecRight.Controls.Add(this.GbVoorraad);
			this.PSecRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PSecRight.Location = new System.Drawing.Point(200, 0);
			this.PSecRight.Name = "PSecRight";
			this.PSecRight.Size = new System.Drawing.Size(649, 450);
			this.PSecRight.TabIndex = 2;
			// 
			// GbVoorraad
			// 
			this.GbVoorraad.Controls.Add(this.DgvVoorraad);
			this.GbVoorraad.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GbVoorraad.Location = new System.Drawing.Point(0, 0);
			this.GbVoorraad.Name = "GbVoorraad";
			this.GbVoorraad.Size = new System.Drawing.Size(649, 450);
			this.GbVoorraad.TabIndex = 0;
			this.GbVoorraad.TabStop = false;
			this.GbVoorraad.Text = "Voorraad";
			// 
			// DgvVoorraad
			// 
			this.DgvVoorraad.AllowUserToAddRows = false;
			this.DgvVoorraad.AllowUserToDeleteRows = false;
			this.DgvVoorraad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.DgvVoorraad.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.DgvVoorraad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvVoorraad.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DgvVoorraad.Location = new System.Drawing.Point(3, 16);
			this.DgvVoorraad.MultiSelect = false;
			this.DgvVoorraad.Name = "DgvVoorraad";
			this.DgvVoorraad.RowHeadersVisible = false;
			this.DgvVoorraad.Size = new System.Drawing.Size(643, 431);
			this.DgvVoorraad.TabIndex = 0;
			this.DgvVoorraad.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvVoorraad_DataBindingComplete);
			// 
			// PSecLeft
			// 
			this.PSecLeft.Controls.Add(this.BtnSearch);
			this.PSecLeft.Controls.Add(this.BtnRefresh);
			this.PSecLeft.Controls.Add(this.TxbSearch);
			this.PSecLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.PSecLeft.Location = new System.Drawing.Point(0, 0);
			this.PSecLeft.Name = "PSecLeft";
			this.PSecLeft.Size = new System.Drawing.Size(200, 450);
			this.PSecLeft.TabIndex = 1;
			// 
			// BtnSearch
			// 
			this.BtnSearch.Location = new System.Drawing.Point(26, 157);
			this.BtnSearch.Name = "BtnSearch";
			this.BtnSearch.Size = new System.Drawing.Size(75, 23);
			this.BtnSearch.TabIndex = 2;
			this.BtnSearch.Text = "Zoeken";
			this.BtnSearch.UseVisualStyleBackColor = true;
			this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
			// 
			// BtnRefresh
			// 
			this.BtnRefresh.Location = new System.Drawing.Point(13, 13);
			this.BtnRefresh.Name = "BtnRefresh";
			this.BtnRefresh.Size = new System.Drawing.Size(75, 23);
			this.BtnRefresh.TabIndex = 1;
			this.BtnRefresh.Text = "Vernieuwen";
			this.BtnRefresh.UseVisualStyleBackColor = true;
			this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
			// 
			// TxbSearch
			// 
			this.TxbSearch.Location = new System.Drawing.Point(26, 186);
			this.TxbSearch.Name = "TxbSearch";
			this.TxbSearch.Size = new System.Drawing.Size(100, 20);
			this.TxbSearch.TabIndex = 0;
			// 
			// Voorraad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(849, 450);
			this.Controls.Add(this.PMain);
			this.Name = "Voorraad";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Voorraad";
			this.Load += new System.EventHandler(this.Voorraad_Load);
			this.Shown += new System.EventHandler(this.Voorraad_Shown);
			this.PMain.ResumeLayout(false);
			this.PSecRight.ResumeLayout(false);
			this.GbVoorraad.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DgvVoorraad)).EndInit();
			this.PSecLeft.ResumeLayout(false);
			this.PSecLeft.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel PMain;
		private System.Windows.Forms.GroupBox GbVoorraad;
		private System.Windows.Forms.DataGridView DgvVoorraad;
		private System.Windows.Forms.Panel PSecRight;
		private System.Windows.Forms.Panel PSecLeft;
		private System.Windows.Forms.TextBox TxbSearch;
		private System.Windows.Forms.Button BtnRefresh;
		private System.Windows.Forms.Button BtnSearch;
	}
}