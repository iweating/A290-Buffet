/**********************************************************
* A290Buffet.cs
*
* These definitions set up the I/O interface for the PowerBox.
*
* Author: ---
* Date Created: ---
* Last Modified by: ---
* Date Last Modified: ---
* Assignment: ---
* Part of: ---
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Collections;

namespace A290Buffet
{
    public partial class A290Buffet : Form
    {
        public A290Buffet()
        {
            InitializeComponent();
        }
        const bool defPromptOnExit = true;
        bool blnPromptOnExit = defPromptOnExit;
        private void frmBuffet_Load(object sender, EventArgs e)
        {
            lblX.Text = "";
            lblY.Text = "";
            chkPromptExit.Checked = blnPromptOnExit;
        }

        private void btnSelectPicture_Click(object sender, EventArgs e)
        {
            if (ofdSelectPicture.ShowDialog() == DialogResult.OK)
            {
                //Load the picture into the picture box
                picShowPicture.Image = Image.FromFile(ofdSelectPicture.FileName);
                this.Text = string.Concat("A290 Buffet(" + ofdSelectPicture.FileName + ")");
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            //Exit our application
            this.Close();
        }

        private void btnEnlarge_Click(object sender, EventArgs e)
        {
            this.Width = this.Width + 20;
            this.Height = this.Height + 20;

            drawBorder();
        }

        private void btnShrink_Click(object sender, EventArgs e)
        {
            this.Width = this.Width - 20;
            this.Height = this.Height - 20;
            drawBorder();
        }

        private void btnDrawBorder_Click(object sender, EventArgs e)
        {
            drawBorder();
        }

        private void picShowPicture_MouseMove(object sender, MouseEventArgs e)
        {
            lblX.Text = "X: " + e.X.ToString();
            lblY.Text = "Y: " + e.Y.ToString();
        }

        private void picShowPicture_MouseLeave(object sender, EventArgs e)
        {
            lblX.Text = "";
            lblY.Text = "";
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            frmBuffetOptions frmBuffetOptionsDialog = new frmBuffetOptions();
            frmBuffetOptionsDialog.ShowDialog();
        }

        private void chkPromptExit_CheckedChanged(object sender, EventArgs e)
        {
            blnPromptOnExit = (chkPromptExit.Checked);
        }

        private void A290Buffet_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (blnPromptOnExit)
            {
                //if box is checked
                if (MessageBox.Show("Close the Buffet Program?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    if (MessageBox.Show("Close the Buffet Program?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        if (MessageBox.Show("Close the Buffet Program?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    //Display a dialog with Yes/No buttons that asks "Close the Buffet Program?,
                    //uses the "?" icon, and has the caption "Confirm Exit"
                    //If the user selects "No", then
                    e.Cancel = true;
                }
                //otherwise, close the application
            }
        }

        private void btnCollections_Click(object sender, EventArgs e)
        {
            frmCollections frmCollectionsDialog = new frmCollections();
            frmCollectionsDialog.ShowDialog();
        }

        private void A290Buffet_ResizeEnd(object sender, EventArgs e)
        {
            drawBorder();
        }

        private void drawBorder()
        {
            Graphics objDrawBorder = null;
            objDrawBorder = this.CreateGraphics();
            objDrawBorder.Clear(SystemColors.Control);

            objDrawBorder.DrawRectangle(Pens.Blue,
                picShowPicture.Left - 1, picShowPicture.Top - 1,
                picShowPicture.Width + 1, picShowPicture.Height + 1);

            objDrawBorder.Dispose();
        }

    }
}
