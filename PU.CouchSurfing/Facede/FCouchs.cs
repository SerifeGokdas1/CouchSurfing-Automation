using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PU.CouchSurfing.Entity;
using System.Data;
using System.Data.SqlClient;

namespace PU.CouchSurfing.Facede
{
    public class FCouchs
    {
        public static DataTable List()
        {
            SqlDataAdapter adp = new SqlDataAdapter("CList", Tools.Connect);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        /*public static DataTable Search(ECouchs id)
        {
            SqlCommand search = new SqlCommand("CSearch", Tools.Connect);
            search.CommandType = CommandType.StoredProcedure;
            search.Parameters.AddWithValue("@CouchId", id.CouchId);
            Tools.ExecuteNonQuery(search);
            SqlDataAdapter adp = new SqlDataAdapter(search);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }*/

        public static bool Delete (ECouchs cdelete)
        {
            SqlCommand delete = new SqlCommand("CDelete", Tools.Connect);
            delete.CommandType = CommandType.StoredProcedure;
            delete.Parameters.AddWithValue("@CouchId", cdelete.CouchId);
            return Tools.ExecuteNonQuery(delete);
        }

        public static bool Add (ECouchs cadd)
        {
            SqlCommand add = new SqlCommand("CAdd", Tools.Connect);
            add.CommandType = CommandType.StoredProcedure;
            add.Parameters.AddWithValue("@CouchAddress", cadd.CouchAddress);
            add.Parameters.AddWithValue("@HostId", cadd.HostId);
            return Tools.ExecuteNonQuery(add);
        }

        public static bool Update (ECouchs cupdate)
        {
            SqlCommand update = new SqlCommand("CUpdate", Tools.Connect);
            update.CommandType = CommandType.StoredProcedure;
            update.Parameters.AddWithValue("@CouchId", cupdate.CouchId);
            update.Parameters.AddWithValue("@CouchAddress", cupdate.CouchAddress);
            update.Parameters.AddWithValue("@HostId", cupdate.HostId);
            return Tools.ExecuteNonQuery(update);
        }
    }
}
