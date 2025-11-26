using NUnit.Framework;
using Tyuiu.LeushinP.Sprint2.Task7.V10.Lib;

namespace Tyuiu.LeushinP.Sprint2.Task7.V10.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 0.7;
            double y = 0.5;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}