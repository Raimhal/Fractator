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
        List<Pixel> pixels;

        double hx = -0.6, hy = 0, maxZ = 4, x_, y_;
        bool er_x, er_y, er_z;
        Size StartSize;
        double ZoomVal = 1;

        Size size;
        double SizeArea;



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void GenerateFractal_Click(object sender, EventArgs e)
        {
            ZoomNUM.Text = ZoomVal.ToString("F0") + " X";
            er_x = double.TryParse(CenterX.Text, out hx);
            er_y = double.TryParse(CenterY.Text, out hy);
            er_z = double.TryParse(MaxZDegreeTwo.Text, out maxZ);
            Bitmap bitmap = (Bitmap)Grad.Image;
            pixels = GetPixels(bitmap);
            ZoomNUM.Visible = true;
            if (er_x == false)
            {
                MessageBox.Show("Помилка введення значення x!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (er_y == false)
            {
                MessageBox.Show("Помилка введення значення y!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (er_z == false)
            {
                MessageBox.Show("Помилка введення значення max |z| ^ 2!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DrawMBrot();
            }

        }
        private void DecreaseZOOM_Click(object sender, EventArgs e)
        {
            SizeArea *= (double)ZOOMValue.Value;
            CenterX.Text = hx.ToString();
            CenterY.Text = hy.ToString();
            ZoomVal /= (double)ZOOMValue.Value;
            ZoomNUM.Clear();
            ZoomNUM.Text = ZoomVal.ToString("F2") + " X";
            DrawMBrot();
        }
        private void IncreaseZOOM_Click(object sender, EventArgs e)
        {
            SizeArea /= (double)ZOOMValue.Value;
            CenterX.Text = hx.ToString();
            CenterY.Text = hy.ToString();
            ZoomVal *= (double)ZOOMValue.Value;
            ZoomNUM.Clear();
            ZoomNUM.Text = ZoomVal.ToString("F2") + " X";
            DrawMBrot();
        }

        void image_MouseClick(object sender, MouseEventArgs e)
        {
            int X = e.X, Y = e.Y;
            if (e.Button == MouseButtons.Left)
            {
                hx = (hx - SizeArea / 2) + X * (SizeArea / size.Width);
                hy = (hy - SizeArea / 2) + Y * (SizeArea / size.Height);
                SizeArea /= (double)ZOOMValue.Value; // increase zoom by ZOOMValue value
                CenterX.Text = hx.ToString();
                CenterY.Text = hy.ToString();
                ZoomVal *= (double)ZOOMValue.Value;
                ZoomNUM.Clear();
                ZoomNUM.Text = ZoomVal.ToString("F2") + " X";
                DrawMBrot();


            }
            else if (e.Button == MouseButtons.Middle)
            {                // back to default
                SizeArea = 3;
                hx = -0.6;
                hy = 0;
                CenterX.Text = hx.ToString();
                CenterY.Text = hy.ToString();
                ZoomVal = 1;
                ZoomNUM.Clear();
                ZoomNUM.Width = 80;
                ZoomNUM.Text = ZoomVal.ToString("F0") + " X";
                DrawMBrot();

            }
            else if (e.Button == MouseButtons.Right)
            {
                x_ = (hx - SizeArea / 2) + X * (SizeArea / size.Width);
                y_ = (hy - SizeArea / 2) + Y * (SizeArea / size.Height);
                SizeArea *= (double)ZOOMValue.Value; // decrease zoom by ZOOMValue value
                CenterX.Text = x_.ToString();
                CenterY.Text = y_.ToString();
                ZoomVal /= (double)ZOOMValue.Value;
                ZoomNUM.Clear();
                ZoomNUM.Text = ZoomVal.ToString("F2") + " X";
                DrawMBrot();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            //DrawMBrot();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterX.Text = hx.ToString();
            CenterY.Text = hy.ToString();
            MaxZDegreeTwo.Text = maxZ.ToString();
            ZoomNUM.Visible = false;
            //Gradient();
        }

        public void DrawMBrot()
        {


            Bitmap picture = new Bitmap(image.Width, image.Height);
            size = image.Size;
            UserIt = (int)Iterations.Value;
            ZoomNUM.Width = ZoomNUM.Text.Length * 10 + 70;
            for (int x = 0; x < size.Width; x++)
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
                        if (z.Magn() > maxZ)
                        {
                            break;
                        }
                    } while (it < UserIt);
                    //Gradient Gradient = new Gradient(x, y, it, picture);
                    //picture.SetPixel() = Gradient.PixelColor();
                    for (int color = 0; color <= Grad.Width; color += 1)
                    {
                        if(it < UserIt)
                        {
                            if(it < UserIt * (color / 100.0)) {
                                picture.SetPixel(x, y, pixels[(color * 30) % Grad.Width].Color/*Color.FromArgb((int)(((color * 20) + 36)% 255), (int)(((color * 20) + 9) % 255), (int)((((color) * 20) +25) % 255))*/);
                                break;
                            }
                        }
                        else
                        {
                            picture.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                            break;
                        }
                    }
                    //if (it < UserIt * 0.05)
                    //{
                    //    picture.SetPixel(x, y, Color.FromArgb(253, 127, 153));
                    //}
                    //else if (it < (int)(UserIt * 0.1))
                    //{
                    //    picture.SetPixel(x, y, Color.FromArgb(209, 50, 103));
                    //}
                    //else if (it < (int)(UserIt * 0.11))
                    //{
                    //    picture.SetPixel(x, y, Color.FromArgb(117, 239, 0));
                    //}
                    //else if (it < (int)(UserIt * 0.14))
                    //{
                    //    picture.SetPixel(x, y, Color.FromArgb(166, 222, 230));
                    //}
                    //else if (it < (int)(UserIt * 0.16))
                    //{
                    //    picture.SetPixel(x, y, Color.FromArgb(255, 182, 36));
                    //}
                    //else if (it < (int)(UserIt * 0.17))
                    //{
                    //    picture.SetPixel(x, y, Color.FromArgb(117, 0, 132));
                    //}
                    //else if (it < (int)(UserIt * 0.18))
                    //{
                    //    picture.SetPixel(x, y, Color.FromArgb(255, 141, 36));
                    //}
                    //else if (it < (int)(UserIt * 0.19))
                    //{
                    //    picture.SetPixel(x, y, Color.FromArgb(117, 0, 132));
                    //}
                    //else if (it < (int)(UserIt * 0.2))
                    //{
                    //    picture.SetPixel(x, y, Color.FromArgb(250, 179, 122));
                    //}
                    //else if (it < (int)(UserIt * 0.23))
                    //{
                    //    picture.SetPixel(x, y, Color.FromArgb(1, 147, 154));
                    //}
                    //else if (it < (int)(UserIt * 0.26))
                    //{
                    //    picture.SetPixel(x, y, Color.FromArgb(1, 149, 154));
                    //}
                    ////else if (it < (int)(UserIt * 0.3))
                    ////{
                    ////    picture.SetPixel(x, y, Color.FromArgb(125, 125, 125));
                    ////}
                    ////else if (it < (int)(UserIt * 0.4))
                    ////{
                    ////    picture.SetPixel(x, y, Color.FromArgb(210, 53, 210));
                    ////}
                    ////else if (it < (int)(UserIt * 0.5))
                    ////{
                    ////    picture.SetPixel(x, y, Color.FromArgb(23, 97, 125));
                    ////}
                    ////else if (it < (int)(UserIt * 0.6))
                    ////{
                    ////    picture.SetPixel(x, y, Color.FromArgb(255, 204, 115));
                    ////}
                    ////else if (it < (int)(UserIt * 0.7))
                    ////{
                    ////    picture.SetPixel(x, y, Color.FromArgb(225, 225, 225));
                    ////}
                    ////else if (it < (int)(UserIt * 0.8))
                    ////{
                    ////    picture.SetPixel(x, y, Color.FromArgb(86, 225, 225));
                    ////}
                    ////else if (it < (int)(UserIt * 0.90))
                    ////{
                    ////    picture.SetPixel(x, y, Color.FromArgb(237, 65, 56));
                    ////}
                    ////else if (it < (int)(UserIt * 0.93))
                    ////{
                    ////    picture.SetPixel(x, y, Color.FromArgb(224, 53, 80));
                    ////}
                    ////else if (it < (int)(UserIt * 0.96))
                    ////{
                    ////    picture.SetPixel(x, y, Color.FromArgb(0, 34, 225));
                    ////}
                    ////else if (it < (int)(UserIt * 0.99))
                    ////{
                    ////    picture.SetPixel(x, y, Color.FromArgb(48, 50, 133));
                    ////}
                    ////else if (it < (int)(UserIt))
                    ////{
                    ////    picture.SetPixel(x, y, Color.FromArgb(117, 239, 0));
                    ////}
                    //else
                    //{
                    //    picture.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    //}

                }
                image.Image = picture;
            }

        }

        private List<Pixel> GetPixels(Bitmap bitmap)
        {
            List<Pixel> pixels = new List<Pixel>(bitmap.Width);
            for (int x = 0; x < bitmap.Width; x++)
            {
                pixels.Add(new Pixel()
                {
                    Color = bitmap.GetPixel(x, 1)
                });
            }
            return pixels;
        }
        public void Gradient()
        {
            Bitmap Gradient = new Bitmap(Grad.Width, Grad.Height);
            for (int x = 0; x < Grad.Width; x++)
            {
                for (int y = 0; y < Grad.Height; y++)
                {
                    if (x < 256)
                    {
                        Gradient.SetPixel(x, y, Color.FromArgb(y % 255, x % 255, y % 255));
                    }
                    else if (x < 512)
                    {
                        Gradient.SetPixel(x, y, Color.FromArgb(255 - y % 255, 255 - x % 255, 255 - y % 255));
                    }
                }
            }
            Grad.Image = Gradient;
        }
        public Form1()
        {
            InitializeComponent();

            Bitmap bmp = new Bitmap(image.Width, image.Height);
            image.Image = bmp;
            size = image.Size;
            StartSize = image.Size;
            SizeArea = 4;
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            ZoomNUM.BackColor = BackColor;
            ZoomNUM.BorderStyle = BorderStyle.None;
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

    public class Gradient
    {
        public int x;
        public int y;
        public int it;
        public Bitmap picture;

        public Gradient(int x,int y, int it, Bitmap picture)
        {
            this.x = x;
            this.y = y;
            this.it = it;
            this.picture = picture;
        }
        public void PixelColor()
        {
            for (int t = 0; t < it; t += 5) {
                if (t < it)
                {
                   picture.SetPixel(x, y, Color.FromArgb((int)(t), (int)(t), (int)(t)));
                    break;
                }
            }
            //if (it < (int)(UserIt * 0.1))
            //{
            //    picture.SetPixel(x, y, Color.FromArgb(209, 50, 103));
            //}
            //else if (it < (int)(UserIt * 0.11))
            //{
            //    picture.SetPixel(x, y, Color.FromArgb(117, 239, 0));
            //}
            //else if (it < (int)(UserIt * 0.14))
            //{
            //    picture.SetPixel(x, y, Color.FromArgb(166, 222, 230));
            //}
            //else if (it < (int)(UserIt * 0.16))
            //{
            //    picture.SetPixel(x, y, Color.FromArgb(255, 182, 36));
            //}
            //else if (it < (int)(UserIt * 0.17))
            //{
            //    picture.SetPixel(x, y, Color.FromArgb(117, 0, 132));
            //}
            //else if (it < (int)(UserIt * 0.18))
            //{
            //    picture.SetPixel(x, y, Color.FromArgb(255, 141, 36));
            //}
            //else if (it < (int)(UserIt * 0.19))
            //{
            //    picture.SetPixel(x, y, Color.FromArgb(117, 0, 132));
            //}
            //else if (it < (int)(UserIt * 0.2))
            //{
            //    picture.SetPixel(x, y, Color.FromArgb(250, 179, 122));
            //}
            //else if (it < (int)(UserIt * 0.23))
            //{
            //    picture.SetPixel(x, y, Color.FromArgb(1, 147, 154));
            //}
            //else if (it < (int)(UserIt * 0.26))
            //{
            //    picture.SetPixel(x, y, Color.FromArgb(1, 149, 154));
            //}
            //else if (it < (int)(UserIt * 0.3))
            //{
            //    picture.SetPixel(x, y, Color.FromArgb(125, 125, 125));
            //}
            //else if (it < (int)(UserIt * 0.4))
            //{
            //    picture.SetPixel(x, y, Color.FromArgb(210, 53, 210));
            //}
            //else if (it < (int)(UserIt * 0.5))
            //{
            //    picture.SetPixel(x, y, Color.FromArgb(23, 97, 125));
            //}
            //else if (it < (int)(UserIt * 0.6))
            //{
            //    picture.SetPixel(x, y, Color.FromArgb(255, 204, 115));
            //}
            //else if (it < (int)(UserIt * 0.7))
            //{
            //    picture.SetPixel(x, y, Color.FromArgb(225, 225, 225));
            //}
            //else if (it < (int)(UserIt * 0.8))
            //{
            //    picture.SetPixel(x, y, Color.FromArgb(86, 225, 225));
            //}
            //else if (it < (int)(UserIt * 0.90))
            //{
            //    picture.SetPixel(x, y, Color.FromArgb(237, 65, 56));
            //}
            //else if (it < (int)(UserIt * 0.93))
            //{
            //    picture.SetPixel(x, y, Color.FromArgb(224, 53, 80));
            //}
            //else if (it < (int)(UserIt * 0.96))
            //{
            //    picture.SetPixel(x, y, Color.FromArgb(0, 34, 225));
            //}
            //else if (it < (int)(UserIt * 0.99))
            //{
            //    picture.SetPixel(x, y, Color.FromArgb(48, 50, 133));
            //}
            //else if (it < (int)(UserIt))
            //{
            //    picture.SetPixel(x, y, Color.FromArgb(117, 239, 0));
            //}
            //else
            //{
            //    picture.SetPixel(x, y, Color.FromArgb(0, 0, 0));
            //}
        }
    }
}
