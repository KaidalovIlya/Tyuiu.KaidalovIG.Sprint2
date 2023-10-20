using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KaidalovIG.Sprint2.Task6.V4.Lib;

namespace Tyuiu.KaidalovIG.Sprint2.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            Assert.AreEqual("Пики", ds.FindCardSuit(1));
            Assert.AreEqual("Трефы", ds.FindCardSuit(2));
            Assert.AreEqual("Бубны", ds.FindCardSuit(3));
            Assert.AreEqual("Червы", ds.FindCardSuit(4));
            Assert.AreEqual("Введено некорректное число", ds.FindCardSuit(0));
        }
    }
}
