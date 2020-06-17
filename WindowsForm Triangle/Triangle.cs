using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForm_Triangle
{
    class Triangle
    {
        public double a;
        public double b;
        public double c;

        public Triangle(double A, double B, double C)
        {
            a = A;
            b = B;
            c = C;
        }

        public string outputA()
        {
            return Convert.ToString(a);
        }

        public string outputB()
        {
            return Convert.ToString(b);
        }

        public string outputC()
        {
            return Convert.ToString(c);
        }

        public double Perimeter()
        {
            double p = 0;
            p = a + b + c;
            return p;
        }

        public double Surface()
        {
            double s = 0;
            double p = 0;
            p = (a + b + c) / 2;
            s = Math.Sqrt((p * (p - a) * (p - b) * (p - c)));
            s = Math.Round(s, 2);
            return s;
        }

        public double Radius()
        {
            double p = 0;
            double r = 0;
            p = (a + b + c) / 2;
            r = Math.Sqrt(((p - a) * (p - b) * (p - c)) / p);
            r = Math.Round(r, 2);
            return r;
        }

        public double Bisector()
        {
            double p = 0;
            double l = 0; 
            p = (a + b + c) / 2;
            l = 2 * Math.Sqrt (a*b*p * (p - c)) / (a + b);
            l = Math.Round(l, 2);
            return l;
        }

        public double GetSetA
        {
            get
            { return a; }
            set
            { a = value; }
        }

        public double GetSetB
        {
            get
            { return b; }
            set
            { b = value; }
        }

        public double GetSetC
        {
            get
            { return c; }
            set
            { c = value; }
        }




        public bool ExistTriangle
        {
            get
            {
                if ((a > b + c) && (b > a + c) && (c > a + b))
                return false;
                else return true;
            }
        }

    }
}
