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
            this.CreateFractal = new System.Windows.Forms.Button();
            this.IncreaseZOOM = new System.Windows.Forms.Button();
            this.ZOOMValue = new System.Windows.Forms.NumericUpDown();
            this.DecreaseZOOM = new System.Windows.Forms.Button();
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
            this.ColorButton = new System.Windows.Forms.Button();
            this.labelBackColor = new System.Windows.Forms.Label();
            this.BranchWidth = new System.Windows.Forms.NumericUpDown();
            this.labelBranchWidth = new System.Windows.Forms.Label();
            this.MinBranchLenght = new System.Windows.Forms.NumericUpDown();
            this.labelMinimalLength = new System.Windows.Forms.Label();
            this.NumberOfAngles = new System.Windows.Forms.ListBox();
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
            this.FractalsList = new System.Windows.Forms.ListBox();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.CulculationTime = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
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
            this.labelVertical = new System.Windows.Forms.Label();
            this.labelHorizontal = new System.Windows.Forms.Label();
            this.Vertical = new System.Windows.Forms.NumericUpDown();
            this.Horizontal = new System.Windows.Forms.NumericUpDown();
            this.NumberPoints = new System.Windows.Forms.NumericUpDown();
            this.labelNumberPoints = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.Vertical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateFractal
            // 
            this.CreateFractal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateFractal.Cursor = System.Windows.Forms.Cursors.Default;
            this.CreateFractal.Location = new System.Drawing.Point(11, 526);
            this.CreateFractal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CreateFractal.Name = "CreateFractal";
            this.CreateFractal.Size = new System.Drawing.Size(192, 52);
            this.CreateFractal.TabIndex = 1;
            this.CreateFractal.Text = "Create fractal";
            this.CreateFractal.UseVisualStyleBackColor = true;
            this.CreateFractal.Click += new System.EventHandler(this.GenerateFractal_Click);
            // 
            // IncreaseZOOM
            // 
            this.IncreaseZOOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IncreaseZOOM.Location = new System.Drawing.Point(107, 69);
            this.IncreaseZOOM.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.IncreaseZOOM.Name = "IncreaseZOOM";
            this.IncreaseZOOM.Size = new System.Drawing.Size(40, 26);
            this.IncreaseZOOM.TabIndex = 2;
            this.IncreaseZOOM.Text = "+";
            this.IncreaseZOOM.UseVisualStyleBackColor = true;
            this.IncreaseZOOM.Click += new System.EventHandler(this.IncreaseZOOM_Click);
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
            // DecreaseZOOM
            // 
            this.DecreaseZOOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DecreaseZOOM.Location = new System.Drawing.Point(153, 69);
            this.DecreaseZOOM.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DecreaseZOOM.Name = "DecreaseZOOM";
            this.DecreaseZOOM.Size = new System.Drawing.Size(40, 26);
            this.DecreaseZOOM.TabIndex = 4;
            this.DecreaseZOOM.Text = "-";
            this.DecreaseZOOM.UseVisualStyleBackColor = true;
            this.DecreaseZOOM.Click += new System.EventHandler(this.DecreaseZOOM_Click);
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
            this.ZoomNUM.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZoomNUM.ForeColor = System.Drawing.Color.OrangeRed;
            this.ZoomNUM.Location = new System.Drawing.Point(3, 0);
            this.ZoomNUM.MaximumSize = new System.Drawing.Size(228, 40);
            this.ZoomNUM.Name = "ZoomNUM";
            this.ZoomNUM.ReadOnly = true;
            this.ZoomNUM.Size = new System.Drawing.Size(10, 28);
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
            this.SplitImageAndInterface.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.SplitImageAndInterface_Panel2_Paint);
            this.SplitImageAndInterface.Size = new System.Drawing.Size(1513, 724);
            this.SplitImageAndInterface.SplitterDistance = 1284;
            this.SplitImageAndInterface.TabIndex = 17;
            // 
            // Grad
            // 
            this.Grad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Grad.BackColor = System.Drawing.Color.Transparent;
            this.Grad.Image = global::WindowsFormsApp2.Properties.Resources.third;
            this.Grad.Location = new System.Drawing.Point(835, -2);
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
            this.FractalProperties.Controls.Add(this.NumberOfAngles);
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
            this.FractalProperties.Controls.Add(this.FractalsList);
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
            this.FractalProperties.Controls.Add(this.DecreaseZOOM);
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
            // ColorButton
            // 
            this.ColorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorButton.Location = new System.Drawing.Point(66, 248);
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
            this.labelBackColor.Location = new System.Drawing.Point(13, 254);
            this.labelBackColor.Name = "labelBackColor";
            this.labelBackColor.Size = new System.Drawing.Size(121, 20);
            this.labelBackColor.TabIndex = 40;
            this.labelBackColor.Text = "BackgroundColor :";
            // 
            // BranchWidth
            // 
            this.BranchWidth.Location = new System.Drawing.Point(66, 250);
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
            // NumberOfAngles
            // 
            this.NumberOfAngles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberOfAngles.FormattingEnabled = true;
            this.NumberOfAngles.ItemHeight = 20;
            this.NumberOfAngles.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.NumberOfAngles.Location = new System.Drawing.Point(68, 159);
            this.NumberOfAngles.Name = "NumberOfAngles";
            this.NumberOfAngles.Size = new System.Drawing.Size(97, 24);
            this.NumberOfAngles.TabIndex = 30;
            this.NumberOfAngles.SelectedIndexChanged += new System.EventHandler(this.NumberOfAngles_SelectedIndexChanged);
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
            this.FourthAngle.Location = new System.Drawing.Point(143, 221);
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
            this.StartY.Location = new System.Drawing.Point(66, 248);
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
            this.SecondAngle.Location = new System.Drawing.Point(143, 189);
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
            this.ThirdAngle.Location = new System.Drawing.Point(11, 221);
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
            this.StartX.Location = new System.Drawing.Point(66, 248);
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
            this.BranchLenght.Location = new System.Drawing.Point(66, 248);
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
            // FractalsList
            // 
            this.FractalsList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FractalsList.FormattingEnabled = true;
            this.FractalsList.ItemHeight = 20;
            this.FractalsList.Items.AddRange(new object[] {
            "Mandelbrot set ",
            "Fractal tree",
            "Barnsley fern"});
            this.FractalsList.Location = new System.Drawing.Point(12, 19);
            this.FractalsList.Name = "FractalsList";
            this.FractalsList.Size = new System.Drawing.Size(192, 24);
            this.FractalsList.TabIndex = 20;
            this.FractalsList.SelectedIndexChanged += new System.EventHandler(this.FractalsList_SelectedIndexChanged);
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
            this.CulculationTime.Location = new System.Drawing.Point(133, 606);
            this.CulculationTime.Name = "CulculationTime";
            this.CulculationTime.ReadOnly = true;
            this.CulculationTime.Size = new System.Drawing.Size(77, 26);
            this.CulculationTime.TabIndex = 18;
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(7, 609);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(127, 20);
            this.labelTime.TabIndex = 17;
            this.labelTime.Text = "Time of calculation :";
            // 
            // Details
            // 
            this.Details.Controls.Add(this.TextAngles);
            this.Details.Location = new System.Drawing.Point(4, 29);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(213, 656);
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
            this.RandomGradientButton.Location = new System.Drawing.Point(7, 3);
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
            // labelNumberPoints
            // 
            this.labelNumberPoints.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumberPoints.AutoSize = true;
            this.labelNumberPoints.Location = new System.Drawing.Point(17, 251);
            this.labelNumberPoints.Name = "labelNumberPoints";
            this.labelNumberPoints.Size = new System.Drawing.Size(104, 20);
            this.labelNumberPoints.TabIndex = 47;
            this.labelNumberPoints.Text = "Number points :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.Vertical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Horizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumberPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateFractal;
        private System.Windows.Forms.Button IncreaseZOOM;
        private System.Windows.Forms.NumericUpDown ZOOMValue;
        private System.Windows.Forms.Button DecreaseZOOM;
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
        private System.Windows.Forms.ListBox FractalsList;
        private System.Windows.Forms.Label LabelBranchLength;
        private System.Windows.Forms.TextBox TextAngles;
        private System.Windows.Forms.Label labelAngles;
        private System.Windows.Forms.TabPage Details;
        private System.Windows.Forms.NumericUpDown BranchLenght;
        private System.Windows.Forms.NumericUpDown SecondAngle;
        private System.Windows.Forms.NumericUpDown ThirdAngle;
        private System.Windows.Forms.NumericUpDown FirstAngle;
        private System.Windows.Forms.NumericUpDown FourthAngle;
        private System.Windows.Forms.ListBox NumberOfAngles;
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
    }
}

