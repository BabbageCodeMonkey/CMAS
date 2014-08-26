using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapDataMaper;
using System.Data;

namespace BusinessLayer
{
    public class Event
    {
        public void insertEvent(int locID, int catID, int useID, string decr, DateTime date)
        {
            MapDataMaper.EventMapper ev = new EventMapper();

            ev.insertEvent(locID, catID, useID, decr, date);
        }

        public DataTable getEventList()
        {
            EventMapper ev = new EventMapper();

            return ev.getEventList();
        }

        public DataTable getEventByID(int ID)
        {
            EventMapper ev = new EventMapper();

            return ev.getEventByID(ID);
        }

        public void updateEvent(int ID, int locID, int catID, int useID, string decr, DateTime date, bool active)
        {
            EventMapper ev = new EventMapper();

            ev.updateEvent(ID, locID, catID, useID, decr, date, active);
        }
    }
}
