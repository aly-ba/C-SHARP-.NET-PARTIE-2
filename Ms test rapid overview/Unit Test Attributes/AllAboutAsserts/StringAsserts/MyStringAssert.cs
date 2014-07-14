using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringAsserts
{
    [TestClass]
    public class MyStringAsserts
    {
        [TestMethod]
        public void StringContainsTest()
        {
            StringAssert.Contains("All about asserts",
                                                    "out");
        }

        [TestMethod]
        public void StringMatchesTest()
        {
               StringAssert.Matches("Search thisstringforwhitespaces",
                            new System.Text.RegularExpressions.Regex(@"\s"));
        }


        [TestMethod]
        public void StringStartsWithTest()
        {
            StringAssert.StartsWith("Starts with correct text",
                                                    "Starts with");
        }

        [TestMethod]
        public void StringEndsWithTest()
        {
            StringAssert.EndsWith("string which ends with searched",
                                    "Ends with searched");
        }


    }
}
