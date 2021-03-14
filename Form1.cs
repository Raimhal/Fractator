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

/// <summary>
/// 1)  Попробувати реалізувати приближення по алгоратму 
/// if(newWidth < newHeight)
/// {
///     for(int i = newWidth; newWidth < oldWidth; newWidth++)
///     {
///         zoom -= zoomSpeed / zoom;
///     }
/// }
/// else
/// {
/// 
///      for(int i = newHeight; newHeight < oldHeight; newHeight++)
///      {
///         zoom -= zoomSpeed / zoom;
///      }
/// }
/// 
/// 2) Додати розфарбування фракталу за допомогою градієнту
/// 3) Спробувати ререндирити картинку для виконання зумузуму
/// 4) Вияснити причину чому не виконується подія image_MOuseClick
/// /// </summary>
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int UserIt;

        double hx = -0.6, hy = 0, x_, y_, n = 0;
        bool er_x, er_y;
        Size StartSize;
        double ZoomVal = 1;
        
        Size size;
        double SizeArea, ScaleArea;



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void GenerateFractal_Click(object sender, EventArgs e)
        {
            ZoomNUM.Text = ZoomVal.ToString("F0") + " X";
            er_x = double.TryParse(CenterX.Text, out hx);
            er_y = double.TryParse(CenterY.Text, out hy);
            if (er_x == false)
            {
                MessageBox.Show("Помилка введення значення x!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (er_y == false)
            {
                MessageBox.Show("Помилка введення значення y!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DrawMBrot();
            }
        }
        private void DecreaseZOOM_Click(object sender, EventArgs e)
        {
            n = (double)ZOOMValue.Value;
            SizeArea *= n;
            CenterX.Text = hx.ToString();
            CenterY.Text = hy.ToString();
            DrawMBrot();
            ZoomVal /= (double)ZOOMValue.Value;
            ZoomNUM.Clear();
            ZoomNUM.Text = ZoomVal.ToString("F2") + " X";
        }
        private void IncreaseZOOM_Click(object sender, EventArgs e)
        {
            n = (double)ZOOMValue.Value;
            SizeArea /= n;
            CenterX.Text = hx.ToString();
            CenterY.Text = hy.ToString();
            DrawMBrot();
            ZoomVal *= (double)ZOOMValue.Value;
            ZoomNUM.Clear();
            ZoomNUM.Text = ZoomVal.ToString("F2") + " X";
        }

        void image_MouseClick(object sender, MouseEventArgs e)
        {
            int X = e.X, Y = e.Y;
            if (e.Button == MouseButtons.Left)
            {
                hx = (hx - SizeArea / 2) + X * (SizeArea / size.Width);
                hy = (hy - SizeArea / 2) + Y * (SizeArea / size.Height);
                SizeArea /= ScaleArea; // increase zoom by ScaleArea value
                CenterX.Text = hx.ToString();
                CenterY.Text = hy.ToString();
                DrawMBrot();
                ZoomVal *= (double)ZOOMValue.Value;
                ZoomNUM.Clear();
                ZoomNUM.Text = ZoomVal.ToString("F2") + " X";

            }
            else if (e.Button == MouseButtons.Middle)
            {                // back to default
                SizeArea = 3;
                ScaleArea = 3;
                hx = -0.6;
                hy = 0;
                CenterX.Text = hx.ToString();
                CenterY.Text = hy.ToString();
                DrawMBrot();
                ZoomVal = 1;
                ZoomNUM.Clear();
                ZoomNUM.Width = 80;
                ZoomNUM.Text = ZoomVal.ToString("F0") + " X";
            }
            else if (e.Button == MouseButtons.Right)
            {
                x_ = (hx - SizeArea / 2) + X * (SizeArea / size.Width);
                y_ = (hy - SizeArea / 2) + Y * (SizeArea / size.Height);
                SizeArea *= ScaleArea; // decrease zoom by ScaleArea value
                CenterX.Text = x_.ToString();
                CenterY.Text = y_.ToString();
                DrawMBrot();
                ZoomVal /= (double)ZOOMValue.Value;
                ZoomNUM.Clear();
                ZoomNUM.Text = ZoomVal.ToString("F2") + " X";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterX.Text = hx.ToString();
            CenterY.Text = hy.ToString();
        }


        public void DrawMBrot()
        {

            Bitmap picture = new Bitmap(image.Width, image.Height);
            size = image.Size;
            UserIt = (int)Iterations.Value;
            ZoomNUM.Width = ZoomNUM.Text.Length* 10 + 70;
            for (int x = 0; x < size.Width ; x++)
            {
                x_ = (hx - SizeArea / 2) + x * (SizeArea / size.Width);
                for (int y = 0; y < size.Height; y++)
                {
                    y_ = (hy - SizeArea / 2) + y * (SizeArea / size.Height);

                    Complex c = new Complex(x_, y_);
                    Complex z = new Complex(0, 0);


                    int it = 0;

                    do
                    {
                        it++;
                        z.Sqr();
                        z.Add(c);
                        if (z.Magn() > 4.0d)
                        {
                            break;
                        }
                    } while (it < UserIt);

                    if (it < (int)(UserIt * 0.09))
                    {
                        picture.SetPixel(x, y, Color.FromArgb(255, 187, 138));
                    }
                    else if (it < (int)(UserIt * 0.1))
                    {
                        picture.SetPixel(x, y, Color.FromArgb(209, 50, 103));
                    }
                    else if (it < (int)(UserIt * 0.11))
                    {
                        picture.SetPixel(x, y, Color.FromArgb(117, 239, 0));
                    }
                    else if (it < (int)(UserIt * 0.14))
                    {
                        picture.SetPixel(x, y, Color.FromArgb(166, 222, 230));
                    }
                    else if (it < (int)(UserIt * 0.16))
                    {
                        picture.SetPixel(x, y, Color.FromArgb(255, 182, 36));
                    }
                    else if (it < (int)(UserIt * 0.17))
                    {
                        picture.SetPixel(x, y, Color.FromArgb(117, 0, 132));
                    }
                    else if (it < (int)(UserIt * 0.18))
                    {
                        picture.SetPixel(x, y, Color.FromArgb(255, 141, 36));
                    }
                    else if (it < (int)(UserIt * 0.19))
                    {
                        picture.SetPixel(x, y, Color.FromArgb(117, 0, 132));
                    }
                    else if (it < (int)(UserIt * 0.2))
                    {
                        picture.SetPixel(x, y, Color.FromArgb(250, 179, 122));
                    }
                    else if (it < (int)(UserIt * 0.23))
                    {
                        picture.SetPixel(x, y, Color.FromArgb(1, 147, 154));
                    }
                    else if (it < (int)(UserIt * 0.26))
                    {
                        picture.SetPixel(x, y, Color.FromArgb(1, 149, 154));
                    }
                    else if (it < (int)(UserIt * 0.3))
                    {
                        picture.SetPixel(x, y, Color.FromArgb(125, 125, 125));
                    }
                    else if (it < (int)(UserIt * 0.4))
                    {
                        picture.SetPixel(x, y, Color.FromArgb(210, 53, 210));
                    }
                    else if (it < (int)(UserIt * 0.5))
                    {
                        picture.SetPixel(x, y, Color.FromArgb(23, 97, 125));
                    }
                    else if (it < (int)(UserIt * 0.6))
                    {
                        picture.SetPixel(x, y, Color.FromArgb(255, 204, 115));
                    }
                    else if (it < (int)(UserIt * 0.7))
                    {
                        picture.SetPixel(x, y, Color.FromArgb(225, 225, 225));
                    }
                    else if (it < (int)(UserIt * 0.8))
                    {
                        picture.SetPixel(x, y, Color.FromArgb(86, 225, 225));
                    }
                    else if (it < (int)(UserIt * 0.90))
                    {
                        picture.SetPixel(x, y, Color.FromArgb(237, 65, 56));
                    }
                    else if (it < (int)(UserIt * 0.93))
                    {
                        picture.SetPixel(x, y, Color.FromArgb(224, 53, 80));
                    }
                    else if (it < (int)(UserIt * 0.96))
                    {
                        picture.SetPixel(x, y, Color.FromArgb(0, 34, 225));
                    }
                    else if (it < (int)(UserIt * 0.99))
                    {
                        picture.SetPixel(x, y, Color.FromArgb(48, 50, 133));
                    }
                    else if (it < (int)(UserIt))
                    {
                        picture.SetPixel(x, y, Color.FromArgb(117, 239, 0));
                    }
                    else
                    {
                        picture.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                }
                image.Image = picture;
            }

        }
        public Form1()
        {
            InitializeComponent();

            Bitmap bmp = new Bitmap(image.Width, image.Height);
            image.Image = bmp;
            size = image.Size;
            StartSize = image.Size;
            SizeArea = 3;
            ScaleArea = 3;
        }

       

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        private void image_Click(object sender, EventArgs e)
        {

        }


    }

    public class Complex {
        public double a;
        public double b;

        public Complex(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public void Sqr()
        {
            double tmp = (a * a) - (b * b );
            b = 2.0d * a * b;
            a = tmp;
        }

        public double Magn()
        {
            return Math.Sqrt((a * a) + (b * b));
        }

        public void Add(Complex c)
        {
            a += c.a;
            b += c.b;
        }
        
    }

}
