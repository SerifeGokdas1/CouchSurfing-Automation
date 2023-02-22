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
    public class FHosts
    {
        public static DataTable List()
        {
            SqlDataAdapter adp = new SqlDataAdapter("HList", Tools.Connect);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        /*public static DataTable Search(EHosts id)
        {
            SqlCommand search = new SqlCommand("GSearch", Tools.Connect);
            search.CommandType = CommandType.StoredProcedure;
            search.Parameters.AddWithValue("@HostId", id.HostId);
            Tools.ExecuteNonQuery(search);
            SqlDataAdapter adp = new SqlDataAdapter(search);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }*/

        public static bool Delete(EHosts hdelete)
        {
            SqlCommand delete = new SqlCommand("HDelete", Tools.Connect);
            delete.CommandType = CommandType.StoredProcedure;
            delete.Parameters.AddWithValue("@HostId", hdelete.HostId);
            return Tools.ExecuteNonQuery(delete);
        }

        public static bool Add(EHosts hadd)
        {
            SqlCommand add = new SqlCommand("HAdd", Tools.Connect);
            add.CommandType = CommandType.StoredProcedure;
            add.Parameters.AddWithValue("@HostNameSurname", hadd.HostNameSurname);
            add.Parameters.AddWithValue("@HostPhone", hadd.HostPhone);
            add.Parameters.AddWithValue("@HostMail", hadd.HostMail);
            add.Parameters.AddWithValue("@HostAddress", hadd.HostAddress);
            add.Parameters.AddWithValue("@HostAcceptGuests", hadd.HostAcceptGuests);
            return Tools.ExecuteNonQuery(add);
        }

        public static bool Update(EHosts hupdate)
        {
            SqlCommand update = new SqlCommand("HUpdate", Tools.Connect);
            update.CommandType = CommandType.StoredProcedure;
            update.Parameters.AddWithValue("@HostId", hupdate.HostId);
            update.Parameters.AddWithValue("@HostNameSurname", hupdate.HostNameSurname);
            update.Parameters.AddWithValue("@HostPhone", hupdate.HostPhone);
            update.Parameters.AddWithValue("@HostMail", hupdate.HostMail);
            update.Parameters.AddWithValue("@HostAddress", hupdate.HostAddress);
            update.Parameters.AddWithValue("@HostAcceptGuests", hupdate.HostAcceptGuests);
            return Tools.ExecuteNonQuery(update);
        }
    }
}
