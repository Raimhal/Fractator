using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;
using FractalClasses;
using HelperClasses;


namespace FractalsCreator
{
    public partial class FractalForm : Form
    {

        ///
        ///
        ///     Start values
        ///
        ///

        internal Graphics g;
        internal Color BackgroundColor = Color.Transparent;
        internal List<Pixel> pixels;
        internal readonly GradientForm gradientForm;

        // start values for MBrot
        internal double hx, hy, maxZ, x_, y_;
        internal double ZoomVal = 1;

        internal Size size;
        internal double SizeArea;

        internal DateTime start, end;

        internal int selectFractal = 0;

        // start values for fractal tree
        internal List<NumericUpDown> Angles;

        // start values for curve dragon
        internal List<List<NumericUpDown>> Points;

        // list of the changing values
        internal readonly List<NumericUpDown> changingValues;
        NumericUpDown change;

        // information about fractals;
        internal Fractals info;

        // FractalForm FullScreen settings
        internal bool FullScreen = false;


        ///
        ///
        ///     Main form properties
        ///
        ///

        public FractalForm()
        {
            InitializeComponent();
            TopMost = false;
            
            CultureInfo customCulture = (CultureInfo)
                Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            Thread.CurrentThread.CurrentCulture = customCulture;

            image.Image = new Bitmap(image.Width, image.Height);
            size = image.Size;
            g = Graphics.FromImage(image.Image);
            this.DoubleBuffered = true;
            gradientForm = new GradientForm();
            // list of the curves dragon points
            Points = new List<List<NumericUpDown>>()
            {
                new List<NumericUpDown>{ FirstStartPointX, FirstStartPointY, FirstEndPointX, FirstEndPointY },
                new List<NumericUpDown>{ SecondStartPointX, SecondStartPointY, SecondEndPointX, SecondEndPointY },
                new List<NumericUpDown>{ ThirdStartPointX, ThirdStartPointY, ThirdEndPointX, ThirdEndPointY },
                new List<NumericUpDown>{ FourthStartPointX, FourthStartPointY, FourthEndPointX, FourthEndPointY },
                new List<NumericUpDown>{ FifthStartPointX, FifthStartPointY, FifthEndPointX, FifthEndPointY },
                new List<NumericUpDown>{ SixthStartPointX, SixthStartPointY, SixthEndPointX, SixthEndPointY },
                new List<NumericUpDown>{ SeventhStartPointX, SeventhStartPointY, SeventhEndPointX, SeventhEndPointY },
                new List<NumericUpDown>{ EighthStartPointX, EighthStartPointY, EighthEndPointX, EighthEndPointY }
            };

            // list of the angles
            Angles = new List<NumericUpDown> {
                FirstAngle, SecondAngle, ThirdAngle, FourthAngle
            };

            // list of the changing values
            changingValues = new List<NumericUpDown>
            {
                Iterations, BranchLength, NumberPoints, DragonIterations
            };

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            FractalsList.SelectedIndex = 0;
            ShowImageHeight.Value = image.Height;
            ShowImageWidth.Value = image.Width;



            // change the coordinates of the elements
            for (int i = 1; i < Angles.Count; i++)
            {
                if (i == 1)
                {
                    Angles[i].Location = new Point(Angles[i - 1].Location.X + 132, Angles[i - 1].Location.Y);
                }
                else
                {
                    Angles[i].Location = new Point(Angles[i - 2].Location.X, Angles[i - 2].Location.Y + 35);
                }
            }

            labelNumberOfCurves.Location = labelZOOM.Location;
            NumberOfCurves.Location = new Point(labelNumberOfCurves.Location.X + labelNumberOfCurves.Width + 30, labelNumberOfCurves.Location.Y);

            LabelBranchLength.Location = labelZOOM.Location;
            BranchLength.Location = ZOOMValue.Location;

            labelStartX.Location = y.Location;
            labelStartY.Location = LabelMaxZDegreeTwo.Location;

            labelBranchWidth.Location = labelIterations.Location;
            BranchWidth.Location = Iterations.Location;

            StartX.Location = CenterY.Location;
            StartY.Location = MaxZDegreeTwo.Location;

            labelHorizontal.Location = y.Location;
            Horizontal.Location = CenterY.Location;

            labelVertical.Location = LabelMaxZDegreeTwo.Location;
            Vertical.Location = MaxZDegreeTwo.Location;

            labelNumberPoints.Location = labelIterations.Location;
            NumberPoints.Location = Iterations.Location;

            labelStartPoint.Location = new Point(labelNumberOfCurves.Location.X, labelNumberOfCurves.Location.Y + 28);
            labelEndPoint.Location = new Point(labelStartPoint.Location.X + labelStartPoint.Width + 30, labelStartPoint.Location.Y);

            labelStartPointX.Location = new Point(labelStartPoint.Location.X, labelStartPoint.Location.Y + 23);
            labelStartPointY.Location = new Point(labelStartPointX.Location.X + labelStartPointX.Width + 25, labelStartPointX.Location.Y);
            labelEndPointX.Location = new Point(labelEndPoint.Location.X, labelEndPoint.Location.Y + 23);
            labelEndPointY.Location = new Point(labelEndPointX.Location.X + labelEndPointX.Width + 25, labelEndPointX.Location.Y);

            FirstStartPointX.Location = new Point(labelStartPointX.Location.X, labelStartPointX.Location.Y + 23);
            FirstStartPointY.Location = new Point(labelStartPointY.Location.X + 5, labelStartPointY.Location.Y + 23);
            FirstEndPointX.Location = new Point(labelEndPointX.Location.X, labelEndPointX.Location.Y + 23);
            FirstEndPointY.Location = new Point(labelEndPointY.Location.X + 5, labelEndPointY.Location.Y + 23);

            for (int i = 1; i < Points.Count; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Points[i][j].Location = new Point(Points[i - 1][j].Location.X, Points[i - 1][j].Location.Y + 28);
                }
            }

