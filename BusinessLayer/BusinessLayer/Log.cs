using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapDataMaper;

namespace BusinessLayer
{
    public class Log
    {
        public void insertLog(int userID, DateTime logTime, string descr, string progLoc, string message)
        {
            LogMapper log = new LogMapper();

            log.insertLog(userID, logTime, descr, progLoc, message);
        }
    }
}
