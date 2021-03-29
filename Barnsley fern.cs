using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsApp2
{
    class Barnsley_fern
    {
        public Graphics g;
        public Bitmap picture;
        public float minX = -3;
        public float maxX;
        public float minY = 0.1f;
        public float maxY;
        public int NumberOfPoints;
        public float[] probability;
        public float[,] Coefficient;
        public List<Pixel> pixels;
        public Color BackgroundColor;
        public int LenGradient;

        public Barnsley_fern(Graphics g, Bitmap picture, float maxX, float maxY, int NumberOfPoints, float[] probability, float[,] Coefficient, List<Pixel> pixels, Color backgroundColor, int LenGradient)
        {

            this.picture = new Bitmap(picture.Width, picture.Height);
            this.g = Graphics.FromImage(this.picture);
            this.maxX = maxX;
            this.maxY = maxY;
            this.NumberOfPoints = NumberOfPoints;
            this.probability = probability;
            this.Coefficient = Coefficient;
            this.pixels = pixels;
            this.BackgroundColor = backgroundColor;
            this.LenGradient = LenGradient;
        }

        public Barnsley_fern()
        {

        }
        private void Effects()
        {
            g.Clear(BackgroundColor);
            g.SmoothingMode = SmoothingMode.HighQuality;
        }
        public Bitmap DrawBransleyFern()
        {
            Random random = new Random();
            float x0 = 0, y0 = -10;
            float x = 0, y = 0;
            int width = (int)(picture.Width / (maxX - minX));
            int height = (int)(picture.Height / (maxY - minY));
            int FunctionIndex = 0;
            Effects();

            for (int i = 1; i <= NumberOfPoints; i++)
            {
                // генерация числа (0;1)
                double randomNum = random.NextDouble();
                for (int j = 0; j < probability.Length; j++)
                {
                    randomNum -= probability[j];
                    if (randomNum <= 0)
                    {
                        FunctionIndex = j;
                        break;
                    }
                }
                // вичислення координат
                x = Coefficient[FunctionIndex, 0] * x0 + Coefficient[FunctionIndex, 1] * y0 + Coefficient[FunctionIndex, 4];
                y = Coefficient[FunctionIndex, 2] * x0 + Coefficient[FunctionIndex, 3] * y0 + Coefficient[FunctionIndex, 5];

                x0 = x;
                y0 = y;
                // перерахунок пікселів відносно форми
                x = (int)(x0 * width + picture.Width / 2);
                y = (int)(y0 * height);

                picture.SetPixel(Math.Abs((int)x) % picture.Width, (int)(Math.Abs(picture.Height - (int)(y)) % picture.Height),
                    pixels[(int)((((x * pixels.Count / LenGradient / (picture.Width * 0.0019))) % pixels.Count))].Color); // розтяг градієнта на весь папоротник
            }
            return picture;
        }

        public string Info()
        {
            string info = "The fern is one of the basic examples" +
                " of self-similar sets, i.e. it is a mathematically" +
                " generated pattern that can be reproducible at any" +
                " magnification or reduction. Like the Sierpinski triangle," +
                " the Barnsley fern shows how graphically beautiful structures" +
                " can be built from repetitive uses of mathematical formulas" +
                " with computers. " +
                Environment.NewLine +
                Environment.NewLine +
                "The fern code developed by Barnsley is an" +
                " example of an iterated function system(IFS) to create a fractal." +
                " This follows from the collage theorem.He has used fractals to" +
                " model a diverse range of phenomena in science and technology," +
                " but most specifically plant structures." +
                Environment.NewLine +
                Environment.NewLine +
                "IFSs provide models" +
                " for certain plants, leaves, and ferns, by virtue of the self" +
                " - similarity which often occurs in branching structures in nature." +
                "But nature also exhibits randomness and variation from one level" +
                " to the next; no two ferns are exactly alike," +
                " and the branching fronds become leaves at a smaller scale.";
            return info;
        }
    }
}
