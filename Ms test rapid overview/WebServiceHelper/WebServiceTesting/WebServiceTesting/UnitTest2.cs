using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System.Web;

namespace WebServiceTesting
{
    /// <summary>
    /// Summary description for UnitTest2
    /// </summary>
    [TestClass]
    public class UnitTest2
    {
        public UnitTest2()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        [Microsoft.VisualStudio.TestTools.UnitTesting.Web.AspNetDevelopmentServer("WcfService1",
            @"F:\PS_OnDemand\Miscellaneous unit test features\WebServiceTesting\WcfService1")]
        public void TestMethod1()
        {
            //
            // TODO: Add test logic here
            //
            WebServiceTesting.ServiceReference1.Service1Client target = new 
                                        WebServiceTesting.ServiceReference1.Service1Client();
            
            System.Web.Services.Protocols.WebClientProtocol protocol = 
                    new System.Web.Services.Protocols.HttpGetClientProtocol();

            protocol.Url = "http://localhost:25555/Service1.svc";

            Assert.IsTrue(WebServiceHelper.TryUrlRedirection(protocol, 
                                                    testContextInstance,
                                                    "WcfService1"));
            int value = 222;
            string expected = "You entered: 222";
            string actual;
            actual = target.GetData(value);
            Assert.AreEqual(expected, actual);

        }
    }
}
