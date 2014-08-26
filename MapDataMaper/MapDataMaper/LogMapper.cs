using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MapDataMaper
{
    public class LogMapper
    {
        public void insertLog(int userID, DateTime logTime, string descr, string progLoc, string message)
        {
            DataTable dt = new DataTable();
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_InsertLog";
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("@UserID", SqlDbType.VarChar).Value = userID;
            com.Parameters.Add("@Logtime", SqlDbType.DateTime).Value = logTime;
            com.Parameters.Add("@Descr", SqlDbType.VarChar).Value = descr;
            com.Parameters.Add("@ProgramLocation", SqlDbType.VarChar).Value = progLoc;
            com.Parameters.Add("@Message", SqlDbType.VarChar).Value = message;

            com.Connection = con;

            con.Open();

            com.ExecuteNonQuery();

            con.Close();
        }
    }
}
