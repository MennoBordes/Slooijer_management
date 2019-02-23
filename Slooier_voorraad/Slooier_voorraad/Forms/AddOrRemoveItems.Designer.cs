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
			this.BtnAddFileToDb = new System.Windows.Forms.Button();
			this.DgvData = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.BtnAddItems = new System.Windows.Forms.Button();
			this.PMain = new System.Windows.Forms.Panel();
			this.BtnAddAfdeling = new System.Windows.Forms.Button();
			this.LblDeactive = new System.Windows.Forms.Label();
			this.PboxLogo = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.PMain.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PboxLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// BtnAddFileToDb
			// 
			this.BtnAddFileToDb.Location = new System.Drawing.Point(690, 187);
			this.BtnAddFileToDb.Name = "BtnAddFileToDb";
			this.BtnAddFileToDb.Size = new System.Drawing.Size(231, 23);
			this.BtnAddFileToDb.TabIndex = 16;
			this.BtnAddFileToDb.Text = "Meerdere items uit een bestand toevoegen";
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
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(681, 423);
			this.groupBox1.TabIndex = 20;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Huidige gegevens";
			// 
			// BtnAddItems
			// 
			this.BtnAddItems.Location = new System.Drawing.Point(751, 51);
			this.BtnAddItems.Name = "BtnAddItems";
			this.BtnAddItems.Size = new System.Drawing.Size(122, 23);
			this.BtnAddItems.TabIndex = 21;
			this.BtnAddItems.Text = "Items toevoegen";
			this.BtnAddItems.UseVisualStyleBackColor = true;
			this.BtnAddItems.Click += new System.EventHandler(this.BtnAddItems_Click);
			// 
			// PMain
			// 
			this.PMain.Controls.Add(this.BtnAddAfdeling);
			this.PMain.Controls.Add(this.groupBox1);
			this.PMain.Controls.Add(this.BtnAddFileToDb);
			this.PMain.Controls.Add(this.BtnAddItems);
			this.PMain.Location = new System.Drawing.Point(0, 111);
			this.PMain.Name = "PMain";
			this.PMain.Size = new System.Drawing.Size(956, 429);
			this.PMain.TabIndex = 22;
			// 
			// BtnAddAfdeling
			// 
			this.BtnAddAfdeling.Location = new System.Drawing.Point(751, 22);
			this.BtnAddAfdeling.Name = "BtnAddAfdeling";
			this.BtnAddAfdeling.Size = new System.Drawing.Size(122, 23);
			this.BtnAddAfdeling.TabIndex = 22;
			this.BtnAddAfdeling.Text = "Afdeling toevoegen";
			this.BtnAddAfdeling.UseVisualStyleBackColor = true;
			this.BtnAddAfdeling.Click += new System.EventHandler(this.BtnAddAfdeling_Click);
			// 
			// LblDeactive
			// 
			this.LblDeactive.AutoSize = true;
			this.LblDeactive.BackColor = System.Drawing.Color.Transparent;
			this.LblDeactive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.LblDeactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblDeactive.Location = new System.Drawing.Point(87, 95);
			this.LblDeactive.Name = "LblDeactive";
			this.LblDeactive.Size = new System.Drawing.Size(788, 27);
			this.LblDeactive.TabIndex = 20;
			this.LblDeactive.Text = "Let op: Sluit het andere scherm om weer gebruik te maken van dit scherm";
			this.LblDeactive.Visible = false;
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
			this.PboxLogo.Size = new System.Drawing.Size(959, 108);
			this.PboxLogo.TabIndex = 4;
			this.PboxLogo.TabStop = false;
			// 
			// AddOrRemoveItems
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(959, 541);
			this.Controls.Add(this.LblDeactive);
			this.Controls.Add(this.PMain);
			this.Controls.Add(this.PboxLogo);
			this.Name = "AddOrRemoveItems";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddOrRemoveItems";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.AddOrRemoveItems_Load);
			this.Shown += new System.EventHandler(this.AddOrRemoveItems_Shown);
			this.SizeChanged += new System.EventHandler(this.AddOrRemoveItems_SizeChanged);
			((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.PMain.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PboxLogo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button BtnAddFileToDb;
		private System.Windows.Forms.DataGridView DgvData;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button BtnAddItems;
		private System.Windows.Forms.Panel PMain;
		private System.Windows.Forms.Label LblDeactive;
		private System.Windows.Forms.Button BtnAddAfdeling;
		private System.Windows.Forms.PictureBox PboxLogo;
	}
}