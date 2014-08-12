using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MapDataMaper
{
    public class UserMapper
    {
        public DataTable getUserPickListFName()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_getUserPickListFName";
            com.CommandType = CommandType.StoredProcedure;

            com.Connection = con;


            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);

            con.Close();


            return dt;
        }

        public DataTable getUserList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_getPersonList";
            com.CommandType = CommandType.StoredProcedure;

            com.Connection = con;


            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);

            con.Close();


            return dt;
        }

        public void insertPerson(string FName, string LName, string Username, string Password, int AddressID, int pType, bool Active)
        {
            DataTable dt = new DataTable();
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_InsertPerson";
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("@FName", SqlDbType.VarChar).Value = FName;

            com.Parameters.Add("@LName", SqlDbType.VarChar).Value = LName;

            com.Parameters.Add("@Username", SqlDbType.VarChar).Value = Username;

            com.Parameters.Add("@Password", SqlDbType.VarChar).Value = Password;

            com.Parameters.Add("@AddressID", SqlDbType.Int).Value = AddressID;
            com.Parameters.Add("@pTypeID", SqlDbType.Int).Value = pType;

            com.Parameters.Add("@Active", SqlDbType.Bit).Value = Active;

            com.Connection = con;

            con.Open();

            com.ExecuteNonQuery();
            
            con.Close();
        }

        public DataTable getPersonByID(int ID)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_getPersonByID";
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("@UserID", SqlDbType.Int).Value = ID;

            com.Connection = con;


            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);

            con.Close();


            return dt;
        }
    }
}
