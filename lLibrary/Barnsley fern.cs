using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using HelperClasses;

namespace FractalClasses
{
    public class Barnsley_fern:Fractals
    {

        protected float minX;
        protected float maxX;
        protected float minY;
        protected float maxY;
        protected int NumberOfPoints;
        protected float[] probability;
        protected float[,] Coefficient;
        protected int LenGradient;

        public Barnsley_fern(Bitmap picture, float maxX, float maxY, int NumberOfPoints, float[] probability, float[,] Coefficient, List<Pixel> pixels, Color backgroundColor, int LenGradient, float MinX = -3, float MinY = 0.1f):base(picture, pixels, backgroundColor)
        {
            this.maxX = maxX;
            this.maxY = maxY;
            this.minX = MinX;
            this.minY = MinY;
            this.NumberOfPoints = NumberOfPoints;
            this.probability = probability;
            this.Coefficient = Coefficient;
            this.LenGradient = LenGradient;
        }

        public Barnsley_fern():base()
        {

        }

        public Bitmap DrawBransleyFern(ProgressBar progress)
        {
            Random random = new Random();
            float x0 = 0, y0 = 0;
            float x, y;
            int width = (int)(picture.Width / (maxX - minX));
            int height = (int)(picture.Height / (maxY - minY));
            int FunctionIndex = 0;

            base.Effects(g, BackgroundColor);

            progress.Invoke(new Action(() =>
            {
                progress.Maximum = NumberOfPoints;
                progress.Step = (NumberOfPoints / 100);
            }));

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

                // перерахунок координат відносно форми
                x = (int)(x0 * width + picture.Width / 2);
                y = (int)(y0 * height);
               
                picture.SetPixel(Math.Abs((int)x) % picture.Width, (int)(Math.Abs(picture.Height - (int)(y)) % picture.Height),
                    pixels[(int)((((x * pixels.Count / LenGradient / (picture.Width * 0.00195))) % pixels.Count))].Color); // розтяг градієнта на весь папоротник
                
                if(i % progress.Step == 0) { 

                    progress.Invoke(new Action(() =>
                    {
                        progress.PerformStep();
                    }));
                }
            }
            return picture;
        }

        public override void Info(TextBox info)
        {
            info.Text = "The fern is one of the basic examples" +
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
        }

        ~Barnsley_fern()
        {
            Console.WriteLine("Class Barsley_fern is cleared");
        }
    }
}
