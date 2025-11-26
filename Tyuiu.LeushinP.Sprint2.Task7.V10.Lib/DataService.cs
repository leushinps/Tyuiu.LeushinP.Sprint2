using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LeushinP.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((y >= Math.Pow(x, 2) - 2) && (x <= 2) && (x >= -2) && (y >= -2) && (y <= 2))
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