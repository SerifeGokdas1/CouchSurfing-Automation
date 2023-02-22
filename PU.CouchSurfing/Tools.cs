using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace PU.CouchSurfing
{
    public class Tools
    {
        private static SqlConnection connect = new SqlConnection(ConfigurationManager.ConnectionStrings["CouchSurfing"].ToString());
        public static SqlConnection Connect
        {
            get { return connect; }
            set { connect = value; }
        }
        public static bool ExecuteNonQuery (SqlCommand command)
        {
            try
            {
                if (command.Connection.State != ConnectionState.Open)
                    command.Connection.Open();
                return command.ExecuteNonQuery() > 0;
            }catch(Exception)
            {
                return false;
            }finally
            {
                if (command.Connection.State != ConnectionState.Closed)
                    command.Connection.Close();
            }
        }
        
    }
}
