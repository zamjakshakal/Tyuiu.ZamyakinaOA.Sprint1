using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZamyakinaOA.Sprint1.Task0.V16.Lib;

namespace Tyuiu.ZamyakinaOA.Sprint1.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);

        }
    }
}
