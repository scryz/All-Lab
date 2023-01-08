using MathTaskClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MathTaskClassLibraryTests
{
    [TestClass]
    public class Zadanie4Test
    {
        [TestMethod]
        public void zadanie4Test1()
        {
            Zadanie4 zadanie4 = new Zadanie4();
            string email = "test@test.test";
            int expected = 1;
            int actual = zadanie4.zadanie4(email);
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void zadanie4Test2()
        {
            Zadanie4 zadanie4 = new Zadanie4();
            string email = "test@testtest";
            int expected = 0;
            int actual = zadanie4.zadanie4(email);
            Assert.AreEqual(actual, expected);
        }
    }
}
