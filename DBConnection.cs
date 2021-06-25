using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Historial_Catergorias_Articulos
{
    static class DBConnection
    {

        public static SqlConnection GetConnection() 
        {
            string server = "localhost";
            string user = "sa";
            string pass = "farmatic";
            string db = "Farmatic";

            SqlConnectionStringBuilder stringBuilder = new SqlConnectionStringBuilder();
            stringBuilder.DataSource = server;
            stringBuilder.IntegratedSecurity = false;
            stringBuilder.UserID = user;
            stringBuilder.Password = pass;
            stringBuilder.InitialCatalog = db;

            return new SqlConnection(stringBuilder.ConnectionString);
        }

    }

}
