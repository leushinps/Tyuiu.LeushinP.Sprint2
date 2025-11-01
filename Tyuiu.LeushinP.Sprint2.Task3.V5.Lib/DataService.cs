using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LeushinP.Sprint2.Task3.V5.Lib
{
    public class DataService : ISprint2Task3V5
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 1)
            {

                y = x - Math.Pow((x + 1) / (x - 1), x);
            }
            else if (x == 0)
            {

                double xSquared = x * x;
                y = (xSquared - Math.Cos(xSquared)) / (xSquared - Math.Sin(xSquared) + 12);
            }
            else if (x > -9 && x < 0)
            {
                // y = 6 + 4/x²
                y = 6 + 4 / (x * x);
            }
            else
            {

                y = Math.Pow(x, 3) + 10 * x - (x * x / Math.Pow(x, 4));
            }

            return Math.Round(y, 3);
        }
    }
}