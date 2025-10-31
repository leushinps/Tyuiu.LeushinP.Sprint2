using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.LeushinP.Sprint2.Task1.V12.Lib
{
    public class DataService : ISprint2Task1V12
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (c > d);           // true | true = true
            res[1] = (a + 2 > b) | (c > d);       // true | true = true
            res[2] = (a > b) || (c > d);          // true || true = true
            res[3] = (a + 2 > b) && (c < d);      // true && false = false
            res[4] = !(res[3]);                   // !false = true
            res[5] = (a > b) ^ (c > d);           // true ^ true = false

            return res;
        }
    }
}