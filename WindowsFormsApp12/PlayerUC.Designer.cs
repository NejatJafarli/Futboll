
namespace WindowsFormsApp12
{
    partial class PlayerUC
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
			this.txtPosition = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtPlayerNumber = new Guna.UI2.WinForms.Guna2TextBox();
			this.txtPlayerName = new Guna.UI2.WinForms.Guna2TextBox();
			this.SuspendLayout();
			// 
			// txtPosition
			// 
			this.txtPosition.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPosition.DefaultText = "";
			this.txtPosition.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtPosition.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtPosition.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPosition.DisabledState.Parent = this.txtPosition;
			this.txtPosition.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPosition.Enabled = false;
			this.txtPosition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPosition.FocusedState.Parent = this.txtPosition;
			this.txtPosition.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPosition.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPosition.HoverState.Parent = this.txtPosition;
			this.txtPosition.Location = new System.Drawing.Point(13, 5);
			this.txtPosition.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.txtPosition.Name = "txtPosition";
			this.txtPosition.PasswordChar = '\0';
			this.txtPosition.PlaceholderText = "";
			this.txtPosition.SelectedText = "";
			this.txtPosition.ShadowDecoration.Parent = this.txtPosition;
			this.txtPosition.Size = new System.Drawing.Size(199, 37);
			this.txtPosition.TabIndex = 0;
			// 
			// txtPlayerNumber
			// 
			this.txtPlayerNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPlayerNumber.DefaultText = "";
			this.txtPlayerNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtPlayerNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtPlayerNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPlayerNumber.DisabledState.Parent = this.txtPlayerNumber;
			this.txtPlayerNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPlayerNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPlayerNumber.FocusedState.Parent = this.txtPlayerNumber;
			this.txtPlayerNumber.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
			this.txtPlayerNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPlayerNumber.HoverState.Parent = this.txtPlayerNumber;
			this.txtPlayerNumber.Location = new System.Drawing.Point(299, 5);
			this.txtPlayerNumber.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.txtPlayerNumber.MaxLength = 2;
			this.txtPlayerNumber.Name = "txtPlayerNumber";
			this.txtPlayerNumber.PasswordChar = '\0';
			this.txtPlayerNumber.PlaceholderText = "";
			this.txtPlayerNumber.SelectedText = "";
			this.txtPlayerNumber.ShadowDecoration.Parent = this.txtPlayerNumber;
			this.txtPlayerNumber.Size = new System.Drawing.Size(165, 37);
			this.txtPlayerNumber.TabIndex = 1;
			this.txtPlayerNumber.TextChanged += new System.EventHandler(this.txtPlayerNumber_TextChanged);
			// 
			// txtPlayerName
			// 
			this.txtPlayerName.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtPlayerName.DefaultText = "";
			this.txtPlayerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtPlayerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtPlayerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPlayerName.DisabledState.Parent = this.txtPlayerName;
			this.txtPlayerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtPlayerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPlayerName.FocusedState.Parent = this.txtPlayerName;
			this.txtPlayerName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
			this.txtPlayerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtPlayerName.HoverState.Parent = this.txtPlayerName;
			this.txtPlayerName.Location = new System.Drawing.Point(555, 5);
			this.txtPlayerName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.txtPlayerName.Name = "txtPlayerName";
			this.txtPlayerName.PasswordChar = '\0';
			this.txtPlayerName.PlaceholderText = "";
			this.txtPlayerName.SelectedText = "";
			this.txtPlayerName.ShadowDecoration.Parent = this.txtPlayerName;
			this.txtPlayerName.Size = new System.Drawing.Size(151, 37);
			this.txtPlayerName.TabIndex = 2;
			this.txtPlayerName.TextChanged += new System.EventHandler(this.txtPlayerName_TextChanged);
			this.txtPlayerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlayerName_KeyPress);
			// 
			// PlayerUC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.txtPlayerName);
			this.Controls.Add(this.txtPlayerNumber);
			this.Controls.Add(this.txtPosition);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
			this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.Name = "PlayerUC";
			this.Size = new System.Drawing.Size(769, 51);
			this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2TextBox txtPosition;
        public Guna.UI2.WinForms.Guna2TextBox txtPlayerNumber;
        public Guna.UI2.WinForms.Guna2TextBox txtPlayerName;
    }
}
