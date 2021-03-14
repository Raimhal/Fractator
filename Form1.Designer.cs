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
            this.image = new System.Windows.Forms.PictureBox();
            this.CreateFractal = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.IncreaseZOOM = new System.Windows.Forms.Button();
            this.ZOOMValue = new System.Windows.Forms.NumericUpDown();
            this.DecreaseZOOM = new System.Windows.Forms.Button();
            this.Iterations = new System.Windows.Forms.NumericUpDown();
            this.labelIterations = new System.Windows.Forms.Label();
            this.labelZOOM = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ZoomNUM = new System.Windows.Forms.TextBox();
            this.CenterX = new System.Windows.Forms.MaskedTextBox();
            this.CenterY = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZOOMValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iterations)).BeginInit();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.image.Location = new System.Drawing.Point(0, 0);
            this.image.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(1101, 561);
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            this.image.Click += new System.EventHandler(this.image_Click);
            this.image.MouseClick += new System.Windows.Forms.MouseEventHandler(this.image_MouseClick);
            // 
            // CreateFractal
            // 
            this.CreateFractal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateFractal.Location = new System.Drawing.Point(784, 6);
            this.CreateFractal.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.CreateFractal.Name = "CreateFractal";
            this.CreateFractal.Size = new System.Drawing.Size(151, 52);
            this.CreateFractal.TabIndex = 1;
            this.CreateFractal.Text = "Create fractal";
            this.CreateFractal.UseVisualStyleBackColor = true;
            this.CreateFractal.Click += new System.EventHandler(this.GenerateFractal_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // IncreaseZOOM
            // 
            this.IncreaseZOOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IncreaseZOOM.Location = new System.Drawing.Point(946, 69);
            this.IncreaseZOOM.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.IncreaseZOOM.Name = "IncreaseZOOM";
            this.IncreaseZOOM.Size = new System.Drawing.Size(54, 35);
            this.IncreaseZOOM.TabIndex = 2;
            this.IncreaseZOOM.Text = "+";
            this.IncreaseZOOM.UseVisualStyleBackColor = true;
            this.IncreaseZOOM.Click += new System.EventHandler(this.IncreaseZOOM_Click);
            // 
            // ZOOMValue
            // 
            this.ZOOMValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ZOOMValue.Location = new System.Drawing.Point(942, 34);
            this.ZOOMValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.ZOOMValue.Maximum = new decimal(new int[] {
            200,
            0,
            0,
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
            this.DecreaseZOOM.Location = new System.Drawing.Point(1023, 69);
            this.DecreaseZOOM.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.DecreaseZOOM.Name = "DecreaseZOOM";
            this.DecreaseZOOM.Size = new System.Drawing.Size(46, 35);
            this.DecreaseZOOM.TabIndex = 4;
            this.DecreaseZOOM.Text = "-";
            this.DecreaseZOOM.UseVisualStyleBackColor = true;
            this.DecreaseZOOM.Click += new System.EventHandler(this.DecreaseZOOM_Click);
            // 
            // Iterations
            // 
            this.Iterations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Iterations.Location = new System.Drawing.Point(946, 132);
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
            this.labelIterations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIterations.AutoSize = true;
            this.labelIterations.Location = new System.Drawing.Point(942, 109);
            this.labelIterations.Name = "labelIterations";
            this.labelIterations.Size = new System.Drawing.Size(95, 20);
            this.labelIterations.TabIndex = 6;
            this.labelIterations.Text = "Max iterations:";
            // 
            // labelZOOM
            // 
            this.labelZOOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelZOOM.AutoSize = true;
            this.labelZOOM.Location = new System.Drawing.Point(942, 9);
            this.labelZOOM.Name = "labelZOOM";
            this.labelZOOM.Size = new System.Drawing.Size(51, 20);
            this.labelZOOM.TabIndex = 7;
            this.labelZOOM.Text = "ZOOM:";
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1058, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(28, 28);
            this.comboBox1.TabIndex = 8;
            // 
            // ZoomNUM
            // 
            this.ZoomNUM.BackColor = System.Drawing.SystemColors.Menu;
            this.ZoomNUM.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ZoomNUM.Location = new System.Drawing.Point(14, 12);
            this.ZoomNUM.MaximumSize = new System.Drawing.Size(228, 40);
            this.ZoomNUM.Name = "ZoomNUM";
            this.ZoomNUM.ReadOnly = true;
            this.ZoomNUM.Size = new System.Drawing.Size(0, 35);
            this.ZoomNUM.TabIndex = 9;
            // 
            // CenterX
            // 
            this.CenterX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CenterX.Location = new System.Drawing.Point(906, 462);
            this.CenterX.Name = "CenterX";
            this.CenterX.Size = new System.Drawing.Size(180, 26);
            this.CenterX.TabIndex = 10;
            // 
            // CenterY
            // 
            this.CenterY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CenterY.Location = new System.Drawing.Point(906, 513);
            this.CenterY.Name = "CenterY";
            this.CenterY.Size = new System.Drawing.Size(180, 26);
            this.CenterY.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(901, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Center x:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(902, 490);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Center y:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CenterY);
            this.Controls.Add(this.CenterX);
            this.Controls.Add(this.ZoomNUM);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelZOOM);
            this.Controls.Add(this.labelIterations);
            this.Controls.Add(this.Iterations);
            this.Controls.Add(this.DecreaseZOOM);
            this.Controls.Add(this.ZOOMValue);
            this.Controls.Add(this.IncreaseZOOM);
            this.Controls.Add(this.CreateFractal);
            this.Controls.Add(this.image);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZOOMValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Iterations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Button CreateFractal;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button IncreaseZOOM;
        private System.Windows.Forms.NumericUpDown ZOOMValue;
        private System.Windows.Forms.Button DecreaseZOOM;
        private System.Windows.Forms.NumericUpDown Iterations;
        private System.Windows.Forms.Label labelIterations;
        private System.Windows.Forms.Label labelZOOM;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox ZoomNUM;
        private System.Windows.Forms.MaskedTextBox CenterX;
        private System.Windows.Forms.MaskedTextBox CenterY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

