using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Globalization;
using System.Diagnostics;
using System.Threading;

namespace FractalsCreator
{
    public class MBrotSet
    {
        protected Graphics g;
        protected List<Pixel> pixels;
        protected List<Pixel> TmpPixels;
        protected Bitmap image;
        protected Size size;
        protected PictureBox gradientBox;
        protected int Iterations;

        public MBrotSet(Bitmap image, List<Pixel> pixels, List<Pixel> TmpPixels, Size size, PictureBox gradientBox,int Iterations)
        {
            this.g = Graphics.FromImage(image);
            this.image = new Bitmap(image.Width, image.Height);
            this.pixels = pixels;
            this.TmpPixels = TmpPixels;
            this.size = size;
            this.Iterations = Iterations;
            this.gradientBox = gradientBox;

            
        }

        public MBrotSet()
        {

        }

        public Bitmap CalculationMBrot(double hx, double hy, double x_, double y_, double maxZ, double SizeArea, ProgressBar progress)
        {
            Bitmap picture = new Bitmap(image.Width, image.Height);
            int UserIt = Iterations;
            int change;
            
            int[] ColorIndex = new int[42];
            int i = 0;
            for (int p = 0; p < gradientBox.Image.Width; p++)
            {
                if (p % (int)(gradientBox.Image.Width * 0.025) == 0)
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
            


            progress.Invoke(new Action(() => // делегат для відображення progressBar
            {
                progress.Value = 0;
                progress.Minimum = 0;
                progress.Maximum = size.Width;
            }));

            for (int x = 0; x < size.Width; x++)
            {
                x_ = (hx - SizeArea / 2) + x * (SizeArea / size.Width);
                for (int y = 0; y < size.Height; y++)
                {
                    y_ = (hy - SizeArea / 2) + y * (SizeArea / size.Height);

                    Complex c = new Complex(x_, y_);
                    Complex z = new Complex(0, 0);


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
                        switch (change)
                        {
                            case 0:
                                picture.SetPixel(x, y, pixels[ColorIndex[0]].Color);
                                break;
                            case 1:
                                picture.SetPixel(x, y, pixels[ColorIndex[1]].Color);
                                break;
                            case 2:
                                picture.SetPixel(x, y, pixels[ColorIndex[2]].Color);
                                break;
                            case 3:
                                picture.SetPixel(x, y, pixels[ColorIndex[3]].Color);
                                break;
                            case 4:
                                picture.SetPixel(x, y, pixels[ColorIndex[4]].Color);
                                break;
                            case 5:
                                picture.SetPixel(x, y, pixels[ColorIndex[5]].Color);
                                break;
                            case 6:
                                picture.SetPixel(x, y, pixels[ColorIndex[6]].Color);
                                break;
                            case 7:
                                picture.SetPixel(x, y, pixels[ColorIndex[7]].Color);
                                break;
                            case 8:
                                picture.SetPixel(x, y, pixels[ColorIndex[8]].Color);
                                break;
                            case 9:
                                picture.SetPixel(x, y, pixels[ColorIndex[9]].Color);
                                break;
                            case 10:
                                picture.SetPixel(x, y, pixels[ColorIndex[10]].Color);
                                break;
                            case 11:
                                picture.SetPixel(x, y, pixels[ColorIndex[11]].Color);
                                break;
                            case 12:
                                picture.SetPixel(x, y, pixels[ColorIndex[12]].Color);
                                break;
                            case 13:
                                picture.SetPixel(x, y, pixels[ColorIndex[13]].Color);
                                break;
                            case 14:
                                picture.SetPixel(x, y, pixels[ColorIndex[14]].Color);
                                break;
                            case 15:
                                picture.SetPixel(x, y, pixels[ColorIndex[15]].Color);
                                break;
                            case 16:
                                picture.SetPixel(x, y, pixels[ColorIndex[16]].Color);
                                break;
                            case 17:
                                picture.SetPixel(x, y, pixels[ColorIndex[17]].Color);
                                break;
                            case 18:
                                picture.SetPixel(x, y, pixels[ColorIndex[18]].Color);
                                break;
                            case 19:
                                picture.SetPixel(x, y, pixels[ColorIndex[19]].Color);
                                break;
                            case 20:
                                picture.SetPixel(x, y, pixels[ColorIndex[20]].Color);
                                break;
                            case 21:
                                picture.SetPixel(x, y, pixels[ColorIndex[21]].Color);
                                break;
                            case 22:
                                picture.SetPixel(x, y, pixels[ColorIndex[22]].Color);
                                break;
                            case 23:
                                picture.SetPixel(x, y, pixels[ColorIndex[23]].Color);
                                break;
                            case 24:
                                picture.SetPixel(x, y, pixels[ColorIndex[24]].Color);
                                break;
                            case 25:
                                picture.SetPixel(x, y, pixels[ColorIndex[25]].Color);
                                break;
                            case 26:
                                picture.SetPixel(x, y, pixels[ColorIndex[26]].Color);
                                break;
                            case 27:
                                picture.SetPixel(x, y, pixels[ColorIndex[27]].Color);
                                break;
                            case 28:
                                picture.SetPixel(x, y, pixels[ColorIndex[28]].Color);
                                break;
                            case 29:
                                picture.SetPixel(x, y, pixels[ColorIndex[29]].Color);
                                break;
                            case 30:
                                picture.SetPixel(x, y, pixels[ColorIndex[30]].Color);
                                break;
                            case 31:
                                picture.SetPixel(x, y, pixels[ColorIndex[31]].Color);
                                break;
                            case 32:
                                picture.SetPixel(x, y, pixels[ColorIndex[32]].Color);
                                break;
                            case 33:
                                picture.SetPixel(x, y, pixels[ColorIndex[33]].Color);
                                break;
                            case 34:
                                picture.SetPixel(x, y, pixels[ColorIndex[34]].Color);
                                break;
                            case 35:
                                picture.SetPixel(x, y, pixels[ColorIndex[35]].Color);
                                break;
                            case 36:
                                picture.SetPixel(x, y, pixels[ColorIndex[36]].Color);
                                break;
                            case 37:
                                picture.SetPixel(x, y, pixels[ColorIndex[37]].Color);
                                break;
                            case 38:
                                picture.SetPixel(x, y, pixels[ColorIndex[38]].Color);
                                break;
                            case 39:
                                picture.SetPixel(x, y, pixels[ColorIndex[39]].Color);
                                break;
                            case 40:
                                picture.SetPixel(x, y, pixels[ColorIndex[40]].Color);
                                break;
                            case 41:
                                picture.SetPixel(x, y, pixels[ColorIndex[41]].Color);
                                break;
                            default:
                                picture.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                                break;
                        }
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

        public string Info()
        {
            string info = "The Mandelbrot set is the set of complex numbers C" +
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
            return info;
        }

        ~MBrotSet()
        {
            Console.WriteLine("Class MBrotSet is clear");
        }
    }
}
