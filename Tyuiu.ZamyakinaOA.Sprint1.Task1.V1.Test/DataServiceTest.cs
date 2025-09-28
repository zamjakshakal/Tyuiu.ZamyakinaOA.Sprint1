using Tyuiu.ZamyakinaOA.Sprint1.Task1.V1.Lib;

namespace Tyuiu.ZamyakinaOA.Sprint1.Task1.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 1.0;
            double a = 2.0;
            var res = ds.Calculate(a, x, y);
            Assert.AreEqual(13, res);
        }
    }
}
