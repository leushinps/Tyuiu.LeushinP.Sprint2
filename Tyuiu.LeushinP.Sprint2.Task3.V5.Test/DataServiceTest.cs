using NUnit.Framework;
using Tyuiu.LeushinP.Sprint2.Task3.V5.Lib;

namespace Tyuiu.LeushinP.Sprint2.Task3.V5.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = -7;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}