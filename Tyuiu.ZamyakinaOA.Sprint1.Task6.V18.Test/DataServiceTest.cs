using Tyuiu.ZamyakinaOA.Sprint1.Task6.V18.Lib;

namespace Tyuiu.ZamyakinaOA.Sprint1.Task6.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string x = "123";
            var res = ds.CheckNumber(x);
            Assert.AreEqual(true, res);
        }
    }
}
