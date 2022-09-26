using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class QuadraticEquation
    {
        private double a;
        private double b;
        private double c;
        public double? X1 { get; private set; }
        public double? X2 { get; private set; }
        public double? this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return X1;
                    case 1:
                        return X2;
                    default:
                        return null;
                }
            }
            private set
            {
                switch (index)
                {
                    case 0:
                        X1 = value;
                        break;
                    case 1:
                        X2 = value;
                        break;
                }
            }
        }

        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public void Solve()
        {
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d > 0)
            {
                X1 = (-1 * b + Math.Sqrt(d)) / (2 * a);
                X2 = (-1 * b - Math.Sqrt(d)) / (2 * a);
            }
            else
            {
                X1 = null;
                X2 = null;
            }
        }
    }
}
