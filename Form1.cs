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
using System.Threading;


namespace FractalsCreator
{
    public partial class FractalForm : Form
    {

        ///
        ///
        ///     Start values
        ///
        ///

        public Graphics g;
        public Color BackgroundColor = Color.Transparent;
        public List<Pixel> tmpPixels;
        List<Pixel> pixels ;
        public GradientForm gradientForm;

        // start value for MBrot
        double hx, hy, maxZ, x_, y_;
        bool er_x, er_y, er_z;
        double ZoomVal = 1;

        Size size;
        double SizeArea;

        DateTime start, end;

        public int selectFractal = 0;


        ///
        ///
        ///     Main form properties
        ///
        ///

        public FractalForm()
        {
            InitializeComponent();

            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)
                System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            image.Image = new Bitmap(image.Width, image.Height);
            size = image.Size;
            g = Graphics.FromImage(image.Image);
            this.DoubleBuffered = true;
            gradientForm = new GradientForm();

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            FractalsList.SelectedIndex = 0;
            FractalsInfo.Text = InfoMBrot();
            ShowImageHeight.Value = image.Height;
            ShowImageWidth.Value = image.Width;
        }
        private void FractalForm_Resize(object sender, EventArgs e)
        {
            ShowImageHeight.Value = image.Height;
            ShowImageWidth.Value = image.Width;
            
            if (FractalsList.SelectedIndex == 1)
            {
                StartX.Value = image.Width / 2;
                StartY.Value = image.Height / 5;
            }
            else if (FractalsList.SelectedIndex == 3)
            {
                double CoefOfLen = 3.5;
                FirstStartPointX.Value = image.Width / 2;
                FirstStartPointY.Value = image.Height / 2;
                FirstEndPointX.Value = image.Width / 2 + (int)(image.Width / CoefOfLen);
                FirstEndPointY.Value = image.Height / 2;

                SecondStartPointX.Value = image.Width / 2;
                SecondStartPointY.Value = image.Height / 2;
                SecondEndPointX.Value = image.Width / 2;
                SecondEndPointY.Value = image.Height / 2 + (int)(image.Width / CoefOfLen);

                ThirdStartPointX.Value = image.Width / 2;
                ThirdStartPointY.Value = image.Height / 2;
                ThirdEndPointX.Value = image.Width / 2;
                ThirdEndPointY.Value = image.Height / 2 - (int)(image.Width / CoefOfLen);

                FourthStartPointX.Value = image.Width / 2;
                FourthStartPointY.Value = image.Height / 2;
                FourthEndPointX.Value = image.Width / 2 - (int)(image.Width / CoefOfLen);
                FourthEndPointY.Value = image.Height / 2;

                FifthStartPointX.Value = image.Width / 2;
                FifthStartPointY.Value = image.Height / 2;
                FifthEndPointX.Value = image.Width / 2 - (int)(image.Width / CoefOfLen * 1.5);
                FifthEndPointY.Value = image.Height / 2 - (int)(image.Width / CoefOfLen * 1.5);

                SixthStartPointX.Value = image.Width / 2;
                SixthStartPointY.Value = image.Height / 2 - (int)(image.Width / CoefOfLen * 1.5);
                SixthEndPointX.Value = image.Width / 2 + (int)(image.Width / CoefOfLen * 1.5);
                SixthEndPointY.Value = image.Height / 2 ;

                SeventhStartPointX.Value = image.Width / 2;
                SeventhStartPointY.Value = image.Height / 2;
                SeventhEndPointX.Value = image.Width / 2 - (int)(image.Width / CoefOfLen * 1.5);
                SeventhEndPointY.Value = image.Height / 2 + (int)(image.Width / CoefOfLen * 1.5);

                EighthStartPointX.Value = image.Width / 2 + (int)(image.Width / CoefOfLen );
                EighthStartPointY.Value = image.Height / 2;
                EighthEndPointX.Value = image.Width / 2 ;
                EighthEndPointY.Value = image.Height / 2 ;
            }
        }
        private void FractalForm_ResizeEnd(object sender, EventArgs e)
        {
            if (Progress.Value == Progress.Maximum)
            {
                DrawFractals();
            }

        }
        private void FractalForm_KeyDown(object sender, KeyEventArgs e)
        {
            // save as
            if(e.Control && e.Shift && e.KeyCode == Keys.S)
            {
                SaveAs.PerformClick();
            }
            // load gradient
            else if (e.Control && e.Shift && e.KeyCode == Keys.Z)
            {
                LoadGradient.PerformClick();
            }
            // generate gradient
            else if (e.Control && e.KeyCode == Keys.Z)
            {
                Gradient(gradientForm.pictureGradient);
            }
            // create or update fractal
            else if (e.Control && e.Shift && e.KeyCode == Keys.F)
            {
                if (tabControl.SelectedIndex == 2)
                {
                    buttonUpdate.PerformClick();
                }
                else
                {
                    CreateFractal.PerformClick();
                }
            }
            // previous fractal
            else if (e.Shift && e.KeyCode == Keys.D1)
            {
                selectFractal -= 1;
                if(selectFractal == -1)
                {
                    selectFractal = FractalsList.Items.Count - 1;
                }
                FractalsList.SelectedIndex = selectFractal % 4;
            }
            // next fractal
            else if(e.Shift && e.KeyCode == Keys.D2){
                selectFractal += 1;
                FractalsList.SelectedIndex = selectFractal % 4;
            }
            // Open GradientForm
            else if (e.Control && e.Shift && e.KeyCode == Keys.X)
            {
                gradientToolMenuItem.PerformClick();
            }
            // control keys
            else if (FractalsList.SelectedIndex == 0)
            {
                if (e.Shift && e.KeyCode == Keys.Q)
                {
                    if (ZOOMValue.Value < ZOOMValue.Maximum)
                    {
                        ZOOMValue.Value += ZOOMValue.Increment;
                    }
                }
                else if (e.Shift && e.KeyCode == Keys.E)
                {
                    if (ZOOMValue.Value > ZOOMValue.Minimum)
                    {
                        ZOOMValue.Value -= ZOOMValue.Increment;
                    }
                }
                else if (e.KeyCode == Keys.Q )
                {
                    IncreaseZOOM.PerformClick();
                }
                else if (e.KeyCode == Keys.E)
                {
                    DecreaseZOOM.PerformClick();
                }
                else if (e.KeyCode == Keys.Oemplus && e.Shift)
                {
                    if (Iterations.Value < Iterations.Maximum)
                    {
                        Iterations.Value += Iterations.Increment;
                    }
                }
                else if (e.KeyCode == Keys.OemMinus && e.Shift)
                {
                    if (Iterations.Value > Iterations.Minimum)
                    {
                        Iterations.Value -= Iterations.Increment;
                    }
                }
            }
            else if (FractalsList.SelectedIndex == 1)
            {
                if (e.KeyCode == Keys.Oemplus && e.Shift)
                {
                    if (BranchLenght.Value < BranchLenght.Maximum)
                    {
                        BranchLenght.Value += BranchLenght.Increment;
                    }
                }
                else if (e.KeyCode == Keys.OemMinus && e.Shift)
                {
                    if (BranchLenght.Value > BranchLenght.Minimum)
                    {
                        BranchLenght.Value -= BranchLenght.Increment;
                    }
                }
            }
            else if (FractalsList.SelectedIndex == 2)
            {
                if (e.KeyCode == Keys.Oemplus && e.Shift)
                {
                    if (NumberPoints.Value < NumberPoints.Maximum)
                    {
                        NumberPoints.Value += NumberPoints.Increment;
                    }
                }
                else if (e.KeyCode == Keys.OemMinus && e.Shift)
                {
                    if (NumberPoints.Value > NumberPoints.Minimum)
                    {
                        NumberPoints.Value -= NumberPoints.Increment;
                    }
                }
                

            }
            else if (FractalsList.SelectedIndex == 3)
            {
                if (e.KeyCode == Keys.Oemplus && e.Shift)
                {
                    if (DragonIterations.Value < DragonIterations.Maximum)
                    {
                        DragonIterations.Value += DragonIterations.Increment;
                    }
                }
                else if (e.KeyCode == Keys.OemMinus && e.Shift)
                {
                    if (DragonIterations.Value > DragonIterations.Minimum)
                    {
                        DragonIterations.Value -= DragonIterations.Increment;
                    }
                }
            }
        }


        ///
        ///
        ///      Tool Strip
        /// 
        ///

