using System;
using System.Drawing;
using System.Windows.Forms;
namespace FractalClasses
{
    public class CurveDragon : Fractals
    {
        private int i = 0;

        public CurveDragon(Bitmap picture, Color BackgroundColor):base(picture, BackgroundColor)
        {
        }

        public CurveDragon():base()
        {

        }

        public void DrawCurveDragon(int x1, int y1, int x2, int y2, int Iterations, Pen pen, ProgressBar progress)
        {
            int NextX, NextY;
            if (i == 0)
            {
                base.Effects(g, BackgroundColor);
            }
 

            if (Iterations == 0)
            {
                g.DrawLine(pen, x1, y1, x2, y2);


            }
            else if(Iterations > 0)
            {
                i++;
                NextX = (int)((x1 + x2) / 2 + (y2 - y1) / 2);
                NextY = (int)((y1 + y2) / 2 - (x2 - x1) / 2);

                DrawCurveDragon(x1, y1, NextX, NextY, Iterations - 1, pen, progress);
                DrawCurveDragon(x2, y2, NextX, NextY, Iterations - 1, pen, progress);
            }
        }

        public override void Info(TextBox info)
        {
            info.Text = "The Harter dragon, also known as" +
                " the Harter-Haytway dragon, was first explored" +
                " by NASA physicists John Heighway, Bruce Banks," +
                " and William Harter. It was described in 1967 by" +
                " Martin Gardner in the Math Games column of Scientific" +
                " American. Many of the properties of a fractal have been" +
                " described by Chandler Davis and Donald Knuth." +
                " The fractal can be created manually. " +
                Environment.NewLine +
                Environment.NewLine +
                "A dragon curve is any member of a family of self-similar" +
                " fractal curves, which can be approximated by recursive" +
                " methods such as Lindenmayer systems. The dragon curve" +
                " is probably most commonly thought of as the shape that" +
                " is generated from repeatedly folding a strip of paper in half," +
                " although there are other curves that are called dragon curves" +
                " that are generated differently." +
                Environment.NewLine +
                Environment.NewLine +
                "For this, we take a segment, bend it in half." +
                " Then we iterate over and over again. If we then" +
                " unbend the resulting (folded) line again so that all" +
                " angles are equal to 90 °, we get a dragon curve.";
        }
        ~CurveDragon()
        {
            Console.WriteLine("Class CurveDragon is cleared");
        }
    }
}
