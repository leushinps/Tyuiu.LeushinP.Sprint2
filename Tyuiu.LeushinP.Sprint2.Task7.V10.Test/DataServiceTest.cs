using NUnit.Framework;
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

            // внутри заштрихованной
            Assert.IsTrue(ds.CheckDotInShadedArea(0, 0));
            Assert.IsTrue(ds.CheckDotInShadedArea(1, 0));
            Assert.IsTrue(ds.CheckDotInShadedArea(-1, 0));
        }

        [Test]
        public void ValidCheckDotInShadedArea_OnBoundary()
        {
            DataService ds = new DataService();

            // на границе
            Assert.IsTrue(ds.CheckDotInShadedArea(1, -1)); 
            Assert.IsTrue(ds.CheckDotInShadedArea(2, 2)); 
            Assert.IsTrue(ds.CheckDotInShadedArea(-2, 2));
        }

        [Test]
        public void ValidCheckDotInShadedArea_Outside()
        {
            DataService ds = new DataService();

            // вне заштрихованной
            Assert.IsFalse(ds.CheckDotInShadedArea(0, -3));  
            Assert.IsFalse(ds.CheckDotInShadedArea(2, 3));  
            Assert.IsFalse(ds.CheckDotInShadedArea(-2, -3)); 
        }

        [Test]
        public void ValidCheckDotInShadedArea_CornerCases()
        {
            DataService ds = new DataService();
            Assert.IsTrue(ds.CheckDotInShadedArea(0, -2));   
            Assert.IsFalse(ds.CheckDotInShadedArea(3, 1));  
        }
    }
}