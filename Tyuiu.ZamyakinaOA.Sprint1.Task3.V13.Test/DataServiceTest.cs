using Tyuiu.ZamyakinaOA.Sprint1.Task3.V13.Lib;

namespace Tyuiu.ZamyakinaOA.Sprint1.Task3.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 215;
            var res = ds.MultiplyOfDigits(x);
            Assert.AreEqual(10, res);
        }
    }
}
