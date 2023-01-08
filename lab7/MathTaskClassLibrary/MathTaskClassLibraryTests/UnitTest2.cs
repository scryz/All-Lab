using MathTaskClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathTaskClassLibraryTests
{

    [TestClass]
    public class Zadanie2Test
    {
      #region Дополнительные атрибуты тестирования
        //
        // При написании тестов можно использовать следующие дополнительные атрибуты:
        //
        // ClassInitialize используется для выполнения кода до запуска первого теста в классе
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // TestInitialize используется для выполнения кода перед запуском каждого теста 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // TestCleanup используется для выполнения кода после завершения каждого теста
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void zadanie2Test1()
        {
            Zadanie2 zadanie2 = new Zadanie2();
            double[] actual = zadanie2.zadanie2(1, 2, 1);
            double[] expected = new double[1] { -1 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void zadanie2Test2()
        {
            Zadanie2 zadanie2 = new Zadanie2();
            double[] actual = zadanie2.zadanie2(3, 2, 1);
            double[] expected = new double[0];
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void zadanie2Test3()
        {
            Zadanie2 zadanie2 = new Zadanie2();
            double[] actual = zadanie2.zadanie2(1, 4, 3);
            double[] expected = new double[2] { -1, -3 };
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
