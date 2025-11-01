
using Tyuiu.LeushinP.Sprint2.Task7.V10.Lib;

namespace Tyuiu.LeushinP.Sprint2.Task7.V10.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void ValidCheckDotInShadedArea_Inside()
        {
            DataService ds = new DataService();

            Assert.IsTrue(ds.CheckDotInShadedArea(0, -1));
            Assert.IsTrue(ds.CheckDotInShadedArea(-1, 0));
            Assert.IsTrue(ds.CheckDotInShadedArea(0.5, -1.5));
        }

    }
}