using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using HelperClasses;


namespace FractalsCreator
{
    public partial class GradientForm : Form
    {
        internal List<Pixel> pixels;
        internal GradientForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            
        }

        private void GradientForm_Load(object sender, EventArgs e)
        {

        }

        /// 
        /// 
        ///     Gradient
        /// 
        ///

        // getting gradient pixels 
        internal List<Pixel> GetPixels(Bitmap bitmap)
        {
            pixels = new List<Pixel>();
            for (int x = 0; x < bitmap.Width; x++)
            {
                pixels.Add(new Pixel()
                {
                    Color = bitmap.GetPixel(x, bitmap.Height / 2) // отримання кольору ряду пікселів з градієнту
                });
            }

            return pixels;
        }

        // random gradient creation
        internal void Gradient(PictureBox pictureBox)
        {
            Random color = new Random();

            int r = color.Next(256);
            int g = color.Next(256);
            int b = color.Next(256);
            int changer = color.Next(256);
            Bitmap Gradient = new Bitmap(pictureBox.Width, pictureBox.Height);
            switch (changer % 3)
            {
                case 0:
                    {
                        SetGradient(Gradient, r, 255 - g, b, 2);
                        break;
                    }
                case 1:
                    {
                        SetGradient(Gradient, 255 - r, g, b, 1);
                        break;
                    }
                case 2:
                    {
                        SetGradient(Gradient, r, g, 255 - b, 0);
                        break;
                    }
                default:
                    break;
            }

            pictureBox.Image = Gradient;
        }

        // generation gradient
        private void SetGradient(Bitmap Gradient, int r, int g, int b, int NoChangeIndex)
        {
            int x;
            int[] change = new int[3];
            change[NoChangeIndex] = 0;
            double GradientStretch = 3;
            for (x = 0; x < Gradient.Width; x++)
            {
                for (int i = 0; i < change.Length; i++)
                {
                    if (i != NoChangeIndex)
                    {
                        change[i] = x;
                    }
                }
                for (int y = 0; y < Gradient.Height; y++)
                {
                    Gradient.SetPixel(x, y, Color.FromArgb((int)((r + change[0]) / GradientStretch) % 255, (int)((g + change[1]) / GradientStretch) % 255, (int)((b + change[2]) / GradientStretch) % 255));
                }
            }
        }
        // Random gradient button
        private void RandomGradient_Click(object sender, EventArgs e)
        {
            Gradient(pictureGradient);
        }
        

        // Gradient hot keys
        private void GradientForm_KeyDown(object sender, KeyEventArgs e)
        {
            // generate gradient
            if (e.Control && e.KeyCode == Keys.Z)
            {
                RandomGradient.PerformClick();
            }
        }
        ~GradientForm()
        {
            Console.WriteLine("Form GradientForm is cleared");
        }
    }
}
