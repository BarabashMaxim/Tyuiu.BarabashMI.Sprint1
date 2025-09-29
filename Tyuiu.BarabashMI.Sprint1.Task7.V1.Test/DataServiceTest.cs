using Tyuiu.BarabashMI.Sprint1.Task7.V1.Lib;
namespace Tyuiu.BarabashMI.Sprint1.Task7.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double a = 1, b = 2, c = 3;
            double res = 0.25;
            Assert.AreEqual(res, ds.Calculate(a, b ,c));
        }
    }
}
