using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp2
{
    class FractalTree
    {
        public Graphics g;
        public Bitmap picture;
        public List<Pixel> pixels;
        public double[] angles;
        public int minLen;
        public int BranchWidth;
        int i = 0;
        public Color BackgroundColor;
        


        public FractalTree(Graphics g, Bitmap picture, List<Pixel> pixels, double[] angles, int minLen, int BranchWidth, Color BackgroundColor)
        {
            this.g = Graphics.FromImage(picture); 
            this.picture = new Bitmap(picture.Width, picture.Height);
            this.pixels = pixels;
            this.angles = angles;
            this.minLen = minLen;
            this.BranchWidth = BranchWidth;
            this.BackgroundColor = BackgroundColor;

        }
        public void DrawFractalTree(int x, int y, int len, double angle)
        {

            if (i == 0)
            {
                g.Clear(BackgroundColor);
            }

            int x1, y1;
            x1 = (int)(x + len * Math.Sin((2 * Math.PI * angle) / 360.0));
            y1 = (int)(y + len * Math.Cos((2 * Math.PI * angle) / 360.0));
            g.DrawLine(new Pen(pixels[i % pixels.Count].Color, BranchWidth), x, picture.Height - y, x1, picture.Height - y1);
            i++;
            if (len > minLen)
            {
                for(int j = 0; j < angles.Length; j++)
                {
                    DrawFractalTree(x1, y1, (int)(len / 1.5), angle + angles[j]);
                }
            }
        }
    }
}
