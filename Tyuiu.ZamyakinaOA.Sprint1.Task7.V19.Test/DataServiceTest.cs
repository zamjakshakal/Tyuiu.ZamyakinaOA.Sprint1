using Tyuiu.ZamyakinaOA.Sprint1.Task7.V19.Lib;

namespace Tyuiu.ZamyakinaOA.Sprint1.Task7.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(-5.158529015192103, res);
        }
    }
}
