using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapDataMaper
{
    class Connection
    {
           public string createSqlServerConnection()
           {
               string conStr;

               conStr = "Server=" + "sqlinstance-1.cnsq0dkjy1df.us-west-2.rds.amazonaws.com,1433" + ";Database=" + "CMAS" + ";User Id =" + "awsuserwill" + ";Password=" + "*050987Wwhite";

               return conStr;
           }
    }
}
