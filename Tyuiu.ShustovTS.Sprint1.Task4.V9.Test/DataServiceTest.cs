using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShustovTS.Sprint1.Task4.V9.Lib;

namespace Tyuiu.ShustovTS.Sprint1.Task4.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 5;
            double wait = -0.171;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
