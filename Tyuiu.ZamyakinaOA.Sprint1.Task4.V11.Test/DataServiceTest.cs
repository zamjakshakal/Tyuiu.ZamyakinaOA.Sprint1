using Tyuiu.ZamyakinaOA.Sprint1.Task4.V11.Lib;

namespace Tyuiu.ZamyakinaOA.Sprint1.Task4.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 0.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.785, res);
        }
    }
}
