using System;
using System.Text;
using System.Collections.Generic;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;

namespace CollectionAsserts
{
    [TestClass]
    public class CollectionTests
    {
        static Collection<string> employees;

        [ClassInitialize]
        public static void CreateData(TestContext testContext)
        {
            employees = new Collection<string>();
           
            employees.Add("Aaron");
            employees.Add("David");
            employees.Add("Phani");
            employees.Add("Vineet");
        }

        [ClassCleanup]
        public static void CleanUp()
        {
            // cleanup
        }

        [TestMethod]
        public void AllItemsAreNotNull()
        {
            CollectionAssert.AllItemsAreNotNull(employees, "Not null failed");
        }

        [TestMethod]
        public void AllItemsAreUnique()
        {
            CollectionAssert.AllItemsAreUnique(employees, "Uniqueness failed");
        }

        [TestMethod]
        public void AreEqual()
        {
            
            Collection<string> employees3 = new Collection<string>();

            employees3.Add("Aaron");
            employees3.Add("David");
            employees3.Add("Phani");
            employees3.Add("Vineet");           

            CollectionAssert.AreEqual(employees, employees3);

        }

        [TestMethod]
        public void AreEquivalent()
        {

            Collection<string> employees3 = new Collection<string>();

            employees3.Add("David");
            employees3.Add("Aaron");
            employees3.Add("Phani");
            employees3.Add("Vineet");

            CollectionAssert.AreEquivalent(employees, employees3);
        }

        [TestMethod]
        public void employees_Subset()
        {
            Collection<string> employees_Subset = new Collection<string>();

            employees_Subset.Add(employees[2]);
            employees_Subset.Add("Soni");

            CollectionAssert.IsSubsetOf(employees_Subset, employees, "failed!");
        }

    }

}
