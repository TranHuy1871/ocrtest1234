using System;
using System.Windows.Forms;
using Exception = System.Exception;
using Patagames.Ocr;

namespace TestOCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnload_Click(object sender, EventArgs e)
        {
            try
            {
                openimagedia.Filter = @"png file|*.png|jpg file|*.ipg|All files|*.*";
                if (openimagedia.ShowDialog() == DialogResult.OK)
                {
                    pbimg.Load(openimagedia.FileName);
                    pbimg.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error Load Image. " + ex.Message);
            }
        }

        private void Btnprocess_Click(object sender, EventArgs e)
        {
            try
            {
                if (pbimg.Image != null)
                {
                    var ocr = OcrApi.Create();
                    ocr.Init(Patagames.Ocr.Enums.Languages.Vietnamese);
                    string result = ocr.GetTextFromImage((System.Drawing.Bitmap)pbimg.Image);

                    rtxresult.Text = result;
                }
                else
                {
                    MessageBox.Show(@"No Image Selected. ");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error Process Image Conversion. " + ex.Message);
            }
        }

        private void Btnrl_Click(object sender, EventArgs e)
        {
            if (pbimg.Image != null)
            {
                var imagerl = pbimg.Image;
                imagerl.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipXY);
                pbimg.Image = imagerl;
            }
        }

        private void Btnrr_Click(object sender, EventArgs e)
        {
            if (pbimg.Image != null)
            {
                var imagerr = pbimg.Image;
                imagerr.RotateFlip(System.Drawing.RotateFlipType.Rotate90FlipNone);
                pbimg.Image = imagerr;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pbimg_Click(object sender, EventArgs e)
        {

        }
    }
}