            labelDragonBrashWidth.Location = LabelMaxZDegreeTwo.Location;
            DragonBrashWidth.Location = MaxZDegreeTwo.Location;

            labelDragonIterations.Location = labelIterations.Location;
            DragonIterations.Location = Iterations.Location;

        }
        private void FractalForm_Resize(object sender, EventArgs e)
        {
            if (FractalsList.SelectedIndex == 1)
            {
                if (StartX.Value > StartX.Minimum && StartX.Value < StartX.Maximum) { StartX.Value += (image.Width - size.Width) / 2; };
                if (StartY.Value > StartY.Minimum && StartY.Value < StartY.Maximum) { StartY.Value += (image.Height - size.Height) / 2; };
            }
            else if (FractalsList.SelectedIndex == 3)
            {
                for (int i = 0; i < Points.Count; i++)
                {
                    for (int j = 0; j < Points[i].Count; j++)
                    {
                        if (Points[i][j].Value > Points[i][j].Minimum && Points[i][j].Value < Points[i][j].Maximum)
                        {
                            if (j % 2 == 0)
                            {
                                Points[i][j].Value += (image.Width - size.Width) / 2;
                            }
                            else
                            {
                                Points[i][j].Value += (image.Height - size.Height) / 2;
                            }
                        }
                    }
                }
            }


            if (FractalsList.SelectedIndex != 0)
            {
                if (BackgroundColor == Color.Transparent)
                {
                    image.BackColor = Color.White;
                }
                else
                {
                    image.BackColor = BackgroundColor;
                }
            }
            size = image.Size;
            ShowImageHeight.Value = image.Height;
            ShowImageWidth.Value = image.Width;


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
            if (Progress.Value == Progress.Maximum)
            {
                change = changingValues[FractalsList.SelectedIndex];

                // save as
                if (e.Control && e.Shift && e.KeyCode == Keys.S)
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
                    GenerateGradientToolStripMenuItem.PerformClick();
                }
                // create or update fractal
                else if (e.Control && e.Shift && e.KeyCode == Keys.F)
                {
                    if (tabControl.SelectedIndex == 2)
                    {
                        ButtonUpdate.PerformClick();
                    }
                    else
                    {
                        CreateFractal.PerformClick();
                    }
                }
                // previous fractal
                else if (e.Shift && e.KeyCode == Keys.D1)
                {
                    PreviousFractalToolStripMenuItem.PerformClick();
                }
                // next fractal
                else if (e.Shift && e.KeyCode == Keys.D2)
                {
                    NextFractalToolStripMenuItem.PerformClick();
                }
                // Open GradientForm
                else if (e.Control && e.Shift && e.KeyCode == Keys.X)
                {
                    GradientToolMenuItem.PerformClick();
                }
                else if (e.KeyCode == Keys.Oemplus && e.Shift)
                {
                    IncreaseToolStripMenuItem.PerformClick();
                }
                else if (e.KeyCode == Keys.OemMinus && e.Shift)
                {
                    DecreaseToolStripMenuItem.PerformClick();
                }
                // control keys
                else if (FractalsList.SelectedIndex == 0)
                {
                    if (e.Shift && e.KeyCode == Keys.Q)
                    {
                        IncreaseTheZoomValueToolStripMenuItem.PerformClick();
                    }
                    else if (e.Shift && e.KeyCode == Keys.E)
                    {
                        DecreaseTheZoomValueToolStripMenuItem.PerformClick();
                    }
                    else if (e.KeyCode == Keys.Q)
                    {
                        IncreaseZOOM.PerformClick();
                    }
                    else if (e.KeyCode == Keys.E)
                    {
                        DecreaseZOOM.PerformClick();
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
                await Task.Run(() => {

                    gradientForm.ShowDialog();
                    gradientForm.Focus();

                });
            }

        }

        // Generate Gradient
        private void GenerateGradientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gradientForm.Gradient(gradientForm.pictureGradient);
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
            change = changingValues[FractalsList.SelectedIndex];

            if (change.Value < change.Maximum)
            {
                change.Value += change.Increment;
            }
        }

