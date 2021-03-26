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
        public Bitmap bmp;
        public Color BackgroundColor;

        public Barnsley_fern(Graphics g, Bitmap picture, float maxX, float maxY, int NumberOfPoints, float[] probability, float[,] Coefficient, List<Pixel> pixels, Color backgroundColor)
        {

            this.picture = new Bitmap(picture.Width, picture.Height);
            this.bmp = new Bitmap(picture.Width, picture.Height);
            this.g = Graphics.FromImage(this.picture);
            this.maxX = maxX;
            this.maxY = maxY;
            this.NumberOfPoints = NumberOfPoints;
            this.probability = probability;
            this.Coefficient = Coefficient;
            this.pixels = pixels;
            this.BackgroundColor = backgroundColor;
        }
        private void Effects()
        {
            g.Clear(BackgroundColor);
            g.SmoothingMode = SmoothingMode.AntiAlias;
        }
        public Bitmap DrawBransleyFern()
        {
            Random random = new Random();
            float x0 = 0, y0 = 0;
            float x = 0, y = 0;
            int width = (int)(bmp.Width / (maxX - minX));
            int height = (int)(bmp.Height / (maxY - minY));
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
                x = (int)(x0 * width + bmp.Width / 2);
                y = (int)(y0 * height);

                picture.SetPixel((int)x, (int)((bmp.Height - (int)(y)) % bmp.Height), pixels[(int)(Math.Abs(x / 3) % pixels.Count)].Color); // розтяг градієнта на весь папоротник
            }
            return picture;
        }
    }
}
