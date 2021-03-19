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
        int i = 0;


        public FractalTree(Graphics g, Bitmap picture, List<Pixel> pixels, double[] angles)
        {
            this.g = Graphics.FromImage(picture); 
            this.picture = new Bitmap(picture.Width, picture.Height);
            this.pixels = pixels;
            this.angles = angles;
        }
        public void DrawFractalTree(int x, int y, int len, double angle)
        {

            int x1, y1;

            x1 = (int)(x + len * Math.Sin((2 * Math.PI * angle) / 360.0));
            y1 = (int)(y + len * Math.Cos((2 * Math.PI * angle) / 360.0));
            g.DrawLine(new Pen(pixels[i % 440].Color, 3), x, picture.Height - y, x1, picture.Height - y1);
            i++;
            if (len > 2)
            {
                for(int j = 0; j < angles.Length; j++)
                {
                    DrawFractalTree(x1, y1, (int)(len / 1.5), angle + angles[j]);
                }
            }
        }
    }
}
