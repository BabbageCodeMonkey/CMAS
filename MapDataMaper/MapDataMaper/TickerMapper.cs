using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MapDataMaper
{
    public class TickerMapper
    {
        public DataTable getEventList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            //this needs to be updated with the proper event sp
            com.CommandText = "sp_getEventList";
            com.CommandType = CommandType.StoredProcedure;

            com.Connection = con;


            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);

            con.Close();


            return dt;
        }
    }
}