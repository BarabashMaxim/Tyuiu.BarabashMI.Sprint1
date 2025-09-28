using Tyuiu.BarabashMI.Sprint1.Task4.V24.Lib;
namespace Tyuiu.BarabashMI.Sprint1.Task4.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.333, res);
        }
    }
}
