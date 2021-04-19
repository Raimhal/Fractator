using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperClasses;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
namespace FractalClasses
{
    public class Fractals
    {
        protected List<Pixel> pixels;
        protected Bitmap picture;
        protected Graphics g;
        protected Color BackgroundColor;
        public Graphics G
        {
            set
            {
                if (picture == null)
                {
                    g = null;
                }
                else
                {
                    g = value;
                }
            }
        }
        public Fractals()
        {
            this.picture = null;
            this.pixels = null;
        }
        public Fractals(Bitmap picture, List<Pixel> pixels, Color BackgroundColor) : this(picture, pixels)
        {
            this.BackgroundColor = BackgroundColor;
        }
        public Fractals(Bitmap picture, List<Pixel> pixels):this(picture)
        {
            this.pixels = pixels;
        }
        public Fractals(Bitmap picture):this()
        {
            this.picture = picture;
            G = Graphics.FromImage(picture);
        }
        public Fractals(Bitmap picture, Color BackgroundColor) : this(picture)
        {
            this.BackgroundColor = BackgroundColor;
        }
        public void Effects(Graphics g, Color BackgroundColor)
        {
            g.Clear(BackgroundColor);
            g.SmoothingMode = SmoothingMode.AntiAlias;
        }
        public virtual void Info(TextBox info) { }
        ~Fractals()
        {
            Console.WriteLine("Class Fractals is cleared");
        }
    }
}
