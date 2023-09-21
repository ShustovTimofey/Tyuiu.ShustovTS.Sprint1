using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShustovTS.Sprint1.Task2.V7.Lib;

namespace Tyuiu.ShustovTS.Sprint1.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5; 
            double res = ds.CalculateSquareCircle(x);
            Assert.AreEqual(25, res);
        }
    }
}
