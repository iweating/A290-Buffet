namespace A290Buffet
{
    partial class frmBuffetOptions
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.grpDefaultBackgroundColor = new System.Windows.Forms.GroupBox();
            this.optBackgoundDefault = new System.Windows.Forms.RadioButton();
            this.optBackgroundGreen = new System.Windows.Forms.RadioButton();
            this.optBackgroundBlue = new System.Windows.Forms.RadioButton();
            this.optBackgroundRed = new System.Windows.Forms.RadioButton();
            this.cboBorderColors = new System.Windows.Forms.ComboBox();
            this.grpDefaultBackgroundColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(205, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(205, 40);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(1, 5);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(63, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "UserName: ";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(4, 21);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtUserName.Size = new System.Drawing.Size(195, 105);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.Text = "This is some sample text";
            // 
            // grpDefaultBackgroundColor
            // 
            this.grpDefaultBackgroundColor.Controls.Add(this.optBackgoundDefault);
            this.grpDefaultBackgroundColor.Controls.Add(this.optBackgroundGreen);
            this.grpDefaultBackgroundColor.Controls.Add(this.optBackgroundBlue);
            this.grpDefaultBackgroundColor.Controls.Add(this.optBackgroundRed);
            this.grpDefaultBackgroundColor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpDefaultBackgroundColor.Location = new System.Drawing.Point(4, 132);
            this.grpDefaultBackgroundColor.Name = "grpDefaultBackgroundColor";
            this.grpDefaultBackgroundColor.Size = new System.Drawing.Size(105, 117);
            this.grpDefaultBackgroundColor.TabIndex = 4;
            this.grpDefaultBackgroundColor.TabStop = false;
            this.grpDefaultBackgroundColor.Text = "Default Picture Backgound Color";
            // 
            // optBackgoundDefault
            // 
            this.optBackgoundDefault.AutoSize = true;
            this.optBackgoundDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optBackgoundDefault.ForeColor = System.Drawing.Color.Black;
            this.optBackgoundDefault.Location = new System.Drawing.Point(6, 94);
            this.optBackgoundDefault.Name = "optBackgoundDefault";
            this.optBackgoundDefault.Size = new System.Drawing.Size(66, 17);
            this.optBackgoundDefault.TabIndex = 3;
            this.optBackgoundDefault.TabStop = true;
            this.optBackgoundDefault.Text = "Default";
            this.optBackgoundDefault.UseVisualStyleBackColor = true;
            this.optBackgoundDefault.CheckedChanged += new System.EventHandler(this.optBackgoundDefault_CheckedChanged);
            // 
            // optBackgroundGreen
            // 
            this.optBackgroundGreen.AutoSize = true;
            this.optBackgroundGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optBackgroundGreen.ForeColor = System.Drawing.Color.Green;
            this.optBackgroundGreen.Location = new System.Drawing.Point(6, 73);
            this.optBackgroundGreen.Name = "optBackgroundGreen";
            this.optBackgroundGreen.Size = new System.Drawing.Size(59, 17);
            this.optBackgroundGreen.TabIndex = 2;
            this.optBackgroundGreen.TabStop = true;
            this.optBackgroundGreen.Text = "Green";
            this.optBackgroundGreen.UseVisualStyleBackColor = true;
            this.optBackgroundGreen.CheckedChanged += new System.EventHandler(this.optBackgroundGreen_CheckedChanged);
            // 
            // optBackgroundBlue
            // 
            this.optBackgroundBlue.AutoSize = true;
            this.optBackgroundBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optBackgroundBlue.ForeColor = System.Drawing.Color.Blue;
            this.optBackgroundBlue.Location = new System.Drawing.Point(6, 50);
            this.optBackgroundBlue.Name = "optBackgroundBlue";
            this.optBackgroundBlue.Size = new System.Drawing.Size(50, 17);
            this.optBackgroundBlue.TabIndex = 1;
            this.optBackgroundBlue.TabStop = true;
            this.optBackgroundBlue.Text = "Blue";
            this.optBackgroundBlue.UseVisualStyleBackColor = true;
            this.optBackgroundBlue.CheckedChanged += new System.EventHandler(this.optBackgroundBlue_CheckedChanged);
            // 
            // optBackgroundRed
            // 
            this.optBackgroundRed.AutoSize = true;
            this.optBackgroundRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optBackgroundRed.ForeColor = System.Drawing.Color.Red;
            this.optBackgroundRed.Location = new System.Drawing.Point(6, 31);
            this.optBackgroundRed.Name = "optBackgroundRed";
            this.optBackgroundRed.Size = new System.Drawing.Size(48, 17);
            this.optBackgroundRed.TabIndex = 0;
            this.optBackgroundRed.TabStop = true;
            this.optBackgroundRed.Text = "Red";
            this.optBackgroundRed.UseVisualStyleBackColor = true;
            this.optBackgroundRed.CheckedChanged += new System.EventHandler(this.optBackgroundRed_CheckedChanged);
            // 
            // cboBorderColors
            // 
            this.cboBorderColors.FormattingEnabled = true;
            this.cboBorderColors.Items.AddRange(new object[] {
            "Red",
            "Blue",
            "Green",
            "Black",
            "Default"});
            this.cboBorderColors.Location = new System.Drawing.Point(151, 136);
            this.cboBorderColors.Name = "cboBorderColors";
            this.cboBorderColors.Size = new System.Drawing.Size(121, 21);
            this.cboBorderColors.TabIndex = 5;
            this.cboBorderColors.Text = "Border Colors";
            this.cboBorderColors.SelectedIndexChanged += new System.EventHandler(this.cboBorderColors_SelectedIndexChanged);
            // 
            // frmBuffetOptions
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cboBorderColors);
            this.Controls.Add(this.grpDefaultBackgroundColor);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuffetOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "A290 Buffet Options";
            this.grpDefaultBackgroundColor.ResumeLayout(false);
            this.grpDefaultBackgroundColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.GroupBox grpDefaultBackgroundColor;
        private System.Windows.Forms.ComboBox cboBorderColors;
        private System.Windows.Forms.RadioButton optBackgoundDefault;
        private System.Windows.Forms.RadioButton optBackgroundGreen;
        private System.Windows.Forms.RadioButton optBackgroundBlue;
        private System.Windows.Forms.RadioButton optBackgroundRed;
    }
}