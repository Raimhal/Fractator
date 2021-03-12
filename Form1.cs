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
/// /// </summary>
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public double wx = -150, wy = 0;
        public double speed = 2f, zoom = 2.4f, zoomSpeed = 0.1d;
        public int res = 1;
        public double screenSize = 16 / 9.0;
        int UserIt = 100;


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                wy -= speed * (5 - Math.Abs(zoom));
                DrawMBrot();
            }
            if (e.KeyCode == Keys.S)
            {
                wy += speed * (5 - Math.Abs(zoom));
                DrawMBrot();
            }

            if (e.KeyCode == Keys.A)
            {
                wx -= speed * (5 - Math.Abs(zoom));
                DrawMBrot();
            }
            if (e.KeyCode == Keys.D)
            {
                wx += speed * (5 - Math.Abs(zoom));
                DrawMBrot();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public void DrawMBrot()
        {
            if (res <= 0)
            {
                res = 1;
            }

            Bitmap picture = new Bitmap(Width / res, Height / res);
            for (int x = 0; x < Width/res; x++)
            {
                for (int y = 0; y < Height/res; y++)
                {
                    double a = (double)((x + (wx / res / Math.Abs(zoom))) - ((Width / 2d) / res)) / (double)(Width / Math.Abs(zoom) / res / screenSize);
                    double b = (double)((y + (wy / res / Math.Abs(zoom))) - ((Height / 2d) / res)) / (double)(Height / Math.Abs(zoom) / res);

                    Complex c = new Complex(a , b);
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
                    if (it < (int)(UserIt * 0.05))
                    {
                        picture.SetPixel(x, y, Color.FromArgb(147, 230, 212));
                    }
                    if (it < (int)(UserIt * 0.07))
                    {
                        picture.SetPixel(x, y, Color.FromArgb(255, 191, 151));
                    }
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
                image.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }
        public Form1()
        {
            InitializeComponent();
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            zoom -= zoomSpeed / zoom;
            wx -= speed * (5 - Math.Abs(zoom));
            DrawMBrot();
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
