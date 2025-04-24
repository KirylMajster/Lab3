using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Lab3_zadanie3
{
    public partial class Form1 : Form
    {
        private Bitmap? img;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var temp = new Bitmap(openFileDialog1.FileName))
                {
                    img = new Bitmap(temp); 
                }

                pictureOriginal.Image = img; 
                StartProcessing();           
            }

        }

        private Bitmap CloneBitmap(Bitmap source)
        {
            Bitmap clone = new Bitmap(source.Width, source.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using (Graphics g = Graphics.FromImage(clone))
            {
                g.DrawImage(source, new Rectangle(0, 0, source.Width, source.Height));
            }
            return clone;
        }



        private void StartProcessing()
        {
            if (img == null) return;

            Bitmap copy1 = CloneBitmap(img);
            Bitmap copy2 = CloneBitmap(img);
            Bitmap copy3 = CloneBitmap(img);
            Bitmap copy4 = CloneBitmap(img);

            Thread t1 = new Thread(() => ApplyFilter(copy1, FilterType.Grayscale, pictureGray));
            Thread t2 = new Thread(() => ApplyFilter(copy2, FilterType.Negative, pictureNegative));
            Thread t3 = new Thread(() => ApplyFilter(copy3, FilterType.Threshold, pictureThreshold));
            Thread t4 = new Thread(() => ApplyFilter(copy4, FilterType.Mirror, pictureMirror));

            t1.Start(); t2.Start(); t3.Start(); t4.Start();
        }


        private void ApplyFilter(Bitmap original, FilterType type, PictureBox target)
        {
            Bitmap processed = CloneBitmap(original);

            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color pixel = original.GetPixel(x, y);
                    Color newPixel = type switch
                    {
                        FilterType.Grayscale => Color.FromArgb((pixel.R + pixel.G + pixel.B) / 3,
                                                                (pixel.R + pixel.G + pixel.B) / 3,
                                                                (pixel.R + pixel.G + pixel.B) / 3),
                        FilterType.Negative => Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B),
                        FilterType.Threshold => ((pixel.R + pixel.G + pixel.B) / 3 > 128)
                                                ? Color.White : Color.Black,
                        FilterType.Mirror => original.GetPixel(original.Width - 1 - x, y),
                        _ => pixel
                    };
                    processed.SetPixel(x, y, newPixel);
                }
            }

            
            if (target.InvokeRequired)
            {
                target.Invoke(new Action(() => target.Image = processed));
            }
            else
            {
                target.Image = processed;
            }
        }

        enum FilterType
        {
            Grayscale,
            Negative,
            Threshold,
            Mirror
        }
    }
}
