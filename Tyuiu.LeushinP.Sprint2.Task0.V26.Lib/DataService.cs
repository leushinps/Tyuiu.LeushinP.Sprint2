
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LeushinP.Sprint2.Task0.V26.Lib
{
    public class DataService : ISprint2Task0V26
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            {
                bool[] res = new bool[6];
                res[0] = x == y; //False
                res[1] = x != y + 70;  //False
                res[2] = x < y;  //False
                res[3] = x > y;  //True
                res[4] = y <= x;  //True
                res[5] = x >= y;  //True

                return res;
            }
        }
    }
}
