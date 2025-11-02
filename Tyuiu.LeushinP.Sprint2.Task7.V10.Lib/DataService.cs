using System;
using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.LeushinP.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Условие: область ограничена y = x^2 - 2, y = x и y = -x
            bool aboveParabola = y >= x * x - 2;
            bool belowLineYEqualsX = y <= x;
            bool aboveLineYEqualsMinusX = y >= -x;

            return aboveParabola && belowLineYEqualsX && aboveLineYEqualsMinusX;
        }
    }
}