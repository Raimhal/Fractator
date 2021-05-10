using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using HelperClasses;

namespace FractalClasses
{
    public class FractalTree : Fractals
    {
        protected double[] angles;
        protected int minLen;
        protected int BranchWidth;
        private int i = 0;

        public FractalTree(Bitmap picture, List<Pixel> pixels, double[] angles, int minLen, int BranchWidth, Color BackgroundColor):base(picture, pixels, BackgroundColor)
        {
            this.angles = angles;
            this.minLen = minLen;
            this.BranchWidth = BranchWidth;
        }

        public FractalTree() : base()
        {

        }

        public void DrawFractalTree(int x, int y, int len, double angle, ProgressBar progress)
        {
            
            if (i == 0)
            {
                base.Effects(g, BackgroundColor);
                progress.Invoke(new Action(() => // делегат для відображення progressBar
                {
                    progress.Maximum = 0;
                    double count = 0;
                    double tmpCount = len;
                    while (tmpCount > minLen)
                    {
                        tmpCount /= 1.5;
                        count++;
                    }
                    if (angles.Length == 2)
                    {
                       
                        for (int i = 0; i < count; i++)
                        {
                            progress.Maximum += (int)(Math.Pow(2, i) / Math.Pow(angles.Length, 2));
                        }
                    }
                    else if(angles.Length == 3)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            progress.Maximum += (int)(Math.Pow(3, i) / angles.Length);
                        }
                        if(len / minLen > 40)
                        {
                            progress.Maximum *= (int)(Math.Log(len, minLen) / 2);
                        }
                    }
                    else if (angles.Length == 4)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            progress.Maximum += (int)((Math.Pow(4, i) / angles.Length));
                        }
                        if ((double)len / minLen <=  len * 0.05)
                        {
                            progress.Maximum *= (int)(Math.Pow(Math.Log(len, minLen), 1.4));
                        }

                    }
                }));
            }

            int x1, y1;
            x1 = (int)(x + len * Math.Sin((2 * Math.PI * angle) / 360.0));
            y1 = (int)(y + len * Math.Cos((2 * Math.PI * angle) / 360.0));
            g.DrawLine(new Pen(pixels[i % pixels.Count].Color, BranchWidth), x, picture.Height - y, x1, picture.Height - y1);
            i++;
            if (len > minLen)
            {
                for (int j = 0; j < angles.Length; j++)
                {
                    DrawFractalTree(x1, y1, (int)(len / 1.5), angle + angles[j], progress);
                }
                progress.Invoke(new Action(() => // делегат для зміни progressBar
                {
                    progress.PerformStep();
                }));
            }



        }

        public override void Info(TextBox info)
        {
            info.Text = "Pythagoras, proving his famous theorem," +
                " built a figure with squares on the sides of a right-angled triangle." +
                " In our century, this figure of Pythagoras has grown into a whole tree." +
                Environment.NewLine +
                Environment.NewLine +
                " For the first time, the Pythagorean tree was built" +
                " by A.E. Bosman (1891-1961) during the Second World War," +
                " using an ordinary drawing ruler. If in the classical Pythagorean" +
                " tree the angle is 45 degrees, then it is also possible to build" +
                " a generalized Pythagorean tree using other angles. Such a tree" +
                " is often called the windswept Pythagoras tree. If you draw only" +
                " the segments connecting the selected centers of the triangles in" +
                " some way, you get a naked Pythagorean tree." +
                Environment.NewLine +
                Environment.NewLine +
                "Angles (one angle - one branch)" +
                " (-35 - left branch will  have angle 35)" +
                " or (45 right branch will have angle 45)" +
                " (e.g. (-35, 40, 10) we wil have 3 branches" +
                " with corresponding angles)";
        }

        ~FractalTree()
        {
            Console.WriteLine("Class FractalTree is cleared");
        }
    }
}
