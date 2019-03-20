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
			this.defaultHeaderBar1 = new Slooier_voorraad.Controls.DefaultHeaderBar();
			this.LeftBorder = new Slooier_voorraad.UI.OuterFormBorder();
			this.RightBorder = new Slooier_voorraad.UI.OuterFormBorder();
			this.BottomBorder = new Slooier_voorraad.UI.OuterFormBorder();
			this.defaultBackGround1 = new Slooier_voorraad.UI.DefaultBackGround();
			this.PMain.SuspendLayout();
			this.PSecRight.SuspendLayout();
			this.GbVoorraad.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.DgvVoorraad)).BeginInit();
			this.PSecLeft.SuspendLayout();
			this.defaultBackGround1.SuspendLayout();
			this.SuspendLayout();
			// 
			// PMain
			// 
			this.PMain.Controls.Add(this.PSecRight);
			this.PMain.Controls.Add(this.PSecLeft);
			this.PMain.Location = new System.Drawing.Point(6, 6);
			this.PMain.Name = "PMain";
			this.PMain.Size = new System.Drawing.Size(962, 502);
			this.PMain.TabIndex = 0;
			// 
			// PSecRight
			// 
			this.PSecRight.Controls.Add(this.GbVoorraad);
			this.PSecRight.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PSecRight.Location = new System.Drawing.Point(120, 0);
			this.PSecRight.Name = "PSecRight";
			this.PSecRight.Size = new System.Drawing.Size(842, 502);
			this.PSecRight.TabIndex = 2;
			// 
			// GbVoorraad
			// 
			this.GbVoorraad.Controls.Add(this.DgvVoorraad);
			this.GbVoorraad.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GbVoorraad.Location = new System.Drawing.Point(0, 0);
			this.GbVoorraad.Name = "GbVoorraad";
			this.GbVoorraad.Size = new System.Drawing.Size(842, 502);
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
			this.DgvVoorraad.Size = new System.Drawing.Size(836, 483);
			this.DgvVoorraad.TabIndex = 0;
			this.DgvVoorraad.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DgvVoorraad_DataBindingComplete);
			this.DgvVoorraad.DoubleClick += new System.EventHandler(this.DgvVoorraad_DoubleClick);
			// 
			// PSecLeft
			// 
			this.PSecLeft.Controls.Add(this.BtnSearch);
			this.PSecLeft.Controls.Add(this.BtnRefresh);
			this.PSecLeft.Controls.Add(this.TxbSearch);
			this.PSecLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.PSecLeft.Location = new System.Drawing.Point(0, 0);
			this.PSecLeft.Name = "PSecLeft";
			this.PSecLeft.Size = new System.Drawing.Size(120, 502);
			this.PSecLeft.TabIndex = 1;
			// 
			// BtnSearch
			// 
			this.BtnSearch.Location = new System.Drawing.Point(13, 93);
			this.BtnSearch.Name = "BtnSearch";
			this.BtnSearch.Size = new System.Drawing.Size(100, 23);
			this.BtnSearch.TabIndex = 2;
			this.BtnSearch.Text = "Zoeken";
			this.BtnSearch.UseVisualStyleBackColor = true;
			this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
			// 
			// BtnRefresh
			// 
			this.BtnRefresh.Location = new System.Drawing.Point(13, 13);
			this.BtnRefresh.Name = "BtnRefresh";
			this.BtnRefresh.Size = new System.Drawing.Size(100, 23);
			this.BtnRefresh.TabIndex = 1;
			this.BtnRefresh.Text = "Vernieuwen";
			this.BtnRefresh.UseVisualStyleBackColor = true;
			this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
			// 
			// TxbSearch
			// 
			this.TxbSearch.Location = new System.Drawing.Point(13, 122);
			this.TxbSearch.Name = "TxbSearch";
			this.TxbSearch.Size = new System.Drawing.Size(100, 20);
			this.TxbSearch.TabIndex = 0;
			// 
			// defaultHeaderBar1
			// 
			this.defaultHeaderBar1.AutoSize = true;
			this.defaultHeaderBar1.Dock = System.Windows.Forms.DockStyle.Top;
			this.defaultHeaderBar1.Location = new System.Drawing.Point(0, 0);
			this.defaultHeaderBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.defaultHeaderBar1.Name = "defaultHeaderBar1";
			this.defaultHeaderBar1.Size = new System.Drawing.Size(985, 27);
			this.defaultHeaderBar1.TabIndex = 1;
			// 
			// LeftBorder
			// 
			this.LeftBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.LeftBorder.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.LeftBorder.Dock = System.Windows.Forms.DockStyle.Left;
			this.LeftBorder.Location = new System.Drawing.Point(0, 27);
			this.LeftBorder.Name = "LeftBorder";
			this.LeftBorder.OutBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.LeftBorder.Size = new System.Drawing.Size(8, 515);
			this.LeftBorder.TabIndex = 2;
			// 
			// RightBorder
			// 
			this.RightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.RightBorder.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.RightBorder.Dock = System.Windows.Forms.DockStyle.Right;
			this.RightBorder.Location = new System.Drawing.Point(977, 27);
			this.RightBorder.Name = "RightBorder";
			this.RightBorder.OutBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.RightBorder.Size = new System.Drawing.Size(8, 515);
			this.RightBorder.TabIndex = 3;
			// 
			// BottomBorder
			// 
			this.BottomBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.BottomBorder.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.BottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BottomBorder.Location = new System.Drawing.Point(8, 534);
			this.BottomBorder.Name = "BottomBorder";
			this.BottomBorder.OutBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.BottomBorder.Size = new System.Drawing.Size(969, 8);
			this.BottomBorder.TabIndex = 4;
			// 
			// defaultBackGround1
			// 
			this.defaultBackGround1.BackColor = System.Drawing.Color.Gainsboro;
			this.defaultBackGround1.Controls.Add(this.PMain);
			this.defaultBackGround1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.defaultBackGround1.Location = new System.Drawing.Point(8, 27);
			this.defaultBackGround1.Name = "defaultBackGround1";
			this.defaultBackGround1.Size = new System.Drawing.Size(969, 507);
			this.defaultBackGround1.TabIndex = 5;
			// 
			// Voorraad
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(985, 542);
			this.Controls.Add(this.defaultBackGround1);
			this.Controls.Add(this.BottomBorder);
			this.Controls.Add(this.RightBorder);
			this.Controls.Add(this.LeftBorder);
			this.Controls.Add(this.defaultHeaderBar1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Voorraad";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Voorraad";
			this.Activated += new System.EventHandler(this.Voorraad_Activated);
			this.Load += new System.EventHandler(this.Voorraad_Load);
			this.Shown += new System.EventHandler(this.Voorraad_Shown);
			this.PMain.ResumeLayout(false);
			this.PSecRight.ResumeLayout(false);
			this.GbVoorraad.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.DgvVoorraad)).EndInit();
			this.PSecLeft.ResumeLayout(false);
			this.PSecLeft.PerformLayout();
			this.defaultBackGround1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

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
		private Controls.DefaultHeaderBar defaultHeaderBar1;
		private UI.OuterFormBorder LeftBorder;
		private UI.OuterFormBorder RightBorder;
		private UI.OuterFormBorder BottomBorder;
		private UI.DefaultBackGround defaultBackGround1;
	}
}