using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_var17
{
    internal class Tabul
    {
        public double[,] xy = new double[1000, 2];
        public int n = 0;

        private double f1(double x)
        {
            return Math.Pow(Math.Abs(x), 2 * x + 1);
        }

        private double f2(double x)
        {
            return Math.Sin(x * x);
        }

        private double f3(double x)
        {
            return Math.Pow(Math.Log(Math.Abs(x)), 2) + Math.Sqrt(x);
        }

        // Метод табулювання
        public void tab(double xn = -4.41, double xk = 11.25, double h = 0.6, double a = 0.8)
        {
            double x = xn;
            double y = 0;
            int i = 0;

            while (x <= xk)
            {
                if (x <= 0)
                {
                    y = f1(x);
                }
                else
                {
                    if ((x > 0) && (x <= a))
                    {
                        y = f2(x);
                    }
                    else
                    {
                        y = f3(x);
                    }
                }

                xy[i, 0] = x;
                xy[i, 1] = y;
                x += h;
                i++;
            }
            n = i;
        }
    }
}