using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapDataMaper;

namespace BusinessLayer
{
    class Event
    {
        public void insertEvent(int locID, int catID, int useID, string decr, DateTime date)
        {
            MapDataMaper.EventMapper ev = new EventMapper();

            ev.insertEvent(locID, catID, useID, decr, date);
        }
    }
}
