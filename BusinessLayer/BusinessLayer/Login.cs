using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using MapDataMaper;

namespace BusinessLayer
{
    public class Login
    {
        public DataTable getCred(string username, string password)
        {
            DataTable dt = new DataTable();
            MapDataMaper.Login log = new MapDataMaper.Login();

            dt = log.getCred(username, password);


            return dt;
        }
    }
}
