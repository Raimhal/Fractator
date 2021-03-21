using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp2
{
    class Barnsley_fern
    {
        public Graphics g;
        public Bitmap picture;
        private const float minX = -3;
        private const float maxX = 3;
        private const float minY = 0.1f;
        private const float maxY = 10;
        public int NumberOfPoints;
        public float[] probability;
        public float[,] Coefficient;
        public List<Pixel> pixels;
        public Bitmap bmp;

        public Barnsley_fern(Graphics g, Bitmap bitmap, int NumberOfPoints, float[] probability,float[,] Coefficient, List<Pixel> pixels)
        {
            this.g = Graphics.FromImage(bitmap);
            this.picture = new Bitmap(bitmap.Width, bitmap.Height);
            this.bmp = new Bitmap(bitmap.Width, bitmap.Height);
            this.NumberOfPoints = NumberOfPoints;
            this.probability = probability;
            this.Coefficient = Coefficient;
            this.pixels = pixels;
        }

        public Bitmap DrawBransleyFern()
        {
            g.Clear(Color.Beige);
            Random random = new Random();
            float x0 = 0, y0 = 0;
            int width = (int)(bmp.Width / (maxX - minX));
            int height = (int)(bmp.Height / (maxY - minY));
            int FunctionIndex = 0;

            for (int i = 1; i <= NumberOfPoints; i++)
            {
                // генерация числа (0;1)
                var randomNum = random.NextDouble();
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
                var x = Coefficient[FunctionIndex, 0] * x0 + Coefficient[FunctionIndex, 1] * y0 + Coefficient[FunctionIndex, 4];
                var y = Coefficient[FunctionIndex, 2] * x0 + Coefficient[FunctionIndex, 3] * y0 + Coefficient[FunctionIndex, 5];

                x0 = x;
                y0 = y;
                // перерахунок пікселів відносно форми
                x = (int)(x0 * width + bmp.Width / 2);
                y = (int)(y0 * height);

                picture.SetPixel((int)x, (int)((bmp.Height - (int)(y)) % bmp.Height), pixels[(int)(Math.Abs(x / 3) % 440)].Color);
            }
            return picture;
        }
    }
}
