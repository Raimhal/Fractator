using System;

namespace HelperClasses
{
    public class Complex
    {
        public double Re;
        public double Im;

        public Complex(double a, double b)
        {
            this.Re = a;
            this.Im = b;
        }

        public void Sqr()
        {
            double tmp = (Re * Re) - (Im * Im);
            Im = 2.0d * Re * Im;
            Re = tmp;
        }

        public double Magn()
        {
            return Math.Sqrt((Re * Re) + (Im * Im));
        }

        public void Add(Complex c)
        {
            Re += c.Re;
            Im += c.Im;
        }

    }
}