        // Create or update a fractal
        private void CreateAndUpdateFractalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateFractal.PerformClick();
        }
        
        // Open gradient window
        private async void Gradient_Click(object sender, EventArgs e)
        {
            if (gradientForm.Visible == false)
            {
                await Task.Run(() => { gradientForm.ShowDialog(); });
            }
        }

        // Generate Gradient
        private void GenerateGradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Gradient(gradientForm.pictureGradient);
        }

        // Zoom in
        private void ZoomInMBrotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncreaseZOOM.PerformClick();
        }

        // Zoom out
        private void ZoomOutMBrotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DecreaseZOOM.PerformClick();
        }

        // Increase the zoom value
        private void IncreaseZoomValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ZOOMValue.Value < ZOOMValue.Maximum)
            {
                ZOOMValue.Value += ZOOMValue.Increment;
            }
        }

        // Decrease the zoom value
        private void DecreaseTheZoomValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ZOOMValue.Value > ZOOMValue.Minimum)
            {
                ZOOMValue.Value -= ZOOMValue.Increment;
            }
        }

        // icrease the most impotant value
        private void IncreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FractalsList.SelectedIndex == 0)
            {
                if (Iterations.Value < Iterations.Maximum)
                {
                    Iterations.Value += Iterations.Increment;
                }
            }
            else if (FractalsList.SelectedIndex == 1)
            {
                if (BranchLenght.Value < BranchLenght.Maximum)
                {
                    BranchLenght.Value += BranchLenght.Increment;
                }
            }
            else if (FractalsList.SelectedIndex == 2)
            {
                if (NumberPoints.Value < NumberPoints.Maximum)
                {
                    NumberPoints.Value += NumberPoints.Increment;
                }
            }
            else if (FractalsList.SelectedIndex == 3)
            {
                if (DragonIterations.Value < DragonIterations.Maximum)
                {
                    DragonIterations.Value += DragonIterations.Increment;
                }
            }
        }
    
        // decrease the most impotant value
        private void DecreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FractalsList.SelectedIndex == 0)
            {
                if (Iterations.Value > Iterations.Minimum)
                {
                    Iterations.Value -= Iterations.Increment;
                }
            }
            else if(FractalsList.SelectedIndex == 1)
            {
                if (BranchLenght.Value > BranchLenght.Minimum)
                {
                    BranchLenght.Value -= BranchLenght.Increment;
                }
            }
            else if(FractalsList.SelectedIndex == 2)
            {
                if (NumberPoints.Value > NumberPoints.Minimum)
                {
                    NumberPoints.Value -= NumberPoints.Increment;
                }
            }
            else if(FractalsList.SelectedIndex == 3)
            {
                if (DragonIterations.Value > DragonIterations.Minimum)
                {
                    DragonIterations.Value -= DragonIterations.Increment;
                }
            }
        }

        // next fractal
        private void NextFractalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectFractal += 1;
            FractalsList.SelectedIndex = selectFractal % 4;
        }

        // previous fractal
        private void PreviousFractalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectFractal -= 1;
            if (selectFractal == -1)
            {
                selectFractal = FractalsList.Items.Count - 1;
            }
            FractalsList.SelectedIndex = selectFractal % 4;
        }


        /// 
        /// 
        ///     Resize image
        /// 
        /// 

        private void ShowImageHeight_ValueChanged(object sender, EventArgs e)
        {
            this.Height += ((int)ShowImageHeight.Value - image.Height);
            image.Height = (int)ShowImageHeight.Value;
        }
        private void ShowImageWidth_ValueChanged(object sender, EventArgs e)
        {
            this.Width += ((int)ShowImageWidth.Value - image.Width);
            image.Width = (int)ShowImageWidth.Value;
        }


        ///
        ///
        ///     UserDialogs
        ///
        ///

        // Load Gradient
        private void LoadGradient_Click(object sender, EventArgs e)
        {
            OpenFile.Title = "Load Gradient";
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                Bitmap isSufficientSize = new Bitmap(OpenFile.FileName);
                int minimumImageWidth = (int)Math.Round(gradientForm.pictureGradient.Width - gradientForm.pictureGradient.Width * 0.055); // minimum optimal width for stretching an image of 5.5%, connected with a Picturebox
                if (isSufficientSize.Width >= minimumImageWidth)
                {
                    gradientForm.pictureGradient.Image = isSufficientSize;
                }
                else
                {
                    MessageBox.Show($"Image size is too small!!!\nMinimum image width : {minimumImageWidth}\nCurrent width: {isSufficientSize.Width}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        // Save image
        private void SaveAs_Click(object sender, EventArgs e)
        {
            if (image.Image != null)
            {
                SaveFileDialog SaveAs = new SaveFileDialog();
                SaveAs.Title = "Save as";
                SaveAs.OverwritePrompt = true;
                SaveAs.Filter = "(*.png)|*.png|(*.jpg)|*.jpg|(*.bmp)| *.bmp|All files(*.*)|*.*";
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

        // selection of the background color for the image
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
            if (BackColor.ShowDialog() == DialogResult.OK)
            {
                BackgroundColor = BackColor.Color;
                ColorButton.BackColor = BackColor.Color;
                //image.BackColor = BackColor.Color;
            }
        }


        /// 
        /// 
        ///     Fractals selection and generation
        /// 
        /// 

        // selection of the type of fractal
        private void FractalsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            image.Image = null;
            image.BackColor = Color.White;
            FractalsInfo.Text = null;
            CulculationTime.Text = null;
            increaseToolStripMenuItem.Text = null;
            decreaseToolStripMenuItem.Text = null;
            if (FractalsList.SelectedIndex == 0)
            {
                hx = -0.6;
                hy = 0;
                maxZ = 4;
                CenterX.Text = hx.ToString();
                CenterY.Text = hy.ToString();
                MaxZDegreeTwo.Text = maxZ.ToString();
                ZoomVal = 1;
                SizeArea = 4;

                FractalsInfo.Text = InfoMBrot(); // add info about the Mandelbrot set

                image.Enabled = false;
                DecreaseZOOM.Enabled = false;
                IncreaseZOOM.Enabled = false;

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

                labelHorizontal.Visible = false;
                Horizontal.Visible = false;

                labelVertical.Visible = false;
                Vertical.Visible = false;

                labelNumberPoints.Visible = false;
                NumberPoints.Visible = false;

                labelNumberOfCurves.Visible = false;
                NumberOfCurves.Visible = false;

                labelStartPoint.Visible = false;
                labelEndPoint.Visible = false;

                labelStartPointX.Visible = false;
                labelStartPointY.Visible = false;
                labelEndPointX.Visible = false;
                labelEndPointY.Visible = false;

                FirstStartPointX.Visible = false;
                FirstStartPointY.Visible = false;
                FirstEndPointX.Visible = false;
                FirstEndPointY.Visible = false;

                SecondStartPointX.Visible = false;
                SecondStartPointY.Visible = false;
                SecondEndPointX.Visible = false;
                SecondEndPointY.Visible = false;

                ThirdStartPointX.Visible = false;
                ThirdStartPointY.Visible = false;
                ThirdEndPointX.Visible = false;
                ThirdEndPointY.Visible = false;

                FourthStartPointX.Visible = false;
                FourthStartPointY.Visible = false;
                FourthEndPointX.Visible = false;
                FourthEndPointY.Visible = false;

                FifthStartPointX.Visible = false;
                FifthStartPointY.Visible = false;
                FifthEndPointX.Visible = false;
                FifthEndPointY.Visible = false;

                SixthStartPointX.Visible = false;
                SixthStartPointY.Visible = false;
                SixthEndPointX.Visible = false;
                SixthEndPointY.Visible = false;

                SeventhStartPointX.Visible = false;
                SeventhStartPointY.Visible = false;
                SeventhEndPointX.Visible = false;
                SeventhEndPointY.Visible = false;

                EighthStartPointX.Visible = false;
                EighthStartPointY.Visible = false;
                EighthEndPointX.Visible = false;
                EighthEndPointY.Visible = false;

                labelDragonBrashWidth.Visible = false;
                DragonBrashWidth.Visible = false;

                labelDragonIterations.Visible = false;
                DragonIterations.Visible = false;

                GroupMouseControl.Visible = true;

                increaseToolStripMenuItem.Text = "Increase the value of the max iterations";
                decreaseToolStripMenuItem.Text = "Decrease the value of the max iterations";

                zoomInMBrotToolStripMenuItem.Visible = true;
                zoomOutMBrotToolStripMenuItem.Visible = true;
                increaseZoomValueToolStripMenuItem.Visible = true;
                decreaseTheZoomValueToolStripMenuItem.Visible = true;

            }
            else if (FractalsList.SelectedIndex == 1)
            {
                FractalTree info = new FractalTree();
                FractalsInfo.Text = info.Info(); // add info about the fractal tree

                StartX.Value = image.Width / 2;
                StartY.Value = image.Height / 5;


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
                ThirdAngle.Visible = false;
                FourthAngle.Visible = false;

                SecondAngle.Location = new Point(FirstAngle.Location.X + 132, FirstAngle.Location.Y);
                ThirdAngle.Location = new Point(FirstAngle.Location.X, FirstAngle.Location.Y + 35);
                FourthAngle.Location = new Point(SecondAngle.Location.X, SecondAngle.Location.Y + 35);

                NumberOfAngles.SelectedIndex = 1;

                labelBackColor.Visible = true;
                labelBackColor.Location = x.Location;

                ColorButton.Visible = true;
                ColorButton.Location = CenterX.Location;

                BackgroundColor = Color.Transparent;
                ColorButton.BackColor = Color.White;

                Progress.Visible = true;

                labelHorizontal.Visible = false;
                Horizontal.Visible = false;

                labelVertical.Visible = false;
                Vertical.Visible = false;

                labelNumberPoints.Visible = false;
                NumberPoints.Visible = false;

                labelNumberOfCurves.Visible = false;
                NumberOfCurves.Visible = false;

                labelStartPoint.Visible = false;
                labelEndPoint.Visible = false;

                labelStartPointX.Visible = false;
                labelStartPointY.Visible = false;
                labelEndPointX.Visible = false;
                labelEndPointY.Visible = false;

                FirstStartPointX.Visible = false;
                FirstStartPointY.Visible = false;
                FirstEndPointX.Visible = false;
                FirstEndPointY.Visible = false;

                SecondStartPointX.Visible = false;
                SecondStartPointY.Visible = false;
                SecondEndPointX.Visible = false;
                SecondEndPointY.Visible = false;

                ThirdStartPointX.Visible = false;
                ThirdStartPointY.Visible = false;
                ThirdEndPointX.Visible = false;
                ThirdEndPointY.Visible = false;

                FourthStartPointX.Visible = false;
                FourthStartPointY.Visible = false;
                FourthEndPointX.Visible = false;
                FourthEndPointY.Visible = false;

                FifthStartPointX.Visible = false;
                FifthStartPointY.Visible = false;
                FifthEndPointX.Visible = false;
                FifthEndPointY.Visible = false;

                SixthStartPointX.Visible = false;
                SixthStartPointY.Visible = false;
                SixthEndPointX.Visible = false;
                SixthEndPointY.Visible = false;

                SeventhStartPointX.Visible = false;
                SeventhStartPointY.Visible = false;
                SeventhEndPointX.Visible = false;
                SeventhEndPointY.Visible = false;

                EighthStartPointX.Visible = false;
                EighthStartPointY.Visible = false;
                EighthEndPointX.Visible = false;
                EighthEndPointY.Visible = false;

                labelDragonBrashWidth.Visible = false;
                DragonBrashWidth.Visible = false;

                labelDragonIterations.Visible = false;
                DragonIterations.Visible = false;

                GroupMouseControl.Visible = false;

                increaseToolStripMenuItem.Text = "Increase the value of the branch length";
                decreaseToolStripMenuItem.Text = "Decrease the value of the branch length";

                zoomInMBrotToolStripMenuItem.Visible = false;
                zoomOutMBrotToolStripMenuItem.Visible = false;
                increaseZoomValueToolStripMenuItem.Visible = false;
                decreaseTheZoomValueToolStripMenuItem.Visible = false;
            }
            else if (FractalsList.SelectedIndex == 2)
            {
                Barnsley_fern info = new Barnsley_fern();
                FractalsInfo.Text = info.Info(); // add info about the Barnsley fern

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

                LabelBranchLength.Visible = false;
                BranchLenght.Visible = false;

                labelMinimalLength.Visible = false;
                MinBranchLenght.Visible = false;

                labelBranchWidth.Visible = false;
                BranchWidth.Visible = false;

                StartX.Visible = false;
                StartY.Visible = false;

                labelAngles.Visible = false;
                NumberOfAngles.Visible = false;

                FirstAngle.Visible = false;
                SecondAngle.Visible = false;
                ThirdAngle.Visible = false;
                FourthAngle.Visible = false;

                labelBackColor.Visible = true;
                labelBackColor.Location = x.Location;

                ColorButton.Visible = true;
                ColorButton.Location = CenterX.Location;

                Progress.Visible = true;

                labelIterations.Visible = false;
                Iterations.Visible = false;

                labelHorizontal.Visible = true;
                labelHorizontal.Location = y.Location;

                Horizontal.Visible = true;
                Horizontal.Location = CenterY.Location;

                labelVertical.Visible = true;
                labelVertical.Location = LabelMaxZDegreeTwo.Location;

                Vertical.Visible = true;
                Vertical.Location = MaxZDegreeTwo.Location;

                labelNumberPoints.Visible = true;
                labelNumberPoints.Location = labelIterations.Location;

                NumberPoints.Visible = true;
                NumberPoints.Location = Iterations.Location;

                BackgroundColor = Color.Transparent;
                ColorButton.BackColor = Color.White;

                labelNumberOfCurves.Visible = false;
                NumberOfCurves.Visible = false;

                labelStartPoint.Visible = false;
                labelEndPoint.Visible = false;

                labelStartPointX.Visible = false;
                labelStartPointY.Visible = false;
                labelEndPointX.Visible = false;
                labelEndPointY.Visible = false;

                FirstStartPointX.Visible = false;
                FirstStartPointY.Visible = false;
                FirstEndPointX.Visible = false;
                FirstEndPointY.Visible = false;

                SecondStartPointX.Visible = false;
                SecondStartPointY.Visible = false;
                SecondEndPointX.Visible = false;
                SecondEndPointY.Visible = false;

                ThirdStartPointX.Visible = false;
                ThirdStartPointY.Visible = false;
                ThirdEndPointX.Visible = false;
                ThirdEndPointY.Visible = false;

                FourthStartPointX.Visible = false;
                FourthStartPointY.Visible = false;
                FourthEndPointX.Visible = false;
                FourthEndPointY.Visible = false;

                FifthStartPointX.Visible = false;
                FifthStartPointY.Visible = false;
                FifthEndPointX.Visible = false;
                FifthEndPointY.Visible = false;

                SixthStartPointX.Visible = false;
                SixthStartPointY.Visible = false;
                SixthEndPointX.Visible = false;
                SixthEndPointY.Visible = false;

                SeventhStartPointX.Visible = false;
                SeventhStartPointY.Visible = false;
                SeventhEndPointX.Visible = false;
                SeventhEndPointY.Visible = false;

                EighthStartPointX.Visible = false;
                EighthStartPointY.Visible = false;
                EighthEndPointX.Visible = false;
                EighthEndPointY.Visible = false;

                labelDragonBrashWidth.Visible = false;
                DragonBrashWidth.Visible = false;

                labelDragonIterations.Visible = false;
                DragonIterations.Visible = false;

                GroupMouseControl.Visible = false;

                increaseToolStripMenuItem.Text = "Increase the value of the Numbers points";
                decreaseToolStripMenuItem.Text = "Decrease the value of the Numbers points";

                zoomInMBrotToolStripMenuItem.Visible = false;
                zoomOutMBrotToolStripMenuItem.Visible = false;
                increaseZoomValueToolStripMenuItem.Visible = false;
                decreaseTheZoomValueToolStripMenuItem.Visible = false;
            }
            else if (FractalsList.SelectedIndex == 3)
            {
                CurveDragon info = new CurveDragon();
                FractalsInfo.Text = info.Info(); // add info about the curve of dragon

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

                LabelBranchLength.Visible = false;
                BranchLenght.Visible = false;

                labelMinimalLength.Visible = false;
                MinBranchLenght.Visible = false;

                labelBranchWidth.Visible = false;
                BranchWidth.Visible = false;

                StartX.Visible = false;
                StartY.Visible = false;

                labelStartX.Visible = false;
                labelStartY.Visible = false;

                labelAngles.Visible = false;
                NumberOfAngles.Visible = false;

                FirstAngle.Visible = false;
                SecondAngle.Visible = false;
                ThirdAngle.Visible = false;
                FourthAngle.Visible = false;

                labelBackColor.Visible = true;
                labelBackColor.Location = y.Location;

                ColorButton.Visible = true;
                ColorButton.Location = CenterY.Location;

                Progress.Visible = true;

                labelIterations.Visible = false;
                Iterations.Visible = false;

                labelHorizontal.Visible = false;
                Horizontal.Visible = false;

                labelVertical.Visible = false;
                Vertical.Visible = false;

                labelNumberPoints.Visible = false;
                NumberPoints.Visible = false;

                BackgroundColor = Color.Transparent;
                ColorButton.BackColor = Color.White;

                labelNumberOfCurves.Visible = true;
                NumberOfCurves.Visible = true;

                labelNumberOfCurves.Location = labelZOOM.Location;
                NumberOfCurves.Location = new Point(labelNumberOfCurves.Location.X + labelNumberOfCurves.Width + 30, labelNumberOfCurves.Location.Y);

                NumberOfCurves.SelectedIndex = 3;

                labelStartPoint.Visible = true;
                labelEndPoint.Visible = true;

                labelStartPoint.Location = new Point(labelNumberOfCurves.Location.X, labelNumberOfCurves.Location.Y + 28);
                labelEndPoint.Location = new Point(labelStartPoint.Location.X + labelStartPoint.Width + 30, labelStartPoint.Location.Y);

                labelStartPointX.Visible = true;
                labelStartPointY.Visible = true;
                labelEndPointX.Visible = true;
                labelEndPointY.Visible = true;

                labelStartPointX.Location = new Point(labelStartPoint.Location.X, labelStartPoint.Location.Y + 23);
                labelStartPointY.Location = new Point(labelStartPointX.Location.X + labelStartPointX.Width + 25, labelStartPointX.Location.Y);
                labelEndPointX.Location = new Point(labelEndPoint.Location.X, labelEndPoint.Location.Y + 23);
                labelEndPointY.Location = new Point(labelEndPointX.Location.X + labelEndPointX.Width + 25, labelEndPointX.Location.Y);

                FirstStartPointX.Visible = true;
                FirstStartPointY.Visible = true;
                FirstEndPointX.Visible = true;
                FirstEndPointY.Visible = true;

                FirstStartPointX.Location = new Point(labelStartPointX.Location.X, labelStartPointX.Location.Y + 23);
                FirstStartPointY.Location = new Point(labelStartPointY.Location.X + 5, labelStartPointY.Location.Y + 23);
                FirstEndPointX.Location = new Point(labelEndPointX.Location.X, labelEndPointX.Location.Y + 23);
                FirstEndPointY.Location = new Point(labelEndPointY.Location.X + 5, labelEndPointY.Location.Y + 23);

                SecondStartPointX.Visible = true;
                SecondStartPointY.Visible = true;
                SecondEndPointX.Visible = true;
                SecondEndPointY.Visible = true;

                SecondStartPointX.Location = new Point(FirstStartPointX.Location.X, FirstStartPointX.Location.Y + 28);
                SecondStartPointY.Location = new Point(FirstStartPointY.Location.X, FirstStartPointY.Location.Y + 28);
                SecondEndPointX.Location = new Point(FirstEndPointX.Location.X, FirstEndPointX.Location.Y + 28);
                SecondEndPointY.Location = new Point(FirstEndPointY.Location.X, FirstEndPointY.Location.Y + 28);

                ThirdStartPointX.Visible = true;
                ThirdStartPointY.Visible = true;
                ThirdEndPointX.Visible = true;
                ThirdEndPointY.Visible = true;

                ThirdStartPointX.Location = new Point(SecondStartPointX.Location.X, SecondStartPointX.Location.Y + 28);
                ThirdStartPointY.Location = new Point(SecondStartPointY.Location.X, SecondStartPointY.Location.Y + 28);
                ThirdEndPointX.Location = new Point(SecondEndPointX.Location.X, SecondEndPointX.Location.Y + 28);
                ThirdEndPointY.Location = new Point(SecondEndPointY.Location.X, SecondEndPointY.Location.Y + 28);

                FourthStartPointX.Visible = true;
                FourthStartPointY.Visible = true;
                FourthEndPointX.Visible = true;
                FourthEndPointY.Visible = true;

                FourthStartPointX.Location = new Point(ThirdStartPointX.Location.X, ThirdStartPointX.Location.Y + 28);
                FourthStartPointY.Location = new Point(ThirdStartPointY.Location.X, ThirdStartPointY.Location.Y + 28);
                FourthEndPointX.Location = new Point(ThirdEndPointX.Location.X, ThirdEndPointX.Location.Y + 28);
                FourthEndPointY.Location = new Point(ThirdEndPointY.Location.X, ThirdEndPointY.Location.Y + 28);

                FifthStartPointX.Visible = false;
                FifthStartPointY.Visible = false;
                FifthEndPointX.Visible = false;
                FifthEndPointY.Visible = false;

                FifthStartPointX.Location = new Point(FourthStartPointX.Location.X, FourthStartPointX.Location.Y + 28);
                FifthStartPointY.Location = new Point(FourthStartPointY.Location.X, FourthStartPointY.Location.Y + 28);
                FifthEndPointX.Location = new Point(FourthEndPointX.Location.X, FourthEndPointX.Location.Y + 28);
                FifthEndPointY.Location = new Point(FourthEndPointY.Location.X, FourthEndPointY.Location.Y + 28);

                SixthStartPointX.Visible = false;
                SixthStartPointY.Visible = false;
                SixthEndPointX.Visible = false;
                SixthEndPointY.Visible = false;

                SixthStartPointX.Location = new Point(FifthStartPointX.Location.X, FifthStartPointX.Location.Y + 28);
                SixthStartPointY.Location = new Point(FifthStartPointY.Location.X, FifthStartPointY.Location.Y + 28);
                SixthEndPointX.Location = new Point(FifthEndPointX.Location.X, FifthEndPointX.Location.Y + 28);
                SixthEndPointY.Location = new Point(FifthEndPointY.Location.X, FifthEndPointY.Location.Y + 28);

                SeventhStartPointX.Visible = false;
                SeventhStartPointY.Visible = false;
                SeventhEndPointX.Visible = false;
                SeventhEndPointY.Visible = false;

                SeventhStartPointX.Location = new Point(SixthStartPointX.Location.X, SixthStartPointX.Location.Y + 28);
                SeventhStartPointY.Location = new Point(SixthStartPointY.Location.X, SixthStartPointY.Location.Y + 28);
                SeventhEndPointX.Location = new Point(SixthEndPointX.Location.X, SixthEndPointX.Location.Y + 28);
                SeventhEndPointY.Location = new Point(SixthEndPointY.Location.X, SixthEndPointY.Location.Y + 28);

                EighthStartPointX.Visible = false;
                EighthStartPointY.Visible = false;
                EighthEndPointX.Visible = false;
                EighthEndPointY.Visible = false;

                EighthStartPointX.Location = new Point(SeventhStartPointX.Location.X, SeventhStartPointX.Location.Y + 28);
                EighthStartPointY.Location = new Point(SeventhStartPointY.Location.X, SeventhStartPointY.Location.Y + 28);
                EighthEndPointX.Location = new Point(SeventhEndPointX.Location.X, SeventhEndPointX.Location.Y + 28);
                EighthEndPointY.Location = new Point(SeventhEndPointY.Location.X, SeventhEndPointY.Location.Y + 28);

                labelDragonBrashWidth.Visible = true;
                labelDragonBrashWidth.Location = LabelMaxZDegreeTwo.Location;

                DragonBrashWidth.Visible = true;
                DragonBrashWidth.Location = MaxZDegreeTwo.Location;

                labelDragonIterations.Visible = true;
                labelDragonIterations.Location = labelIterations.Location;

                DragonIterations.Visible = true;
                DragonIterations.Location = Iterations.Location;

                GroupMouseControl.Visible = false;

                increaseToolStripMenuItem.Text = "Increase the value of the Numbers points";
                decreaseToolStripMenuItem.Text = "Decrease the value of the Numbers points";

                zoomInMBrotToolStripMenuItem.Visible = false;
                zoomOutMBrotToolStripMenuItem.Visible = false;
                increaseZoomValueToolStripMenuItem.Visible = false;
                decreaseTheZoomValueToolStripMenuItem.Visible = false;
            }
            DrawFractals();
        }

        // button for generating a fractal
        private void GenerateFractal_Click(object sender, EventArgs e)
        {
            DrawFractals();
        }

        // drawing Fractals
        public void DrawFractals()
        {
            Progress.Value = 0;
            pixels = GetPixels((Bitmap)gradientForm.pictureGradient.Image);
            if (FractalsList.SelectedIndex == 0)
            {
                ZoomNUM.Text = ZoomVal.ToString("F0") + " X";
                ZoomNUM.Visible = true;
                image.Enabled = true;
                DecreaseZOOM.Enabled = true;
                IncreaseZOOM.Enabled = true;

                er_x = double.TryParse(CenterX.Text, out hx);
                er_y = double.TryParse(CenterY.Text, out hy);
                er_z = double.TryParse(MaxZDegreeTwo.Text, out maxZ);


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
                    tmpPixels = GetPixels((Bitmap)(gradientForm.pictureGradient.Image));
                    DrawMBrot();
                }
            }
            else if (FractalsList.SelectedIndex == 1)
            {
                image.Image = null;
                DrawFractalTree();
            }
            else if (FractalsList.SelectedIndex == 2)
            {
                image.Image = null;
                DrawBarnsleyFern();
            }
            else if (FractalsList.SelectedIndex == 3)
            {
                image.Image = null;
                DrawCurveDragon();
            }
            Progress.Value = Progress.Maximum;
        }


        /// 
        /// 
        ///     Mandelbrot set
        /// 
        /// 

        // Draw MBrot set
        private async void DrawMBrot()
        {
            image.Cursor = Cursors.WaitCursor;
            image.Enabled = false;          /// 
            IncreaseZOOM.Enabled = false;   ///
            DecreaseZOOM.Enabled = false;   /// disabled access to change the image
            CreateFractal.Enabled = false;  ///
            FractalsList.Enabled = false;
            start = DateTime.Now;
            ZoomNUM.Width = ZoomNUM.Text.Length * 8 + 70;
            image.Invalidate();
            pixels = GetPixels((Bitmap)gradientForm.pictureGradient.Image);
            await Task.Run(() => { CalculationMBrot(); });

            end = DateTime.Now;
            CulculationTime.Text = (end - start).TotalMilliseconds.ToString("F2") + " ms";

            image.Enabled = true;
            IncreaseZOOM.Enabled = true;
            DecreaseZOOM.Enabled = true;    /// added access to change the image
            CreateFractal.Enabled = true;
            FractalsList.Enabled = true;
            image.Cursor = Cursors.Default;
        }

        // Calculate MBrot set
        private void CalculationMBrot()
        {
            Bitmap picture = new Bitmap(image.Width, image.Height);
            size = image.Size;
            int UserIt = (int)Iterations.Value;
            int change;
            int[] ColorIndex = new int[42];
            int i = 0;
            for (int p = 0; p < gradientForm.pictureGradient.Image.Width; p++)
            {
                if (p % (int)(gradientForm.pictureGradient.Image.Width * 0.025) == 0)
                {
                    if (i >= ColorIndex.Length)
                    {
                        break;
                    }
                    ColorIndex[i] = p;
                    i++;
                }
            }

            if (pixels.Count > gradientForm.pictureGradient.Width)
            {
                for (int p = 0; p < gradientForm.pictureGradient.Width; p++)
                {
                    pixels[p].Color = tmpPixels[(int)(p * (pixels.Count / gradientForm.pictureGradient.Width))].Color;
                }
            }



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
                    if (it < UserIt)
                    {
                        change = it % ColorIndex.Length;
                        switch (change)
                        {
                            case 0:
                                picture.SetPixel(x, y, pixels[ColorIndex[0]].Color);
                                break;
                            case 1:
                                picture.SetPixel(x, y, pixels[ColorIndex[1]].Color);
                                break;
                            case 2:
                                picture.SetPixel(x, y, pixels[ColorIndex[2]].Color);
                                break;
                            case 3:
                                picture.SetPixel(x, y, pixels[ColorIndex[3]].Color);
                                break;
                            case 4:
                                picture.SetPixel(x, y, pixels[ColorIndex[4]].Color);
                                break;
                            case 5:
                                picture.SetPixel(x, y, pixels[ColorIndex[5]].Color);
                                break;
                            case 6:
                                picture.SetPixel(x, y, pixels[ColorIndex[6]].Color);
                                break;
                            case 7:
                                picture.SetPixel(x, y, pixels[ColorIndex[7]].Color);
                                break;
                            case 8:
                                picture.SetPixel(x, y, pixels[ColorIndex[8]].Color);
                                break;
                            case 9:
                                picture.SetPixel(x, y, pixels[ColorIndex[9]].Color);
                                break;
                            case 10:
                                picture.SetPixel(x, y, pixels[ColorIndex[10]].Color);
                                break;
                            case 11:
                                picture.SetPixel(x, y, pixels[ColorIndex[11]].Color);
                                break;
                            case 12:
                                picture.SetPixel(x, y, pixels[ColorIndex[12]].Color);
                                break;
                            case 13:
                                picture.SetPixel(x, y, pixels[ColorIndex[13]].Color);
                                break;
                            case 14:
                                picture.SetPixel(x, y, pixels[ColorIndex[14]].Color);
                                break;
                            case 15:
                                picture.SetPixel(x, y, pixels[ColorIndex[15]].Color);
                                break;
                            case 16:
                                picture.SetPixel(x, y, pixels[ColorIndex[16]].Color);
                                break;
                            case 17:
                                picture.SetPixel(x, y, pixels[ColorIndex[17]].Color);
                                break;
                            case 18:
                                picture.SetPixel(x, y, pixels[ColorIndex[18]].Color);
                                break;
                            case 19:
                                picture.SetPixel(x, y, pixels[ColorIndex[19]].Color);
                                break;
                            case 20:
                                picture.SetPixel(x, y, pixels[ColorIndex[20]].Color);
                                break;
                            case 21:
                                picture.SetPixel(x, y, pixels[ColorIndex[21]].Color);
                                break;
                            case 22:
                                picture.SetPixel(x, y, pixels[ColorIndex[22]].Color);
                                break;
                            case 23:
                                picture.SetPixel(x, y, pixels[ColorIndex[23]].Color);
                                break;
                            case 24:
                                picture.SetPixel(x, y, pixels[ColorIndex[24]].Color);
                                break;
                            case 25:
                                picture.SetPixel(x, y, pixels[ColorIndex[25]].Color);
                                break;
                            case 26:
                                picture.SetPixel(x, y, pixels[ColorIndex[26]].Color);
                                break;
                            case 27:
                                picture.SetPixel(x, y, pixels[ColorIndex[27]].Color);
                                break;
                            case 28:
                                picture.SetPixel(x, y, pixels[ColorIndex[28]].Color);
                                break;
                            case 29:
                                picture.SetPixel(x, y, pixels[ColorIndex[29]].Color);
                                break;
                            case 30:
                                picture.SetPixel(x, y, pixels[ColorIndex[30]].Color);
                                break;
                            case 31:
                                picture.SetPixel(x, y, pixels[ColorIndex[31]].Color);
                                break;
                            case 32:
                                picture.SetPixel(x, y, pixels[ColorIndex[32]].Color);
                                break;
                            case 33:
                                picture.SetPixel(x, y, pixels[ColorIndex[33]].Color);
                                break;
                            case 34:
                                picture.SetPixel(x, y, pixels[ColorIndex[34]].Color);
                                break;
                            case 35:
                                picture.SetPixel(x, y, pixels[ColorIndex[35]].Color);
                                break;
                            case 36:
                                picture.SetPixel(x, y, pixels[ColorIndex[36]].Color);
                                break;
                            case 37:
                                picture.SetPixel(x, y, pixels[ColorIndex[37]].Color);
                                break;
                            case 38:
                                picture.SetPixel(x, y, pixels[ColorIndex[38]].Color);
                                break;
                            case 39:
                                picture.SetPixel(x, y, pixels[ColorIndex[39]].Color);
                                break;
                            case 40:
                                picture.SetPixel(x, y, pixels[ColorIndex[40]].Color);
                                break;
                            case 41:
                                picture.SetPixel(x, y, pixels[ColorIndex[41]].Color);
                                break;
                            default:
                                picture.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                                break;
                        }
                    }
                    else
                    {
                        picture.SetPixel(x, y, Color.FromArgb(0, 0, 0));
                    }
                }
                this.Invoke(new Action(() => // делегат для зміни progressBar
                {
                    Progress.PerformStep();
                }));

            }
            image.Image = picture;
        }

        // Info about MBrot set
        private string InfoMBrot()
        {
            string info = "The Mandelbrot set is the set of complex numbers C" +
                " for which the function f(z)=z^2 + c does not diverge when iterated" +
                " from z = 0, i.e., for which the sequence f(0), f(f(0)) etc.," +
                " remains bounded in absolute value. Its definition is credited" +
                " to Adrien Douady who named it in tribute to the mathematician " +
                "Benoit Mandelbrot, a pioneer of fractal geometry." +
                Environment.NewLine +
                Environment.NewLine +
                "Visually, inside the Mandelbrot set," +
                " an infinite number of elementary figures can be distinguished," +
                " the largest of which is in the center - the cardioid." +
                " There is also a set of ovals related to the cardioid," +
                " the size of which gradually decreases, tending to zero." +
                " Each of these ovals has its own set of smaller ovals," +
                " the diameter of which also tends to zero, etc." +
                Environment.NewLine +
                Environment.NewLine +
                " This process continues indefinitely, forming a fractal." +
                " It is also important that these processes of figure branching" +
                " do not completely exhaust the Mandelbrot set: if we consider" +
                " additional “branchings” with magnification, then in them" +
                " you can see your cardioids and circles that are not associated" +
                " with the main figure.";
            return info;
        }

        // Control buttons for MBrot set
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
            if (ZoomVal < 1)
            {
                ZoomNUM.Text = ZoomVal.ToString("F4") + " X";
            }
            else
            {
                ZoomNUM.Text = ZoomVal.ToString("F2") + " X";
            }
            DrawMBrot();
        }
        private void Image_MouseClick(object sender, MouseEventArgs e)
        {
            size = image.Size;
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
                    SizeArea = 4;
                    hx = -0.6;
                    hy = 0;
                    CenterX.Text = hx.ToString();
                    CenterY.Text = hy.ToString();
                    ZoomVal = 1;
                    ZoomNUM.Clear();
                    ZoomNUM.Width = 80;
                    ZoomNUM.Text = ZoomVal.ToString("F2") + " X";
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
                    if (ZoomVal < 1)
                    {
                        ZoomNUM.Text = ZoomVal.ToString("F4") + " X";
                    }
                    else
                    {
                        ZoomNUM.Text = ZoomVal.ToString("F2") + " X";
                    }
                    DrawMBrot();
                }
            }
        }


        /// 
        /// 
        ///     Fractal tree
        /// 
        /// 

        // selection of the number of angles
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

        // Draw fractal tree
        private async void DrawFractalTree()
        {
            image.Cursor = Cursors.WaitCursor;
            FractalsList.Enabled = false;
            start = DateTime.Now;
            image.Invalidate();
            CreateFractal.Enabled = false;
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

            FractalTree tree = new FractalTree(pictureTree, pixels, angles, (int)(MinBranchLenght.Value), (int)(BranchWidth.Value), BackgroundColor, Progress);
            await Task.Run(() => { tree.DrawFractalTree((int)(StartX.Value), (int)(StartY.Value), branchLenght, 0); });

            end = DateTime.Now;
            CulculationTime.Text = (end - start).TotalMilliseconds.ToString("F2") + " ms";
            image.Image = pictureTree;
            CreateFractal.Enabled = true;
            FractalsList.Enabled = true;
            image.Cursor = Cursors.Default;
        }
        private void BranchLenght_ValueChanged(object sender, EventArgs e)
        {
            if (NumberOfAngles.SelectedIndex == 3)
            {
                MinBranchLenght.Minimum = (int)(Math.Floor(BranchLenght.Value / 40));

            }
            else
            {
                MinBranchLenght.Minimum = (int)(Math.Floor((double)BranchLenght.Value * 0.005)) + 1;
            }

            if (MinBranchLenght.Value < MinBranchLenght.Minimum)
            {
                MinBranchLenght.Value = MinBranchLenght.Minimum;
            }

        }


        /// 
        /// 
        ///     Fern Barnsley
        /// 
        /// 

        // Draw fern Barnsley
        private async void DrawBarnsleyFern()
        {
            image.Cursor = Cursors.WaitCursor;
            start = DateTime.Now;
            image.Invalidate();
            CreateFractal.Enabled = false;
            FractalsList.Enabled = false;

            float[] probability = new float[4] { 0.01f, 0.06f, 0.08f, 0.85f };
            int NumbersOfPoint = (int)NumberPoints.Value;
            float maxX = 3 + (float)Horizontal.Value, maxY = 10.1f + (float)Vertical.Value;
            float[,] Coefficient = new float[4, 6]
            {
            {0, 0, 0, 0.16f, 0, 0},
            {-0.15f, 0.28f, 0.26f, 0.24f, 0, 0.44f},
            {0.2f, -0.26f, 0.23f, 0.22f, 0, 1.6f},
            {0.85f, 0.04f, -0.04f, 0.85f, 0, 1.6f}

            };

            Bitmap pictureFern = new Bitmap(image.Width, image.Height);
            Barnsley_fern Fern = new Barnsley_fern(pictureFern, maxX, maxY, NumbersOfPoint, probability, Coefficient, pixels, BackgroundColor, gradientForm.pictureGradient.Width);
            await Task.Run(() => { pictureFern = Fern.DrawBransleyFern(); });

            end = DateTime.Now;
            CulculationTime.Text = (end - start).TotalMilliseconds.ToString("F2") + " ms";

            image.Image = pictureFern;
            CreateFractal.Enabled = true;
            FractalsList.Enabled = true;
            image.Cursor = Cursors.Default;
        }


        /// 
        /// 
        ///     Dragon curve
        /// 
        /// 

        // Draw fern Barnsley
        private async void DrawCurveDragon()
        {
            image.Cursor = Cursors.WaitCursor;
            start = DateTime.Now;
            image.Invalidate();
            CreateFractal.Enabled = false;
            FractalsList.Enabled = false;
            int brushWidth = (int)(DragonBrashWidth.Value);
            int CountIterations;
            Bitmap pictureCurveDragon = new Bitmap(image.Width, image.Height);

            List<int> indexs = new List<int>();
            List<int> Coords = new List<int>();

            if (NumberOfCurves.SelectedIndex == 0)
            {
                Coords = new List<int>() {
                (int)FirstStartPointX.Value, (int)FirstStartPointY.Value, (int)FirstEndPointX.Value, (int)FirstEndPointY.Value
                };
            }
            else if (NumberOfCurves.SelectedIndex == 1)
            {
                Coords = new List<int>() {
                (int)FirstStartPointX.Value, (int)FirstStartPointY.Value, (int)FirstEndPointX.Value, (int)FirstEndPointY.Value,
                (int)SecondStartPointX.Value, (int)SecondStartPointY.Value, (int)SecondEndPointX.Value, (int)SecondEndPointY.Value
                };
            }
            else if (NumberOfCurves.SelectedIndex == 2)
            {
                Coords = new List<int>() {
                (int)FirstStartPointX.Value, (int)FirstStartPointY.Value, (int)FirstEndPointX.Value, (int)FirstEndPointY.Value,
                (int)SecondStartPointX.Value, (int)SecondStartPointY.Value, (int)SecondEndPointX.Value, (int)SecondEndPointY.Value,
                (int)ThirdStartPointX.Value, (int)ThirdStartPointY.Value, (int)ThirdEndPointX.Value, (int)ThirdEndPointY.Value
                };
            }
            else if (NumberOfCurves.SelectedIndex == 3)
            {
                Coords = new List<int>() {
                (int)FirstStartPointX.Value, (int)FirstStartPointY.Value, (int)FirstEndPointX.Value, (int)FirstEndPointY.Value,
                (int)SecondStartPointX.Value, (int)SecondStartPointY.Value, (int)SecondEndPointX.Value, (int)SecondEndPointY.Value,
                (int)ThirdStartPointX.Value, (int)ThirdStartPointY.Value, (int)ThirdEndPointX.Value, (int)ThirdEndPointY.Value,
                (int)FourthStartPointX.Value, (int)FourthStartPointY.Value, (int)FourthEndPointX.Value, (int)FourthEndPointY.Value
                };
            }
            else if (NumberOfCurves.SelectedIndex == 4)
            {
                Coords = new List<int>() {
                (int)FirstStartPointX.Value, (int)FirstStartPointY.Value, (int)FirstEndPointX.Value, (int)FirstEndPointY.Value,
                (int)SecondStartPointX.Value, (int)SecondStartPointY.Value, (int)SecondEndPointX.Value, (int)SecondEndPointY.Value,
                (int)ThirdStartPointX.Value, (int)ThirdStartPointY.Value, (int)ThirdEndPointX.Value, (int)ThirdEndPointY.Value,
                (int)FourthStartPointX.Value, (int)FourthStartPointY.Value, (int)FourthEndPointX.Value, (int)FourthEndPointY.Value,
                (int)FifthStartPointX.Value, (int)FifthStartPointY.Value, (int)FifthEndPointX.Value, (int)FifthEndPointY.Value
                };
            }
            else if (NumberOfCurves.SelectedIndex == 5)
            {
                Coords = new List<int>() {
                (int)FirstStartPointX.Value, (int)FirstStartPointY.Value, (int)FirstEndPointX.Value, (int)FirstEndPointY.Value,
                (int)SecondStartPointX.Value, (int)SecondStartPointY.Value, (int)SecondEndPointX.Value, (int)SecondEndPointY.Value,
                (int)ThirdStartPointX.Value, (int)ThirdStartPointY.Value, (int)ThirdEndPointX.Value, (int)ThirdEndPointY.Value,
                (int)FourthStartPointX.Value, (int)FourthStartPointY.Value, (int)FourthEndPointX.Value, (int)FourthEndPointY.Value,
                (int)FifthStartPointX.Value, (int)FifthStartPointY.Value, (int)FifthEndPointX.Value, (int)FifthEndPointY.Value,
                (int)SixthStartPointX.Value, (int)SixthStartPointY.Value, (int)SixthEndPointX.Value, (int)SixthEndPointY.Value
                };
            }
            else if (NumberOfCurves.SelectedIndex == 6)
            {
                Coords = new List<int>() {
                (int)FirstStartPointX.Value, (int)FirstStartPointY.Value, (int)FirstEndPointX.Value, (int)FirstEndPointY.Value,
                (int)SecondStartPointX.Value, (int)SecondStartPointY.Value, (int)SecondEndPointX.Value, (int)SecondEndPointY.Value,
                (int)ThirdStartPointX.Value, (int)ThirdStartPointY.Value, (int)ThirdEndPointX.Value, (int)ThirdEndPointY.Value,
                (int)FourthStartPointX.Value, (int)FourthStartPointY.Value, (int)FourthEndPointX.Value, (int)FourthEndPointY.Value,
                (int)FifthStartPointX.Value, (int)FifthStartPointY.Value, (int)FifthEndPointX.Value, (int)FifthEndPointY.Value,
                (int)SixthStartPointX.Value, (int)SixthStartPointY.Value, (int)SixthEndPointX.Value, (int)SixthEndPointY.Value,
                (int)SeventhStartPointX.Value, (int)SeventhStartPointY.Value, (int)SeventhEndPointX.Value, (int)SeventhEndPointY.Value
                };
            }
            else if (NumberOfCurves.SelectedIndex == 7)
            {
                Coords = new List<int>() {
                (int)FirstStartPointX.Value, (int)FirstStartPointY.Value, (int)FirstEndPointX.Value, (int)FirstEndPointY.Value,
                (int)SecondStartPointX.Value, (int)SecondStartPointY.Value, (int)SecondEndPointX.Value, (int)SecondEndPointY.Value,
                (int)ThirdStartPointX.Value, (int)ThirdStartPointY.Value, (int)ThirdEndPointX.Value, (int)ThirdEndPointY.Value,
                (int)FourthStartPointX.Value, (int)FourthStartPointY.Value, (int)FourthEndPointX.Value, (int)FourthEndPointY.Value,
                (int)FifthStartPointX.Value, (int)FifthStartPointY.Value, (int)FifthEndPointX.Value, (int)FifthEndPointY.Value,
                (int)SixthStartPointX.Value, (int)SixthStartPointY.Value, (int)SixthEndPointX.Value, (int)SixthEndPointY.Value,
                (int)SeventhStartPointX.Value, (int)SeventhStartPointY.Value, (int)SeventhEndPointX.Value, (int)SeventhEndPointY.Value,
                (int)EighthStartPointX.Value, (int)EighthStartPointY.Value, (int)EighthEndPointX.Value, (int)EighthEndPointY.Value
                };
            }

            // obtaining color for colloring
            for (int i = 0; i < Coords.Count / 4; i++)
            {
                indexs.Add((int)((i + 1) * gradientForm.pictureGradient.Width / ((Coords.Count / 4) + 1)));
            }

            CurveDragon Dragon = new CurveDragon(pictureCurveDragon, BackgroundColor);
            CountIterations = (int)(DragonIterations.Value);
            await Task.Run(() => {
                for (int i = 0; i < Coords.Count; i += 4)
                {
                    Dragon.DrawCurveDragon(Coords[i], image.Height - Coords[i + 1], Coords[i + 2], image.Height - Coords[i + 3], CountIterations, new Pen(pixels[indexs[i / 4]].Color, brushWidth));
                }
            });

            end = DateTime.Now;
            CulculationTime.Text = (end - start).TotalMilliseconds.ToString("F2") + " ms";

            image.Image = pictureCurveDragon;
            CreateFractal.Enabled = true;
            FractalsList.Enabled = true;
            image.Cursor = Cursors.Default;
        }

        // selection of the number of dragon curves
        private void NumberOfCurves_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (NumberOfCurves.SelectedIndex == 0)
            {
                FirstStartPointX.Visible = true;
                FirstStartPointY.Visible = true;
                FirstEndPointX.Visible = true;
                FirstEndPointY.Visible = true;

                SecondStartPointX.Visible = false;
                SecondStartPointY.Visible = false;
                SecondEndPointX.Visible = false;
                SecondEndPointY.Visible = false;

                ThirdStartPointX.Visible = false;
                ThirdStartPointY.Visible = false;
                ThirdEndPointX.Visible = false;
                ThirdEndPointY.Visible = false;

                FourthStartPointX.Visible = false;
                FourthStartPointY.Visible = false;
                FourthEndPointX.Visible = false;
                FourthEndPointY.Visible = false;

                FifthStartPointX.Visible = false;
                FifthStartPointY.Visible = false;
                FifthEndPointX.Visible = false;
                FifthEndPointY.Visible = false;

                SixthStartPointX.Visible = false;
                SixthStartPointY.Visible = false;
                SixthEndPointX.Visible = false;
                SixthEndPointY.Visible = false;

                SeventhStartPointX.Visible = false;
                SeventhStartPointY.Visible = false;
                SeventhEndPointX.Visible = false;
                SeventhEndPointY.Visible = false;

                EighthStartPointX.Visible = false;
                EighthStartPointY.Visible = false;
                EighthEndPointX.Visible = false;
                EighthEndPointY.Visible = false;
            }
            else if (NumberOfCurves.SelectedIndex == 1)
            {
                FirstStartPointX.Visible = true;
                FirstStartPointY.Visible = true;
                FirstEndPointX.Visible = true;
                FirstEndPointY.Visible = true;

                SecondStartPointX.Visible = true;
                SecondStartPointY.Visible = true;
                SecondEndPointX.Visible = true;
                SecondEndPointY.Visible = true;

                ThirdStartPointX.Visible = false;
                ThirdStartPointY.Visible = false;
                ThirdEndPointX.Visible = false;
                ThirdEndPointY.Visible = false;

                FourthStartPointX.Visible = false;
                FourthStartPointY.Visible = false;
                FourthEndPointX.Visible = false;
                FourthEndPointY.Visible = false;

                FifthStartPointX.Visible = false;
                FifthStartPointY.Visible = false;
                FifthEndPointX.Visible = false;
                FifthEndPointY.Visible = false;

                SixthStartPointX.Visible = false;
                SixthStartPointY.Visible = false;
                SixthEndPointX.Visible = false;
                SixthEndPointY.Visible = false;

                SeventhStartPointX.Visible = false;
                SeventhStartPointY.Visible = false;
                SeventhEndPointX.Visible = false;
                SeventhEndPointY.Visible = false;

                EighthStartPointX.Visible = false;
                EighthStartPointY.Visible = false;
                EighthEndPointX.Visible = false;
                EighthEndPointY.Visible = false;
            }
            else if (NumberOfCurves.SelectedIndex == 2)
            {
                FirstStartPointX.Visible = true;
                FirstStartPointY.Visible = true;
                FirstEndPointX.Visible = true;
                FirstEndPointY.Visible = true;

                SecondStartPointX.Visible = true;
                SecondStartPointY.Visible = true;
                SecondEndPointX.Visible = true;
                SecondEndPointY.Visible = true;

                ThirdStartPointX.Visible = true;
                ThirdStartPointY.Visible = true;
                ThirdEndPointX.Visible = true;
                ThirdEndPointY.Visible = true;

                FourthStartPointX.Visible = false;
                FourthStartPointY.Visible = false;
                FourthEndPointX.Visible = false;
                FourthEndPointY.Visible = false;

                FifthStartPointX.Visible = false;
                FifthStartPointY.Visible = false;
                FifthEndPointX.Visible = false;
                FifthEndPointY.Visible = false;

                SixthStartPointX.Visible = false;
                SixthStartPointY.Visible = false;
                SixthEndPointX.Visible = false;
                SixthEndPointY.Visible = false;

                SeventhStartPointX.Visible = false;
                SeventhStartPointY.Visible = false;
                SeventhEndPointX.Visible = false;
                SeventhEndPointY.Visible = false;

                EighthStartPointX.Visible = false;
                EighthStartPointY.Visible = false;
                EighthEndPointX.Visible = false;
                EighthEndPointY.Visible = false;
            }
            else if (NumberOfCurves.SelectedIndex == 3)
            {
                FirstStartPointX.Visible = true;
                FirstStartPointY.Visible = true;
                FirstEndPointX.Visible = true;
                FirstEndPointY.Visible = true;

                SecondStartPointX.Visible = true;
                SecondStartPointY.Visible = true;
                SecondEndPointX.Visible = true;
                SecondEndPointY.Visible = true;

                ThirdStartPointX.Visible = true;
                ThirdStartPointY.Visible = true;
                ThirdEndPointX.Visible = true;
                ThirdEndPointY.Visible = true;

                FourthStartPointX.Visible = true;
                FourthStartPointY.Visible = true;
                FourthEndPointX.Visible = true;
                FourthEndPointY.Visible = true;

                FifthStartPointX.Visible = false;
                FifthStartPointY.Visible = false;
                FifthEndPointX.Visible = false;
                FifthEndPointY.Visible = false;

                SixthStartPointX.Visible = false;
                SixthStartPointY.Visible = false;
                SixthEndPointX.Visible = false;
                SixthEndPointY.Visible = false;

                SeventhStartPointX.Visible = false;
                SeventhStartPointY.Visible = false;
                SeventhEndPointX.Visible = false;
                SeventhEndPointY.Visible = false;

                EighthStartPointX.Visible = false;
                EighthStartPointY.Visible = false;
                EighthEndPointX.Visible = false;
                EighthEndPointY.Visible = false;
            }
            else if (NumberOfCurves.SelectedIndex == 4)
            {
                FirstStartPointX.Visible = true;
                FirstStartPointY.Visible = true;
                FirstEndPointX.Visible = true;
                FirstEndPointY.Visible = true;

                SecondStartPointX.Visible = true;
                SecondStartPointY.Visible = true;
                SecondEndPointX.Visible = true;
                SecondEndPointY.Visible = true;

                ThirdStartPointX.Visible = true;
                ThirdStartPointY.Visible = true;
                ThirdEndPointX.Visible = true;
                ThirdEndPointY.Visible = true;

                FourthStartPointX.Visible = true;
                FourthStartPointY.Visible = true;
                FourthEndPointX.Visible = true;
                FourthEndPointY.Visible = true;

                FifthStartPointX.Visible = true;
                FifthStartPointY.Visible = true;
                FifthEndPointX.Visible = true;
                FifthEndPointY.Visible = true;

                SixthStartPointX.Visible = false;
                SixthStartPointY.Visible = false;
                SixthEndPointX.Visible = false;
                SixthEndPointY.Visible = false;

                SeventhStartPointX.Visible = false;
                SeventhStartPointY.Visible = false;
                SeventhEndPointX.Visible = false;
                SeventhEndPointY.Visible = false;

                EighthStartPointX.Visible = false;
                EighthStartPointY.Visible = false;
                EighthEndPointX.Visible = false;
                EighthEndPointY.Visible = false;
            }
            else if (NumberOfCurves.SelectedIndex == 5)
            {
                FirstStartPointX.Visible = true;
                FirstStartPointY.Visible = true;
                FirstEndPointX.Visible = true;
                FirstEndPointY.Visible = true;

                SecondStartPointX.Visible = true;
                SecondStartPointY.Visible = true;
                SecondEndPointX.Visible = true;
                SecondEndPointY.Visible = true;

                ThirdStartPointX.Visible = true;
                ThirdStartPointY.Visible = true;
                ThirdEndPointX.Visible = true;
                ThirdEndPointY.Visible = true;

                FourthStartPointX.Visible = true;
                FourthStartPointY.Visible = true;
                FourthEndPointX.Visible = true;
                FourthEndPointY.Visible = true;

                FifthStartPointX.Visible = true;
                FifthStartPointY.Visible = true;
                FifthEndPointX.Visible = true;
                FifthEndPointY.Visible = true;

                SixthStartPointX.Visible = true;
                SixthStartPointY.Visible = true;
                SixthEndPointX.Visible = true;
                SixthEndPointY.Visible = true;

                SeventhStartPointX.Visible = false;
                SeventhStartPointY.Visible = false;
                SeventhEndPointX.Visible = false;
                SeventhEndPointY.Visible = false;

                EighthStartPointX.Visible = false;
                EighthStartPointY.Visible = false;
                EighthEndPointX.Visible = false;
                EighthEndPointY.Visible = false;
            }
            else if (NumberOfCurves.SelectedIndex == 6)
            {
                FirstStartPointX.Visible = true;
                FirstStartPointY.Visible = true;
                FirstEndPointX.Visible = true;
                FirstEndPointY.Visible = true;

                SecondStartPointX.Visible = true;
                SecondStartPointY.Visible = true;
                SecondEndPointX.Visible = true;
                SecondEndPointY.Visible = true;

                ThirdStartPointX.Visible = true;
                ThirdStartPointY.Visible = true;
                ThirdEndPointX.Visible = true;
                ThirdEndPointY.Visible = true;

                FourthStartPointX.Visible = true;
                FourthStartPointY.Visible = true;
                FourthEndPointX.Visible = true;
                FourthEndPointY.Visible = true;

                FifthStartPointX.Visible = true;
                FifthStartPointY.Visible = true;
                FifthEndPointX.Visible = true;
                FifthEndPointY.Visible = true;

                SixthStartPointX.Visible = true;
                SixthStartPointY.Visible = true;
                SixthEndPointX.Visible = true;
                SixthEndPointY.Visible = true;

                SeventhStartPointX.Visible = true;
                SeventhStartPointY.Visible = true;
                SeventhEndPointX.Visible = true;
                SeventhEndPointY.Visible = true;

                EighthStartPointX.Visible = false;
                EighthStartPointY.Visible = false;
                EighthEndPointX.Visible = false;
                EighthEndPointY.Visible = false;
            }
            else if (NumberOfCurves.SelectedIndex == 7)
            {
                FirstStartPointX.Visible = true;
                FirstStartPointY.Visible = true;
                FirstEndPointX.Visible = true;
                FirstEndPointY.Visible = true;

                SecondStartPointX.Visible = true;
                SecondStartPointY.Visible = true;
                SecondEndPointX.Visible = true;
                SecondEndPointY.Visible = true;

                ThirdStartPointX.Visible = true;
                ThirdStartPointY.Visible = true;
                ThirdEndPointX.Visible = true;
                ThirdEndPointY.Visible = true;

                FourthStartPointX.Visible = true;
                FourthStartPointY.Visible = true;
                FourthEndPointX.Visible = true;
                FourthEndPointY.Visible = true;

                FifthStartPointX.Visible = true;
                FifthStartPointY.Visible = true;
                FifthEndPointX.Visible = true;
                FifthEndPointY.Visible = true;

                SixthStartPointX.Visible = true;
                SixthStartPointY.Visible = true;
                SixthEndPointX.Visible = true;
                SixthEndPointY.Visible = true;

                SeventhStartPointX.Visible = true;
                SeventhStartPointY.Visible = true;
                SeventhEndPointX.Visible = true;
                SeventhEndPointY.Visible = true;

                EighthStartPointX.Visible = true;
                EighthStartPointY.Visible = true;
                EighthEndPointX.Visible = true;
                EighthEndPointY.Visible = true;
            }
        }


        /// 
        /// 
        ///     Gradient
        /// 
        /// 

        // getting gradient pixels 
        private List<Pixel> GetPixels(Bitmap bitmap)
        {
            List<Pixel> pixels = new List<Pixel>(bitmap.Width);
            for (int x = 0; x < bitmap.Width; x++)
            {
                pixels.Add(new Pixel()
                {
                    Color = bitmap.GetPixel(x, bitmap.Height / 2) // отримання кольору ряду пікселів з градієнту
                });
            }

            return pixels;
        }

        // creating a gradient
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
