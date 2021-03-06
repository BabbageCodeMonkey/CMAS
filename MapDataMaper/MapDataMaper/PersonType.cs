﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MapDataMaper
{
    public class PersonType
    {
        public DataTable getPersonTypePickList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_GetPersonTypePickList";
            com.CommandType = CommandType.StoredProcedure;


            com.Connection = con;


            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);

            con.Close();


            return dt;

        }

        public DataTable getPersonTypeList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_GetPersonTypeList";
            com.CommandType = CommandType.StoredProcedure;


            com.Connection = con;


            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);

            con.Close();


            return dt;
        }
    }
}
