using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCsharp.Factory_Method_Pattern
{
    public  class SqlClientFactory : DbProviderFactory
    {
        public override DbConnection CreateConnection()
        {
            return new SqlConnection();
        }

        public override DbCommand CreateCommadn()
        {
             return SqlCommand();
        }

    }
}
