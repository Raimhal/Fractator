namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CreateFractal = new System.Windows.Forms.Button();
            this.ZOOMValue = new System.Windows.Forms.NumericUpDown();
            this.Iterations = new System.Windows.Forms.NumericUpDown();
            this.labelIterations = new System.Windows.Forms.Label();
            this.labelZOOM = new System.Windows.Forms.Label();
            this.ZoomNUM = new System.Windows.Forms.TextBox();
            this.CenterX = new System.Windows.Forms.MaskedTextBox();
            this.CenterY = new System.Windows.Forms.MaskedTextBox();
            this.x = new System.Windows.Forms.Label();
            this.y = new System.Windows.Forms.Label();
            this.LabelMaxZDegreeTwo = new System.Windows.Forms.Label();
            this.MaxZDegreeTwo = new System.Windows.Forms.MaskedTextBox();
            this.SplitImageAndInterface = new System.Windows.Forms.SplitContainer();
            this.Grad = new System.Windows.Forms.PictureBox();
            this.image = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.FractalProperties = new System.Windows.Forms.TabPage();
            this.DecreaseZOOM = new System.Windows.Forms.Button();
            this.DragonIterations = new System.Windows.Forms.NumericUpDown();
            this.labelDragonIterations = new System.Windows.Forms.Label();
            this.NumberOfAngles = new System.Windows.Forms.ComboBox();
            this.FractalsList = new System.Windows.Forms.ComboBox();
            this.DragonBrashWidth = new System.Windows.Forms.NumericUpDown();
            this.labelDragonBrashWidth = new System.Windows.Forms.Label();
            this.FifthEndPointY = new System.Windows.Forms.NumericUpDown();
            this.FifthStartPointY = new System.Windows.Forms.NumericUpDown();
            this.FifthStartPointX = new System.Windows.Forms.NumericUpDown();
            this.FifthEndPointX = new System.Windows.Forms.NumericUpDown();
            this.SixthStartPointY = new System.Windows.Forms.NumericUpDown();
            this.SixthEndPointY = new System.Windows.Forms.NumericUpDown();
            this.SeventhStartPointY = new System.Windows.Forms.NumericUpDown();
            this.SeventhEndPointY = new System.Windows.Forms.NumericUpDown();
            this.SixthStartPointX = new System.Windows.Forms.NumericUpDown();
            this.SixthEndPointX = new System.Windows.Forms.NumericUpDown();
            this.SeventhEndPointX = new System.Windows.Forms.NumericUpDown();
            this.SeventhStartPointX = new System.Windows.Forms.NumericUpDown();
            this.EighthEndPointY = new System.Windows.Forms.NumericUpDown();
            this.EighthEndPointX = new System.Windows.Forms.NumericUpDown();
            this.EighthStartPointY = new System.Windows.Forms.NumericUpDown();
            this.EighthStartPointX = new System.Windows.Forms.NumericUpDown();
            this.FourthEndPointY = new System.Windows.Forms.NumericUpDown();
            this.FourthStartPointY = new System.Windows.Forms.NumericUpDown();
            this.FourthStartPointX = new System.Windows.Forms.NumericUpDown();
            this.FourthEndPointX = new System.Windows.Forms.NumericUpDown();
            this.ThirdStartPointY = new System.Windows.Forms.NumericUpDown();
            this.ThirdEndPointY = new System.Windows.Forms.NumericUpDown();
            this.SecondStartPointY = new System.Windows.Forms.NumericUpDown();
            this.SecondEndPointY = new System.Windows.Forms.NumericUpDown();
            this.ThirdStartPointX = new System.Windows.Forms.NumericUpDown();
            this.ThirdEndPointX = new System.Windows.Forms.NumericUpDown();
            this.SecondEndPointX = new System.Windows.Forms.NumericUpDown();
            this.SecondStartPointX = new System.Windows.Forms.NumericUpDown();
            this.FirstEndPointY = new System.Windows.Forms.NumericUpDown();
            this.FirstEndPointX = new System.Windows.Forms.NumericUpDown();
            this.FirstStartPointY = new System.Windows.Forms.NumericUpDown();
            this.FirstStartPointX = new System.Windows.Forms.NumericUpDown();
            this.labelEndPointX = new System.Windows.Forms.Label();
            this.labelEndPointY = new System.Windows.Forms.Label();
            this.labelStartPointY = new System.Windows.Forms.Label();
            this.labelStartPointX = new System.Windows.Forms.Label();
            this.labelEndPoint = new System.Windows.Forms.Label();
            this.labelStartPoint = new System.Windows.Forms.Label();
            this.NumberOfCurves = new System.Windows.Forms.ComboBox();
            this.labelNumberOfCurves = new System.Windows.Forms.Label();
            this.labelNumberPoints = new System.Windows.Forms.Label();
            this.NumberPoints = new System.Windows.Forms.NumericUpDown();
            this.Horizontal = new System.Windows.Forms.NumericUpDown();
            this.Vertical = new System.Windows.Forms.NumericUpDown();
            this.labelHorizontal = new System.Windows.Forms.Label();
            this.labelVertical = new System.Windows.Forms.Label();
            this.ColorButton = new System.Windows.Forms.Button();
            this.labelBackColor = new System.Windows.Forms.Label();
            this.BranchWidth = new System.Windows.Forms.NumericUpDown();
            this.labelBranchWidth = new System.Windows.Forms.Label();
            this.MinBranchLenght = new System.Windows.Forms.NumericUpDown();
            this.labelMinimalLength = new System.Windows.Forms.Label();
            this.LabelBranchLength = new System.Windows.Forms.Label();
            this.labelStartY = new System.Windows.Forms.Label();
            this.labelStartX = new System.Windows.Forms.Label();
            this.FourthAngle = new System.Windows.Forms.NumericUpDown();
            this.StartY = new System.Windows.Forms.NumericUpDown();
            this.SecondAngle = new System.Windows.Forms.NumericUpDown();
            this.ThirdAngle = new System.Windows.Forms.NumericUpDown();
            this.StartX = new System.Windows.Forms.NumericUpDown();
            this.BranchLenght = new System.Windows.Forms.NumericUpDown();
            this.FirstAngle = new System.Windows.Forms.NumericUpDown();
            this.labelAngles = new System.Windows.Forms.Label();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.CulculationTime = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.IncreaseZOOM = new System.Windows.Forms.Button();
            this.Details = new System.Windows.Forms.TabPage();
            this.TextAngles = new System.Windows.Forms.TextBox();
            this.RandomGradientButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ZOOMValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitImageAndInterface)).BeginInit();
            this.SplitImageAndInterface.Panel1.SuspendLayout();
            this.SplitImageAndInterface.Panel2.SuspendLayout();
            this.SplitImageAndInterface.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.tabControl.SuspendLayout();
            this.FractalProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DragonIterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DragonBrashWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FifthEndPointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FifthStartPointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FifthStartPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FifthEndPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SixthStartPointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SixthEndPointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeventhStartPointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeventhEndPointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SixthStartPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SixthEndPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeventhEndPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeventhStartPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EighthEndPointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EighthEndPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EighthStartPointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EighthStartPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthEndPointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthStartPointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthStartPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthEndPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdStartPointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdEndPointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondStartPointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondEndPointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdStartPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdEndPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondEndPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondStartPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstEndPointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstEndPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstStartPointY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstStartPointX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinBranchLenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchLenght)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstAngle)).BeginInit();
            this.Details.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateFractal
            // 
            this.CreateFractal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateFractal.Cursor = System.Windows.Forms.Cursors.Default;
            this.CreateFractal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateFractal.Location = new System.Drawing.Point(11, 526);
            this.CreateFractal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CreateFractal.Name = "CreateFractal";
            this.CreateFractal.Size = new System.Drawing.Size(192, 52);
            this.CreateFractal.TabIndex = 1;
            this.CreateFractal.Text = "Create fractal";
            this.CreateFractal.UseVisualStyleBackColor = true;
            this.CreateFractal.Click += new System.EventHandler(this.GenerateFractal_Click);
            // 
            // ZOOMValue
            // 
            this.ZOOMValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ZOOMValue.Location = new System.Drawing.Point(10, 69);
            this.ZOOMValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ZOOMValue.Maximum = new decimal(new int[] {
            200,
            0,
            20,
            0});
            this.ZOOMValue.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.ZOOMValue.Name = "ZOOMValue";
            this.ZOOMValue.Size = new System.Drawing.Size(90, 26);
            this.ZOOMValue.TabIndex = 3;
            this.ZOOMValue.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // Iterations
            // 
            this.Iterations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Iterations.Location = new System.Drawing.Point(11, 492);
            this.Iterations.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Iterations.Name = "Iterations";
            this.Iterations.Size = new System.Drawing.Size(110, 26);
            this.Iterations.TabIndex = 5;
            this.Iterations.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelIterations
            // 
            this.labelIterations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIterations.AutoSize = true;
            this.labelIterations.Location = new System.Drawing.Point(7, 469);
            this.labelIterations.Name = "labelIterations";
            this.labelIterations.Size = new System.Drawing.Size(95, 20);
            this.labelIterations.TabIndex = 6;
            this.labelIterations.Text = "Max iterations:";
            // 
            // labelZOOM
            // 
            this.labelZOOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelZOOM.AutoSize = true;
            this.labelZOOM.Location = new System.Drawing.Point(7, 46);
            this.labelZOOM.Name = "labelZOOM";
            this.labelZOOM.Size = new System.Drawing.Size(51, 20);
            this.labelZOOM.TabIndex = 7;
            this.labelZOOM.Text = "ZOOM:";
            // 
            // ZoomNUM
            // 
            this.ZoomNUM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ZoomNUM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ZoomNUM.CausesValidation = false;
            this.ZoomNUM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ZoomNUM.Enabled = false;
            this.ZoomNUM.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZoomNUM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ZoomNUM.Location = new System.Drawing.Point(3, 0);
            this.ZoomNUM.MaximumSize = new System.Drawing.Size(228, 40);
            this.ZoomNUM.Name = "ZoomNUM";
            this.ZoomNUM.ReadOnly = true;
            this.ZoomNUM.Size = new System.Drawing.Size(0, 28);
            this.ZoomNUM.TabIndex = 9;
            this.ZoomNUM.Visible = false;
            // 
            // CenterX
            // 
            this.CenterX.AllowDrop = true;
            this.CenterX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CenterX.Location = new System.Drawing.Point(11, 336);
            this.CenterX.Name = "CenterX";
            this.CenterX.Size = new System.Drawing.Size(192, 26);
            this.CenterX.TabIndex = 10;
            // 
            // CenterY
            // 
            this.CenterY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CenterY.Location = new System.Drawing.Point(11, 388);
            this.CenterY.Name = "CenterY";
            this.CenterY.Size = new System.Drawing.Size(192, 26);
            this.CenterY.TabIndex = 11;
            // 
            // x
            // 
            this.x.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(7, 313);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(63, 20);
            this.x.TabIndex = 12;
            this.x.Text = "Center x:";
            // 
            // y
            // 
            this.y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.y.AutoSize = true;
            this.y.Location = new System.Drawing.Point(7, 365);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(63, 20);
            this.y.TabIndex = 13;
            this.y.Text = "Center y:";
            // 
            // LabelMaxZDegreeTwo
            // 
            this.LabelMaxZDegreeTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelMaxZDegreeTwo.AutoSize = true;
            this.LabelMaxZDegreeTwo.Location = new System.Drawing.Point(7, 417);
            this.LabelMaxZDegreeTwo.Name = "LabelMaxZDegreeTwo";
            this.LabelMaxZDegreeTwo.Size = new System.Drawing.Size(76, 20);
            this.LabelMaxZDegreeTwo.TabIndex = 14;
            this.LabelMaxZDegreeTwo.Text = "max |z| ^ 2:";
            // 
            // MaxZDegreeTwo
            // 
            this.MaxZDegreeTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxZDegreeTwo.Location = new System.Drawing.Point(11, 440);
            this.MaxZDegreeTwo.Name = "MaxZDegreeTwo";
            this.MaxZDegreeTwo.Size = new System.Drawing.Size(192, 26);
            this.MaxZDegreeTwo.TabIndex = 15;
            // 
            // SplitImageAndInterface
            // 
            this.SplitImageAndInterface.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SplitImageAndInterface.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SplitImageAndInterface.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.SplitImageAndInterface.IsSplitterFixed = true;
            this.SplitImageAndInterface.Location = new System.Drawing.Point(0, 24);
            this.SplitImageAndInterface.Name = "SplitImageAndInterface";
            // 
            // SplitImageAndInterface.Panel1
            // 
            this.SplitImageAndInterface.Panel1.Controls.Add(this.ZoomNUM);
            this.SplitImageAndInterface.Panel1.Controls.Add(this.Grad);
            this.SplitImageAndInterface.Panel1.Controls.Add(this.image);
            // 
            // SplitImageAndInterface.Panel2
            // 
            this.SplitImageAndInterface.Panel2.Controls.Add(this.tabControl);
            this.SplitImageAndInterface.Panel2.Controls.Add(this.RandomGradientButton);
            this.SplitImageAndInterface.Size = new System.Drawing.Size(1513, 724);
            this.SplitImageAndInterface.SplitterDistance = 1284;
            this.SplitImageAndInterface.TabIndex = 17;
            // 
            // Grad
            // 
            this.Grad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Grad.BackColor = System.Drawing.Color.Transparent;
            this.Grad.Image = ((System.Drawing.Image)(resources.GetObject("Grad.Image")));
            this.Grad.Location = new System.Drawing.Point(832, 1);
            this.Grad.Name = "Grad";
            this.Grad.Size = new System.Drawing.Size(445, 28);
            this.Grad.TabIndex = 16;
            this.Grad.TabStop = false;
            // 
            // image
            // 
            this.image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.image.Location = new System.Drawing.Point(0, 0);
            this.image.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(1280, 720);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            this.image.MouseClick += new System.Windows.Forms.MouseEventHandler(this.image_MouseClick);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.FractalProperties);
            this.tabControl.Controls.Add(this.Details);
            this.tabControl.Location = new System.Drawing.Point(0, 31);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(221, 689);
            this.tabControl.TabIndex = 17;
            // 
            // FractalProperties
            // 
            this.FractalProperties.Controls.Add(this.DecreaseZOOM);
            this.FractalProperties.Controls.Add(this.DragonIterations);
            this.FractalProperties.Controls.Add(this.labelDragonIterations);
            this.FractalProperties.Controls.Add(this.NumberOfAngles);
            this.FractalProperties.Controls.Add(this.FractalsList);
            this.FractalProperties.Controls.Add(this.DragonBrashWidth);
            this.FractalProperties.Controls.Add(this.labelDragonBrashWidth);
            this.FractalProperties.Controls.Add(this.FifthEndPointY);
            this.FractalProperties.Controls.Add(this.FifthStartPointY);
            this.FractalProperties.Controls.Add(this.FifthStartPointX);
            this.FractalProperties.Controls.Add(this.FifthEndPointX);
            this.FractalProperties.Controls.Add(this.SixthStartPointY);
            this.FractalProperties.Controls.Add(this.SixthEndPointY);
            this.FractalProperties.Controls.Add(this.SeventhStartPointY);
            this.FractalProperties.Controls.Add(this.SeventhEndPointY);
            this.FractalProperties.Controls.Add(this.SixthStartPointX);
            this.FractalProperties.Controls.Add(this.SixthEndPointX);
            this.FractalProperties.Controls.Add(this.SeventhEndPointX);
            this.FractalProperties.Controls.Add(this.SeventhStartPointX);
            this.FractalProperties.Controls.Add(this.EighthEndPointY);
            this.FractalProperties.Controls.Add(this.EighthEndPointX);
            this.FractalProperties.Controls.Add(this.EighthStartPointY);
            this.FractalProperties.Controls.Add(this.EighthStartPointX);
            this.FractalProperties.Controls.Add(this.FourthEndPointY);
            this.FractalProperties.Controls.Add(this.FourthStartPointY);
            this.FractalProperties.Controls.Add(this.FourthStartPointX);
            this.FractalProperties.Controls.Add(this.FourthEndPointX);
            this.FractalProperties.Controls.Add(this.ThirdStartPointY);
            this.FractalProperties.Controls.Add(this.ThirdEndPointY);
            this.FractalProperties.Controls.Add(this.SecondStartPointY);
            this.FractalProperties.Controls.Add(this.SecondEndPointY);
            this.FractalProperties.Controls.Add(this.ThirdStartPointX);
            this.FractalProperties.Controls.Add(this.ThirdEndPointX);
            this.FractalProperties.Controls.Add(this.SecondEndPointX);
            this.FractalProperties.Controls.Add(this.SecondStartPointX);
            this.FractalProperties.Controls.Add(this.FirstEndPointY);
            this.FractalProperties.Controls.Add(this.FirstEndPointX);
            this.FractalProperties.Controls.Add(this.FirstStartPointY);
            this.FractalProperties.Controls.Add(this.FirstStartPointX);
            this.FractalProperties.Controls.Add(this.labelEndPointX);
            this.FractalProperties.Controls.Add(this.labelEndPointY);
            this.FractalProperties.Controls.Add(this.labelStartPointY);
            this.FractalProperties.Controls.Add(this.labelStartPointX);
            this.FractalProperties.Controls.Add(this.labelEndPoint);
            this.FractalProperties.Controls.Add(this.labelStartPoint);
            this.FractalProperties.Controls.Add(this.NumberOfCurves);
            this.FractalProperties.Controls.Add(this.labelNumberOfCurves);
            this.FractalProperties.Controls.Add(this.labelNumberPoints);
            this.FractalProperties.Controls.Add(this.NumberPoints);
            this.FractalProperties.Controls.Add(this.Horizontal);
            this.FractalProperties.Controls.Add(this.Vertical);
            this.FractalProperties.Controls.Add(this.labelHorizontal);
            this.FractalProperties.Controls.Add(this.labelVertical);
            this.FractalProperties.Controls.Add(this.ColorButton);
            this.FractalProperties.Controls.Add(this.labelBackColor);
            this.FractalProperties.Controls.Add(this.BranchWidth);
            this.FractalProperties.Controls.Add(this.labelBranchWidth);
            this.FractalProperties.Controls.Add(this.MinBranchLenght);
            this.FractalProperties.Controls.Add(this.labelMinimalLength);
            this.FractalProperties.Controls.Add(this.LabelBranchLength);
            this.FractalProperties.Controls.Add(this.labelStartY);
            this.FractalProperties.Controls.Add(this.labelStartX);
            this.FractalProperties.Controls.Add(this.FourthAngle);
            this.FractalProperties.Controls.Add(this.StartY);
            this.FractalProperties.Controls.Add(this.SecondAngle);
            this.FractalProperties.Controls.Add(this.ThirdAngle);
            this.FractalProperties.Controls.Add(this.StartX);
            this.FractalProperties.Controls.Add(this.BranchLenght);
            this.FractalProperties.Controls.Add(this.FirstAngle);
            this.FractalProperties.Controls.Add(this.labelAngles);
            this.FractalProperties.Controls.Add(this.Progress);
            this.FractalProperties.Controls.Add(this.CulculationTime);
            this.FractalProperties.Controls.Add(this.labelTime);
            this.FractalProperties.Controls.Add(this.x);
            this.FractalProperties.Controls.Add(this.ZOOMValue);
            this.FractalProperties.Controls.Add(this.CenterX);
            this.FractalProperties.Controls.Add(this.y);
            this.FractalProperties.Controls.Add(this.CenterY);
            this.FractalProperties.Controls.Add(this.LabelMaxZDegreeTwo);
            this.FractalProperties.Controls.Add(this.MaxZDegreeTwo);
            this.FractalProperties.Controls.Add(this.CreateFractal);
            this.FractalProperties.Controls.Add(this.labelZOOM);
            this.FractalProperties.Controls.Add(this.IncreaseZOOM);
            this.FractalProperties.Controls.Add(this.labelIterations);
            this.FractalProperties.Controls.Add(this.Iterations);
            this.FractalProperties.Cursor = System.Windows.Forms.Cursors.Default;
            this.FractalProperties.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FractalProperties.Location = new System.Drawing.Point(4, 29);
            this.FractalProperties.Name = "FractalProperties";
            this.FractalProperties.Padding = new System.Windows.Forms.Padding(3);
            this.FractalProperties.Size = new System.Drawing.Size(213, 656);
            this.FractalProperties.TabIndex = 0;
            this.FractalProperties.Text = "Fractal";
            this.FractalProperties.UseVisualStyleBackColor = true;
            // 
            // DecreaseZOOM
            // 
            this.DecreaseZOOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DecreaseZOOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DecreaseZOOM.Image = ((System.Drawing.Image)(resources.GetObject("DecreaseZOOM.Image")));
            this.DecreaseZOOM.Location = new System.Drawing.Point(144, 65);
            this.DecreaseZOOM.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DecreaseZOOM.Name = "DecreaseZOOM";
            this.DecreaseZOOM.Size = new System.Drawing.Size(32, 33);
            this.DecreaseZOOM.TabIndex = 95;
            this.DecreaseZOOM.UseVisualStyleBackColor = true;
            this.DecreaseZOOM.Click += new System.EventHandler(this.DecreaseZOOM_Click);
            // 
            // DragonIterations
            // 
            this.DragonIterations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DragonIterations.Location = new System.Drawing.Point(76, 269);
            this.DragonIterations.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.DragonIterations.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DragonIterations.Name = "DragonIterations";
            this.DragonIterations.Size = new System.Drawing.Size(110, 26);
            this.DragonIterations.TabIndex = 94;
            this.DragonIterations.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // labelDragonIterations
            // 
            this.labelDragonIterations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDragonIterations.AutoSize = true;
            this.labelDragonIterations.Location = new System.Drawing.Point(66, 194);
            this.labelDragonIterations.Name = "labelDragonIterations";
            this.labelDragonIterations.Size = new System.Drawing.Size(132, 20);
            this.labelDragonIterations.TabIndex = 93;
            this.labelDragonIterations.Text = "Number of iterations:";
            // 
            // NumberOfAngles
            // 
            this.NumberOfAngles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NumberOfAngles.FormattingEnabled = true;
            this.NumberOfAngles.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.NumberOfAngles.Location = new System.Drawing.Point(73, 156);
            this.NumberOfAngles.Name = "NumberOfAngles";
            this.NumberOfAngles.Size = new System.Drawing.Size(103, 28);
            this.NumberOfAngles.TabIndex = 92;
            this.NumberOfAngles.SelectedIndexChanged += new System.EventHandler(this.NumberOfAngles_SelectedIndexChanged);
            // 
            // FractalsList
            // 
            this.FractalsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FractalsList.FormattingEnabled = true;
            this.FractalsList.Items.AddRange(new object[] {
            "Mandelbrot set ",
            "Fractal tree",
            "Fern Barnsley",
            "Curve of dragon"});
            this.FractalsList.Location = new System.Drawing.Point(7, 6);
            this.FractalsList.Name = "FractalsList";
            this.FractalsList.Size = new System.Drawing.Size(192, 28);
            this.FractalsList.TabIndex = 91;
            this.FractalsList.SelectedIndexChanged += new System.EventHandler(this.FractalsList_SelectedIndexChanged);
            // 
            // DragonBrashWidth
            // 
            this.DragonBrashWidth.Location = new System.Drawing.Point(129, 270);
            this.DragonBrashWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.DragonBrashWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.DragonBrashWidth.Name = "DragonBrashWidth";
            this.DragonBrashWidth.Size = new System.Drawing.Size(47, 26);
            this.DragonBrashWidth.TabIndex = 90;
            this.DragonBrashWidth.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelDragonBrashWidth
            // 
            this.labelDragonBrashWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDragonBrashWidth.AutoSize = true;
            this.labelDragonBrashWidth.Location = new System.Drawing.Point(19, 274);
            this.labelDragonBrashWidth.Name = "labelDragonBrashWidth";
            this.labelDragonBrashWidth.Size = new System.Drawing.Size(81, 20);
            this.labelDragonBrashWidth.TabIndex = 89;
            this.labelDragonBrashWidth.Text = "Brush width:";
            // 
            // FifthEndPointY
            // 
            this.FifthEndPointY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FifthEndPointY.Location = new System.Drawing.Point(159, 217);
            this.FifthEndPointY.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.FifthEndPointY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.FifthEndPointY.Name = "FifthEndPointY";
            this.FifthEndPointY.Size = new System.Drawing.Size(40, 26);
            this.FifthEndPointY.TabIndex = 88;
            this.FifthEndPointY.Value = new decimal(new int[] {
            960,
            0,
            0,
            0});
            // 
            // FifthStartPointY
            // 
            this.FifthStartPointY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FifthStartPointY.Location = new System.Drawing.Point(63, 217);
            this.FifthStartPointY.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.FifthStartPointY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.FifthStartPointY.Name = "FifthStartPointY";
            this.FifthStartPointY.Size = new System.Drawing.Size(40, 26);
            this.FifthStartPointY.TabIndex = 87;
            this.FifthStartPointY.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            // 
            // FifthStartPointX
            // 
            this.FifthStartPointX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FifthStartPointX.Location = new System.Drawing.Point(10, 217);
            this.FifthStartPointX.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.FifthStartPointX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.FifthStartPointX.Name = "FifthStartPointX";
            this.FifthStartPointX.Size = new System.Drawing.Size(47, 26);
            this.FifthStartPointX.TabIndex = 86;
            this.FifthStartPointX.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // FifthEndPointX
            // 
            this.FifthEndPointX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FifthEndPointX.Location = new System.Drawing.Point(107, 217);
            this.FifthEndPointX.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.FifthEndPointX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.FifthEndPointX.Name = "FifthEndPointX";
            this.FifthEndPointX.Size = new System.Drawing.Size(47, 26);
            this.FifthEndPointX.TabIndex = 85;
            this.FifthEndPointX.Value = new decimal(new int[] {
            940,
            0,
            0,
            0});
            // 
            // SixthStartPointY
            // 
            this.SixthStartPointY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SixthStartPointY.Location = new System.Drawing.Point(63, 217);
            this.SixthStartPointY.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.SixthStartPointY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.SixthStartPointY.Name = "SixthStartPointY";
            this.SixthStartPointY.Size = new System.Drawing.Size(40, 26);
            this.SixthStartPointY.TabIndex = 84;
            this.SixthStartPointY.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            // 
            // SixthEndPointY
            // 
            this.SixthEndPointY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SixthEndPointY.Location = new System.Drawing.Point(160, 217);
            this.SixthEndPointY.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.SixthEndPointY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.SixthEndPointY.Name = "SixthEndPointY";
            this.SixthEndPointY.Size = new System.Drawing.Size(40, 26);
            this.SixthEndPointY.TabIndex = 83;
            this.SixthEndPointY.Value = new decimal(new int[] {
            160,
            0,
            0,
            0});
            // 
            // SeventhStartPointY
            // 
            this.SeventhStartPointY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SeventhStartPointY.Location = new System.Drawing.Point(61, 217);
            this.SeventhStartPointY.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.SeventhStartPointY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.SeventhStartPointY.Name = "SeventhStartPointY";
            this.SeventhStartPointY.Size = new System.Drawing.Size(40, 26);
            this.SeventhStartPointY.TabIndex = 82;
            this.SeventhStartPointY.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            // 
            // SeventhEndPointY
            // 
            this.SeventhEndPointY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SeventhEndPointY.Location = new System.Drawing.Point(159, 217);
            this.SeventhEndPointY.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.SeventhEndPointY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.SeventhEndPointY.Name = "SeventhEndPointY";
            this.SeventhEndPointY.Size = new System.Drawing.Size(40, 26);
            this.SeventhEndPointY.TabIndex = 81;
            this.SeventhEndPointY.Value = new decimal(new int[] {
            660,
            0,
            0,
            0});
            // 
            // SixthStartPointX
            // 
            this.SixthStartPointX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SixthStartPointX.Location = new System.Drawing.Point(10, 217);
            this.SixthStartPointX.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.SixthStartPointX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.SixthStartPointX.Name = "SixthStartPointX";
            this.SixthStartPointX.Size = new System.Drawing.Size(47, 26);
            this.SixthStartPointX.TabIndex = 80;
            this.SixthStartPointX.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // SixthEndPointX
            // 
            this.SixthEndPointX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SixthEndPointX.Location = new System.Drawing.Point(106, 217);
            this.SixthEndPointX.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.SixthEndPointX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.SixthEndPointX.Name = "SixthEndPointX";
            this.SixthEndPointX.Size = new System.Drawing.Size(47, 26);
            this.SixthEndPointX.TabIndex = 79;
            this.SixthEndPointX.Value = new decimal(new int[] {
            340,
            0,
            0,
            0});
            // 
            // SeventhEndPointX
            // 
            this.SeventhEndPointX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SeventhEndPointX.Location = new System.Drawing.Point(107, 217);
            this.SeventhEndPointX.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.SeventhEndPointX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.SeventhEndPointX.Name = "SeventhEndPointX";
            this.SeventhEndPointX.Size = new System.Drawing.Size(47, 26);
            this.SeventhEndPointX.TabIndex = 78;
            this.SeventhEndPointX.Value = new decimal(new int[] {
            200,
            0,
            0,
            -2147483648});
            // 
            // SeventhStartPointX
            // 
            this.SeventhStartPointX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SeventhStartPointX.Location = new System.Drawing.Point(10, 217);
            this.SeventhStartPointX.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.SeventhStartPointX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.SeventhStartPointX.Name = "SeventhStartPointX";
            this.SeventhStartPointX.Size = new System.Drawing.Size(47, 26);
            this.SeventhStartPointX.TabIndex = 77;
            this.SeventhStartPointX.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // EighthEndPointY
            // 
            this.EighthEndPointY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.EighthEndPointY.Location = new System.Drawing.Point(160, 217);
            this.EighthEndPointY.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.EighthEndPointY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.EighthEndPointY.Name = "EighthEndPointY";
            this.EighthEndPointY.Size = new System.Drawing.Size(40, 26);
            this.EighthEndPointY.TabIndex = 76;
            this.EighthEndPointY.Value = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            // 
            // EighthEndPointX
            // 
            this.EighthEndPointX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.EighthEndPointX.Location = new System.Drawing.Point(107, 217);
            this.EighthEndPointX.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.EighthEndPointX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.EighthEndPointX.Name = "EighthEndPointX";
            this.EighthEndPointX.Size = new System.Drawing.Size(47, 26);
            this.EighthEndPointX.TabIndex = 75;
            this.EighthEndPointX.Value = new decimal(new int[] {
            160,
            0,
            0,
            -2147483648});
            // 
            // EighthStartPointY
            // 
            this.EighthStartPointY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.EighthStartPointY.Location = new System.Drawing.Point(63, 217);
            this.EighthStartPointY.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.EighthStartPointY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.EighthStartPointY.Name = "EighthStartPointY";
            this.EighthStartPointY.Size = new System.Drawing.Size(40, 26);
            this.EighthStartPointY.TabIndex = 74;
            this.EighthStartPointY.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            // 
            // EighthStartPointX
            // 
            this.EighthStartPointX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.EighthStartPointX.Location = new System.Drawing.Point(10, 217);
            this.EighthStartPointX.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.EighthStartPointX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.EighthStartPointX.Name = "EighthStartPointX";
            this.EighthStartPointX.Size = new System.Drawing.Size(47, 26);
            this.EighthStartPointX.TabIndex = 73;
            this.EighthStartPointX.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // FourthEndPointY
            // 
            this.FourthEndPointY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FourthEndPointY.Location = new System.Drawing.Point(160, 217);
            this.FourthEndPointY.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.FourthEndPointY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.FourthEndPointY.Name = "FourthEndPointY";
            this.FourthEndPointY.Size = new System.Drawing.Size(40, 26);
            this.FourthEndPointY.TabIndex = 72;
            this.FourthEndPointY.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            // 
            // FourthStartPointY
            // 
            this.FourthStartPointY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FourthStartPointY.Location = new System.Drawing.Point(63, 217);
            this.FourthStartPointY.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.FourthStartPointY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.FourthStartPointY.Name = "FourthStartPointY";
            this.FourthStartPointY.Size = new System.Drawing.Size(40, 26);
            this.FourthStartPointY.TabIndex = 71;
            this.FourthStartPointY.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            // 
            // FourthStartPointX
            // 
            this.FourthStartPointX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FourthStartPointX.Location = new System.Drawing.Point(9, 217);
            this.FourthStartPointX.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.FourthStartPointX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.FourthStartPointX.Name = "FourthStartPointX";
            this.FourthStartPointX.Size = new System.Drawing.Size(47, 26);
            this.FourthStartPointX.TabIndex = 70;
            this.FourthStartPointX.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // FourthEndPointX
            // 
            this.FourthEndPointX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FourthEndPointX.Location = new System.Drawing.Point(106, 217);
            this.FourthEndPointX.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.FourthEndPointX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.FourthEndPointX.Name = "FourthEndPointX";
            this.FourthEndPointX.Size = new System.Drawing.Size(47, 26);
            this.FourthEndPointX.TabIndex = 69;
            this.FourthEndPointX.Value = new decimal(new int[] {
            340,
            0,
            0,
            0});
            // 
            // ThirdStartPointY
            // 
            this.ThirdStartPointY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ThirdStartPointY.Location = new System.Drawing.Point(62, 217);
            this.ThirdStartPointY.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.ThirdStartPointY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.ThirdStartPointY.Name = "ThirdStartPointY";
            this.ThirdStartPointY.Size = new System.Drawing.Size(40, 26);
            this.ThirdStartPointY.TabIndex = 68;
            this.ThirdStartPointY.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            // 
            // ThirdEndPointY
            // 
            this.ThirdEndPointY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ThirdEndPointY.Location = new System.Drawing.Point(159, 217);
            this.ThirdEndPointY.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.ThirdEndPointY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.ThirdEndPointY.Name = "ThirdEndPointY";
            this.ThirdEndPointY.Size = new System.Drawing.Size(40, 26);
            this.ThirdEndPointY.TabIndex = 67;
            this.ThirdEndPointY.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            // 
            // SecondStartPointY
            // 
            this.SecondStartPointY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SecondStartPointY.Location = new System.Drawing.Point(63, 217);
            this.SecondStartPointY.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.SecondStartPointY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.SecondStartPointY.Name = "SecondStartPointY";
            this.SecondStartPointY.Size = new System.Drawing.Size(40, 26);
            this.SecondStartPointY.TabIndex = 66;
            this.SecondStartPointY.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            // 
            // SecondEndPointY
            // 
            this.SecondEndPointY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SecondEndPointY.Location = new System.Drawing.Point(160, 217);
            this.SecondEndPointY.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.SecondEndPointY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.SecondEndPointY.Name = "SecondEndPointY";
            this.SecondEndPointY.Size = new System.Drawing.Size(40, 26);
            this.SecondEndPointY.TabIndex = 65;
            this.SecondEndPointY.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // ThirdStartPointX
            // 
            this.ThirdStartPointX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ThirdStartPointX.Location = new System.Drawing.Point(10, 217);
            this.ThirdStartPointX.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.ThirdStartPointX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.ThirdStartPointX.Name = "ThirdStartPointX";
            this.ThirdStartPointX.Size = new System.Drawing.Size(47, 26);
            this.ThirdStartPointX.TabIndex = 64;
            this.ThirdStartPointX.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // ThirdEndPointX
            // 
            this.ThirdEndPointX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ThirdEndPointX.Location = new System.Drawing.Point(106, 217);
            this.ThirdEndPointX.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.ThirdEndPointX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.ThirdEndPointX.Name = "ThirdEndPointX";
            this.ThirdEndPointX.Size = new System.Drawing.Size(47, 26);
            this.ThirdEndPointX.TabIndex = 63;
            this.ThirdEndPointX.Value = new decimal(new int[] {
            940,
            0,
            0,
            0});
            // 
            // SecondEndPointX
            // 
            this.SecondEndPointX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SecondEndPointX.Location = new System.Drawing.Point(107, 217);
            this.SecondEndPointX.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.SecondEndPointX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.SecondEndPointX.Name = "SecondEndPointX";
            this.SecondEndPointX.Size = new System.Drawing.Size(47, 26);
            this.SecondEndPointX.TabIndex = 62;
            this.SecondEndPointX.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // SecondStartPointX
            // 
            this.SecondStartPointX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SecondStartPointX.Location = new System.Drawing.Point(10, 217);
            this.SecondStartPointX.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.SecondStartPointX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.SecondStartPointX.Name = "SecondStartPointX";
            this.SecondStartPointX.Size = new System.Drawing.Size(47, 26);
            this.SecondStartPointX.TabIndex = 61;
            this.SecondStartPointX.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // FirstEndPointY
            // 
            this.FirstEndPointY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FirstEndPointY.Location = new System.Drawing.Point(159, 217);
            this.FirstEndPointY.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.FirstEndPointY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.FirstEndPointY.Name = "FirstEndPointY";
            this.FirstEndPointY.Size = new System.Drawing.Size(40, 26);
            this.FirstEndPointY.TabIndex = 60;
            this.FirstEndPointY.Value = new decimal(new int[] {
            660,
            0,
            0,
            0});
            // 
            // FirstEndPointX
            // 
            this.FirstEndPointX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FirstEndPointX.Location = new System.Drawing.Point(106, 217);
            this.FirstEndPointX.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.FirstEndPointX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.FirstEndPointX.Name = "FirstEndPointX";
            this.FirstEndPointX.Size = new System.Drawing.Size(47, 26);
            this.FirstEndPointX.TabIndex = 59;
            this.FirstEndPointX.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // FirstStartPointY
            // 
            this.FirstStartPointY.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FirstStartPointY.Location = new System.Drawing.Point(63, 217);
            this.FirstStartPointY.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.FirstStartPointY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.FirstStartPointY.Name = "FirstStartPointY";
            this.FirstStartPointY.Size = new System.Drawing.Size(40, 26);
            this.FirstStartPointY.TabIndex = 58;
            this.FirstStartPointY.Value = new decimal(new int[] {
            360,
            0,
            0,
            0});
            // 
            // FirstStartPointX
            // 
            this.FirstStartPointX.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.FirstStartPointX.Location = new System.Drawing.Point(10, 217);
            this.FirstStartPointX.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.FirstStartPointX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.FirstStartPointX.Name = "FirstStartPointX";
            this.FirstStartPointX.Size = new System.Drawing.Size(47, 26);
            this.FirstStartPointX.TabIndex = 57;
            this.FirstStartPointX.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // labelEndPointX
            // 
            this.labelEndPointX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEndPointX.AutoSize = true;
            this.labelEndPointX.Location = new System.Drawing.Point(111, 257);
            this.labelEndPointX.Name = "labelEndPointX";
            this.labelEndPointX.Size = new System.Drawing.Size(25, 20);
            this.labelEndPointX.TabIndex = 56;
            this.labelEndPointX.Text = "X :";
            // 
            // labelEndPointY
            // 
            this.labelEndPointY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEndPointY.AutoSize = true;
            this.labelEndPointY.Location = new System.Drawing.Point(167, 262);
            this.labelEndPointY.Name = "labelEndPointY";
            this.labelEndPointY.Size = new System.Drawing.Size(26, 20);
            this.labelEndPointY.TabIndex = 55;
            this.labelEndPointY.Text = "Y :";
            // 
            // labelStartPointY
            // 
            this.labelStartPointY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStartPointY.AutoSize = true;
            this.labelStartPointY.Location = new System.Drawing.Point(53, 259);
            this.labelStartPointY.Name = "labelStartPointY";
            this.labelStartPointY.Size = new System.Drawing.Size(26, 20);
            this.labelStartPointY.TabIndex = 54;
            this.labelStartPointY.Text = "Y :";
            // 
            // labelStartPointX
            // 
            this.labelStartPointX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStartPointX.AutoSize = true;
            this.labelStartPointX.Location = new System.Drawing.Point(10, 257);
            this.labelStartPointX.Name = "labelStartPointX";
            this.labelStartPointX.Size = new System.Drawing.Size(25, 20);
            this.labelStartPointX.TabIndex = 53;
            this.labelStartPointX.Text = "X :";
            // 
            // labelEndPoint
            // 
            this.labelEndPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEndPoint.AutoSize = true;
            this.labelEndPoint.Location = new System.Drawing.Point(106, 270);
            this.labelEndPoint.Name = "labelEndPoint";
            this.labelEndPoint.Size = new System.Drawing.Size(70, 20);
            this.labelEndPoint.TabIndex = 52;
            this.labelEndPoint.Text = "End point:";
            // 
            // labelStartPoint
            // 
            this.labelStartPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStartPoint.AutoSize = true;
            this.labelStartPoint.Location = new System.Drawing.Point(13, 272);
            this.labelStartPoint.Name = "labelStartPoint";
            this.labelStartPoint.Size = new System.Drawing.Size(72, 20);
            this.labelStartPoint.TabIndex = 51;
            this.labelStartPoint.Text = "Start point:";
            // 
            // NumberOfCurves
            // 
            this.NumberOfCurves.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NumberOfCurves.FormattingEnabled = true;
            this.NumberOfCurves.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.NumberOfCurves.Location = new System.Drawing.Point(147, 269);
            this.NumberOfCurves.Name = "NumberOfCurves";
            this.NumberOfCurves.Size = new System.Drawing.Size(46, 28);
            this.NumberOfCurves.TabIndex = 50;
            this.NumberOfCurves.SelectedIndexChanged += new System.EventHandler(this.NumberOfCurves_SelectedIndexChanged);
            // 
            // labelNumberOfCurves
            // 
            this.labelNumberOfCurves.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumberOfCurves.AutoSize = true;
            this.labelNumberOfCurves.Location = new System.Drawing.Point(13, 274);
            this.labelNumberOfCurves.Name = "labelNumberOfCurves";
            this.labelNumberOfCurves.Size = new System.Drawing.Size(123, 20);
            this.labelNumberOfCurves.TabIndex = 49;
            this.labelNumberOfCurves.Text = "Number of curves :";
            // 
            // labelNumberPoints
            // 
            this.labelNumberPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumberPoints.AutoSize = true;
            this.labelNumberPoints.Location = new System.Drawing.Point(12, 270);
            this.labelNumberPoints.Name = "labelNumberPoints";
            this.labelNumberPoints.Size = new System.Drawing.Size(104, 20);
            this.labelNumberPoints.TabIndex = 47;
            this.labelNumberPoints.Text = "Number points :";
            // 
            // NumberPoints
            // 
            this.NumberPoints.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumberPoints.Location = new System.Drawing.Point(76, 302);
            this.NumberPoints.Maximum = new decimal(new int[] {
            20000000,
            0,
            0,
            0});
            this.NumberPoints.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumberPoints.Name = "NumberPoints";
            this.NumberPoints.Size = new System.Drawing.Size(140, 26);
            this.NumberPoints.TabIndex = 46;
            this.NumberPoints.Value = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            // 
            // Horizontal
            // 
            this.Horizontal.Location = new System.Drawing.Point(74, 302);
            this.Horizontal.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Horizontal.Name = "Horizontal";
            this.Horizontal.Size = new System.Drawing.Size(140, 26);
            this.Horizontal.TabIndex = 45;
            // 
            // Vertical
            // 
            this.Vertical.Location = new System.Drawing.Point(74, 302);
            this.Vertical.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.Vertical.Name = "Vertical";
            this.Vertical.Size = new System.Drawing.Size(140, 26);
            this.Vertical.TabIndex = 44;
            // 
            // labelHorizontal
            // 
            this.labelHorizontal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHorizontal.AutoSize = true;
            this.labelHorizontal.Location = new System.Drawing.Point(10, 279);
            this.labelHorizontal.Name = "labelHorizontal";
            this.labelHorizontal.Size = new System.Drawing.Size(147, 20);
            this.labelHorizontal.TabIndex = 43;
            this.labelHorizontal.Text = "Horizontal constriction :";
            // 
            // labelVertical
            // 
            this.labelVertical.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVertical.AutoSize = true;
            this.labelVertical.Location = new System.Drawing.Point(13, 277);
            this.labelVertical.Name = "labelVertical";
            this.labelVertical.Size = new System.Drawing.Size(136, 20);
            this.labelVertical.TabIndex = 42;
            this.labelVertical.Text = "Vertical constriction  :";
            // 
            // ColorButton
            // 
            this.ColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColorButton.Location = new System.Drawing.Point(70, 264);
            this.ColorButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(51, 26);
            this.ColorButton.TabIndex = 41;
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // labelBackColor
            // 
            this.labelBackColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBackColor.AutoSize = true;
            this.labelBackColor.Location = new System.Drawing.Point(20, 264);
            this.labelBackColor.Name = "labelBackColor";
            this.labelBackColor.Size = new System.Drawing.Size(121, 20);
            this.labelBackColor.TabIndex = 40;
            this.labelBackColor.Text = "BackgroundColor :";
            // 
            // BranchWidth
            // 
            this.BranchWidth.Location = new System.Drawing.Point(66, 268);
            this.BranchWidth.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.BranchWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BranchWidth.Name = "BranchWidth";
            this.BranchWidth.Size = new System.Drawing.Size(194, 26);
            this.BranchWidth.TabIndex = 39;
            this.BranchWidth.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // labelBranchWidth
            // 
            this.labelBranchWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBranchWidth.AutoSize = true;
            this.labelBranchWidth.Location = new System.Drawing.Point(12, 254);
            this.labelBranchWidth.Name = "labelBranchWidth";
            this.labelBranchWidth.Size = new System.Drawing.Size(88, 20);
            this.labelBranchWidth.TabIndex = 38;
            this.labelBranchWidth.Text = "Branch width:";
            // 
            // MinBranchLenght
            // 
            this.MinBranchLenght.Location = new System.Drawing.Point(10, 127);
            this.MinBranchLenght.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.MinBranchLenght.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinBranchLenght.Name = "MinBranchLenght";
            this.MinBranchLenght.Size = new System.Drawing.Size(194, 26);
            this.MinBranchLenght.TabIndex = 35;
            this.MinBranchLenght.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // labelMinimalLength
            // 
            this.labelMinimalLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMinimalLength.AutoSize = true;
            this.labelMinimalLength.Location = new System.Drawing.Point(8, 100);
            this.labelMinimalLength.Name = "labelMinimalLength";
            this.labelMinimalLength.Size = new System.Drawing.Size(142, 20);
            this.labelMinimalLength.TabIndex = 34;
            this.labelMinimalLength.Text = "Minimal branch length:";
            // 
            // LabelBranchLength
            // 
            this.LabelBranchLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelBranchLength.AutoSize = true;
            this.LabelBranchLength.Location = new System.Drawing.Point(8, 254);
            this.LabelBranchLength.Name = "LabelBranchLength";
            this.LabelBranchLength.Size = new System.Drawing.Size(98, 20);
            this.LabelBranchLength.TabIndex = 21;
            this.LabelBranchLength.Text = "Branch length :";
            // 
            // labelStartY
            // 
            this.labelStartY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStartY.AutoSize = true;
            this.labelStartY.Location = new System.Drawing.Point(10, 250);
            this.labelStartY.Name = "labelStartY";
            this.labelStartY.Size = new System.Drawing.Size(50, 20);
            this.labelStartY.TabIndex = 33;
            this.labelStartY.Text = "Start y:";
            // 
            // labelStartX
            // 
            this.labelStartX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStartX.AutoSize = true;
            this.labelStartX.Location = new System.Drawing.Point(7, 246);
            this.labelStartX.Name = "labelStartX";
            this.labelStartX.Size = new System.Drawing.Size(50, 20);
            this.labelStartX.TabIndex = 32;
            this.labelStartX.Text = "Start x:";
            // 
            // FourthAngle
            // 
            this.FourthAngle.Location = new System.Drawing.Point(10, 186);
            this.FourthAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.FourthAngle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.FourthAngle.Name = "FourthAngle";
            this.FourthAngle.Size = new System.Drawing.Size(50, 26);
            this.FourthAngle.TabIndex = 29;
            this.FourthAngle.Value = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            // 
            // StartY
            // 
            this.StartY.Location = new System.Drawing.Point(68, 262);
            this.StartY.Maximum = new decimal(new int[] {
            720,
            0,
            0,
            0});
            this.StartY.Name = "StartY";
            this.StartY.Size = new System.Drawing.Size(196, 26);
            this.StartY.TabIndex = 37;
            this.StartY.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // SecondAngle
            // 
            this.SecondAngle.Location = new System.Drawing.Point(10, 186);
            this.SecondAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.SecondAngle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.SecondAngle.Name = "SecondAngle";
            this.SecondAngle.Size = new System.Drawing.Size(50, 26);
            this.SecondAngle.TabIndex = 28;
            this.SecondAngle.Value = new decimal(new int[] {
            55,
            0,
            0,
            0});
            // 
            // ThirdAngle
            // 
            this.ThirdAngle.Location = new System.Drawing.Point(11, 186);
            this.ThirdAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.ThirdAngle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.ThirdAngle.Name = "ThirdAngle";
            this.ThirdAngle.Size = new System.Drawing.Size(49, 26);
            this.ThirdAngle.TabIndex = 27;
            this.ThirdAngle.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // StartX
            // 
            this.StartX.Location = new System.Drawing.Point(68, 262);
            this.StartX.Maximum = new decimal(new int[] {
            1280,
            0,
            0,
            0});
            this.StartX.Name = "StartX";
            this.StartX.Size = new System.Drawing.Size(196, 26);
            this.StartX.TabIndex = 36;
            this.StartX.Value = new decimal(new int[] {
            640,
            0,
            0,
            0});
            // 
            // BranchLenght
            // 
            this.BranchLenght.Location = new System.Drawing.Point(66, 265);
            this.BranchLenght.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.BranchLenght.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.BranchLenght.Name = "BranchLenght";
            this.BranchLenght.Size = new System.Drawing.Size(194, 26);
            this.BranchLenght.TabIndex = 25;
            this.BranchLenght.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // FirstAngle
            // 
            this.FirstAngle.Location = new System.Drawing.Point(11, 186);
            this.FirstAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.FirstAngle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.FirstAngle.Name = "FirstAngle";
            this.FirstAngle.Size = new System.Drawing.Size(49, 26);
            this.FirstAngle.TabIndex = 26;
            this.FirstAngle.Value = new decimal(new int[] {
            55,
            0,
            0,
            -2147483648});
            // 
            // labelAngles
            // 
            this.labelAngles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAngles.AutoSize = true;
            this.labelAngles.Location = new System.Drawing.Point(6, 159);
            this.labelAngles.Name = "labelAngles";
            this.labelAngles.Size = new System.Drawing.Size(55, 20);
            this.labelAngles.TabIndex = 22;
            this.labelAngles.Text = "Angles:";
            // 
            // Progress
            // 
            this.Progress.BackColor = System.Drawing.SystemColors.Control;
            this.Progress.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Progress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Progress.ForeColor = System.Drawing.Color.Blue;
            this.Progress.Location = new System.Drawing.Point(3, 635);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(207, 18);
            this.Progress.Step = 1;
            this.Progress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Progress.TabIndex = 19;
            // 
            // CulculationTime
            // 
            this.CulculationTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CulculationTime.BackColor = System.Drawing.Color.White;
            this.CulculationTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CulculationTime.Enabled = false;
            this.CulculationTime.Location = new System.Drawing.Point(14, 603);
            this.CulculationTime.Name = "CulculationTime";
            this.CulculationTime.ReadOnly = true;
            this.CulculationTime.Size = new System.Drawing.Size(189, 19);
            this.CulculationTime.TabIndex = 18;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(10, 583);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(127, 20);
            this.labelTime.TabIndex = 17;
            this.labelTime.Text = "Time of calculation :";
            // 
            // IncreaseZOOM
            // 
            this.IncreaseZOOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IncreaseZOOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncreaseZOOM.Image = ((System.Drawing.Image)(resources.GetObject("IncreaseZOOM.Image")));
            this.IncreaseZOOM.Location = new System.Drawing.Point(107, 65);
            this.IncreaseZOOM.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.IncreaseZOOM.Name = "IncreaseZOOM";
            this.IncreaseZOOM.Size = new System.Drawing.Size(32, 33);
            this.IncreaseZOOM.TabIndex = 2;
            this.IncreaseZOOM.UseVisualStyleBackColor = true;
            this.IncreaseZOOM.Click += new System.EventHandler(this.IncreaseZOOM_Click);
            // 
            // Details
            // 
            this.Details.Controls.Add(this.TextAngles);
            this.Details.Location = new System.Drawing.Point(4, 22);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(213, 663);
            this.Details.TabIndex = 1;
            this.Details.Text = "The details";
            this.Details.UseVisualStyleBackColor = true;
            // 
            // TextAngles
            // 
            this.TextAngles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextAngles.Font = new System.Drawing.Font("Arial Narrow", 9F);
            this.TextAngles.Location = new System.Drawing.Point(3, 3);
            this.TextAngles.Multiline = true;
            this.TextAngles.Name = "TextAngles";
            this.TextAngles.Size = new System.Drawing.Size(204, 122);
            this.TextAngles.TabIndex = 22;
            this.TextAngles.Text = "Angles (one angle one branch)\r\n(-35 - left branch will  have angle 35)\r\nor \r\n(45 " +
    "right branch will have angle 45 )\r\n(e.g. (-35, 40, 10) we wil have 3 branches wi" +
    "th corresponding angles) :";
            // 
            // RandomGradientButton
            // 
            this.RandomGradientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomGradientButton.Location = new System.Drawing.Point(4, 1);
            this.RandomGradientButton.Name = "RandomGradientButton";
            this.RandomGradientButton.Size = new System.Drawing.Size(210, 29);
            this.RandomGradientButton.TabIndex = 16;
            this.RandomGradientButton.Text = "Generate Gradient";
            this.RandomGradientButton.UseVisualStyleBackColor = true;
            this.RandomGradientButton.Click += new System.EventHandler(this.RandomGradientButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1513, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.openToolStripMenuItem.Text = "Load gradient";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.saveToolStripMenuItem.Text = "Save image";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.Filter = "Images|*.bmp;*.png;*.jpg;";
            this.OpenFile.FilterIndex = 3;
            // 
            // SaveFile
            // 
            this.SaveFile.Filter = "Images|*.bmp;*.png;*.jpg";
            this.SaveFile.FilterIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1513, 748);
            this.Controls.Add(this.SplitImageAndInterface);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1529, 787);
            this.MinimumSize = new System.Drawing.Size(1529, 787);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ZOOMValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iterations)).EndInit();
            this.SplitImageAndInterface.Panel1.ResumeLayout(false);
            this.SplitImageAndInterface.Panel1.PerformLayout();
            this.SplitImageAndInterface.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SplitImageAndInterface)).EndInit();
            this.SplitImageAndInterface.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.FractalProperties.ResumeLayout(false);
            this.FractalProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DragonIterations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DragonBrashWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FifthEndPointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FifthStartPointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FifthStartPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FifthEndPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SixthStartPointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SixthEndPointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeventhStartPointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeventhEndPointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SixthStartPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SixthEndPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeventhEndPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SeventhStartPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EighthEndPointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EighthEndPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EighthStartPointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EighthStartPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthEndPointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthStartPointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthStartPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthEndPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdStartPointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdEndPointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondStartPointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondEndPointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdStartPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdEndPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondEndPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondStartPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstEndPointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstEndPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstStartPointY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstStartPointX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinBranchLenght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FourthAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThirdAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BranchLenght)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FirstAngle)).EndInit();
            this.Details.ResumeLayout(false);
            this.Details.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateFractal;
        private System.Windows.Forms.Button IncreaseZOOM;
        private System.Windows.Forms.NumericUpDown ZOOMValue;
        private System.Windows.Forms.NumericUpDown Iterations;
        private System.Windows.Forms.Label labelIterations;
        private System.Windows.Forms.Label labelZOOM;
        private System.Windows.Forms.TextBox ZoomNUM;
        private System.Windows.Forms.MaskedTextBox CenterX;
        private System.Windows.Forms.MaskedTextBox CenterY;
        private System.Windows.Forms.Label x;
        private System.Windows.Forms.Label y;
        private System.Windows.Forms.Label LabelMaxZDegreeTwo;
        private System.Windows.Forms.MaskedTextBox MaxZDegreeTwo;
        private System.Windows.Forms.PictureBox Grad;
        private System.Windows.Forms.SplitContainer SplitImageAndInterface;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button RandomGradientButton;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage FractalProperties;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox CulculationTime;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.Label LabelBranchLength;
        private System.Windows.Forms.TextBox TextAngles;
        private System.Windows.Forms.Label labelAngles;
        private System.Windows.Forms.TabPage Details;
        private System.Windows.Forms.NumericUpDown BranchLenght;
        private System.Windows.Forms.NumericUpDown SecondAngle;
        private System.Windows.Forms.NumericUpDown ThirdAngle;
        private System.Windows.Forms.NumericUpDown FirstAngle;
        private System.Windows.Forms.NumericUpDown FourthAngle;
        private System.Windows.Forms.Label labelMinimalLength;
        private System.Windows.Forms.Label labelStartY;
        private System.Windows.Forms.Label labelStartX;
        private System.Windows.Forms.NumericUpDown MinBranchLenght;
        private System.Windows.Forms.NumericUpDown StartY;
        private System.Windows.Forms.NumericUpDown StartX;
        private System.Windows.Forms.NumericUpDown BranchWidth;
        private System.Windows.Forms.Label labelBranchWidth;
        private System.Windows.Forms.Label labelBackColor;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.NumericUpDown Horizontal;
        private System.Windows.Forms.NumericUpDown Vertical;
        private System.Windows.Forms.Label labelHorizontal;
        private System.Windows.Forms.Label labelVertical;
        private System.Windows.Forms.Label labelNumberPoints;
        private System.Windows.Forms.NumericUpDown NumberPoints;
        private System.Windows.Forms.ComboBox NumberOfCurves;
        private System.Windows.Forms.Label labelNumberOfCurves;
        private System.Windows.Forms.Label labelEndPoint;
        private System.Windows.Forms.Label labelStartPoint;
        private System.Windows.Forms.Label labelEndPointX;
        private System.Windows.Forms.Label labelEndPointY;
        private System.Windows.Forms.Label labelStartPointY;
        private System.Windows.Forms.Label labelStartPointX;
        private System.Windows.Forms.NumericUpDown FirstEndPointY;
        private System.Windows.Forms.NumericUpDown FirstEndPointX;
        private System.Windows.Forms.NumericUpDown FirstStartPointY;
        private System.Windows.Forms.NumericUpDown FirstStartPointX;
        private System.Windows.Forms.NumericUpDown ThirdStartPointX;
        private System.Windows.Forms.NumericUpDown ThirdEndPointX;
        private System.Windows.Forms.NumericUpDown SecondEndPointX;
        private System.Windows.Forms.NumericUpDown SecondStartPointX;
        private System.Windows.Forms.NumericUpDown ThirdStartPointY;
        private System.Windows.Forms.NumericUpDown ThirdEndPointY;
        private System.Windows.Forms.NumericUpDown SecondStartPointY;
        private System.Windows.Forms.NumericUpDown SecondEndPointY;
        private System.Windows.Forms.NumericUpDown FourthEndPointY;
        private System.Windows.Forms.NumericUpDown FourthStartPointY;
        private System.Windows.Forms.NumericUpDown FourthStartPointX;
        private System.Windows.Forms.NumericUpDown FourthEndPointX;
        private System.Windows.Forms.NumericUpDown FifthEndPointY;
        private System.Windows.Forms.NumericUpDown FifthStartPointY;
        private System.Windows.Forms.NumericUpDown FifthStartPointX;
        private System.Windows.Forms.NumericUpDown FifthEndPointX;
        private System.Windows.Forms.NumericUpDown SixthStartPointY;
        private System.Windows.Forms.NumericUpDown SixthEndPointY;
        private System.Windows.Forms.NumericUpDown SeventhStartPointY;
        private System.Windows.Forms.NumericUpDown SeventhEndPointY;
        private System.Windows.Forms.NumericUpDown SixthStartPointX;
        private System.Windows.Forms.NumericUpDown SixthEndPointX;
        private System.Windows.Forms.NumericUpDown SeventhEndPointX;
        private System.Windows.Forms.NumericUpDown SeventhStartPointX;
        private System.Windows.Forms.NumericUpDown EighthEndPointY;
        private System.Windows.Forms.NumericUpDown EighthEndPointX;
        private System.Windows.Forms.NumericUpDown EighthStartPointY;
        private System.Windows.Forms.NumericUpDown EighthStartPointX;
        private System.Windows.Forms.NumericUpDown DragonBrashWidth;
        private System.Windows.Forms.Label labelDragonBrashWidth;
        private System.Windows.Forms.ComboBox FractalsList;
        private System.Windows.Forms.ComboBox NumberOfAngles;
        private System.Windows.Forms.NumericUpDown DragonIterations;
        private System.Windows.Forms.Label labelDragonIterations;
        private System.Windows.Forms.Button DecreaseZOOM;
    }
}

