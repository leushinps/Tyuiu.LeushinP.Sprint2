using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LeushinP.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {

            bool isAboveParabola = y >= Math.Pow(x, 2) - 2;
            bool isBelowLine = y <= -x;

            return isAboveParabola && isBelowLine;
        }
    }
}