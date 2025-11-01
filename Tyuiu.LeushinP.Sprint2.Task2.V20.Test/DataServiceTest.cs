using NUnit.Framework;
using Tyuiu.LeushinP.Sprint2.Task2.V20.Lib;

namespace Tyuiu.LeushinP.Sprint2.Task2.V20.Test
{
    [TestFixture]
    public class DataServiceTest
    {
        [Test]
        public void CheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 4;
            bool expected = true;


            bool actual = ds.CheckDotInShadedArea(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}