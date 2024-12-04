using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MenshchikovaDA.Lab1.Review.V6.Lib;

namespace Tyuiu.MenshchikovaDA.Lab1.Review.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            double x = 0.6;
            double y = 0.4;

            DataService ds = new DataService();

            double result = ds.Calc(x, y);

            double true_val = 0.492;

            Assert.AreEqual(true_val, result);
        }
    }
}
