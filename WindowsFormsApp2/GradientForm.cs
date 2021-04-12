﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using HelperClasses;


namespace FractalsCreator
{
    public partial class GradientForm : Form
    {
        public List<Pixel> pixels;
        public GradientForm()
        {

            InitializeComponent();

            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo) 
                System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

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
        public List<Pixel> GetPixels(Bitmap bitmap)
        {
            List<Pixel> pixels = new List<Pixel>(bitmap.Width);
            for (int x = 0; x < bitmap.Width; x++)
            {
                pixels.Add(new Pixel()
                {
                    Color = bitmap.GetPixel(x, bitmap.Height / 2) // отримання кольору ряду пікселів з градієнту
                });
            }

            return pixels;
        }

        // creating a gradient
        public void Gradient(PictureBox pictureBox)
        {
            Random color = new Random();

            int r = color.Next(256);
            int g = color.Next(256);
            int b = color.Next(256);
            int changer = color.Next(256);
            Bitmap Gradient = new Bitmap(pictureBox.Width, pictureBox.Height);
            if (changer % 6 == 0)
            {

                for (int x = 0; x < Gradient.Width; x++)
                {

                    for (int y = 0; y < Gradient.Height; y++)
                    {
                        Gradient.SetPixel(x, y, Color.FromArgb(((r + x) / 3) % 255, ((255 - g + x) / 3) % 255, ((b) / 3) % 255));
                    }
                }
            }
            else if (changer % 6 == 1)
            {
                for (int x = 0; x < Gradient.Width; x++)
                {

                    for (int y = 0; y < Gradient.Height; y++)
                    {
                        Gradient.SetPixel(x, y, Color.FromArgb(((r + x) / 3) % 255, ((g) / 3) % 255, ((255 - b + x) / 3) % 255));
                    }
                }
            }
            else if (changer % 6 == 2)
            {
                for (int x = 0; x < Gradient.Width; x++)
                {

                    for (int y = 0; y < Gradient.Height; y++)
                    {
                        Gradient.SetPixel(x, y, Color.FromArgb(((r) / 3) % 255, ((g + x) / 3) % 255, ((255 - b + x) / 3) % 255));
                    }
                }
            }
            else if (changer % 6 == 3)
            {
                for (int x = 0; x < Gradient.Width; x++)
                {

                    for (int y = 0; y < Gradient.Height; y++)
                    {
                        Gradient.SetPixel(x, y, Color.FromArgb(((255 - r + x) / 3) % 255, ((g + x) / 3) % 255, ((b) / 3) % 255));
                    }
                }
            }
            else if (changer % 6 == 4)
            {
                for (int x = 0; x < Gradient.Width; x++)
                {

                    for (int y = 0; y < Gradient.Height; y++)
                    {
                        Gradient.SetPixel(x, y, Color.FromArgb(((r) / 3) % 255, ((255 - g + x) / 3) % 255, ((b + x) / 3) % 255));
                    }
                }
            }
            else
            {
                for (int x = 0; x < Gradient.Width; x++)
                {

                    for (int y = 0; y < Gradient.Height; y++)
                    {
                        Gradient.SetPixel(x, y, Color.FromArgb(((255 - r + x) / 3) % 255, ((g) / 3) % 255, ((b + x) / 3) % 255));
                    }
                }
            }

            pictureBox.Image = Gradient;
        }

        // Random gradient
        public void RandomGradient_Click(object sender, EventArgs e)
        {
            Gradient(pictureGradient);
        }

        // Gradient hot key
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
            Console.WriteLine("Class GradientForm is clear");
        }
    }
}