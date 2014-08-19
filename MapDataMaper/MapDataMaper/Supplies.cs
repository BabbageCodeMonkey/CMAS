using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MapDataMaper
{
    public class Supplies
    {
        public DataTable getSkuPickList()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("SkuID", typeof(int));
            dt.Columns.Add("Descr", typeof(string));
            SqlDataAdapter adapter;
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_GetSkuPickList";
            com.CommandType = CommandType.StoredProcedure;

            com.Connection = con;

            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);

            con.Close();


            return dt;
        }

        public DataTable getSkuTypePickList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_GetSkuTypePickList";
            com.CommandType = CommandType.StoredProcedure;

            com.Connection = con;

            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);

            con.Close();


            return dt;
        }

        public DataTable getAddressTypePickList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_GetAddressTypePickList";
            com.CommandType = CommandType.StoredProcedure;

            com.Connection = con;

            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);

            con.Close();


            return dt;
        }

        public DataTable getLocationPickList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_GetLocationPickList";
            com.CommandType = CommandType.StoredProcedure;

            com.Connection = con;

            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);

            con.Close();


            return dt;
        }

        public DataTable getAddressByID(int addressID)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_GetAddressByID";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@AddressID", SqlDbType.Int);
            com.Parameters["@AddressID"].Value = addressID;

            com.Connection = con;

            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);

            con.Close();


            return dt;
        }

        public DataTable getLocationByID(int locationID)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_GetLocationByID";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@LocationID", SqlDbType.Int);
            com.Parameters["@LocationID"].Value = locationID;

            com.Connection = con;

            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);

            con.Close();


            return dt;
        }

        public DataTable getCanvasList()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_GetCanvasList";
            com.CommandType = CommandType.StoredProcedure;

            com.Connection = con;

            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);

            con.Close();


            return dt;
        }

        public void insertSku(int sKuTypeID, string name, string descr, decimal unitPrice, int inStock, int onOrder)
        {
            Connection dataConnecter = new Connection();
            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_InsertSku";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@SkuTypeID", SqlDbType.Int);
            com.Parameters["@SkuTypeID"].Value = sKuTypeID;
            com.Parameters.Add("@Name", SqlDbType.NVarChar);
            com.Parameters["@Name"].Value = name;
            com.Parameters.Add("@Descr", SqlDbType.NVarChar);
            com.Parameters["@descr"].Value = descr;
            com.Parameters.Add("@UnitPrice", SqlDbType.Decimal);
            com.Parameters["@unitPrice"].Value = unitPrice;
            com.Parameters.Add("@InStock", SqlDbType.Int);
            com.Parameters["@inStock"].Value = inStock;
            com.Parameters.Add("@OnOrder", SqlDbType.Int);
            com.Parameters["@onOrder"].Value = onOrder;

            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public void updateSku(int skuID, int sKuTypeID, string name, string descr, decimal unitPrice, int inStock, int onOrder)
        {
            Connection dataConnecter = new Connection();
            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_UpdateSku";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@SkuID", SqlDbType.Int);
            com.Parameters["@SkuID"].Value = skuID;
            com.Parameters.Add("@SkuTypeID", SqlDbType.Int);
            com.Parameters["@SkuTypeID"].Value = sKuTypeID;
            com.Parameters.Add("@Name", SqlDbType.NVarChar);
            com.Parameters["@Name"].Value = name;
            com.Parameters.Add("@Descr", SqlDbType.NVarChar);
            com.Parameters["@descr"].Value = descr;
            com.Parameters.Add("@UnitPrice", SqlDbType.Decimal);
            com.Parameters["@unitPrice"].Value = unitPrice;
            com.Parameters.Add("@InStock", SqlDbType.Int);
            com.Parameters["@inStock"].Value = inStock;
            com.Parameters.Add("@OnOrder", SqlDbType.Int);
            com.Parameters["@onOrder"].Value = onOrder;

            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public DataTable getSkuByIDs(int skuID, int sKuTypeID)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_GetSkuByIDs";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@SkuID", SqlDbType.Int);
            com.Parameters["@SkuID"].Value = skuID;
            com.Parameters.Add("@SkuTypeID", SqlDbType.Int);
            com.Parameters["@SkuTypeID"].Value = sKuTypeID;

            com.Connection = con;

            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);

            con.Close();


            return dt;
        }

        public DataTable deleteSku(int skuID, int sKuTypeID)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_DeleteSku";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@SkuID", SqlDbType.Int);
            com.Parameters["@SkuID"].Value = skuID;
            com.Parameters.Add("@SkuTypeID", SqlDbType.Int);
            com.Parameters["@SkuTypeID"].Value = sKuTypeID;

            com.Connection = con;

            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);

            con.Close();


            return dt;
        }

        public void insertAddress(string descr, string address1, string address2, string city, string state, string zip, string phonePri, string phoneSec, string email)
        {
            Connection dataConnecter = new Connection();
            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_InsertAddress";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@Descr", SqlDbType.NVarChar);
            com.Parameters["@Descr"].Value = descr;
            com.Parameters.Add("@Address1", SqlDbType.NVarChar);
            com.Parameters["@Address1"].Value = address1;
            com.Parameters.Add("@Address2", SqlDbType.NVarChar);
            com.Parameters["@Address2"].Value = address2;
            com.Parameters.Add("@City", SqlDbType.NVarChar);
            com.Parameters["@City"].Value = city;
            com.Parameters.Add("@State", SqlDbType.NVarChar);
            com.Parameters["@State"].Value = state;
            com.Parameters.Add("@Zip", SqlDbType.NVarChar);
            com.Parameters["@Zip"].Value = zip;
            com.Parameters.Add("@PhonePri", SqlDbType.NVarChar);
            com.Parameters["@PhonePri"].Value = phonePri;
            com.Parameters.Add("@PhoneSec", SqlDbType.NVarChar);
            com.Parameters["@PhoneSec"].Value = phoneSec;
            com.Parameters.Add("@ContactEmail", SqlDbType.NVarChar);
            com.Parameters["@ContactEmail"].Value = email;

            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }

        public void updateAddress(int AddressID, string descr, string address1, string address2, string city, string state, string zip, string phonePri, string phoneSec, string email)
        {
            Connection dataConnecter = new Connection();
            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_UpdateAddress";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@AddressID", SqlDbType.Int);
            com.Parameters["@AddressID"].Value = AddressID;
            com.Parameters.Add("@Descr", SqlDbType.NVarChar);
            com.Parameters["@Descr"].Value = descr;
            com.Parameters.Add("@Address1", SqlDbType.NVarChar);
            com.Parameters["@Address1"].Value = address1;
            com.Parameters.Add("@Address2", SqlDbType.NVarChar);
            com.Parameters["@Address2"].Value = address2;
            com.Parameters.Add("@City", SqlDbType.NVarChar);
            com.Parameters["@City"].Value = city;
            com.Parameters.Add("@State", SqlDbType.NVarChar);
            com.Parameters["@State"].Value = state;
            com.Parameters.Add("@Zip", SqlDbType.NVarChar);
            com.Parameters["@Zip"].Value = zip;
            com.Parameters.Add("@PhonePri", SqlDbType.NVarChar);
            com.Parameters["@PhonePri"].Value = phonePri;
            com.Parameters.Add("@PhoneSec", SqlDbType.NVarChar);
            com.Parameters["@PhoneSec"].Value = phoneSec;
            com.Parameters.Add("@ContactEmail", SqlDbType.NVarChar);
            com.Parameters["@ContactEmail"].Value = email;

            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public DataTable deleteAddress(int addressID)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_DeleteAddress";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@AddressID", SqlDbType.Int);
            com.Parameters["@AddressID"].Value = addressID;

            com.Connection = con;

            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);

            con.Close();


            return dt;
        }

        public void insertLocation(string name, int addressID)
        {
            Connection dataConnecter = new Connection();
            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_InsertLocation";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@Name", SqlDbType.NVarChar);
            com.Parameters["@Name"].Value = name;
            com.Parameters.Add("@AddressID", SqlDbType.NVarChar);
            com.Parameters["@AddressID"].Value = addressID;

            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            con.Close();

        }

        public void updateLocation(int LocationID, int AddressID, string descr)
        {
            Connection dataConnecter = new Connection();
            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_UpdateLocation";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@LocationID", SqlDbType.Int);
            com.Parameters["@LocationID"].Value = LocationID;
            com.Parameters.Add("@AddressID", SqlDbType.Int);
            com.Parameters["@AddressID"].Value = AddressID;
            com.Parameters.Add("@Name", SqlDbType.NVarChar);
            com.Parameters["@Name"].Value = descr;

            com.Connection = con;
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }

        public DataTable deleteLocation(int locationID)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adapter;
            Connection dataConnecter = new Connection();

            SqlConnection con = new SqlConnection(dataConnecter.createSqlServerConnection());
            SqlCommand com = new SqlCommand();

            com.CommandText = "sp_DeleteLocation";
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@LocationID", SqlDbType.Int);
            com.Parameters["@LocationID"].Value = locationID;

            com.Connection = con;

            adapter = new SqlDataAdapter(com);
            adapter.Fill(dt);

            con.Close();


            return dt;
        }
    }
}
