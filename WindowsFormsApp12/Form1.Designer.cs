
namespace WindowsFormsApp12
{
    partial class Form1
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
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
			this.cbCountries = new Guna.UI2.WinForms.Guna2ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnGenerate = new Guna.UI2.WinForms.Guna2GradientButton();
			this.playerUC11 = new WindowsFormsApp12.PlayerUC();
			this.playerUC10 = new WindowsFormsApp12.PlayerUC();
			this.playerUC9 = new WindowsFormsApp12.PlayerUC();
			this.playerUC8 = new WindowsFormsApp12.PlayerUC();
			this.playerUC7 = new WindowsFormsApp12.PlayerUC();
			this.playerUC5 = new WindowsFormsApp12.PlayerUC();
			this.playerUC6 = new WindowsFormsApp12.PlayerUC();
			this.playerUC4 = new WindowsFormsApp12.PlayerUC();
			this.playerUC3 = new WindowsFormsApp12.PlayerUC();
			this.playerUC2 = new WindowsFormsApp12.PlayerUC();
			this.playerUC1 = new WindowsFormsApp12.PlayerUC();
			this.guna2Panel1.SuspendLayout();
			this.guna2Panel2.SuspendLayout();
			this.guna2Panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.guna2Panel1.Controls.Add(this.pictureBox1);
			this.guna2Panel1.Controls.Add(this.guna2ComboBox2);
			this.guna2Panel1.Controls.Add(this.cbCountries);
			this.guna2Panel1.Controls.Add(this.label1);
			this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
			this.guna2Panel1.Size = new System.Drawing.Size(790, 59);
			this.guna2Panel1.TabIndex = 0;
			// 
			// guna2ComboBox2
			// 
			this.guna2ComboBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.guna2ComboBox2.Enabled = false;
			this.guna2ComboBox2.FocusedColor = System.Drawing.Color.Empty;
			this.guna2ComboBox2.FocusedState.Parent = this.guna2ComboBox2;
			this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.guna2ComboBox2.FormattingEnabled = true;
			this.guna2ComboBox2.HoverState.Parent = this.guna2ComboBox2;
			this.guna2ComboBox2.ItemHeight = 30;
			this.guna2ComboBox2.Items.AddRange(new object[] {
            "4-3-3"});
			this.guna2ComboBox2.ItemsAppearance.Parent = this.guna2ComboBox2;
			this.guna2ComboBox2.Location = new System.Drawing.Point(499, 9);
			this.guna2ComboBox2.Name = "guna2ComboBox2";
			this.guna2ComboBox2.ShadowDecoration.Parent = this.guna2ComboBox2;
			this.guna2ComboBox2.Size = new System.Drawing.Size(224, 36);
			this.guna2ComboBox2.StartIndex = 0;
			this.guna2ComboBox2.TabIndex = 2;
			// 
			// cbCountries
			// 
			this.cbCountries.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.cbCountries.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.cbCountries.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCountries.FocusedColor = System.Drawing.Color.Empty;
			this.cbCountries.FocusedState.Parent = this.cbCountries;
			this.cbCountries.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.cbCountries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.cbCountries.FormattingEnabled = true;
			this.cbCountries.HoverState.Parent = this.cbCountries;
			this.cbCountries.ItemHeight = 30;
			this.cbCountries.ItemsAppearance.Parent = this.cbCountries;
			this.cbCountries.Location = new System.Drawing.Point(217, 13);
			this.cbCountries.Name = "cbCountries";
			this.cbCountries.ShadowDecoration.Parent = this.cbCountries;
			this.cbCountries.Size = new System.Drawing.Size(215, 36);
			this.cbCountries.TabIndex = 1;
			this.cbCountries.SelectedIndexChanged += new System.EventHandler(this.cbCountries_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label1.Location = new System.Drawing.Point(13, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Country";
			// 
			// guna2Panel2
			// 
			this.guna2Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.guna2Panel2.Controls.Add(this.label4);
			this.guna2Panel2.Controls.Add(this.label3);
			this.guna2Panel2.Controls.Add(this.label2);
			this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2Panel2.Location = new System.Drawing.Point(0, 59);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
			this.guna2Panel2.Size = new System.Drawing.Size(790, 51);
			this.guna2Panel2.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label4.Location = new System.Drawing.Point(555, 3);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(146, 25);
			this.label4.TabIndex = 5;
			this.label4.Text = "Player Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label3.Location = new System.Drawing.Point(300, 3);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(167, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "Player Number";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.label2.Location = new System.Drawing.Point(12, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(171, 25);
			this.label2.TabIndex = 3;
			this.label2.Text = "Player Position";
			// 
			// guna2Panel3
			// 
			this.guna2Panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.guna2Panel3.Controls.Add(this.playerUC11);
			this.guna2Panel3.Controls.Add(this.playerUC10);
			this.guna2Panel3.Controls.Add(this.playerUC9);
			this.guna2Panel3.Controls.Add(this.playerUC8);
			this.guna2Panel3.Controls.Add(this.playerUC7);
			this.guna2Panel3.Controls.Add(this.playerUC5);
			this.guna2Panel3.Controls.Add(this.playerUC6);
			this.guna2Panel3.Controls.Add(this.playerUC4);
			this.guna2Panel3.Controls.Add(this.playerUC3);
			this.guna2Panel3.Controls.Add(this.playerUC2);
			this.guna2Panel3.Controls.Add(this.playerUC1);
			this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.guna2Panel3.Location = new System.Drawing.Point(0, 110);
			this.guna2Panel3.Name = "guna2Panel3";
			this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
			this.guna2Panel3.Size = new System.Drawing.Size(790, 561);
			this.guna2Panel3.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.pictureBox1.Location = new System.Drawing.Point(147, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(64, 64);
			this.pictureBox1.TabIndex = 12;
			this.pictureBox1.TabStop = false;
			// 
			// btnGenerate
			// 
			this.btnGenerate.Animated = true;
			this.btnGenerate.AutoRoundedCorners = true;
			this.btnGenerate.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnGenerate.BorderRadius = 21;
			this.btnGenerate.CheckedState.Parent = this.btnGenerate;
			this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGenerate.CustomImages.Parent = this.btnGenerate;
			this.btnGenerate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(101)))), ((int)(((byte)(192)))));
			this.btnGenerate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(43)))), ((int)(((byte)(39)))));
			this.btnGenerate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnGenerate.ForeColor = System.Drawing.Color.White;
			this.btnGenerate.HoverState.Parent = this.btnGenerate;
			this.btnGenerate.Location = new System.Drawing.Point(560, 677);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.ShadowDecoration.Parent = this.btnGenerate;
			this.btnGenerate.Size = new System.Drawing.Size(180, 45);
			this.btnGenerate.TabIndex = 10;
			this.btnGenerate.Text = "Generate";
			this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
			// 
			// playerUC11
			// 
			this.playerUC11.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.playerUC11.Dock = System.Windows.Forms.DockStyle.Top;
			this.playerUC11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
			this.playerUC11.Location = new System.Drawing.Point(0, 510);
			this.playerUC11.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.playerUC11.Name = "playerUC11";
			this.playerUC11.Size = new System.Drawing.Size(790, 51);
			this.playerUC11.TabIndex = 11;
			// 
			// playerUC10
			// 
			this.playerUC10.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.playerUC10.Dock = System.Windows.Forms.DockStyle.Top;
			this.playerUC10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
			this.playerUC10.Location = new System.Drawing.Point(0, 459);
			this.playerUC10.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.playerUC10.Name = "playerUC10";
			this.playerUC10.Size = new System.Drawing.Size(790, 51);
			this.playerUC10.TabIndex = 10;
			// 
			// playerUC9
			// 
			this.playerUC9.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.playerUC9.Dock = System.Windows.Forms.DockStyle.Top;
			this.playerUC9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
			this.playerUC9.Location = new System.Drawing.Point(0, 408);
			this.playerUC9.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.playerUC9.Name = "playerUC9";
			this.playerUC9.Size = new System.Drawing.Size(790, 51);
			this.playerUC9.TabIndex = 9;
			// 
			// playerUC8
			// 
			this.playerUC8.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.playerUC8.Dock = System.Windows.Forms.DockStyle.Top;
			this.playerUC8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
			this.playerUC8.Location = new System.Drawing.Point(0, 357);
			this.playerUC8.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.playerUC8.Name = "playerUC8";
			this.playerUC8.Size = new System.Drawing.Size(790, 51);
			this.playerUC8.TabIndex = 8;
			// 
			// playerUC7
			// 
			this.playerUC7.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.playerUC7.Dock = System.Windows.Forms.DockStyle.Top;
			this.playerUC7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
			this.playerUC7.Location = new System.Drawing.Point(0, 306);
			this.playerUC7.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.playerUC7.Name = "playerUC7";
			this.playerUC7.Size = new System.Drawing.Size(790, 51);
			this.playerUC7.TabIndex = 7;
			// 
			// playerUC5
			// 
			this.playerUC5.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.playerUC5.Dock = System.Windows.Forms.DockStyle.Top;
			this.playerUC5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
			this.playerUC5.Location = new System.Drawing.Point(0, 255);
			this.playerUC5.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.playerUC5.Name = "playerUC5";
			this.playerUC5.Size = new System.Drawing.Size(790, 51);
			this.playerUC5.TabIndex = 6;
			// 
			// playerUC6
			// 
			this.playerUC6.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.playerUC6.Dock = System.Windows.Forms.DockStyle.Top;
			this.playerUC6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
			this.playerUC6.Location = new System.Drawing.Point(0, 204);
			this.playerUC6.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.playerUC6.Name = "playerUC6";
			this.playerUC6.Size = new System.Drawing.Size(790, 51);
			this.playerUC6.TabIndex = 5;
			// 
			// playerUC4
			// 
			this.playerUC4.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.playerUC4.Dock = System.Windows.Forms.DockStyle.Top;
			this.playerUC4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
			this.playerUC4.Location = new System.Drawing.Point(0, 153);
			this.playerUC4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.playerUC4.Name = "playerUC4";
			this.playerUC4.Size = new System.Drawing.Size(790, 51);
			this.playerUC4.TabIndex = 3;
			// 
			// playerUC3
			// 
			this.playerUC3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.playerUC3.Dock = System.Windows.Forms.DockStyle.Top;
			this.playerUC3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
			this.playerUC3.Location = new System.Drawing.Point(0, 102);
			this.playerUC3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.playerUC3.Name = "playerUC3";
			this.playerUC3.Size = new System.Drawing.Size(790, 51);
			this.playerUC3.TabIndex = 2;
			// 
			// playerUC2
			// 
			this.playerUC2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.playerUC2.Dock = System.Windows.Forms.DockStyle.Top;
			this.playerUC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
			this.playerUC2.Location = new System.Drawing.Point(0, 51);
			this.playerUC2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.playerUC2.Name = "playerUC2";
			this.playerUC2.Size = new System.Drawing.Size(790, 51);
			this.playerUC2.TabIndex = 1;
			// 
			// playerUC1
			// 
			this.playerUC1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.playerUC1.Dock = System.Windows.Forms.DockStyle.Top;
			this.playerUC1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
			this.playerUC1.Location = new System.Drawing.Point(0, 0);
			this.playerUC1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.playerUC1.Name = "playerUC1";
			this.playerUC1.Size = new System.Drawing.Size(790, 51);
			this.playerUC1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(790, 738);
			this.Controls.Add(this.btnGenerate);
			this.Controls.Add(this.guna2Panel3);
			this.Controls.Add(this.guna2Panel2);
			this.Controls.Add(this.guna2Panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.MaximumSize = new System.Drawing.Size(806, 777);
			this.MinimumSize = new System.Drawing.Size(806, 777);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			this.guna2Panel2.ResumeLayout(false);
			this.guna2Panel2.PerformLayout();
			this.guna2Panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private Guna.UI2.WinForms.Guna2ComboBox cbCountries;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private PlayerUC playerUC11;
        private PlayerUC playerUC10;
        private PlayerUC playerUC9;
        private PlayerUC playerUC8;
        private PlayerUC playerUC7;
        private PlayerUC playerUC5;
        private PlayerUC playerUC6;
        private PlayerUC playerUC4;
        private PlayerUC playerUC3;
        private PlayerUC playerUC2;
        private PlayerUC playerUC1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private Guna.UI2.WinForms.Guna2GradientButton btnGenerate;
	}
}

