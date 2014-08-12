using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class PersonType
    {
        public DataTable getPersonTypeList()
        {
            DataTable dt = new DataTable();
            MapDataMaper.PersonType pType = new MapDataMaper.PersonType();

            dt = pType.getPersonTypeList();



            return dt;
        }

        public DataTable getPersonTypePickList()
        {
            DataTable dt = new DataTable();
            MapDataMaper.PersonType pType = new MapDataMaper.PersonType();

            dt = pType.getPersonTypePickList();



            return dt;
        }
    }
}
