
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LeushinP.Sprint2.Task0.V26.Lib
{
    public class DataService : ISprint2Task0V26
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x + 70 == y;
            res[1] = x != y;    //неравернство не равно x и y
            res[2] = x > y;
            res[3] = x + 2 > y;
            res[4] = y <= x;
            res[5] = x + 3 >= y;
            return res;
        }
    }
}
