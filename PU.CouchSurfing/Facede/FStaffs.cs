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
    public class FStaffs
    {
        public static DataTable List()
        {
            SqlDataAdapter adp = new SqlDataAdapter("SList", Tools.Connect);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }
        /*public static DataTable Search(EStaffs id)
        {
            SqlCommand search = new SqlCommand("SSearch", Tools.Connect);
            search.CommandType = CommandType.StoredProcedure;
            search.Parameters.AddWithValue("@StaffId", id.StaffId);
            Tools.ExecuteNonQuery(search);
            SqlDataAdapter adp = new SqlDataAdapter(search);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }*/

        public static bool Delete(EStaffs sdelete)
        {
            SqlCommand delete = new SqlCommand("SDelete", Tools.Connect);
            delete.CommandType = CommandType.StoredProcedure;
            delete.Parameters.AddWithValue("@StaffId", sdelete.StaffId);
            return Tools.ExecuteNonQuery(delete);
        }

        public static bool Add(EStaffs sadd)
        {
            SqlCommand add = new SqlCommand("SAdd", Tools.Connect);
            add.CommandType = CommandType.StoredProcedure;
            add.Parameters.AddWithValue("@StaffNameSurname", sadd.StaffNameSurname);
            add.Parameters.AddWithValue("@StaffPassword", sadd.StaffPassword);
            add.Parameters.AddWithValue("@StaffMail", sadd.StaffMail);
            add.Parameters.AddWithValue("@StaffPhone", sadd.StaffPhone);
            return Tools.ExecuteNonQuery(add);
        }

        public static bool Update(EStaffs supdate)
        {
            SqlCommand update = new SqlCommand("SUpdate", Tools.Connect);
            update.CommandType = CommandType.StoredProcedure;
            update.Parameters.AddWithValue("@StaffId", supdate.StaffId);
            update.Parameters.AddWithValue("@StaffNameSurname", supdate.StaffNameSurname);
            update.Parameters.AddWithValue("@StaffPassword", supdate.StaffPassword);
            update.Parameters.AddWithValue("@StaffMail", supdate.StaffMail);
            update.Parameters.AddWithValue("@StaffPhone", supdate.StaffPhone);
            return Tools.ExecuteNonQuery(update);
        }
    }
}
