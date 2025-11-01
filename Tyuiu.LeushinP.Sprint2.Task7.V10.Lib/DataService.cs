﻿using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LeushinP.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {

            bool Parabola = y >= (x * x) - 2;
            bool Line = y <= -x;

            return Parabola && Line;
        }
        public double CalculateFunction(double x)
        {

            double result = Math.Pow(x, 3) + 2 * Math.Pow(x, 2) - 3 * x + 5;

            return Math.Round(result, 3);
        }
    }
}