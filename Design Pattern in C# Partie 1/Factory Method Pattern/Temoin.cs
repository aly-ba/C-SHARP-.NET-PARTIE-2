using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterninCsharp.Factory_Method_Pattern
{
     public  class Temoin
        {
         public void Appinit()
         {

             if (AppDomain.Context == DatabaseType.SqlServer)
             {
                 SqlConnection = new SqlConnection();
                 SqlCommand command = new SqlCommand();

                 command.Connection = connection;
                 command.ExecuteNonQuery();

             }

             else if (AppContext.DataType == DataType.Oracle)
             {
                 OracleConnection connection = new OracleConnecton();
                 OracleCommand command = new OracleCommand();

                 command.Connection = connetion;
                 command.ExecuteNonQuery();
             }
         }


         //remplacé par  un code plus beau

         private void NewInsertRecord()
         {
             DbConnection connection = AppContext.DbProviderFactory.CreateConnection();
             DbCommand command = AppContext.DbProviderFactory.CreateCommand();
             command.Connection = connection;
             command.ExecuteNonQuery();
         }

        }
}
