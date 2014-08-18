using MapDataMaper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class User
    {
        public DataTable getUserPickListFName()
        {
            DataTable dt = new DataTable();
            MapDataMaper.UserMapper userMap = new UserMapper();

            dt = userMap.getUserPickListFName();

            return dt;
        }

        public DataTable getPersonList()
        {
            DataTable dt = new DataTable();
            MapDataMaper.UserMapper userMap = new UserMapper();

            dt = userMap.getUserList();

            return dt;
        }

        public void insertPerson(string FName, string LName, string Username, string Password, int AddressID, int pType, bool Active)
        {
            MapDataMaper.UserMapper user = new UserMapper();

            user.insertPerson(FName, LName, Username, Password, AddressID, pType, Active);

        }

        public void updatePerson(int ID, string FName, string LName, string Username, string Password, int AddressID, int pType, bool Active)
        {
            MapDataMaper.UserMapper user = new UserMapper();

            user.UpdatePerson(ID, FName, LName, Username, Password, AddressID, pType, Active);
        }

        public DataTable getPersonByID(int ID)
        {
            DataTable dt = new DataTable();
            MapDataMaper.UserMapper user = new UserMapper();

            dt = user.getPersonByID(ID);

            return dt;
        }
    }
}
