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
    class FractalTree
    {
        public Graphics g;
        public Bitmap picture;
        public List<Pixel> pixels;
        public double[] angles;
        public int minLen;
        public int BranchWidth;
        private int i = 0;
        public Color BackgroundColor;
        public ProgressBar progress;



        public FractalTree(Bitmap picture, List<Pixel> pixels, double[] angles, int minLen, int BranchWidth, Color BackgroundColor, ProgressBar progress)
        {
            this.g = Graphics.FromImage(picture);
            this.picture = new Bitmap(picture.Width, picture.Height);
            this.pixels = pixels;
            this.angles = angles;
            this.minLen = minLen;
            this.BranchWidth = BranchWidth;
            this.BackgroundColor = BackgroundColor;
            this.progress = progress;
        }

        public FractalTree()
        {

        }

        private void Effects()
        {
            g.Clear(BackgroundColor);
            g.SmoothingMode = SmoothingMode.AntiAlias;
        }
        public void DrawFractalTree(int x, int y, int len, double angle)
        {

            if (i == 0)
            {
                Effects();
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
                    DrawFractalTree(x1, y1, (int)(len / 1.5), angle + angles[j]);
                }
            }
        }

        public string Info()
        {
            string info = "Pythagoras, proving his famous theorem," +
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
                "Angles (one angle one branch)" +
                " (-35 - left branch will  have angle 35)" +
                " or (45 right branch will have angle 45)" +
                " (e.g. (-35, 40, 10) we wil have 3 branches" +
                " with corresponding angles)";
            return info;
        }

        ~FractalTree()
        {

        }
    }
}
