using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShustovTS.Sprint1.Task7.V22.Lib;

namespace Tyuiu.ShustovTS.Sprint1.Task7.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService dataService = new DataService();
            double x = 2, y = 1, wait = 1, res = dataService.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
