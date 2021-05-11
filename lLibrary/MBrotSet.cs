using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using HelperClasses;
namespace FractalClasses
{
    public class MBrotSet:Fractals
    {
        protected List<Pixel> TmpPixels;
        protected Size size;
        protected PictureBox gradientBox;
        protected int Iterations;
        protected Complex c, z;

        
        public MBrotSet(Bitmap picture, List<Pixel> pixels, Size size, PictureBox gradientBox,int Iterations):base(picture, pixels)
        {
            this.size = size;
            this.Iterations = Iterations;
            this.gradientBox = gradientBox;
            TmpPixels = pixels;
        }

        public MBrotSet() : base()
        {

        }

        public Bitmap CalculationMBrot(double hx, double hy, double x_, double y_, double maxZ, double SizeArea, ProgressBar progress)
        {
            progress.Invoke(new Action(() => // делегат для відображення progressBar
            {
                progress.Maximum = size.Width;
            }));

            int UserIt = Iterations;
            int change;
            int LenPixels = 100;
            int[] ColorIndex = new int[LenPixels];
            int i = 0;
            for (int p = 0; p < gradientBox.Image.Width; p++)
            {
                if (p % (int)(gradientBox.Image.Width / ColorIndex.Length) == 0)
                {
                    if (i >= ColorIndex.Length)
                    {
                        break;
                    }
                    ColorIndex[i] = p;
                    i++;
                }
            }
            if (pixels.Count > gradientBox.Width)
            {
                for (int p = 0; p < gradientBox.Width; p++)
                {
                    pixels[p].Color = TmpPixels[(int)(p * (pixels.Count / gradientBox.Width))].Color;
                }
            }

            for (int x = 0; x < size.Width; x++)
            {
                x_ = (hx - SizeArea / 2) + x * (SizeArea / size.Width);
                for (int y = 0; y < size.Height; y++)
                {
                    y_ = (hy - SizeArea / 2) + y * (SizeArea / size.Height);

                    c = new Complex(x_, y_);
                    z = new Complex(0, 0);


                    int it = 0;

                    do
                    {
                        it++;
                        z.Sqr();
                        z.Add(c);
                        if (z.Magn() > maxZ)
                        {
                            break;
                        }
                    } while (it < UserIt);

                    // coloring the set
                    if (it < UserIt)
                    {
                        change = it % ColorIndex.Length;
                        picture.SetPixel(x, y, pixels[ColorIndex[change]].Color);
                    }
                    else
                    {
                        picture.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                }
                progress.Invoke(new Action(() => // делегат для зміни progressBar
                {
                    progress.PerformStep();
                }));

            }
            return picture;
        }

        public override void Info(TextBox info)
        {
            info.Text = "The Mandelbrot set is the set of complex numbers C" +
                " for which the function f(z)=z^2 + c does not diverge when iterated" +
                " from z = 0, i.e., for which the sequence f(0), f(f(0)) etc.," +
                " remains bounded in absolute value. Its definition is credited" +
                " to Adrien Douady who named it in tribute to the mathematician " +
                "Benoit Mandelbrot, a pioneer of fractal geometry." +
                Environment.NewLine +
                Environment.NewLine +
                "Visually, inside the Mandelbrot set," +
                " an infinite number of elementary figures can be distinguished," +
                " the largest of which is in the center - the cardioid." +
                " There is also a set of ovals related to the cardioid," +
                " the size of which gradually decreases, tending to zero." +
                " Each of these ovals has its own set of smaller ovals," +
                " the diameter of which also tends to zero, etc." +
                Environment.NewLine +
                Environment.NewLine +
                " This process continues indefinitely, forming a fractal." +
                " It is also important that these processes of figure branching" +
                " do not completely exhaust the Mandelbrot set: if we consider" +
                " additional “branchings” with magnification, then in them" +
                " you can see your cardioids and circles that are not associated" +
                " with the main figure.";
        }

        ~MBrotSet()
        {
            Console.WriteLine("Class MBrotSet is cleared");
        }
    }
}
