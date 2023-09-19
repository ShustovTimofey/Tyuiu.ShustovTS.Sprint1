using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShustovTS.Sprint1.Task0.V13.Lib

namespace Tyuiu.ShustovTS.Sprint1.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}
