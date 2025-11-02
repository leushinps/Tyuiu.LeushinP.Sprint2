using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LeushinP.Sprint2.Task7.V10.Lib
{
    public class DataService : ISprint2Task7V10
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool Parabola = y >= x * x - 2;
            bool Line = y <= x;
            bool Line2 = y >= -x;

            return Parabola && Line && Line2;
        }
    }
}