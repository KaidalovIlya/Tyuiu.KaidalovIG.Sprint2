using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaidalovIG.Sprint2.Task3.V21.Lib;

namespace Tyuiu.KaidalovIG.Sprint2.Task3.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual(242.0, ds.Calculate(2));
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.833, ds.Calculate(0));
        }
        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.5, ds.Calculate(-1));
        }
        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();
            Assert.AreEqual(-285.962, ds.Calculate(-26));
        }
    }
}
