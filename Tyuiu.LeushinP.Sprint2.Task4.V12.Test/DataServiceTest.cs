using NUnit.Framework;
using Tyuiu.LeushinP.Sprint2.Task4.V12.Lib;

namespace Tyuiu.LeushinP.Sprint2.Task4.V12.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidCalculateFirstCondition()
        {
            DataService ds = new DataService();
            double x = 16;
            double y = 1;
            double wait = 100; 
            double res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}