using MathTaskClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class Zadanie3Test
    {
        [TestMethod]
        public void zadanie3Test1()
        {
            Zadanie3 zadanie3 = new Zadanie3();
            int years = 2000;
            int expected = 366;
            int actual = zadanie3.zadanie3(years);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void zadanie3Test2()
        {
            Zadanie3 zadanie3 = new Zadanie3();
            int years = 2023;
            int expected = 365;
            int actual = zadanie3.zadanie3(years);
            Assert.AreEqual(expected, actual);
        }
    }
}
