using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class Supplies
    {
        public DataTable getSkuList()
        {
            DataTable dt = new DataTable();
            MapDataMaper.Supplies sSku = new MapDataMaper.Supplies();
            dt = sSku.getSkuPickList();
            return dt;
        }

        public DataTable getSkuTypeList()
        {
            DataTable dt = new DataTable();
            MapDataMaper.Supplies sSku = new MapDataMaper.Supplies();
            dt = sSku.getSkuTypePickList();
            return dt;
        }

        public DataTable getSkuByIDs(int skuID, int sKuTypeID)
        {
            DataTable dt = new DataTable();
            MapDataMaper.Supplies sSku = new MapDataMaper.Supplies();
            dt = sSku.getSkuByIDs(skuID, sKuTypeID);
            return dt;
        }

        public DataTable getAddressTypeList()
        {
            DataTable dt = new DataTable();
            MapDataMaper.Supplies sSku = new MapDataMaper.Supplies();
            dt = sSku.getAddressTypePickList();
            return dt;
        }

        public DataTable getLocationList()
        {
            DataTable dt = new DataTable();
            MapDataMaper.Supplies sSku = new MapDataMaper.Supplies();
            dt = sSku.getLocationPickList();
            return dt;
        }

        public DataTable getAddressByID(int addressID)
        {
            DataTable dt = new DataTable();
            MapDataMaper.Supplies sSku = new MapDataMaper.Supplies();
            dt = sSku.getAddressByID(addressID);
            return dt;
        }

        public DataTable getLocationByID(int locationID)
        {
            DataTable dt = new DataTable();
            MapDataMaper.Supplies sSku = new MapDataMaper.Supplies();
            dt = sSku.getLocationByID(locationID);
            return dt;
        }

        public DataTable getCanvasList()
        {
            DataTable dt = new DataTable();
            MapDataMaper.Supplies sSku = new MapDataMaper.Supplies();
            dt = sSku.getCanvasList();
            return dt;
        }

        public void InsertSku(int sKuTypeID, string name, string descr, decimal unitPrice, int inStock, int onOrder)
        {
                MapDataMaper.Supplies insertSku = new MapDataMaper.Supplies();
                insertSku.insertSku(sKuTypeID, name, descr, unitPrice, inStock, onOrder);
        }

        public void UpdateSku(int skuID, int sKuTypeID, string name, string descr, decimal unitPrice, int inStock, int onOrder)
        {
            MapDataMaper.Supplies updateSku = new MapDataMaper.Supplies();
            updateSku.updateSku(skuID, sKuTypeID, name, descr, unitPrice, inStock, onOrder);
        }

        public void DeleteSku(int skuID, int sKuTypeID)
        {
            MapDataMaper.Supplies deleteSku = new MapDataMaper.Supplies();
            deleteSku.deleteSku(skuID, sKuTypeID);
        }

        public void InsertAddress(string descr, string address1, string address2, string city, string state, string zip, string phonePri, string phoneSec, string email)
        {
            MapDataMaper.Supplies insertAddress = new MapDataMaper.Supplies();
            insertAddress.insertAddress(descr, address1, address2, city, state, zip, phonePri, phoneSec, email);
        }

        public void UpdateAddress(int AddressID, string descr, string address1, string address2, string city, string state, string zip, string phonePri, string phoneSec, string email)
        {
            MapDataMaper.Supplies updateAddress = new MapDataMaper.Supplies();
            updateAddress.updateAddress(AddressID, descr, address1, address2, city, state, zip, phonePri, phoneSec, email);
        }

        public void DeleteAddress(int AddressID)
        {
            MapDataMaper.Supplies deleteAddress = new MapDataMaper.Supplies();
            deleteAddress.deleteAddress(AddressID);
        }

        public void InsertLocation(string name, int addressID)
        {
            MapDataMaper.Supplies insertLocation = new MapDataMaper.Supplies();
            insertLocation.insertLocation(name, addressID);
        }

        public void UpdateLocation(int LocationID, int AddressID, string descr)
        {
            MapDataMaper.Supplies updateLocation = new MapDataMaper.Supplies();
            updateLocation.updateLocation(LocationID, AddressID, descr);
        }

        public void DeleteLocation(int LocationID)
        {
            MapDataMaper.Supplies locationAddress = new MapDataMaper.Supplies();
            locationAddress.deleteLocation(LocationID);
        }
    }
}
