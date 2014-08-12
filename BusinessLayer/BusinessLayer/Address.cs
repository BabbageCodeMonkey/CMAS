using MapDataMaper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class Address
    {
        public DataTable getAllAddress()
        {
            DataTable dt = new DataTable();
            MapDataMaper.Address add = new MapDataMaper.Address();

            dt = add.getAddressList();



            return dt;
        }

        public DataTable getAddressPickList()
        {
            DataTable dt = new DataTable();
            MapDataMaper.Address add = new MapDataMaper.Address();

            dt = add.getAddressPickList();



            return dt;
        }
    }
}
