using MapDataMaper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public class Email
    {
        public DataTable getEmailList()
        {

            DataTable dt = new DataTable();
            MapDataMaper.EmailMapper EmailMap = new EmailMapper();

            dt = EmailMap.getEmailList();

            return dt;
        }

    }
}