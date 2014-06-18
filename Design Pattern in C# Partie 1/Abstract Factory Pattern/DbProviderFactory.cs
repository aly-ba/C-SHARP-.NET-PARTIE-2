using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;

namespace DesignPatterninCsharp.Abstract_Factory_Pattern
{
    //public abstract  class DbProviderFactory
    //{
    //    public abstract DbConnection CreaeteConnection();
    //    public abstract DbCommand CreateCommand();
    //}

    /// <summary>
    /// in other wise
    /// </summary>
    public abstract class DbProviderFactory
    {
        public virtual DbCommand CreateCommand();
        public virtual DbCommandBuilder CreateCommandBuilder();
        public virtual DbConnection CreateConnetion();
        public virtual DbDataAdapter CreateDataAdapter();
        public virtual DbParameter CreateParamter();

    }
}
