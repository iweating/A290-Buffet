namespace A290Buffet
{
    partial class A290Buffet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(A290Buffet));
            this.btnSelectPicture = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.picShowPicture = new System.Windows.Forms.PictureBox();
            this.ofdSelectPicture = new System.Windows.Forms.OpenFileDialog();
            this.btnEnlarge = new System.Windows.Forms.Button();
            this.btnShrink = new System.Windows.Forms.Button();
            this.btnDrawBorder = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picShowPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSelectPicture
            // 
            this.btnSelectPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectPicture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSelectPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPicture.Location = new System.Drawing.Point(294, 10);
            this.btnSelectPicture.Name = "btnSelectPicture";
            this.btnSelectPicture.Size = new System.Drawing.Size(85, 23);
            this.btnSelectPicture.TabIndex = 0;
            this.btnSelectPicture.Text = "Select Picture";
            this.btnSelectPicture.UseVisualStyleBackColor = false;
            this.btnSelectPicture.Click += new System.EventHandler(this.btnSelectPicture_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQuit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(294, 70);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(85, 23);
            this.btnQuit.TabIndex = 1;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // picShowPicture
            // 
            this.picShowPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picShowPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picShowPicture.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picShowPicture.Location = new System.Drawing.Point(6, 6);
            this.picShowPicture.Name = "picShowPicture";
            this.picShowPicture.Padding = new System.Windows.Forms.Padding(5);
            this.picShowPicture.Size = new System.Drawing.Size(282, 275);
            this.picShowPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picShowPicture.TabIndex = 2;
            this.picShowPicture.TabStop = false;
            this.picShowPicture.MouseLeave += new System.EventHandler(this.picShowPicture_MouseLeave);
            this.picShowPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picShowPicture_MouseMove);
            // 
            // ofdSelectPicture
            // 
            this.ofdSelectPicture.Filter = "Windows Bitmaps|*.BMP|JPEG|*.JPG|Portable Network Graphics|*.PNG";
            this.ofdSelectPicture.Title = "Select Picture";
            // 
            // btnEnlarge
            // 
            this.btnEnlarge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnlarge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnlarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnlarge.Location = new System.Drawing.Point(363, 261);
            this.btnEnlarge.Name = "btnEnlarge";
            this.btnEnlarge.Size = new System.Drawing.Size(21, 23);
            this.btnEnlarge.TabIndex = 3;
            this.btnEnlarge.Text = "+";
            this.btnEnlarge.UseVisualStyleBackColor = true;
            this.btnEnlarge.Click += new System.EventHandler(this.btnEnlarge_Click);
            // 
            // btnShrink
            // 
            this.btnShrink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShrink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShrink.Location = new System.Drawing.Point(343, 261);
            this.btnShrink.Name = "btnShrink";
            this.btnShrink.Size = new System.Drawing.Size(21, 23);
            this.btnShrink.TabIndex = 4;
            this.btnShrink.Text = "-";
            this.btnShrink.UseVisualStyleBackColor = true;
            this.btnShrink.Click += new System.EventHandler(this.btnShrink_Click);
            // 
            // btnDrawBorder
            // 
            this.btnDrawBorder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDrawBorder.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDrawBorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrawBorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrawBorder.Location = new System.Drawing.Point(294, 40);
            this.btnDrawBorder.Name = "btnDrawBorder";
            this.btnDrawBorder.Size = new System.Drawing.Size(85, 23);
            this.btnDrawBorder.TabIndex = 5;
            this.btnDrawBorder.Text = "Draw Border";
            this.btnDrawBorder.UseVisualStyleBackColor = false;
            this.btnDrawBorder.Click += new System.EventHandler(this.btnDrawBorder_Click);
            // 
            // lblX
            // 
            this.lblX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(300, 110);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(15, 13);
            this.lblX.TabIndex = 6;
            this.lblX.Text = "X";
            // 
            // lblY
            // 
            this.lblY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(300, 125);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(15, 13);
            this.lblY.TabIndex = 7;
            this.lblY.Text = "Y";
            // 
            // A290Buffet
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelButton = this.btnQuit;
            this.ClientSize = new System.Drawing.Size(384, 286);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.btnDrawBorder);
            this.Controls.Add(this.btnShrink);
            this.Controls.Add(this.btnEnlarge);
            this.Controls.Add(this.picShowPicture);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnSelectPicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(350, 275);
            this.Name = "A290Buffet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A290 Buffet";
            this.Load += new System.EventHandler(this.frmBuffet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picShowPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectPicture;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.PictureBox picShowPicture;
        private System.Windows.Forms.OpenFileDialog ofdSelectPicture;
        private System.Windows.Forms.Button btnEnlarge;
        private System.Windows.Forms.Button btnShrink;
        private System.Windows.Forms.Button btnDrawBorder;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
    }
}

