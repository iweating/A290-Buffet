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
    public partial class A290Buffet : Form
    {
        public A290Buffet()
        {
            InitializeComponent();
            
        }

        private void frmBuffet_Load(object sender, EventArgs e)
        {
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
            
        }

        private void btnShrink_Click(object sender, EventArgs e)
        {
            if (this.Height > 325 && this.Width > 400)
            {
                this.Width = this.Width - 20;
                this.Height = this.Height - 20;
            }
        }

        private void btnDrawBorder_Click(object sender, EventArgs e)
        {
            Graphics objDrawBorder = null;
            objDrawBorder = this.CreateGraphics();
            objDrawBorder.Clear(SystemColors.Control);

            objDrawBorder.DrawRectangle(Pens.Blue,
                picShowPicture.Left-1,picShowPicture.Top-1,
                picShowPicture.Width+1,picShowPicture.Height+1);

            objDrawBorder.Dispose();
        }

    }
}
