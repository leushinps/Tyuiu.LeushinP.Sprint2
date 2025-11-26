using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LeushinP.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((Math.Pow(x, 2) + Math.Pow(y, 2) <= 1) && ((x > 0) && (x <= 1) && ((y > 0) && (x <= 1))))
            {
                res = true;
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}