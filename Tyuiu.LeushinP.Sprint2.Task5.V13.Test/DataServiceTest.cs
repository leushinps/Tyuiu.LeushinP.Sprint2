using Tyuiu.LeushinP.Sprint2.Task5.V13.Lib;

namespace Tyuiu.LeushinP.Sprint2.Task5.V13.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidFindDateOfNextDay1()
        {
            DataService ds = new DataService();
            int g = 2025;
            int m = 1;
            int n = 28;
            string wait = "28.01.2025";
            string res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(wait, res);
        }
    }
}