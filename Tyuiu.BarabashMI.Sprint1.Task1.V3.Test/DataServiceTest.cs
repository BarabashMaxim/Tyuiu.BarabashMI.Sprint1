using Tyuiu.BarabashMI.Sprint1.Task1.V3.Lib;
namespace Tyuiu.BarabashMI.Sprint1.Task1.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 3.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(3, res);
        }
    }
}
