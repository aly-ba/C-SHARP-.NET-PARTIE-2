using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Proxy_SOAPService
{
    [ServiceContract]
    public interface IPersonService
    {
        [OperationContract]
        List<Person> GetPeople();
    }

    public class Person
    {
        public string FirstName;
        public string LastName;
        public DateTime StartDate;
        public int Rating;
    }
}
