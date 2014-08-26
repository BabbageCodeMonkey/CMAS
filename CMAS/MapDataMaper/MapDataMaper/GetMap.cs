using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//test

namespace MapDataMaper
{
    public class GetMap
    {
        public DataTable getMap()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection("sqlinstance-1.cnsq0dkjy1df.us-west-2.rds.amazonaws.com,1433", "CMAS", "*050987Wwhite", "awsuserwill"));
            SqlCommand com = new SqlCommand();

            com.CommandText = "MapProcedure";
            com.CommandType = CommandType.StoredProcedure;

            com.Connection = con;


            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);

            con.Close();


            return dt;
        }


    }
}
