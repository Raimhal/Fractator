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
/// 1) додати ще декілька фракталівя
/// 2) додати лічильнику приближення невидимий фон
/// 3) оформити користувацький інтерфейс
/// 4) додати іконки на кнопки зуму
/// 5) додати папоротник
/// 6) додати криву дракона
/// 
/// 
/// /// </summary>
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Graphics g;
        public Color BackgroundColor = Color.Transparent;
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
            g = Graphics.FromImage(image.Image);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }

        private void GenerateFractal_Click(object sender, EventArgs e)
        {
            if (FractalsList.SelectedIndex == 0)
            {
                ZoomNUM.Text = ZoomVal.ToString("F0") + " X";
                ZoomNUM.Visible = true;
                image.Enabled = true;
                DecreaseZOOM.Enabled = true;
                IncreaseZOOM.Enabled = true;
            }

            er_x = double.TryParse(CenterX.Text, out hx);
            er_y = double.TryParse(CenterY.Text, out hy);
            er_z = double.TryParse(MaxZDegreeTwo.Text, out maxZ);
            Bitmap bitmap = (Bitmap)Grad.Image;
            pixels = GetPixels(bitmap);





            if (er_x == false)
            {
                MessageBox.Show("Error entering value x!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (er_y == false)
            {
                MessageBox.Show("Error entering value y!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (er_z == false)
            {
                MessageBox.Show("Error entering value max |z| ^ 2!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (er_z == false)
            {
                MessageBox.Show("Error entering value max |z| ^ 2!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DrawFractals();
            }

        }
        private void DecreaseZOOM_Click(object sender, EventArgs e)
        {
            SizeArea *= (double)ZOOMValue.Value;
            CenterX.Text = hx.ToString();
            CenterY.Text = hy.ToString();
            ZoomVal /= (double)ZOOMValue.Value;
            ZoomNUM.Visible = true;
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
            ZoomNUM.Visible = true;
            ZoomNUM.Clear();
            ZoomNUM.Text = ZoomVal.ToString("F2") + " X";
            DrawMBrot();
        }

        void image_MouseClick(object sender, MouseEventArgs e)
        {
            int X = e.X, Y = e.Y;
            if (FractalsList.SelectedItem == FractalsList.Items[0])
            {
                ZoomNUM.Visible = true;
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
        }



        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                Grad.Image = new Bitmap(OpenFile.FileName);
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
                        image.Image.Save(SaveAs.FileName);
                    }
                    catch
                    {
                        MessageBox.Show("Image can't be saved!!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }

        }

        private void FractalsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (FractalsList.SelectedIndex == 0)
            {
                labelZOOM.Visible = true;
                ZOOMValue.Visible = true;

                DecreaseZOOM.Visible = true;
                IncreaseZOOM.Visible = true;

                x.Visible = true;
                y.Visible = true;

                CenterX.Visible = true;
                CenterY.Visible = true;

                LabelMaxZDegreeTwo.Visible = true;
                MaxZDegreeTwo.Visible = true;

                LabelBranchLength.Visible = false;
                BranchLenght.Visible = false;

                labelMinimalLength.Visible = false;
                MinBranchLenght.Visible = false;

                labelIterations.Visible = true;
                Iterations.Visible = true;

                labelStartX.Visible = false;
                labelStartY.Visible = false;

                StartX.Visible = false;
                StartY.Visible = false;

                labelBranchWidth.Visible = false;
                BranchWidth.Visible = false;

                labelAngles.Visible = false;
                NumberOfAngles.Visible = false;

                FirstAngle.Visible = false;
                SecondAngle.Visible = false;
                ThirdAngle.Visible = false;
                FourthAngle.Visible = false;

                labelBackColor.Visible = false;
                ColorButton.Visible = false;

                Progress.Visible = true;
            }
            else if (FractalsList.SelectedIndex == 1)
            {
                labelZOOM.Visible = false;
                ZOOMValue.Visible = false;

                DecreaseZOOM.Visible = false;
                IncreaseZOOM.Visible = false;

                ZoomNUM.Visible = false;

                x.Visible = false;
                y.Visible = false;

                CenterX.Visible = false;
                CenterY.Visible = false;

                LabelMaxZDegreeTwo.Visible = false;
                MaxZDegreeTwo.Visible = false;

                LabelBranchLength.Visible = true;
                LabelBranchLength.Location = labelZOOM.Location;

                BranchLenght.Visible = true;
                BranchLenght.Location = ZOOMValue.Location;

                labelMinimalLength.Visible = true;
                MinBranchLenght.Visible = true;

                labelIterations.Visible = false;
                Iterations.Visible = false;

                labelStartX.Visible = true;
                labelStartX.Location = y.Location;

                labelStartY.Visible = true;
                labelStartY.Location = LabelMaxZDegreeTwo.Location;

                labelBranchWidth.Visible = true;
                labelBranchWidth.Location = labelIterations.Location;

                StartX.Visible = true;
                StartX.Location = CenterY.Location;

                StartY.Visible = true;
                StartY.Location = MaxZDegreeTwo.Location;

                BranchWidth.Visible = true;
                BranchWidth.Location = Iterations.Location;

                labelAngles.Visible = true;
                NumberOfAngles.Visible = true;

                FirstAngle.Visible = true;
                SecondAngle.Visible = true;
                ThirdAngle.Visible = true;
                FourthAngle.Visible = false;

                NumberOfAngles.SelectedIndex = 2;

                labelBackColor.Visible = true;
                labelBackColor.Location = x.Location;

                ColorButton.Visible = true;
                ColorButton.Location = CenterX.Location;

                BackgroundColor = Color.Transparent;
                ColorButton.BackColor = Color.Transparent;

                Progress.Visible = false;



            }
            else if (FractalsList.SelectedIndex == 2)
            {
                labelZOOM.Visible = false;
                ZOOMValue.Visible = false;
                DecreaseZOOM.Visible = false;
                IncreaseZOOM.Visible = false;
                ZoomNUM.Visible = false;
                x.Visible = false;
                y.Visible = false;
                CenterX.Visible = false;
                CenterY.Visible = false;
                LabelMaxZDegreeTwo.Visible = false;
                MaxZDegreeTwo.Visible = false;

            }
            else
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            // відображення координат центра та max |z| ^ 2 по замовчуванню
            CenterX.Text = hx.ToString();
            CenterY.Text = hy.ToString();
            MaxZDegreeTwo.Text = maxZ.ToString();
            FractalsList.SelectedItem = FractalsList.Items[0];
            NumberOfAngles.SelectedItem = NumberOfAngles.Items[2];

            image.Enabled = false;
            DecreaseZOOM.Enabled = false;
            IncreaseZOOM.Enabled = false;

            FirstAngle.Visible = false;
            SecondAngle.Visible = false;
            ThirdAngle.Visible = false;
            FourthAngle.Visible = false;
        }

        public async void DrawFractalTree()
        {
            CreateFractal.Enabled = false;
            start = DateTime.Now;
            Bitmap pictureTree = new Bitmap(image.Width, image.Height);
            int branchLenght = (int)BranchLenght.Value;
            double[] angles;
            if (NumberOfAngles.SelectedIndex == 0)
            {
                angles = new double[] { (double)FirstAngle.Value };
            }
            else if (NumberOfAngles.SelectedIndex == 1)
            {
                angles = new double[] { (double)FirstAngle.Value, (double)SecondAngle.Value };
            }
            else if (NumberOfAngles.SelectedIndex == 2)
            {
                angles = new double[] { (double)FirstAngle.Value, (double)SecondAngle.Value, (double)ThirdAngle.Value };
            }
            else
            {
                angles = new double[] { (double)FirstAngle.Value, (double)SecondAngle.Value, (double)ThirdAngle.Value, (double)FourthAngle.Value };
            }

            FractalTree tree = new FractalTree(g, pictureTree, pixels, angles, (int)(MinBranchLenght.Value), (int)(BranchWidth.Value), BackgroundColor);
            await Task.Run(() => { tree.DrawFractalTree((int)(StartX.Value), (int)(StartY.Value), branchLenght, 0); });

            end = DateTime.Now;
            CulculationTime.Text = (end - start).TotalMilliseconds.ToString("F2") + " ms";
            image.Image = pictureTree;
            CreateFractal.Enabled = true;

        }

        public void DrawBarnsleyFern()
        {
            start = DateTime.Now;
            float[] probability = new float[4] { 0.01f, 0.06f, 0.08f, 0.85f };
            int NumbersOfPoint = 100000;
            float[,] Coefficient = new float[4, 6]
            {
            {0, 0, 0, 0.16f, 0, 0},
            {-0.15f, 0.28f, 0.26f, 0.24f, 0, 0.44f},
            {0.2f, -0.26f, 0.23f, 0.22f, 0, 1.6f},
            {0.85f, 0.04f, -0.04f, 0.85f, 0, 1.6f}

            };
            Bitmap pictureFern = new Bitmap(image.Width, image.Height);
            Graphics gF;
            gF = Graphics.FromImage(pictureFern);
            gF.Clear(Color.LawnGreen);
            Barnsley_fern Fern = new Barnsley_fern(g, pictureFern, NumbersOfPoint, probability, Coefficient, pixels);
            pictureFern = Fern.DrawBransleyFern();
            end = DateTime.Now;
            CulculationTime.Text = (end - start).TotalMilliseconds.ToString("F2") + " ms";
            image.Image = pictureFern;
        }
            
        
            

        private void NumberOfAngles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NumberOfAngles.SelectedIndex == 0)
            {
                FirstAngle.Visible = true;
                SecondAngle.Visible = false;
                ThirdAngle.Visible = false;
                FourthAngle.Visible = false;
            }
            else if (NumberOfAngles.SelectedIndex == 1)
            {
                FirstAngle.Visible = true;
                SecondAngle.Visible = true;
                ThirdAngle.Visible = false;
                FourthAngle.Visible = false;
            }
            else if (NumberOfAngles.SelectedIndex == 2)
            {
                FirstAngle.Visible = true;
                SecondAngle.Visible = true;
                ThirdAngle.Visible = true;
                FourthAngle.Visible = false;
            }
            else
            {
                FirstAngle.Visible = true;
                SecondAngle.Visible = true;
                ThirdAngle.Visible = true;
                FourthAngle.Visible = true;
            }
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog BackColor = new ColorDialog();
            BackColor.AllowFullOpen = true;
            BackColor.FullOpen = true;
            BackColor.ShowHelp = true;
            BackColor.Color = Color.FromArgb(117, 238, 138);
            BackColor.AnyColor = true;
            BackColor.CustomColors = new int[]
            {
                636125, 382980, 5863935, 5427317, 1566114
            };
            if(BackColor.ShowDialog() == DialogResult.OK)
            {
                BackgroundColor = BackColor.Color;
                ColorButton.BackColor = BackColor.Color;
            }
        }

        private void SplitImageAndInterface_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RandomGradientButton_Click(object sender, EventArgs e)
        {
            Gradient(Grad);
        }
        // drawing a MBrot set
        public void DrawFractals()
        {
            if (FractalsList.SelectedIndex == 0)
            {
                DrawMBrot();
            }
            else if(FractalsList.SelectedIndex == 1)
            {
                DrawFractalTree();
            }
            else if(FractalsList.SelectedIndex == 2)
            {
                DrawBarnsleyFern();
            }
            else
            {

            }
        }
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


            this.Invoke(new Action(() => // делегат для відображення progressBar
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
                            if (it <= UserIt * (color / 100.0))
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
                this.Invoke(new Action(() => // делегат для зміни progressBar
                {
                    Progress.PerformStep();
                }));
                
            }
            image.Image = null;
            image.Invalidate();
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
                    Color = bitmap.GetPixel(x, 10) // отримання кольору ряду пікселів з градієнту
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
            if (changer % 6 == 0)
            {
                
                for (int x = 0; x < Gradient.Width; x++)
                {

                    for (int y = 0; y < Gradient.Height; y++)
                    {
                        Gradient.SetPixel(x, y, Color.FromArgb(((r + x) / 3) % 255, ((255 - g + x) / 3) % 255, ((b) / 3) % 255));
                    }
                }
            }
            else if (changer % 6 == 1)
            {
                for (int x = 0; x < Gradient.Width; x++)
                {

                    for (int y = 0; y < Gradient.Height; y++)
                    {
                        Gradient.SetPixel(x, y, Color.FromArgb(((r + x) / 3) % 255, ((g) / 3) % 255, ((255 - b + x) / 3) % 255));
                    }
                }
            }
            else if (changer % 6 == 2)
            {
                for (int x = 0; x < Gradient.Width; x++)
                {

                    for (int y = 0; y < Gradient.Height; y++)
                    {
                        Gradient.SetPixel(x, y, Color.FromArgb(((r) / 3) % 255, ((g + x) / 3) % 255, ((255 - b + x) / 3) % 255));
                    }
                }
            }
            else if (changer % 6 == 3)
            {
                for (int x = 0; x < Gradient.Width; x++)
                {

                    for (int y = 0; y < Gradient.Height; y++)
                    {
                        Gradient.SetPixel(x, y, Color.FromArgb(((255 - r + x) / 3) % 255, ((g + x) / 3) % 255, ((b) / 3) % 255));
                    }
                }
            }
            else if (changer % 6 == 4)
            {
                for (int x = 0; x < Gradient.Width; x++)
                {

                    for (int y = 0; y < Gradient.Height; y++)
                    {
                        Gradient.SetPixel(x, y, Color.FromArgb(((r) / 3) % 255, ((255 - g + x) / 3) % 255, ((b + x) / 3) % 255));
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
