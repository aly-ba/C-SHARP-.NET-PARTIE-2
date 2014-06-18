using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCsharp.Visitor_Pattern
{   
    [TestClass]
    public  class VisitorTest
    {

        public void IsBoveEighteenTest()
        {
            IList <Member> list = new List<Member>()
            {
                new Member() { Name = "N1", DateOfBirth= new DateTime(2000, 1, 1)},
                new Member() { Name = "N2", DateOfBirth= new DateTime(2000, 1, 1)},
                new Member() { Name = "N3", DateOfBirth= new DateTime(1990, 1, 1)},
                new Member() { Name = "N4", DateOfBirth= new DateTime(1980, 1, 1)}
            };

            var selectedList = list.Where(m =>m.isAboveEighteen);
            foreach (Member member in selectedList) 
                 Console.WriteLine(member.Name);

            Assert.AreEqual(2, selectedList.Count());


        }
    }
}
