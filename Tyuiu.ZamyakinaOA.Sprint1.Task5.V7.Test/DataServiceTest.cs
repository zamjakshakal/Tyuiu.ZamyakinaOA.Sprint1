using Tyuiu.ZamyakinaOA.Sprint1.Task5.V7.Lib;

namespace Tyuiu.ZamyakinaOA.Sprint1.Task5.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double f = 50;
            var res = ds.AngleToHoursMinutes(f);
            Assert.AreEqual(1, res);
        }
    }
}
