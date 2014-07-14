using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserDetails
{
    public class UserDetailEntry
    {
        public bool Add(string userId, 
                            string telephone, 
                            string email)
        {
            if (userId.Length < 4)
                throw new Exception("UserId should be greater than 4 characters!");

            if (telephone.Contains("a"))
                throw new Exception("telephone should not contain alphabets!");

            if (!email.Contains("@"))
                throw new Exception("Email should contain @!");

            // if validations pass then make an entry in database

            // logic to write the code to database

            return true;

        }
    }
}
