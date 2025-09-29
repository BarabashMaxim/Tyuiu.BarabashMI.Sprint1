using Tyuiu.BarabashMI.Sprint1.Task6.V1.Lib;
namespace Tyuiu.BarabashMI.Sprint1.Task6.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "1";
            string res = "49";
            Assert.AreEqual(res, ds.SymbolCode(str));
        }
    }
}
