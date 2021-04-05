
namespace FractalsCreator
{
    partial class GradientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradientForm));
            this.pictureGradient = new System.Windows.Forms.PictureBox();
            this.RandomGradient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureGradient)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureGradient
            // 
            this.pictureGradient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureGradient.Image = ((System.Drawing.Image)(resources.GetObject("pictureGradient.Image")));
            this.pictureGradient.Location = new System.Drawing.Point(0, 0);
            this.pictureGradient.Name = "pictureGradient";
            this.pictureGradient.Size = new System.Drawing.Size(494, 281);
            this.pictureGradient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureGradient.TabIndex = 0;
            this.pictureGradient.TabStop = false;
            // 
            // RandomGradient
            // 
            this.RandomGradient.BackColor = System.Drawing.Color.Transparent;
            this.RandomGradient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomGradient.Location = new System.Drawing.Point(12, 224);
            this.RandomGradient.Name = "RandomGradient";
            this.RandomGradient.Size = new System.Drawing.Size(185, 42);
            this.RandomGradient.TabIndex = 1;
            this.RandomGradient.Text = "Generate Gradient";
            this.RandomGradient.UseVisualStyleBackColor = false;
            this.RandomGradient.Click += new System.EventHandler(this.RandomGradient_Click);
            // 
            // GradientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(494, 281);
            this.Controls.Add(this.RandomGradient);
            this.Controls.Add(this.pictureGradient);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Location = new System.Drawing.Point(50, 750);
            this.MaximizeBox = false;
            this.Name = "GradientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Gradient";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GradientForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GradientForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureGradient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureGradient;
        public System.Windows.Forms.Button RandomGradient;
    }
}