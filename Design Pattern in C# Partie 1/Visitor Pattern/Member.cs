using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCsharp.Visitor_Pattern
{
    public   class Member
    {
        public string Name;
        public DateTime DateOfBirth;

        public bool isAboveEighteen
        {
            get
            {
                bool result = (DateTime.Now - this.DateOfBirth).TotalDays > 365 * 18;
                return result;
            }
            
        }
    }
}
