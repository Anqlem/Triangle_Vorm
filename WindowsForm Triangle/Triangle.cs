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
        public double r;

        public Triangle(double A, double B, double C, double R)
        {
            a = A;
            b = B;
            c = C;
            r = R;
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

        public string outputR()
        {
            return Convert.ToString(r);
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
            s = r*Perimeter();
            return s;
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

        public double GetSetR
        {
            get
            { return r; }
            set
            { r = value; }
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
