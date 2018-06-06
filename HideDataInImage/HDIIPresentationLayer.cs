using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideDataInImage
{
    public partial class HDIIPresentationLayer : Form
    {
        public Image Image { get; set; }
        
        public HDIIPresentationLayer()
        {
            InitializeComponent();

        }

        private void openImage_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {

                Image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = Image;
            }
        }

        private void encodeText_Click(object sender, EventArgs e)
        {
            char[] v = encodeTextBox.Text.ToCharArray();
            int c = 0;

            Bitmap bm = new Bitmap(Image);
            for (int w = 0; w < bm.Width; w++)
            {
                for (int h = 0; h < bm.Height; h++)
                {
                    if (v.Length > c)
                    {
                        Color pixel = bm.GetPixel(w, h);
                        bm.SetPixel(w, h, Color.FromArgb(pixel.R, pixel.G, Convert.ToInt32(v[c]))); 
                        c++;
                    }
                }
            }

            Color p = bm.GetPixel(Image.Width - 1, Image.Height - 1);
            bm.SetPixel(Image.Width - 1, Image.Height - 1, Color.FromArgb(p.R, p.G, Convert.ToInt32(c)));
            Image = (Image) bm;
            pictureBox1.Image = Image;
        }

        private void decodeText_Click(object sender, EventArgs e)
        {
            string message = "";
            
            Bitmap bm = new Bitmap(Image);
            int messageLenght = bm.GetPixel(Image.Width - 1, Image.Height - 1).B;
 
            int con = 0;
            for (int w = 0; w < bm.Width; w++)
            {
                for (int h = 0; h < bm.Height; h++)
                {
                    if (messageLenght > con) {
                        Color pixel = bm.GetPixel(w, h);
                        int dump = pixel.B;
                        char bam = Convert.ToChar(dump);
                        string possible = System.Text.ASCIIEncoding.ASCII.GetString(new byte[] { Convert.ToByte(bam) });
                        message = message + possible;
                        con++;
                    }
                }
            }
            MessageBox.Show("Encoded text is: " + message);
        }

        private void encodeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveImage_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();

            if (dr == DialogResult.OK)
            {
                Image.Save(saveFileDialog1.FileName);
            }
        }
    }
}
