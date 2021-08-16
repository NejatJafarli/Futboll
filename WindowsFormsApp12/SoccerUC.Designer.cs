
namespace WindowsFormsApp12
{
	partial class SoccerUC
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
			this.lblName = new System.Windows.Forms.Label();
			this.lblNumber = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.BackColor = System.Drawing.Color.Transparent;
			this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblName.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblName.Location = new System.Drawing.Point(3, 106);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(236, 37);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "IBRAHIMOVIC";
			// 
			// lblNumber
			// 
			this.lblNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNumber.AutoSize = true;
			this.lblNumber.BackColor = System.Drawing.Color.Transparent;
			this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.lblNumber.Location = new System.Drawing.Point(55, 45);
			this.lblNumber.Name = "lblNumber";
			this.lblNumber.Size = new System.Drawing.Size(62, 42);
			this.lblNumber.TabIndex = 1;
			this.lblNumber.Text = "99";
			// 
			// SoccerUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.BackgroundImage = global::WindowsFormsApp12.Properties.Resources.Soccer2;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.lblNumber);
			this.Controls.Add(this.lblName);
			this.DoubleBuffered = true;
			this.Name = "SoccerUC";
			this.Size = new System.Drawing.Size(165, 143);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.Label lblName;
		public System.Windows.Forms.Label lblNumber;
	}
}
