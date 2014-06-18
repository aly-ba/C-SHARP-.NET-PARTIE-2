using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCsharp.Factory_Method_Pattern
{
    public  class OracleClientFactory
    {
        public override DbConnection CreateConnection()
        {
            return new OracleConnecion();
        }

        public override DbCommand CreateCOmmand()
        {
            return OracleCommand();
        }
    }
}
