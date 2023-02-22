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
    public class FGuests
    {
        public static DataTable List()
        {
            SqlDataAdapter adp = new SqlDataAdapter("GList", Tools.Connect);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        /*public static DataTable Search(EGuest id)
        {
            SqlCommand search = new SqlCommand("GSearch", Tools.Connect);
            search.CommandType = CommandType.StoredProcedure;
            search.Parameters.AddWithValue("@GuestId", id.GuestId);
            Tools.ExecuteNonQuery(search);
            SqlDataAdapter adp = new SqlDataAdapter(search);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }*/

        public static bool Delete(EGuests cdelete)
        {
            SqlCommand delete = new SqlCommand("GDelete", Tools.Connect);
            delete.CommandType = CommandType.StoredProcedure;
            delete.Parameters.AddWithValue("@GuestId", cdelete.GuestId);
            return Tools.ExecuteNonQuery(delete);
        }

        public static bool Add(EGuests gadd)
        {
            SqlCommand add = new SqlCommand("GAdd", Tools.Connect);
            add.CommandType = CommandType.StoredProcedure;
            add.Parameters.AddWithValue("@HostId", gadd.HostId);
            add.Parameters.AddWithValue("@GuestNameSurname", gadd.GuestNameSurname);
            add.Parameters.AddWithValue("@GuestPhone", gadd.GuestPhone);
            add.Parameters.AddWithValue("@GuestMail", gadd.GuestMail);
            add.Parameters.AddWithValue("@GuestAddress", gadd.GuestAddress);
            add.Parameters.AddWithValue("@GuestGoTo", gadd.GuestGoTo);
            return Tools.ExecuteNonQuery(add);
        }

        public static bool Update(EGuests gupdate)
        {
            SqlCommand update = new SqlCommand("GUpdate", Tools.Connect);
            update.CommandType = CommandType.StoredProcedure;
            update.Parameters.AddWithValue("@GuestId", gupdate.GuestId);
            update.Parameters.AddWithValue("@HostId", gupdate.HostId);
            update.Parameters.AddWithValue("@GuestNameSurname", gupdate.GuestNameSurname);
            update.Parameters.AddWithValue("@GuestPhone", gupdate.GuestPhone);
            update.Parameters.AddWithValue("@GuestMail", gupdate.GuestMail);
            update.Parameters.AddWithValue("@GuestAddress", gupdate.GuestAddress);
            update.Parameters.AddWithValue("@GuestGoTo", gupdate.GuestGoTo);
            return Tools.ExecuteNonQuery(update);
        }
    }
}
