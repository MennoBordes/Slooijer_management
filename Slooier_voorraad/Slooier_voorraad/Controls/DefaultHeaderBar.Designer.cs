namespace Slooier_voorraad.Controls
{
	partial class DefaultHeaderBar
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.HeaderBar = new System.Windows.Forms.Panel();
			this.CloseButton = new Slooier_voorraad.UI.CloseButton();
			this.minMaxButton = new Slooier_voorraad.UI.MinMaxButton();
			this.HeaderText = new System.Windows.Forms.Label();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.HeaderBar.SuspendLayout();
			this.SuspendLayout();
			// 
			// HeaderBar
			// 
			this.HeaderBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(182)))));
			this.HeaderBar.Controls.Add(this.CloseButton);
			this.HeaderBar.Controls.Add(this.minMaxButton);
			this.HeaderBar.Controls.Add(this.HeaderText);
			this.HeaderBar.Cursor = System.Windows.Forms.Cursors.Default;
			this.HeaderBar.Dock = System.Windows.Forms.DockStyle.Top;
			this.HeaderBar.Location = new System.Drawing.Point(0, 0);
			this.HeaderBar.Name = "HeaderBar";
			this.HeaderBar.Size = new System.Drawing.Size(406, 27);
			this.HeaderBar.TabIndex = 1;
			this.HeaderBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseDown);
			this.HeaderBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseMove);
			this.HeaderBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.HeaderBar_MouseUp);
			// 
			// CloseButton
			// 
			this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CloseButton.BCBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
			this.CloseButton.DisplayText = "X";
			this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CloseButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CloseButton.ForeColor = System.Drawing.Color.Black;
			this.CloseButton.Location = new System.Drawing.Point(368, 0);
			this.CloseButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.CloseButton.MouseHoverColor = System.Drawing.Color.Red;
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(31, 24);
			this.CloseButton.TabIndex = 0;
			this.CloseButton.Text = "X";
			this.CloseButton.TextLocation_X = 5;
			this.CloseButton.TextLocation_Y = -2;
			this.toolTip1.SetToolTip(this.CloseButton, "Close");
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// minMaxButton
			// 
			this.minMaxButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.minMaxButton.BmmBackColor = System.Drawing.Color.Gray;
			this.minMaxButton.CFormState = Slooier_voorraad.UI.MinMaxButton.CustomFormState.Normal;
			this.minMaxButton.DisplayText = "_KLJS";
			this.minMaxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minMaxButton.ForeColor = System.Drawing.Color.White;
			this.minMaxButton.Location = new System.Drawing.Point(331, 0);
			this.minMaxButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
			this.minMaxButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(240)))));
			this.minMaxButton.Name = "minMaxButton";
			this.minMaxButton.Size = new System.Drawing.Size(31, 24);
			this.minMaxButton.TabIndex = 5;
			this.minMaxButton.Text = "minMaxButton";
			this.minMaxButton.TextLocation_X = 6;
			this.minMaxButton.TextLocation_Y = 6;
			this.toolTip1.SetToolTip(this.minMaxButton, "Minimize");
			this.minMaxButton.UseVisualStyleBackColor = true;
			this.minMaxButton.Click += new System.EventHandler(this.minMaxButton_Click);
			// 
			// HeaderText
			// 
			this.HeaderText.AutoSize = true;
			this.HeaderText.ForeColor = System.Drawing.Color.White;
			this.HeaderText.Location = new System.Drawing.Point(8, 6);
			this.HeaderText.Name = "HeaderText";
			this.HeaderText.Size = new System.Drawing.Size(168, 13);
			this.HeaderText.TabIndex = 6;
			this.HeaderText.Text = "HeaderText, overwritten by parent";
			this.HeaderText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// DefaultHeaderBar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.Controls.Add(this.HeaderBar);
			this.Name = "DefaultHeaderBar";
			this.Size = new System.Drawing.Size(406, 28);
			this.Load += new System.EventHandler(this.DefaultBackground_Load);
			this.HeaderBar.ResumeLayout(false);
			this.HeaderBar.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private UI.CloseButton CloseButton;
		private System.Windows.Forms.Panel HeaderBar;
		private UI.MinMaxButton minMaxButton;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.Label HeaderText;
	}
}
