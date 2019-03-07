namespace Slooier_voorraad.Forms.AlterDataPopup
{
	partial class AlterAfdelingPopup
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
      this.FlpNew = new System.Windows.Forms.FlowLayoutPanel();
      this.label2 = new System.Windows.Forms.Label();
      this.CbbHuidigeNaam = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.TxbNewName = new System.Windows.Forms.TextBox();
      this.BtnAlterAfdeling = new System.Windows.Forms.Button();
      this.LblMain = new System.Windows.Forms.Label();
      this.defaultBackground1 = new Slooier_voorraad.Controls.DefaultBackground();
      this.FlpNew.SuspendLayout();
      this.SuspendLayout();
      // 
      // FlpNew
      // 
      this.FlpNew.BackColor = System.Drawing.Color.Transparent;
      this.FlpNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.FlpNew.Controls.Add(this.label2);
      this.FlpNew.Controls.Add(this.CbbHuidigeNaam);
      this.FlpNew.Controls.Add(this.label3);
      this.FlpNew.Controls.Add(this.TxbNewName);
      this.FlpNew.Controls.Add(this.BtnAlterAfdeling);
      this.FlpNew.Location = new System.Drawing.Point(99, 79);
      this.FlpNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.FlpNew.Name = "FlpNew";
      this.FlpNew.Size = new System.Drawing.Size(322, 136);
      this.FlpNew.TabIndex = 15;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(4, 0);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(302, 17);
      this.label2.TabIndex = 6;
      this.label2.Text = "Van welke afdeling wilt u de naam aanpassen?";
      // 
      // CbbHuidigeNaam
      // 
      this.CbbHuidigeNaam.FormattingEnabled = true;
      this.CbbHuidigeNaam.Location = new System.Drawing.Point(4, 21);
      this.CbbHuidigeNaam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.CbbHuidigeNaam.MaxDropDownItems = 20;
      this.CbbHuidigeNaam.Name = "CbbHuidigeNaam";
      this.CbbHuidigeNaam.Size = new System.Drawing.Size(317, 24);
      this.CbbHuidigeNaam.TabIndex = 1;
      this.CbbHuidigeNaam.Text = "Afdeling:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(4, 49);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(307, 17);
      this.label3.TabIndex = 7;
      this.label3.Text = "Welke naam moet de gekozen afdeling krijgen?";
      // 
      // TxbNewName
      // 
      this.TxbNewName.Location = new System.Drawing.Point(4, 70);
      this.TxbNewName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.TxbNewName.Name = "TxbNewName";
      this.TxbNewName.Size = new System.Drawing.Size(317, 22);
      this.TxbNewName.TabIndex = 2;
      // 
      // BtnAlterAfdeling
      // 
      this.BtnAlterAfdeling.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.BtnAlterAfdeling.Location = new System.Drawing.Point(4, 100);
      this.BtnAlterAfdeling.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.BtnAlterAfdeling.Name = "BtnAlterAfdeling";
      this.BtnAlterAfdeling.Size = new System.Drawing.Size(319, 28);
      this.BtnAlterAfdeling.TabIndex = 6;
      this.BtnAlterAfdeling.Text = "Aanpassen";
      this.BtnAlterAfdeling.UseVisualStyleBackColor = true;
      // 
      // LblMain
      // 
      this.LblMain.BackColor = System.Drawing.Color.Transparent;
      this.LblMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LblMain.Location = new System.Drawing.Point(13, 33);
      this.LblMain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.LblMain.Name = "LblMain";
      this.LblMain.Size = new System.Drawing.Size(500, 20);
      this.LblMain.TabIndex = 2;
      this.LblMain.Text = "Verander de naam van een afdeling";
      this.LblMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // defaultBackground1
      // 
      this.defaultBackground1.AutoSize = true;
      this.defaultBackground1.BackColor = System.Drawing.Color.Gainsboro;
      this.defaultBackground1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.defaultBackground1.Location = new System.Drawing.Point(0, 0);
      this.defaultBackground1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.defaultBackground1.Name = "defaultBackground1";
      this.defaultBackground1.Size = new System.Drawing.Size(527, 465);
      this.defaultBackground1.TabIndex = 17;
      // 
      // AlterAfdelingPopup
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(527, 465);
      this.Controls.Add(this.LblMain);
      this.Controls.Add(this.FlpNew);
      this.Controls.Add(this.defaultBackground1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.Name = "AlterAfdelingPopup";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Afdeling Aanpassen";
      this.Load += new System.EventHandler(this.AlterAfdelingPopup_Load);
      this.SizeChanged += new System.EventHandler(this.AlterAfdelingPopup_SizeChanged);
      this.FlpNew.ResumeLayout(false);
      this.FlpNew.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox CbbHuidigeNaam;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox TxbNewName;
		private System.Windows.Forms.Label LblMain;
		private System.Windows.Forms.FlowLayoutPanel FlpNew;
		private System.Windows.Forms.Button BtnAlterAfdeling;
    private Controls.DefaultBackground defaultBackground1;
  }
}