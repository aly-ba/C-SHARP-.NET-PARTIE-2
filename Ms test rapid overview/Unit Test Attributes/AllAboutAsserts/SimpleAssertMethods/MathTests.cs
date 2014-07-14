using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AssertMethods
{
    [TestClass]
    public class MathTests
    {

        [TestCategory("Sqrt"), Priority(1), CssProjectStructure("vstfs:///Classification/Node/b22eef03-1a63-41b5-ac8e-5e1e0f3684a0"), 
        CssIteration("vstfs:///Classification/Node/97ac810e-e999-4eea-8541-5c7e071aaff7"), 
        TestMethod]
        [Owner("Phani")]
        [Description("This test is for testing the sqrt")]
        [TestProperty("Test Reviewer: ", "Thomas")]
        [Timeout(4000)]
        [WorkItem(1)]
        [ExpectedException(typeof(DivideByZeroException))]
        public void IsSqrtTest_1()
        {
            // arrange
            const double INPUT = 4;
            const double EXPECTED = 2;
            int i;

            // act
            //double actual = Math.Sqrt(4);
            double actual = Math.Sqrt(Math.DivRem(1,0,out i));

            // assert
            Assert.AreEqual(EXPECTED,actual,
                "Sqrt of {0} should have been 2!",INPUT);

        }

        [Priority(2), TestMethod]
        public void DeltaTest_4()
        {
            const double EXPECTED = 3.1622;
            const double DELTA = 0.00007;

            // 3.1622776601683795
            // 0.000077...
            double actual = Math.Sqrt(10);

            Assert.AreEqual(EXPECTED, actual, DELTA, "fail message!!!");

        }

        [TestMethod]
        public void IsStringSame_2()
        {
            // arrange
            const string INPUT = "HELLO";
            const string EXPECTED = "hello";

            // act and assert

            Assert.AreEqual(EXPECTED, INPUT, true);

        }

        [TestMethod]
        public void StringSameTest_3()
        {
            string a = "Hello";
            string b = "Hello";

            Assert.AreSame(a, b);
        }

        [TestMethod]
        public void IntegersSameTest_5()
        {
            int i = 10;
            int j = 10;

            Assert.AreEqual(i, j);

        }

    }
}
