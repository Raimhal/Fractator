using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp2
{
    class CurveDragon
    {
        public Graphics g;
        public Bitmap picture;
        public int i = 0;
        public Color BackgroundColor;
        public CurveDragon(Graphics g, Bitmap picture, Color BackgroundColor)
        {
            this.g = Graphics.FromImage(picture);
            this.picture = new Bitmap(picture.Width, picture.Height);
            this.BackgroundColor = BackgroundColor;
        }

        private void Effects()
        {
            g.Clear(BackgroundColor);
            g.SmoothingMode = SmoothingMode.AntiAlias;
        }

        public void DrawCurveDragon(int x1, int y1, int x2, int y2, int Iterations, Pen pen)
        {
            int NextX, NextY;
            if(i == 0)
            {
                Effects();
                i++;
            }


            if (Iterations == 0)
            {
                g.DrawLine(pen, x1, y1, x2, y2);
            }
            if(Iterations > 0)
            {
                NextX = (x1 + x2) / 2 + (y2 - y1) / 2;
                NextY = (y1 + y2) / 2 - (x2 - x1) / 2;

                DrawCurveDragon(x1, y1, NextX, NextY, Iterations - 1, pen);
                DrawCurveDragon(x2, y2, NextX, NextY, Iterations - 1, pen);
            }
        }

    }
}
