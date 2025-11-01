﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LeushinP.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Порабола
            bool aboveParabola = y >= Math.Pow(x, 2) - 2;

            //прямая
            bool belowLine = y <= -x;

            return aboveParabola && belowLine;
        }
    }
}
