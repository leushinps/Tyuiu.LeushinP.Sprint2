using NUnit.Framework;
using Tyuiu.LeushinP.Sprint2.Task6.V2.Lib;

namespace Tyuiu.LeushinP.Sprint2.Task6.V2.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidFindMonthSeason_Winter()
        {
            DataService ds = new DataService();

            Assert.AreEqual("зима", ds.FindMonthSeason(12));
            Assert.AreEqual("зима", ds.FindMonthSeason(1));
            Assert.AreEqual("зима", ds.FindMonthSeason(2));
        }
    }
}