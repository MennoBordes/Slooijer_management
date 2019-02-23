namespace Slooier_voorraad
{
	partial class NewStartingScreen
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewStartingScreen));
			this.PboxLogo = new System.Windows.Forms.PictureBox();
			this.MenuBar = new System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.nieuweArtikelenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.instellingenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.losArtikelToevoegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.artikelAanpassenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.artikelToevoegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bestandToevoegenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.afdelingToevoegenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.verwijderenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.artikelAanpassenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.afdelingAanpassenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.artikelVerwijderenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.PboxLogo)).BeginInit();
			this.MenuBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// PboxLogo
			// 
			this.PboxLogo.BackColor = System.Drawing.Color.White;
			this.PboxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PboxLogo.BackgroundImage")));
			this.PboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.PboxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PboxLogo.Dock = System.Windows.Forms.DockStyle.Top;
			this.PboxLogo.Location = new System.Drawing.Point(0, 24);
			this.PboxLogo.Name = "PboxLogo";
			this.PboxLogo.Size = new System.Drawing.Size(800, 108);
			this.PboxLogo.TabIndex = 5;
			this.PboxLogo.TabStop = false;
			// 
			// MenuBar
			// 
			this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.nieuweArtikelenToolStripMenuItem,
            this.instellingenToolStripMenuItem,
            this.sluitenToolStripMenuItem});
			this.MenuBar.Location = new System.Drawing.Point(0, 0);
			this.MenuBar.Name = "MenuBar";
			this.MenuBar.Size = new System.Drawing.Size(800, 24);
			this.MenuBar.TabIndex = 6;
			this.MenuBar.Text = "menuStrip1";
			// 
			// menuToolStripMenuItem
			// 
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.menuToolStripMenuItem.Text = "&Voorraad";
			// 
			// nieuweArtikelenToolStripMenuItem
			// 
			this.nieuweArtikelenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.losArtikelToevoegenToolStripMenuItem,
            this.artikelAanpassenToolStripMenuItem,
            this.verwijderenToolStripMenuItem});
			this.nieuweArtikelenToolStripMenuItem.Name = "nieuweArtikelenToolStripMenuItem";
			this.nieuweArtikelenToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
			this.nieuweArtikelenToolStripMenuItem.Text = "&Nieuwe Artikelen";
			// 
			// instellingenToolStripMenuItem
			// 
			this.instellingenToolStripMenuItem.Name = "instellingenToolStripMenuItem";
			this.instellingenToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
			this.instellingenToolStripMenuItem.Text = "&Instellingen";
			this.instellingenToolStripMenuItem.Click += new System.EventHandler(this.instellingenToolStripMenuItem_Click);
			// 
			// sluitenToolStripMenuItem
			// 
			this.sluitenToolStripMenuItem.Name = "sluitenToolStripMenuItem";
			this.sluitenToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.sluitenToolStripMenuItem.Text = "&Sluiten";
			this.sluitenToolStripMenuItem.Click += new System.EventHandler(this.sluitenToolStripMenuItem_Click);
			// 
			// losArtikelToevoegenToolStripMenuItem
			// 
			this.losArtikelToevoegenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afdelingToevoegenToolStripMenuItem1,
            this.artikelToevoegenToolStripMenuItem,
            this.bestandToevoegenToolStripMenuItem1});
			this.losArtikelToevoegenToolStripMenuItem.Name = "losArtikelToevoegenToolStripMenuItem";
			this.losArtikelToevoegenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.losArtikelToevoegenToolStripMenuItem.Text = "&Toevoegen";
			// 
			// artikelAanpassenToolStripMenuItem
			// 
			this.artikelAanpassenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artikelAanpassenToolStripMenuItem1,
            this.afdelingAanpassenToolStripMenuItem});
			this.artikelAanpassenToolStripMenuItem.Name = "artikelAanpassenToolStripMenuItem";
			this.artikelAanpassenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.artikelAanpassenToolStripMenuItem.Text = "&Aanpassen";
			// 
			// artikelToevoegenToolStripMenuItem
			// 
			this.artikelToevoegenToolStripMenuItem.Name = "artikelToevoegenToolStripMenuItem";
			this.artikelToevoegenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.artikelToevoegenToolStripMenuItem.Text = "Artikel toevoegen";
			this.artikelToevoegenToolStripMenuItem.Click += new System.EventHandler(this.artikelToevoegenToolStripMenuItem_Click);
			// 
			// bestandToevoegenToolStripMenuItem1
			// 
			this.bestandToevoegenToolStripMenuItem1.Name = "bestandToevoegenToolStripMenuItem1";
			this.bestandToevoegenToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.bestandToevoegenToolStripMenuItem1.Text = "Bestand  toevoegen";
			// 
			// afdelingToevoegenToolStripMenuItem1
			// 
			this.afdelingToevoegenToolStripMenuItem1.Name = "afdelingToevoegenToolStripMenuItem1";
			this.afdelingToevoegenToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.afdelingToevoegenToolStripMenuItem1.Text = "Afdeling toevoegen";
			this.afdelingToevoegenToolStripMenuItem1.Click += new System.EventHandler(this.afdelingToevoegenToolStripMenuItem1_Click);
			// 
			// verwijderenToolStripMenuItem
			// 
			this.verwijderenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artikelVerwijderenToolStripMenuItem});
			this.verwijderenToolStripMenuItem.Name = "verwijderenToolStripMenuItem";
			this.verwijderenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.verwijderenToolStripMenuItem.Text = "&Verwijderen";
			// 
			// artikelAanpassenToolStripMenuItem1
			// 
			this.artikelAanpassenToolStripMenuItem1.Name = "artikelAanpassenToolStripMenuItem1";
			this.artikelAanpassenToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.artikelAanpassenToolStripMenuItem1.Text = "Artikel aanpassen";
			// 
			// afdelingAanpassenToolStripMenuItem
			// 
			this.afdelingAanpassenToolStripMenuItem.Name = "afdelingAanpassenToolStripMenuItem";
			this.afdelingAanpassenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.afdelingAanpassenToolStripMenuItem.Text = "Afdeling aanpassen";
			// 
			// artikelVerwijderenToolStripMenuItem
			// 
			this.artikelVerwijderenToolStripMenuItem.Name = "artikelVerwijderenToolStripMenuItem";
			this.artikelVerwijderenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.artikelVerwijderenToolStripMenuItem.Text = "Artikel verwijderen";
			// 
			// NewStartingScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.PboxLogo);
			this.Controls.Add(this.MenuBar);
			this.IsMdiContainer = true;
			this.Name = "NewStartingScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NewStartingScreen";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.NewStartingScreen_Load);
			((System.ComponentModel.ISupportInitialize)(this.PboxLogo)).EndInit();
			this.MenuBar.ResumeLayout(false);
			this.MenuBar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox PboxLogo;
		private System.Windows.Forms.MenuStrip MenuBar;
		private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem nieuweArtikelenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem instellingenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sluitenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem losArtikelToevoegenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem afdelingToevoegenToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem artikelToevoegenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bestandToevoegenToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem artikelAanpassenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem artikelAanpassenToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem afdelingAanpassenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem verwijderenToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem artikelVerwijderenToolStripMenuItem;
	}
}