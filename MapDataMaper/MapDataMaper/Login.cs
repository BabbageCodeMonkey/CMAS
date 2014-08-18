using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MapDataMaper
{
    public class Login
    {
        public DataTable getCred(string username, string password)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_GetLogin";
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("@Username", SqlDbType.VarChar).Value = username;
            com.Parameters.Add("@Password", SqlDbType.VarChar).Value = password;


            com.Connection = con;


            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);

            con.Close();


            return dt;
        }
    }
}
