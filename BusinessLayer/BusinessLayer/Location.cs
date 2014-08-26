using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MapDataMaper;

namespace BusinessLayer
{
    public class Location
    {

        public DataTable getLocaitonPickList()
        {
            DataTable dt = new DataTable();

            LocationMapper loc = new LocationMapper();

            dt = loc.getLocPickList();

            return dt;
        }
    }
}
