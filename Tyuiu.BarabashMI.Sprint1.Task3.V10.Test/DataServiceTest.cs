using Tyuiu.BarabashMI.Sprint1.Task3.V10.Lib;
namespace Tyuiu.BarabashMI.Sprint1.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 23.6;
            var res = ds.NumberToMoney(x);
            Assert.AreEqual("23 руб. 6 коп.", res);
        }
    }
}
