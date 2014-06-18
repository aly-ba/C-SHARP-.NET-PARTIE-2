using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCsharp.Abstract_Factory_Pattern
{
   public  class AFPClient : DbProviderFactory
    {
       SqlClientFactory factory = SqlClientFactory.Instance;

       DbConnection connection = factory.CreateConnection();
       DbCommand command  = factory.createCommand();

       command.Connection = connection;
       command.Commandtext =" query here";
       command.ExecuteNonQuery();
       

    }
}
