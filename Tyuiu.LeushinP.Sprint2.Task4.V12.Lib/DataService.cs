
using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LeushinP.Sprint2.Task4.V12.Lib
{
    public class DataService : ISprint2Task4V12
    {
        public double Calculate(double x, double y)
        {

            double result = Math.Sqrt(x) > 2 * y
                ? Math.Pow(7 + 3 / y, x)
                : (Math.Pow(x, y) - Math.Sin(y) + 10) / (Math.Pow(y, x) - Math.Sin(x) + 12);

            return Math.Round(result, 3);
        }
    }
}