using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MapDataMaper
{
    public class MapPinMapper
    {
        public DataTable getPinByType(int Type)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_GetPinList";
            com.CommandType = CommandType.StoredProcedure;

            //com.Parameters.Add("@PinType", SqlDbType.Int).Value = Type;

            com.Connection = con;


            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);

            con.Close();


            return dt;
        }
    }
}

