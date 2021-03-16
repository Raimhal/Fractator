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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Grad = new System.Windows.Forms.PictureBox();
            this.image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ZOOMValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iterations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplitImageAndInterface)).BeginInit();
            this.SplitImageAndInterface.Panel1.SuspendLayout();
            this.SplitImageAndInterface.Panel2.SuspendLayout();
            this.SplitImageAndInterface.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateFractal
            // 
            this.CreateFractal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateFractal.Location = new System.Drawing.Point(3, 420);
            this.CreateFractal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CreateFractal.Name = "CreateFractal";
            this.CreateFractal.Size = new System.Drawing.Size(180, 52);
            this.CreateFractal.TabIndex = 1;
            this.CreateFractal.Text = "Create fractal";
            this.CreateFractal.UseVisualStyleBackColor = true;
            this.CreateFractal.Click += new System.EventHandler(this.GenerateFractal_Click);
            // 
            // IncreaseZOOM
            // 
            this.IncreaseZOOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IncreaseZOOM.Location = new System.Drawing.Point(99, 32);
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
            this.ZOOMValue.Location = new System.Drawing.Point(3, 33);
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
            this.DecreaseZOOM.Location = new System.Drawing.Point(145, 32);
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
            this.Iterations.Location = new System.Drawing.Point(3, 386);
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
            this.labelIterations.Location = new System.Drawing.Point(-2, 363);
            this.labelIterations.Name = "labelIterations";
            this.labelIterations.Size = new System.Drawing.Size(95, 20);
            this.labelIterations.TabIndex = 6;
            this.labelIterations.Text = "Max iterations:";
            // 
            // labelZOOM
            // 
            this.labelZOOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelZOOM.AutoSize = true;
            this.labelZOOM.Location = new System.Drawing.Point(3, 10);
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
            this.CenterX.Location = new System.Drawing.Point(3, 230);
            this.CenterX.Name = "CenterX";
            this.CenterX.Size = new System.Drawing.Size(180, 26);
            this.CenterX.TabIndex = 10;
            // 
            // CenterY
            // 
            this.CenterY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CenterY.Location = new System.Drawing.Point(3, 282);
            this.CenterY.Name = "CenterY";
            this.CenterY.Size = new System.Drawing.Size(180, 26);
            this.CenterY.TabIndex = 11;
            // 
            // x
            // 
            this.x.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.x.AutoSize = true;
            this.x.Location = new System.Drawing.Point(16, 207);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(63, 20);
            this.x.TabIndex = 12;
            this.x.Text = "Center x:";
            // 
            // y
            // 
            this.y.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.y.AutoSize = true;
            this.y.Location = new System.Drawing.Point(3, 259);
            this.y.Name = "y";
            this.y.Size = new System.Drawing.Size(63, 20);
            this.y.TabIndex = 13;
            this.y.Text = "Center y:";
            // 
            // LabelMaxZDegreeTwo
            // 
            this.LabelMaxZDegreeTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelMaxZDegreeTwo.AutoSize = true;
            this.LabelMaxZDegreeTwo.Location = new System.Drawing.Point(3, 311);
            this.LabelMaxZDegreeTwo.Name = "LabelMaxZDegreeTwo";
            this.LabelMaxZDegreeTwo.Size = new System.Drawing.Size(76, 20);
            this.LabelMaxZDegreeTwo.TabIndex = 14;
            this.LabelMaxZDegreeTwo.Text = "max |z| ^ 2:";
            // 
            // MaxZDegreeTwo
            // 
            this.MaxZDegreeTwo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxZDegreeTwo.Location = new System.Drawing.Point(3, 334);
            this.MaxZDegreeTwo.Name = "MaxZDegreeTwo";
            this.MaxZDegreeTwo.Size = new System.Drawing.Size(180, 26);
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
            this.SplitImageAndInterface.Panel2.Controls.Add(this.x);
            this.SplitImageAndInterface.Panel2.Controls.Add(this.CreateFractal);
            this.SplitImageAndInterface.Panel2.Controls.Add(this.MaxZDegreeTwo);
            this.SplitImageAndInterface.Panel2.Controls.Add(this.labelZOOM);
            this.SplitImageAndInterface.Panel2.Controls.Add(this.LabelMaxZDegreeTwo);
            this.SplitImageAndInterface.Panel2.Controls.Add(this.ZOOMValue);
            this.SplitImageAndInterface.Panel2.Controls.Add(this.CenterY);
            this.SplitImageAndInterface.Panel2.Controls.Add(this.y);
            this.SplitImageAndInterface.Panel2.Controls.Add(this.IncreaseZOOM);
            this.SplitImageAndInterface.Panel2.Controls.Add(this.DecreaseZOOM);
            this.SplitImageAndInterface.Panel2.Controls.Add(this.CenterX);
            this.SplitImageAndInterface.Panel2.Controls.Add(this.Iterations);
            this.SplitImageAndInterface.Panel2.Controls.Add(this.labelIterations);
            this.SplitImageAndInterface.Size = new System.Drawing.Size(1172, 530);
            this.SplitImageAndInterface.SplitterDistance = 959;
            this.SplitImageAndInterface.TabIndex = 17;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1172, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // Grad
            // 
            this.Grad.Image = global::WindowsFormsApp2.Properties.Resources.second;
            this.Grad.Location = new System.Drawing.Point(393, 10);
            this.Grad.Name = "Grad";
            this.Grad.Size = new System.Drawing.Size(545, 28);
            this.Grad.TabIndex = 16;
            this.Grad.TabStop = false;
            // 
            // image
            // 
            this.image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.image.Location = new System.Drawing.Point(0, 0);
            this.image.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(955, 526);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            this.image.Click += new System.EventHandler(this.image_Click);
            this.image.MouseClick += new System.Windows.Forms.MouseEventHandler(this.image_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 554);
            this.Controls.Add(this.SplitImageAndInterface);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.MinimumSize = new System.Drawing.Size(740, 432);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.ZOOMValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iterations)).EndInit();
            this.SplitImageAndInterface.Panel1.ResumeLayout(false);
            this.SplitImageAndInterface.Panel1.PerformLayout();
            this.SplitImageAndInterface.Panel2.ResumeLayout(false);
            this.SplitImageAndInterface.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitImageAndInterface)).EndInit();
            this.SplitImageAndInterface.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
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
    }
}

