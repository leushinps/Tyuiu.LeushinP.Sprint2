
using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LeushinP.Sprint2.Task4.V12.Lib
{
    public class DataService : ISprint2Task4V12
    {
        public double Calculate(double x, double y)
        {

            double z = Math.Sqrt(x) > y * 2 ? (Math.Pow((7 + 2 / Math.Pow(y, 2)), x)) : ((3 * Math.Pow(x, 2) - Math.Pow(Math.Cos(y), 2) + 10) / (Math.Pow(y, 2) - Math.Pow(Math.Sin(x), 2) + 12));
            return Math.Round(z, 3);
        }
    }
}