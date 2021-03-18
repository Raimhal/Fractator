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
using System.Globalization;
using System.Diagnostics;
/// <summary>
/// 1) додати діалогові вікна
/// 2) додати ще декілька фракталів
/// 4) додати автозаповнення при розтязі зображення
/// 5) додати лічильнику приближення невидимий фон
/// 6) додати роздільник крапка
/// 7) реалізувати иожливість збереження фракталу
/// 8) реалізувати мождивість рандомногоо генерування градієнту
/// 9) оформити користувацький інтерфейс
/// 10) додати іконки на кнопки зуму
/// 11)
/// 
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

        DateTime start, end;


        public Form1()
        {
            InitializeComponent();

            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;


            Bitmap bmp = new Bitmap(image.Width, image.Height);
            image.Image = bmp;
            size = image.Size;
            StartSize = image.Size;
            SizeArea = 4;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            Progress.ForeColor = Color.FromArgb(0, 0, 255);
            //ZoomNUM.BackColor = Color.Transparent;
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



        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(OpenFile.ShowDialog() == DialogResult.OK)
            {
                image.Image = new Bitmap(OpenFile.FileName);
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image.Image != null)
            {
                SaveFileDialog SaveAs = new SaveFileDialog();
                SaveAs.Title = "Save as";
                SaveAs.OverwritePrompt = true;
                SaveAs.Filter = "(*.bmp)| *.bmp|(*.png)|*.png|(*.jpg)|*.jpg|All files(*.*)|*.*";
                SaveAs.ShowHelp = true;
                if (SaveAs.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        image.Image.Save(SaveAs.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                    }
                    catch
                    {
                        MessageBox.Show("Image can't be saved!!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // відображення координат центра та max |z| ^ 2 по замовчуванню
            CenterX.Text = hx.ToString();
            CenterY.Text = hy.ToString();
            MaxZDegreeTwo.Text = maxZ.ToString(); 
            //Gradient();
        }

        private void SplitImageAndInterface_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RandomGradientButton_Click(object sender, EventArgs e)
        {
            Gradient(Grad);
        }
        // drawing a MBrot set
        public async void DrawMBrot()
        {
            image.Enabled = false;          /// 
            IncreaseZOOM.Enabled = false;   ///
            DecreaseZOOM.Enabled = false;   /// disabled access to change the image
            CreateFractal.Enabled = false;  ///

            start = DateTime.Now;
            ZoomNUM.Width = ZoomNUM.Text.Length * 8 + 50; 
            await Task.Run(() => { CalculationMBrot(); });
            end = DateTime.Now;
            CulculationTime.Text = (end - start).TotalMilliseconds.ToString("F2") + " ms";
            image.Enabled = true;
            IncreaseZOOM.Enabled = true;
            DecreaseZOOM.Enabled = true;    /// added access to change the image
            CreateFractal.Enabled = true;
        }

        public void CalculationMBrot()
        {
            Bitmap picture = new Bitmap(image.Image.Width, image.Image.Height);
            UserIt = (int)Iterations.Value;


            this.Invoke(new Action(() =>
            {
                Progress.Value = 0;
                Progress.Minimum = 0;
                Progress.Maximum = size.Width;
            }));

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

                    // coloring the set
                    for (int color = 0; color <= Grad.Width; color += 1)
                    {
                        if (it < UserIt)
                        {
                            if (it <= UserIt * (color / 50.0))
                            {
                                picture.SetPixel(x, y, pixels[(color * 27) % Grad.Width].Color); // 27 частота градієнта
                                break;
                            }
                        }
                        else
                        {
                            picture.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                            break;
                        }
                    }
                }
                this.Invoke(new Action(() =>
                {
                    Progress.PerformStep();
                }));
                
            }
            image.Image = picture;
        }
        // getting gradient pixels 
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
        // creation of  gradient
        public void Gradient(PictureBox pictureBox)
        {
            Random color = new Random();

            int r = color.Next(256);
            int g = color.Next(256);
            int b = color.Next(256);
            int changer = color.Next(256);
            Bitmap Gradient = new Bitmap(pictureBox.Width, pictureBox.Height);
            if (changer % 3 == 0)
            {
                
                for (int x = 0; x < Gradient.Width; x++)
                {

                    for (int y = 0; y < Gradient.Height; y++)
                    {
                        Gradient.SetPixel(x, y, Color.FromArgb(((r + x) / 3) % 255, ((255 - g + x) / 3) % 255, ((b) / 3) % 255));
                    }
                }
            }
            else if (changer % 3 == 1)
            {
                for (int x = 0; x < Gradient.Width; x++)
                {

                    for (int y = 0; y < Gradient.Height; y++)
                    {
                        Gradient.SetPixel(x, y, Color.FromArgb(((r) / 3) % 255, ((g + x) / 3) % 255, ((255 - b + x) / 3) % 255));
                    }
                }
            }
            else
            {
                for (int x = 0; x < Gradient.Width; x++)
                {

                    for (int y = 0; y < Gradient.Height; y++)
                    {
                        Gradient.SetPixel(x, y, Color.FromArgb(((255 - r + x) / 3) % 255, ((g) / 3) % 255, ((b + x) / 3) % 255));
                    }
                }
            }

            pictureBox.Image = Gradient;
        }
        


    }
}
