using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextureTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openImageFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Basic Image Files(*.png; *.jpg;)|*.png; *.jpg";

            if (open.ShowDialog() == DialogResult.OK) {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image, Int16.Parse(textBoxWidth.Text), Int16.Parse(textBoxHeight.Text));
            pictureBox2.Image = bmp;
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void resizeToGameTextureButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image, Int16.Parse("128"), Int16.Parse("128"));
            pictureBox2.Image = bmp;
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
        }

        private void saveImageFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap bmpSave = new Bitmap(pictureBox2.Image);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Standard PNG Image File(*.png;)|*.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bmpSave.Save(sfd.FileName + ".png", System.Drawing.Imaging.ImageFormat.Png);
            }
            MessageBox.Show("Edited Image was Saved!");
            sfd.Dispose();
        }
    }
}
