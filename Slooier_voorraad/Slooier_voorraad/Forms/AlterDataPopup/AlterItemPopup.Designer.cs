namespace Slooier_voorraad.Forms.AlterDataPopup
{
	partial class AlterItemPopup
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
			this.PCurrent = new System.Windows.Forms.Panel();
			this.FlpCurrent = new System.Windows.Forms.FlowLayoutPanel();
			this.label11 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.label10 = new System.Windows.Forms.Label();
			this.TxbCurrentPrijs = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.TxbCurrentVoorraad = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.TxbCurrentNummer = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.TxbCurrentAfdeling = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.TxbCurrentOmschrijving = new System.Windows.Forms.TextBox();
			this.PNew = new System.Windows.Forms.Panel();
			this.FlpNew = new System.Windows.Forms.FlowLayoutPanel();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.TxbNewOmschrijving = new System.Windows.Forms.TextBox();
			this.LblNewOmschrijving = new System.Windows.Forms.Label();
			this.TxbNewPrijs = new System.Windows.Forms.TextBox();
			this.LblNewPrijs = new System.Windows.Forms.Label();
			this.TxbNewVoorraad = new System.Windows.Forms.TextBox();
			this.LblNewVoorraad = new System.Windows.Forms.Label();
			this.TxbNewNummer = new System.Windows.Forms.TextBox();
			this.LblNewNummer = new System.Windows.Forms.Label();
			this.CbbNewAfdeling = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.BtnAlterArtikel = new System.Windows.Forms.Button();
			this.LblMain = new System.Windows.Forms.Label();
			this.DefaultMenuBar = new Slooier_voorraad.Controls.DefaultHeaderBar();
			this.LeftBorder = new Slooier_voorraad.UI.OuterFormBorder();
			this.RightBorder = new Slooier_voorraad.UI.OuterFormBorder();
			this.BottomBorder = new Slooier_voorraad.UI.OuterFormBorder();
			this.defaultBackGround1 = new Slooier_voorraad.UI.DefaultBackGround();
			this.PMain.SuspendLayout();
			this.PCurrent.SuspendLayout();
			this.FlpCurrent.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.PNew.SuspendLayout();
			this.FlpNew.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.defaultBackGround1.SuspendLayout();
			this.SuspendLayout();
			// 
			// PMain
			// 
			this.PMain.Controls.Add(this.PCurrent);
			this.PMain.Controls.Add(this.PNew);
			this.PMain.Controls.Add(this.LblMain);
			this.PMain.Location = new System.Drawing.Point(6, 6);
			this.PMain.Name = "PMain";
			this.PMain.Size = new System.Drawing.Size(835, 323);
			this.PMain.TabIndex = 16;
			// 
			// PCurrent
			// 
			this.PCurrent.Controls.Add(this.FlpCurrent);
			this.PCurrent.Dock = System.Windows.Forms.DockStyle.Left;
			this.PCurrent.Location = new System.Drawing.Point(0, 16);
			this.PCurrent.Name = "PCurrent";
			this.PCurrent.Size = new System.Drawing.Size(370, 307);
			this.PCurrent.TabIndex = 19;
			// 
			// FlpCurrent
			// 
			this.FlpCurrent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.FlpCurrent.Controls.Add(this.label11);
			this.FlpCurrent.Controls.Add(this.label14);
			this.FlpCurrent.Controls.Add(this.tableLayoutPanel2);
			this.FlpCurrent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.FlpCurrent.Location = new System.Drawing.Point(12, 4);
			this.FlpCurrent.Name = "FlpCurrent";
			this.FlpCurrent.Size = new System.Drawing.Size(352, 286);
			this.FlpCurrent.TabIndex = 0;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label11.Dock = System.Windows.Forms.DockStyle.Top;
			this.label11.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(3, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(348, 26);
			this.label11.TabIndex = 15;
			this.label11.Text = "Hier zijn de huidige gegevens van het geselecteerde artikel zichtbaar. ";
			this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label14.Dock = System.Windows.Forms.DockStyle.Top;
			this.label14.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(3, 26);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(348, 14);
			this.label14.TabIndex = 16;
			this.label14.Text = "Dit is ter referentie.";
			this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.30872F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.69128F));
			this.tableLayoutPanel2.Controls.Add(this.label10, 0, 4);
			this.tableLayoutPanel2.Controls.Add(this.TxbCurrentPrijs, 1, 3);
			this.tableLayoutPanel2.Controls.Add(this.label9, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.TxbCurrentVoorraad, 1, 2);
			this.tableLayoutPanel2.Controls.Add(this.label8, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.TxbCurrentNummer, 1, 1);
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.TxbCurrentAfdeling, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.label7, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.TxbCurrentOmschrijving, 1, 4);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 43);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 5;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(348, 228);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(6, 119);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(138, 12);
			this.label10.TabIndex = 22;
			this.label10.Text = "De huidige omschrijving:";
			// 
			// TxbCurrentPrijs
			// 
			this.TxbCurrentPrijs.Location = new System.Drawing.Point(165, 93);
			this.TxbCurrentPrijs.Name = "TxbCurrentPrijs";
			this.TxbCurrentPrijs.ReadOnly = true;
			this.TxbCurrentPrijs.Size = new System.Drawing.Size(177, 20);
			this.TxbCurrentPrijs.TabIndex = 21;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(6, 90);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(92, 12);
			this.label9.TabIndex = 20;
			this.label9.Text = "De huidige prijs:";
			// 
			// TxbCurrentVoorraad
			// 
			this.TxbCurrentVoorraad.Location = new System.Drawing.Point(165, 64);
			this.TxbCurrentVoorraad.Name = "TxbCurrentVoorraad";
			this.TxbCurrentVoorraad.ReadOnly = true;
			this.TxbCurrentVoorraad.Size = new System.Drawing.Size(177, 20);
			this.TxbCurrentVoorraad.TabIndex = 19;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(6, 61);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(117, 12);
			this.label8.TabIndex = 18;
			this.label8.Text = "De huidige voorraad:";
			// 
			// TxbCurrentNummer
			// 
			this.TxbCurrentNummer.Location = new System.Drawing.Point(165, 35);
			this.TxbCurrentNummer.Name = "TxbCurrentNummer";
			this.TxbCurrentNummer.ReadOnly = true;
			this.TxbCurrentNummer.Size = new System.Drawing.Size(177, 20);
			this.TxbCurrentNummer.TabIndex = 17;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 32);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 12);
			this.label1.TabIndex = 16;
			this.label1.Text = "Het huidige nummer:";
			// 
			// TxbCurrentAfdeling
			// 
			this.TxbCurrentAfdeling.Location = new System.Drawing.Point(165, 6);
			this.TxbCurrentAfdeling.Name = "TxbCurrentAfdeling";
			this.TxbCurrentAfdeling.ReadOnly = true;
			this.TxbCurrentAfdeling.Size = new System.Drawing.Size(177, 20);
			this.TxbCurrentAfdeling.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(6, 3);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(111, 12);
			this.label7.TabIndex = 7;
			this.label7.Text = "De huidige afdeling:";
			// 
			// TxbCurrentOmschrijving
			// 
			this.TxbCurrentOmschrijving.Location = new System.Drawing.Point(165, 122);
			this.TxbCurrentOmschrijving.Multiline = true;
			this.TxbCurrentOmschrijving.Name = "TxbCurrentOmschrijving";
			this.TxbCurrentOmschrijving.ReadOnly = true;
			this.TxbCurrentOmschrijving.Size = new System.Drawing.Size(177, 101);
			this.TxbCurrentOmschrijving.TabIndex = 23;
			// 
			// PNew
			// 
			this.PNew.Controls.Add(this.FlpNew);
			this.PNew.Dock = System.Windows.Forms.DockStyle.Right;
			this.PNew.Location = new System.Drawing.Point(373, 16);
			this.PNew.Name = "PNew";
			this.PNew.Size = new System.Drawing.Size(462, 307);
			this.PNew.TabIndex = 18;
			// 
			// FlpNew
			// 
			this.FlpNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.FlpNew.Controls.Add(this.label13);
			this.FlpNew.Controls.Add(this.label12);
			this.FlpNew.Controls.Add(this.tableLayoutPanel1);
			this.FlpNew.Controls.Add(this.BtnAlterArtikel);
			this.FlpNew.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.FlpNew.Location = new System.Drawing.Point(4, 3);
			this.FlpNew.Name = "FlpNew";
			this.FlpNew.Size = new System.Drawing.Size(448, 287);
			this.FlpNew.TabIndex = 15;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label13.Dock = System.Windows.Forms.DockStyle.Top;
			this.label13.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(3, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(440, 14);
			this.label13.TabIndex = 17;
			this.label13.Text = "De hieronder ingevulde waardes zullen worden opgeslagen.";
			this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label12.Dock = System.Windows.Forms.DockStyle.Top;
			this.label12.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(3, 14);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(440, 14);
			this.label12.TabIndex = 16;
			this.label12.Text = "Indien niks is ingevuld zullen de huidige gegevens bewaard blijven!";
			this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.95454F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.04546F));
			this.tableLayoutPanel1.Controls.Add(this.TxbNewOmschrijving, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.LblNewOmschrijving, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.TxbNewPrijs, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.LblNewPrijs, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.TxbNewVoorraad, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.LblNewVoorraad, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.TxbNewNummer, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.LblNewNummer, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.CbbNewAfdeling, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 31);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 6;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(440, 217);
			this.tableLayoutPanel1.TabIndex = 15;
			// 
			// TxbNewOmschrijving
			// 
			this.TxbNewOmschrijving.Location = new System.Drawing.Point(258, 126);
			this.TxbNewOmschrijving.Multiline = true;
			this.TxbNewOmschrijving.Name = "TxbNewOmschrijving";
			this.TxbNewOmschrijving.Size = new System.Drawing.Size(171, 68);
			this.TxbNewOmschrijving.TabIndex = 5;
			this.TxbNewOmschrijving.TextChanged += new System.EventHandler(this.TxbNewOmschrijving_TextChanged);
			// 
			// LblNewOmschrijving
			// 
			this.LblNewOmschrijving.AutoSize = true;
			this.LblNewOmschrijving.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblNewOmschrijving.Location = new System.Drawing.Point(6, 123);
			this.LblNewOmschrijving.Name = "LblNewOmschrijving";
			this.LblNewOmschrijving.Size = new System.Drawing.Size(199, 12);
			this.LblNewOmschrijving.TabIndex = 9;
			this.LblNewOmschrijving.Text = "Welke omschrijving heeft het artikel?";
			// 
			// TxbNewPrijs
			// 
			this.TxbNewPrijs.Location = new System.Drawing.Point(258, 97);
			this.TxbNewPrijs.Name = "TxbNewPrijs";
			this.TxbNewPrijs.Size = new System.Drawing.Size(171, 20);
			this.TxbNewPrijs.TabIndex = 4;
			this.TxbNewPrijs.TextChanged += new System.EventHandler(this.TxbNewPrijs_TextChanged);
			// 
			// LblNewPrijs
			// 
			this.LblNewPrijs.AutoSize = true;
			this.LblNewPrijs.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblNewPrijs.Location = new System.Drawing.Point(6, 94);
			this.LblNewPrijs.Name = "LblNewPrijs";
			this.LblNewPrijs.Size = new System.Drawing.Size(153, 12);
			this.LblNewPrijs.TabIndex = 12;
			this.LblNewPrijs.Text = "Welke prijs heeft het artikel?";
			// 
			// TxbNewVoorraad
			// 
			this.TxbNewVoorraad.Location = new System.Drawing.Point(258, 65);
			this.TxbNewVoorraad.Name = "TxbNewVoorraad";
			this.TxbNewVoorraad.Size = new System.Drawing.Size(171, 20);
			this.TxbNewVoorraad.TabIndex = 3;
			this.TxbNewVoorraad.TextChanged += new System.EventHandler(this.TxbNewVoorraad_TextChanged);
			// 
			// LblNewVoorraad
			// 
			this.LblNewVoorraad.AutoSize = true;
			this.LblNewVoorraad.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblNewVoorraad.Location = new System.Drawing.Point(6, 62);
			this.LblNewVoorraad.Name = "LblNewVoorraad";
			this.LblNewVoorraad.Size = new System.Drawing.Size(187, 12);
			this.LblNewVoorraad.TabIndex = 14;
			this.LblNewVoorraad.Text = "Wat is de voorraad van het artikel?";
			// 
			// TxbNewNummer
			// 
			this.TxbNewNummer.Location = new System.Drawing.Point(258, 36);
			this.TxbNewNummer.Name = "TxbNewNummer";
			this.TxbNewNummer.Size = new System.Drawing.Size(171, 20);
			this.TxbNewNummer.TabIndex = 2;
			this.TxbNewNummer.TextChanged += new System.EventHandler(this.TxbNewNummer_TextChanged);
			// 
			// LblNewNummer
			// 
			this.LblNewNummer.AutoSize = true;
			this.LblNewNummer.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblNewNummer.Location = new System.Drawing.Point(6, 33);
			this.LblNewNummer.Name = "LblNewNummer";
			this.LblNewNummer.Size = new System.Drawing.Size(208, 12);
			this.LblNewNummer.TabIndex = 7;
			this.LblNewNummer.Text = "Welk nummer moet het artikel krijgen?";
			// 
			// CbbNewAfdeling
			// 
			this.CbbNewAfdeling.FormattingEnabled = true;
			this.CbbNewAfdeling.Location = new System.Drawing.Point(258, 6);
			this.CbbNewAfdeling.MaxDropDownItems = 20;
			this.CbbNewAfdeling.Name = "CbbNewAfdeling";
			this.CbbNewAfdeling.Size = new System.Drawing.Size(171, 21);
			this.CbbNewAfdeling.TabIndex = 1;
			this.CbbNewAfdeling.Text = "Afdeling:";
			this.CbbNewAfdeling.TextChanged += new System.EventHandler(this.CbbNewAfdeling_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Lucida Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(6, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(234, 24);
			this.label2.TabIndex = 6;
			this.label2.Text = "Selecteer de afdeling waaronder het artikel hoort.";
			// 
			// BtnAlterArtikel
			// 
			this.BtnAlterArtikel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BtnAlterArtikel.BackColor = System.Drawing.SystemColors.Control;
			this.BtnAlterArtikel.Location = new System.Drawing.Point(3, 254);
			this.BtnAlterArtikel.Name = "BtnAlterArtikel";
			this.BtnAlterArtikel.Size = new System.Drawing.Size(177, 23);
			this.BtnAlterArtikel.TabIndex = 6;
			this.BtnAlterArtikel.Text = "Aanpassen";
			this.BtnAlterArtikel.UseVisualStyleBackColor = false;
			this.BtnAlterArtikel.Click += new System.EventHandler(this.BtnAlterArtikel_Click);
			// 
			// LblMain
			// 
			this.LblMain.Dock = System.Windows.Forms.DockStyle.Top;
			this.LblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblMain.Location = new System.Drawing.Point(0, 0);
			this.LblMain.Name = "LblMain";
			this.LblMain.Size = new System.Drawing.Size(835, 16);
			this.LblMain.TabIndex = 2;
			this.LblMain.Text = "verander de inhoud van artikelen";
			this.LblMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// DefaultMenuBar
			// 
			this.DefaultMenuBar.AutoSize = true;
			this.DefaultMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.DefaultMenuBar.Location = new System.Drawing.Point(0, 0);
			this.DefaultMenuBar.Margin = new System.Windows.Forms.Padding(4);
			this.DefaultMenuBar.Name = "DefaultMenuBar";
			this.DefaultMenuBar.Size = new System.Drawing.Size(859, 27);
			this.DefaultMenuBar.TabIndex = 20;
			// 
			// LeftBorder
			// 
			this.LeftBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.LeftBorder.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.LeftBorder.Dock = System.Windows.Forms.DockStyle.Left;
			this.LeftBorder.Location = new System.Drawing.Point(0, 27);
			this.LeftBorder.Name = "LeftBorder";
			this.LeftBorder.OutBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.LeftBorder.Size = new System.Drawing.Size(8, 340);
			this.LeftBorder.TabIndex = 21;
			// 
			// RightBorder
			// 
			this.RightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.RightBorder.Cursor = System.Windows.Forms.Cursors.SizeWE;
			this.RightBorder.Dock = System.Windows.Forms.DockStyle.Right;
			this.RightBorder.Location = new System.Drawing.Point(851, 27);
			this.RightBorder.Name = "RightBorder";
			this.RightBorder.OutBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.RightBorder.Size = new System.Drawing.Size(8, 340);
			this.RightBorder.TabIndex = 22;
			// 
			// BottomBorder
			// 
			this.BottomBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.BottomBorder.Cursor = System.Windows.Forms.Cursors.SizeNS;
			this.BottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.BottomBorder.Location = new System.Drawing.Point(8, 359);
			this.BottomBorder.Name = "BottomBorder";
			this.BottomBorder.OutBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.BottomBorder.Size = new System.Drawing.Size(843, 8);
			this.BottomBorder.TabIndex = 23;
			// 
			// defaultBackGround1
			// 
			this.defaultBackGround1.BackColor = System.Drawing.Color.Gainsboro;
			this.defaultBackGround1.Controls.Add(this.PMain);
			this.defaultBackGround1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.defaultBackGround1.Location = new System.Drawing.Point(8, 27);
			this.defaultBackGround1.Name = "defaultBackGround1";
			this.defaultBackGround1.Size = new System.Drawing.Size(843, 332);
			this.defaultBackGround1.TabIndex = 24;
			// 
			// AlterItemPopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(859, 367);
			this.Controls.Add(this.defaultBackGround1);
			this.Controls.Add(this.BottomBorder);
			this.Controls.Add(this.RightBorder);
			this.Controls.Add(this.LeftBorder);
			this.Controls.Add(this.DefaultMenuBar);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AlterItemPopup";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Artikel Aanpassen";
			this.Load += new System.EventHandler(this.AlterItemPopup_Load);
			this.PMain.ResumeLayout(false);
			this.PCurrent.ResumeLayout(false);
			this.FlpCurrent.ResumeLayout(false);
			this.FlpCurrent.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.PNew.ResumeLayout(false);
			this.FlpNew.ResumeLayout(false);
			this.FlpNew.PerformLayout();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.defaultBackGround1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel PMain;
		private System.Windows.Forms.FlowLayoutPanel FlpNew;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox CbbNewAfdeling;
		private System.Windows.Forms.Label LblNewNummer;
		private System.Windows.Forms.TextBox TxbNewNummer;
		private System.Windows.Forms.Label LblNewVoorraad;
		private System.Windows.Forms.TextBox TxbNewVoorraad;
		private System.Windows.Forms.Label LblNewPrijs;
		private System.Windows.Forms.TextBox TxbNewPrijs;
		private System.Windows.Forms.Label LblNewOmschrijving;
		private System.Windows.Forms.TextBox TxbNewOmschrijving;
		private System.Windows.Forms.Button BtnAlterArtikel;
		private System.Windows.Forms.Label LblMain;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox TxbCurrentAfdeling;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TxbCurrentNummer;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox TxbCurrentVoorraad;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox TxbCurrentPrijs;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox TxbCurrentOmschrijving;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel PNew;
		private System.Windows.Forms.Panel PCurrent;
		private System.Windows.Forms.FlowLayoutPanel FlpCurrent;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private Controls.DefaultHeaderBar DefaultMenuBar;
		private UI.OuterFormBorder LeftBorder;
		private UI.OuterFormBorder RightBorder;
		private UI.OuterFormBorder BottomBorder;
		private UI.DefaultBackGround defaultBackGround1;
  }
}