using MathTaskClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class Zadanie1Test
    {
        [TestMethod]
        public void zadanie1Test()
        {

            int n = 2;
            string expected = "AB";

            Zadanie1 zadanie1 = new Zadanie1();
            string actual = zadanie1.zadanie1(n);

            Assert.AreEqual(expected, actual);
        }
    }
}
