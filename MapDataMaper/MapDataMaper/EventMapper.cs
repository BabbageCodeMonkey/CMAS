using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MapDataMaper
{
    public class EventMapper
    {
        public DataTable getEventList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_GetEventList";
            com.CommandType = CommandType.StoredProcedure;

            com.Connection = con;


            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);

            con.Close();


            return dt;
        }

        public DataTable getEventByID(int ID)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_GetEventByID";
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("@EventID", SqlDbType.Int).Value = ID;

            com.Connection = con;


            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);

            con.Close();


            return dt;
        }

        public void insertEvent(int locID, int catID, int useID, string decr, DateTime date)
        {
            DataTable dt = new DataTable();
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_GetEventByID";
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("@LocationID", SqlDbType.Int).Value = locID;
            com.Parameters.Add("@CategoryID", SqlDbType.Int).Value = catID;
            com.Parameters.Add("@UserID", SqlDbType.Int).Value = useID;
            com.Parameters.Add("@Descr", SqlDbType.VarChar).Value = decr;
            com.Parameters.Add("@EventDate", SqlDbType.DateTime).Value = date;
            com.Parameters.Add("@Active", SqlDbType.Bit).Value = true;

            com.Connection = con;

            con.Open();

            com.ExecuteNonQuery();

            con.Close();

        }
    }
}
