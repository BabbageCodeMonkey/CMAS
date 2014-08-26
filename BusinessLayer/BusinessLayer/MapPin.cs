using MapDataMaper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class MapPin
    {
        public DataTable getMapPinByType(int Type)
        {
            DataTable dt = new DataTable();
            MapDataMaper.MapPinMapper user = new MapPinMapper();

            dt = user.getPinByType(Type);

            return dt;
        }
    }
}
