using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;

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

            if (open.ShowDialog() == DialogResult.OK)
            {
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

        private void grayScaleToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox2.Image;
            int width = bmp.Width;
            int height = bmp.Height;

            Color p;

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    p = bmp.GetPixel(x, y);

                    int a = p.A;
                    int r = p.R;
                    int g = p.G;
                    int b = p.B;

                    int avg = (r + g + b) / 3;

                    bmp.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                }
                pictureBox2.Image = bmp;
            }
        }

        private void flipImageVerticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox2.Image = pictureBox2.Image;
        }

        private void flipImageHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox2.Image = pictureBox2.Image;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void SaveImage(Image image, string filename)
        {
            string extension = Path.GetExtension(filename);
            switch (extension.ToLower())
            {
                case ".bmp":
                    image.Save(filename, ImageFormat.Bmp);
                    break;
                case ".exif":
                    image.Save(filename, ImageFormat.Exif);
                    break;
                case ".gif":
                    image.Save(filename, ImageFormat.Gif);
                    break;
                case ".jpg":
                case ".jpeg":
                    image.Save(filename, ImageFormat.Jpeg);
                    break;
                case ".png":
                    image.Save(filename, ImageFormat.Png);
                    break;
                case ".tif":
                case ".tiff":
                    image.Save(filename, ImageFormat.Tiff);
                    break;
                default:
                    throw new NotSupportedException(
                        "Unknown file extension " + extension);
            }
        }

        private void ButtonSelectFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                textBoxSelectFolder.Text = f.SelectedPath;
                DirectoryInfo Folder;

                Folder = new DirectoryInfo(f.SelectedPath);
            }
        }

        private void BatchResizeButton_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Refresh();

            DirectoryInfo dir_info = new DirectoryInfo(textBoxSelectFolder.Text);
            foreach (FileInfo file_info in dir_info.GetFiles())
            {
                try
                {
                    string ext = file_info.Extension.ToLower();
                    if ((ext == ".bmp") || (ext == ".gif") ||
                        (ext == ".jpg") || (ext == ".jpeg") ||
                        (ext == ".png"))
                    {
                        using (Bitmap bm = new Bitmap(file_info.FullName))
                        {
                            pictureBox1.Image = bm;
                            Text = "Resized - " +
                                file_info.Name;
                            Application.DoEvents();

                            Rectangle from_rect =
                                new Rectangle(0, 0, bm.Width, bm.Height);

                            Int16 wid2 = Int16.Parse(textBoxBatchWidth.Text);
                            Int16 hgt2 = Int16.Parse(textBoxBatchHeight.Text);
                            using (Bitmap bm2 = new Bitmap(wid2, hgt2))
                            {
                                Rectangle dest_rect =
                                    new Rectangle(0, 0, wid2, hgt2);
                                using (Graphics gr =
                                    Graphics.FromImage(bm2))
                                {
                                    gr.InterpolationMode =
                                       InterpolationMode.HighQualityBicubic;
                                    gr.DrawImage(bm, dest_rect, from_rect,
                                       GraphicsUnit.Pixel);
                                }

                                string new_name = file_info.FullName;
                                new_name = new_name.Substring(0,
                                    new_name.Length - ext.Length);
                                new_name += "_BatchResized" + ext;
                                SaveImage(bm2, new_name);

                                pictureBox1.Image = null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error processing file '" +
                        file_info.Name + "'\n" + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            } 

            Text = "Resized";
            Cursor = Cursors.Default;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            Refresh();

            DirectoryInfo dir_info = new DirectoryInfo(textBoxSelectFolder.Text);
            foreach (FileInfo file_info in dir_info.GetFiles())
            {
                try
                {
                    string ext = file_info.Extension.ToLower();
                    if ((ext == ".bmp") || (ext == ".gif") ||
                        (ext == ".jpg") || (ext == ".jpeg") ||
                        (ext == ".png"))
                    {
                        using (Bitmap bm = new Bitmap(file_info.FullName))
                        {
                            pictureBox1.Image = bm;
                            Text = "Resized - " +
                                file_info.Name;
                            Application.DoEvents();

                            Rectangle from_rect =
                                new Rectangle(0, 0, bm.Width, bm.Height);

                            Int16 wid2 = Int16.Parse("128");
                            Int16 hgt2 = Int16.Parse("128");
                            using (Bitmap bm2 = new Bitmap(wid2, hgt2))
                            {
                                Rectangle dest_rect =
                                    new Rectangle(0, 0, wid2, hgt2);
                                using (Graphics gr =
                                    Graphics.FromImage(bm2))
                                {
                                    gr.InterpolationMode =
                                       InterpolationMode.HighQualityBicubic;
                                    gr.DrawImage(bm, dest_rect, from_rect,
                                       GraphicsUnit.Pixel);
                                }

                                string new_name = file_info.FullName;
                                new_name = new_name.Substring(0,
                                    new_name.Length - ext.Length);
                                new_name += "_BatchResized" + ext;
                                SaveImage(bm2, new_name);

                                pictureBox1.Image = null;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error processing file '" +
                        file_info.Name + "'\n" + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }

            Text = "Resized";
            Cursor = Cursors.Default;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBoxBatchHeight.Text = null;
            textBoxBatchWidth.Text = null;
            textBoxSelectFolder.Text = null;
        }
    }
}