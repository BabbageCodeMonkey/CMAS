using MapDataMaper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class Ticker
    {
        public DataTable getEventList()
        {
            DataTable dt = new DataTable();
            MapDataMaper.TickerMapper Events = new TickerMapper();

            dt = Events.getEventList();

            return dt;
        }

    }
}