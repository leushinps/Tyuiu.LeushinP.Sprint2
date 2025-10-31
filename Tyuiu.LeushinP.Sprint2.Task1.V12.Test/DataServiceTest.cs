
using Tyuiu.LeushinP.Sprint2.Task1.V12.Lib;

namespace Tyuiu.LeushinP.Sprint2.Task1.V12.Test
{
    public class Tests
    {
        [TestFixture]
        public class DataServiceTest
        {
            [Test]
            public void GetLogicOperations()
            {
                DataService ds = new DataService();
                int a = 152;
                int b = 116;
                int c = 887;
                int d = 556;
                bool[] res = new bool[6];
                res = ds.GetLogicOperations(a, b, c, d);
                bool[] wait = new bool[6] { true, true, true, false, true, false };
                CollectionAssert.AreEqual(res, wait);
            }
        }
    }
}