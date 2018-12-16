using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windowsForm_Pixel_RGB
{
    public partial class Form1 : Form
    {
        private Bitmap bmp;
        public Form1()
        {
            InitializeComponent();
            bmp = null;
        }

        private void upload_pic_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            bmp = new Bitmap(pictureBox1.Image,new Size(pictureBox1.Size.Width,pictureBox1.Size.Height));

        }

        private void MouseMvEv(object sender, MouseEventArgs e)
        {
            if(bmp != null)
            {
                if(e.Location.X < bmp.Width && e.Location.Y < bmp.Height)
                {
                    Color rgb = bmp.GetPixel(e.Location.X, e.Location.Y);
                    string rgbVlaue = "R: " + rgb.R.ToString() + " G: " + rgb.G.ToString() + " B: " + rgb.B.ToString();
                    rgb_text.Text = rgbVlaue;
                }
            }
        }
    }
}
