using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCsharp.Factory_Method_Pattern
{
    public  class DbProviderFactory
    {

        public virtual DbCommand CreateCommand();
        public virtual DbCommandBuilder CreateCommandBuilde();
        public virtual DbConnection CreateConnection();
        public virtual DbDataAdapter CreateDataAdapter();
        public virtual DbParameter CreateParameter();
    }
}