        // decrease the most impotant value
        private void DecreaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            change = changingValues[FractalsList.SelectedIndex];

            if (change.Value > change.Minimum)
            {
                change.Value -= change.Increment;
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

        // FullScreen control
        private void FractalForm_SizeChanged(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Maximized)
            {
                CreateFractal.PerformClick();
                FullScreen = true;
            }
            else if (this.WindowState == FormWindowState.Normal && FullScreen != false)
            {
                FullScreen = false;
                CreateFractal.PerformClick();
            }
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
                    MessageBox.Show("Gradient loaded successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Image size is too small!\nMinimum image width : {minimumImageWidth}\nCurrent width: {isSufficientSize.Width}", "Warning! Image size is too small", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        MessageBox.Show("Fractal saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Image can't be saved!!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            PointsVisibleTrue(Points);
            AnglesVisibleTrue(Angles);

            FractalsInfo.Text = null;
            CulculationTime.Text = null;
            IncreaseToolStripMenuItem.Text = null;
            DecreaseToolStripMenuItem.Text = null;

            Progress.Step = 1;

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
            BranchLength.Visible = false;

            labelMinimalLength.Visible = false;
            MinBranchLength.Visible = false;

            labelStartX.Visible = false;
            labelStartY.Visible = false;

            StartX.Visible = false;
            StartY.Visible = false;

            labelBranchWidth.Visible = false;
            BranchWidth.Visible = false;

            labelAngles.Visible = false;
            NumberOfAngles.Visible = false;



            labelBackColor.Visible = false;
            ColorButton.Visible = false;


            labelIterations.Visible = false;
            Iterations.Visible = false;


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

            labelDragonBrashWidth.Visible = false;
            DragonBrashWidth.Visible = false;

            labelDragonIterations.Visible = false;
            DragonIterations.Visible = false;

            GroupMouseControl.Visible = false;

            zoomInMBrotToolStripMenuItem.Visible = false;
            zoomOutMBrotToolStripMenuItem.Visible = false;
            IncreaseTheZoomValueToolStripMenuItem.Visible = false;
            DecreaseTheZoomValueToolStripMenuItem.Visible = false;

            BackgroundColor = Color.Transparent;
            ColorButton.BackColor = Color.White;


            if (FractalsList.SelectedIndex == 0)
            {
                info = new MBrotSet();
                info.Info(FractalsInfo); // add info about the Mandelbrot set
                hx = -0.6;
                hy = 0;
                maxZ = 4;
                CenterX.Text = hx.ToString();
                CenterY.Text = hy.ToString();
                MaxZDegreeTwo.Text = maxZ.ToString();
                ZoomVal = 1;
                SizeArea = 4;

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

                labelIterations.Visible = true;
                Iterations.Visible = true;

                GroupMouseControl.Visible = true;

                IncreaseToolStripMenuItem.Text = "Increase the value of the max iterations";
                DecreaseToolStripMenuItem.Text = "Decrease the value of the max iterations";

                zoomInMBrotToolStripMenuItem.Visible = true;
                zoomOutMBrotToolStripMenuItem.Visible = true;
                IncreaseTheZoomValueToolStripMenuItem.Visible = true;
                DecreaseTheZoomValueToolStripMenuItem.Visible = true;

            }
            else if (FractalsList.SelectedIndex == 1)
            {
                info = new FractalTree();
                info.Info(FractalsInfo); // add info about the fractal tree

                NumberOfAngles.SelectedIndex = 1;
                StartX.Value = image.Width / 2;
                StartY.Value = image.Height / 5;

                labelBackColor.Location = x.Location;
                ColorButton.Location = CenterX.Location;

                LabelBranchLength.Visible = true;
                BranchLength.Visible = true;

                labelMinimalLength.Visible = true;
                MinBranchLength.Visible = true;

                labelStartX.Visible = true;
                labelStartY.Visible = true;


                labelBranchWidth.Visible = true;
                BranchWidth.Visible = true;

                StartX.Visible = true;
                StartY.Visible = true;

                labelAngles.Visible = true;
                NumberOfAngles.Visible = true;

                AnglesVisibleTrue(Angles, NumberOfAngles.SelectedIndex);

                labelBackColor.Visible = true;
                ColorButton.Visible = true;

                IncreaseToolStripMenuItem.Text = "Increase the value of the branch length";
                DecreaseToolStripMenuItem.Text = "Decrease the value of the branch length";
            }
            else if (FractalsList.SelectedIndex == 2)
            {
                info = new Barnsley_fern();
                info.Info(FractalsInfo); // add info about the Barnsley fern

                labelBackColor.Location = x.Location;
                ColorButton.Location = CenterX.Location;

                labelBackColor.Visible = true;
                ColorButton.Visible = true;

                labelHorizontal.Visible = true;
                Horizontal.Visible = true;

                labelVertical.Visible = true;
                Vertical.Visible = true;

                labelNumberPoints.Visible = true;
                NumberPoints.Visible = true;

                IncreaseToolStripMenuItem.Text = "Increase the value of the Numbers points";
                DecreaseToolStripMenuItem.Text = "Decrease the value of the Numbers points";
            }
            else if (FractalsList.SelectedIndex == 3)
            {
                info = new CurveDragon();
                info.Info(FractalsInfo); // add info about the curve of dragon

                NumberOfCurves.SelectedIndex = 3;
                PointsVisibleTrue(Points, NumberOfCurves.SelectedIndex);

                // start point of the dragon curves
                for (int i = 0; i < Points.Count; i++)
                {
                    if (i == 0)
                    {
                        Points[i][0].Value = image.Width / 2;
                        Points[i][1].Value = image.Height / 2;
                        Points[i][2].Value = image.Width / 2 - 300;
                        Points[i][3].Value = image.Height / 2 - 200;
                    }
                    else
                    {
                        Points[i][0].Value = Points[i - 1][0].Value;
                        Points[i][1].Value = Points[i - 1][1].Value;
                        Points[i][2].Value = Points[i - 1][2].Value - 200;
                        Points[i][3].Value = Points[i - 1][3].Value - 300;
                    }

                }
                labelBackColor.Visible = true;
                labelBackColor.Location = y.Location;

                ColorButton.Visible = true;
                ColorButton.Location = CenterY.Location;

                Progress.Visible = true;

                labelNumberOfCurves.Visible = true;
                NumberOfCurves.Visible = true;

                labelStartPoint.Visible = true;
                labelEndPoint.Visible = true;

                labelStartPointX.Visible = true;
                labelStartPointY.Visible = true;
                labelEndPointX.Visible = true;
                labelEndPointY.Visible = true;

                labelDragonBrashWidth.Visible = true;
                DragonBrashWidth.Visible = true;

                labelDragonIterations.Visible = true;
                DragonIterations.Visible = true;


                IncreaseToolStripMenuItem.Text = "Increase the value of the Numbers points";
                DecreaseToolStripMenuItem.Text = "Decrease the value of the Numbers points";
            }
            DrawFractals();
        }

        // button for generating a fractal
        private void GenerateFractal_Click(object sender, EventArgs e)
        {
            DrawFractals();
        }

        // drawing Fractals
        internal void DrawFractals()
        {
            Progress.Invoke(new Action(() => {
                Progress.Minimum = 0;
                Progress.Value = Progress.Minimum;
            }));

            pixels = gradientForm.GetPixels((Bitmap)gradientForm.pictureGradient.Image);
            size = image.Size;
            if(FractalsList.SelectedIndex != 0)
            {
                image.Image = null;
            }
            if (FractalsList.SelectedIndex == 0)
            {
                bool er_x, er_y, er_z;
                ZoomNUM.Text = ZoomVal.ToString("F0") + " X";
                ZoomNUM.Visible = true;
                image.Enabled = true;
                DecreaseZOOM.Enabled = true;
                IncreaseZOOM.Enabled = true;

                CenterX.ForeColor = Color.Black;
                CenterY.ForeColor = Color.Black;
                MaxZDegreeTwo.ForeColor = Color.Black;
                er_x = double.TryParse(CenterX.Text, out hx);
                er_y = double.TryParse(CenterY.Text, out hy);
                er_z = double.TryParse(MaxZDegreeTwo.Text, out maxZ);

                if (!er_x)
                {
                    CenterX.ForeColor = Color.Red;
                    MessageBox.Show("Error entering value x!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (!er_y)
                {
                    CenterY.ForeColor = Color.Red;
                    MessageBox.Show("Error entering value y!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (!er_z)
                {
                    MaxZDegreeTwo.ForeColor = Color.Red;
                    MessageBox.Show("Error entering value max |z| ^ 2!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    DrawMBrot();
                }
            }
            else if (FractalsList.SelectedIndex == 1)
            {
                DrawFractalTree();
            }
            else if (FractalsList.SelectedIndex == 2)
            {
                DrawBarnsleyFern();
            }
            else if (FractalsList.SelectedIndex == 3)
            {
                DrawCurveDragon();

            }

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
            FractalsList.Enabled = false;   ///

            start = DateTime.Now;
            ZoomNUM.Width = ZoomNUM.Text.Length * 8 + 70;

            image.Invalidate();
            pixels = gradientForm.GetPixels((Bitmap)gradientForm.pictureGradient.Image);
            Bitmap pictureMBrotSet = new Bitmap(image.Width, image.Height);
            MBrotSet MBrotSet = new MBrotSet((Bitmap)pictureMBrotSet, pixels, size, gradientForm.pictureGradient, (int)Iterations.Value);

            await Task.Run(() =>
            {
                pictureMBrotSet = MBrotSet.CalculationMBrot(hx, hy, x_, y_, maxZ, SizeArea, Progress);
                image.Image = pictureMBrotSet;
            });

            end = DateTime.Now;
            CulculationTime.Text = (end - start).TotalMilliseconds.ToString("F2") + " ms";

            image.Enabled = true;           ///
            IncreaseZOOM.Enabled = true;    ///
            DecreaseZOOM.Enabled = true;    /// added access to change the image
            CreateFractal.Enabled = true;   ///
            FractalsList.Enabled = true;    ///
            image.Cursor = Cursors.Default;
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
            DrawFractals();
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
            DrawFractals();
        }
        private void Image_MouseClick(object sender, MouseEventArgs e)
        {
            size = image.Size;
            int X = e.X, Y = e.Y;
            if (FractalsList.SelectedIndex == 0)
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
                    DrawFractals();


                }
                else if (e.Button == MouseButtons.Middle) // back to default
                {                
                    SizeArea = 4;
                    hx = -0.6;
                    hy = 0;
                    CenterX.Text = hx.ToString();
                    CenterY.Text = hy.ToString();
                    ZoomVal = 1;
                    ZoomNUM.Clear();
                    ZoomNUM.Width = 80;
                    ZoomNUM.Text = ZoomVal.ToString("F2") + " X";
                    DrawFractals();

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
                    DrawFractals();
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
            AnglesVisibleTrue(Angles);
            AnglesVisibleTrue(Angles, NumberOfAngles.SelectedIndex);
        }

        // Draw fractal tree
        private async void DrawFractalTree()
        {
            image.Cursor = Cursors.WaitCursor;
            FractalsList.Enabled = false;
            CreateFractal.Enabled = false;
            start = DateTime.Now;
            image.Invalidate();

            Bitmap pictureTree = new Bitmap(image.Width, image.Height);
            int branchLength = (int)BranchLength.Value;

            double[] angles = new double[NumberOfAngles.SelectedIndex + 1];

            for (int i = 0; i < angles.Length; i++)
            {
                angles[i] = (double)Angles[i].Value;
            }


            FractalTree tree = new FractalTree(pictureTree, pixels, angles, (int)(MinBranchLength.Value), (int)(BranchWidth.Value), BackgroundColor);
            await Task.Run(() =>
            {
                tree.DrawFractalTree((int)(StartX.Value), (int)(StartY.Value), branchLength, 0, Progress);
                image.Image = pictureTree;

            });

            if (NumberOfAngles.SelectedIndex == 0)
            {
                Progress.Maximum = 10;
            }
            Progress.Value = Progress.Maximum;

            end = DateTime.Now;
            CulculationTime.Text = (end - start).TotalMilliseconds.ToString("F2") + " ms";

            CreateFractal.Enabled = true;
            FractalsList.Enabled = true;
            image.Cursor = Cursors.Default;
        }

        // changing the number of visible branches
        private void AnglesVisibleTrue(List<NumericUpDown> Angles, int endIndex = -1)
        {
            if (endIndex == -1)
            {
                for (int i = 0; i < Angles.Count; i++)
                {
                    Angles[i].Visible = false;
                }
            }
            else
            {
                for (int i = 0; i <= endIndex; i++)
                {
                    Angles[i].Visible = true;
                }
            }

        }


        // calculation of the changing mininum value of the branch length
        private void BranchLength_ValueChanged(object sender, EventArgs e)
        {
            if (NumberOfAngles.SelectedIndex == 3)
            {
                MinBranchLength.Minimum = (int)(Math.Floor(BranchLength.Value / 40));

            }
            else if (NumberOfAngles.SelectedIndex == 2)
            {
                MinBranchLength.Minimum = (int)(Math.Floor(BranchLength.Value / 60));
            }
            else
            {
                MinBranchLength.Minimum = (int)(Math.Floor((double)BranchLength.Value * 0.005)) + 1;
            }

            if (MinBranchLength.Value < MinBranchLength.Minimum)
            {
                MinBranchLength.Value = MinBranchLength.Minimum;
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
            await Task.Run(() =>
            {
                pictureFern = Fern.DrawBransleyFern(Progress);
                image.Image = pictureFern;
            });

            end = DateTime.Now;
            CulculationTime.Text = (end - start).TotalMilliseconds.ToString("F2") + " ms";

            CreateFractal.Enabled = true;
            FractalsList.Enabled = true;
            image.Cursor = Cursors.Default;
        }


        /// 
        /// 
        ///     Dragon curve
        /// 
        /// 

        // Draw dragon curve
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

            List<int> indexes = new List<int>();
            List<List<int>> Coords = new List<List<int>>();
            List<int> coordinates;

            for (int i = 0; i <= NumberOfCurves.SelectedIndex; i++)
            {
                coordinates = new List<int>();
                for (int j = 0; j < Points[i].Count; j++)
                {
                    coordinates.Add((int)Points[i][j].Value);
                }
                Coords.Add(coordinates);

            }



            // obtaining color for colloring
            for (int i = 0; i < Coords.Count; i++)
            {
                indexes.Add((int)((i + 1) * gradientForm.pictureGradient.Image.Width / (Coords.Count + 1)));
            }

            CurveDragon Dragon = new CurveDragon(pictureCurveDragon, BackgroundColor);
            CountIterations = (int)(DragonIterations.Value);
            //Progress.Maximum = 0;
            //for (int i = CountIterations; i >= 0; i--)
            //{
            //    Progress.Maximum += (int)Math.Pow(2, i);
            //}
            //Progress.Maximum *= (Coords.Count);

            await Task.Run(() => {
                for (int i = 0; i < Coords.Count; i++)
                {
                    Dragon.DrawCurveDragon(Coords[i][0], image.Height - Coords[i][1], Coords[i][2], image.Height - Coords[i][3], CountIterations, new Pen(pixels[indexes[i]].Color, brushWidth), Progress);
                }
                image.Image = pictureCurveDragon;
                Progress.Invoke(new Action(() =>
                {
                    Progress.Value = Progress.Maximum;
                }));
            });

            

            end = DateTime.Now;
            CulculationTime.Text = (end - start).TotalMilliseconds.ToString("F2") + " ms";

            CreateFractal.Enabled = true;
            FractalsList.Enabled = true;
            image.Cursor = Cursors.Default;
        }

        // selection of the number of dragon curves
        private void NumberOfCurves_SelectedIndexChanged(object sender, EventArgs e)
        {

            PointsVisibleTrue(Points);
            PointsVisibleTrue(Points, NumberOfCurves.SelectedIndex);
        }

        // changing the number of visible curves
        internal void PointsVisibleTrue(List<List<NumericUpDown>> Points, int endIndex = -1)
        {
            if (endIndex == -1)
            {
                for (int i = 0; i < Points.Count; i++)
                {
                    for (int j = 0; j < Points[i].Count; j++)
                    {
                        Points[i][j].Visible = false;
                    }

                }
            }
            else
            {
                for (int i = 0; i <= endIndex; i++)
                {
                    for (int j = 0; j < Points[i].Count; j++)
                    {
                        Points[i][j].Visible = true;
                    }

                }
            }
        }


        ~FractalForm()
        {
            Console.WriteLine("Class FractalForm is clear");
        }
    }
}
