
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LeushinP.Sprint2.Task0.V26.Lib
{
    public class DataService : ISprint2Task0V26
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x == y + 70;        // 1045 == 975 + 70 → 1045 == 1045 
            res[1] = x == y;             // 1045 == 975
            res[2] = x - 70 > y;         // 1045 - 70 = 975 > 975
            res[3] = x > y;              // 1045 > 975 
            res[4] = x >= y;             // 1045 >= 975 
            res[5] = x + 1 >= y + 71;    // 1045 + 1 = 1046 >= 975 + 71 = 1046
            return res;
        }
    }
}
