using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace MapDataMaper
{
     public class FormMaper
    {
        public DataTable getFormList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_getFormList";
            com.CommandType = CommandType.StoredProcedure;

            com.Connection = con;


            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);

            con.Close();


            return dt;

        }

        public DataTable getFormByID(int ID)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "getFormByID";
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("@FormID", SqlDbType.Int).Value = ID;

            com.Connection = con;


            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);

            con.Close();


            return dt;

        }

        public void insertForm(int userID, int categoryID, int FileID, int EventFormID, bool active)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_insertForm";
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("@userID", SqlDbType.Int).Value = userID;

            com.Parameters.Add("@categoryID", SqlDbType.Int).Value = categoryID;

            com.Parameters.Add("@FileID", SqlDbType.Int).Value = FileID;

            com.Parameters.Add("@EventFormID", SqlDbType.Int).Value = EventFormID;

            com.Parameters.Add("@Active", SqlDbType.Bit).Value = active;

            com.Connection = con;


            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);

            con.Close();

        }

        public void updateForm(int ID, int userID, int categoryID, int FileID, int EventFormID, bool active)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_UpdateForm";
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.Add("@ID", SqlDbType.Int).Value = ID;

            com.Parameters.Add("@userID", SqlDbType.Int).Value = userID;

            com.Parameters.Add("@categoryID", SqlDbType.Int).Value = categoryID;

            com.Parameters.Add("@FileID", SqlDbType.Int).Value = FileID;

            com.Parameters.Add("@EventFormID", SqlDbType.Int).Value = EventFormID;

            com.Parameters.Add("@Active", SqlDbType.Bit).Value = active;

            com.Connection = con;


            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);

            con.Close();
        }


    }
}
