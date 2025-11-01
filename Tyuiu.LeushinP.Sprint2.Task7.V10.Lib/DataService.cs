using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LeushinP.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {


            bool AboveParabola = y >= x * x - 2;
            bool BelowLine1 = y <= x;
            bool AboveLine2 = y >= -x;

            return AboveParabola && BelowLine1 && AboveLine2;
        }
    }
}