using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A290Buffet
{
    public partial class frmBuffetOptions : Form
    {
        public frmBuffetOptions()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void optBackgroundRed_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void optBackgroundBlue_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void optBackgroundGreen_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void optBackgoundDefault_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void cboBorderColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboBorderColors.Text)
            {
                case "Red":
                    MessageBox.Show("Red was chosen");
                    Graphics objGraphicsRed = null;
                    objGraphicsRed = this.CreateGraphics();
                    objGraphicsRed.Clear(SystemColors.Control);
                    objGraphicsRed.DrawRectangle(Pens.Red, 1, 1, 281, 263);
                    objGraphicsRed.Dispose();
                    break;
                case "Green":
                    MessageBox.Show("Green was chosen");
                    Graphics objGraphicsGreen = null;
                    objGraphicsGreen = this.CreateGraphics();
                    objGraphicsGreen.Clear(SystemColors.Control);
                    objGraphicsGreen.DrawRectangle(Pens.Green, 1, 1, 281, 263);
                    objGraphicsGreen.Dispose();
                    break;
                case "Blue":
                    MessageBox.Show("Blue was chosen");
                    Graphics objGraphicsBlue = null;
                    objGraphicsBlue = this.CreateGraphics();
                    objGraphicsBlue.Clear(SystemColors.Control);
                    objGraphicsBlue.DrawRectangle(Pens.Blue, 1, 1, 281, 263);
                    objGraphicsBlue.Dispose();
                    break;
                case "Black":
                    MessageBox.Show("Black was chosen");
                    Graphics objGraphicsBlack = null;
                    objGraphicsBlack = this.CreateGraphics();
                    objGraphicsBlack.Clear(SystemColors.Control);
                    objGraphicsBlack.DrawRectangle(Pens.Black, 1, 1, 281, 263);
                    objGraphicsBlack.Dispose();
                    break;
                default:
                    MessageBox.Show("Back to the Default");
                    Graphics objGraphicsDefault = null;
                    objGraphicsDefault = this.CreateGraphics();
                    objGraphicsDefault.Clear(SystemColors.Control);
                    objGraphicsDefault.DrawRectangle(Pens.Gray, 1, 1, 281, 263);
                    objGraphicsDefault.Dispose();
                    break;
            }
        }

        private void chkPromptExit_CheckedChanged(object sender, EventArgs e)
        {
            blnPromptOnExit = (chkPromptExit.Checked);
        }

        private void frmBuffetOptions_Load(object sender, EventArgs e)
        {
            //make our checkbox and boolean match values
            chkPromptExit.Checked = blnPromptOnExit;
        }

        private void frmBuffetOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (blnPromptOnExit)
            { 
                //if box is checked
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
    }
}
