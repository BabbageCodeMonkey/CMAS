using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BusinessLayer
{
    public class Search
    {
        public DataRow[] searchOneCriteria(DataTable found, string criteria, string column)
        {
            DataRow[] foundRows;


            foundRows = found.Select(column + " = " + criteria);
            
            return foundRows;
        }

        public DataTable search(DataTable dtPassed, string[] columns, string[] criteria)
        {
            DataTable dt = new DataTable();
            int count = 0;
            DataRow[] found,fAll;

            dt = dtPassed.Clone();

            foreach (string s in columns)
            {

                if (criteria[count] != "")
                {


                    found = searchOneCriteria(dtPassed, criteria[count], s);

                    foreach (DataRow r in found)
                    {
                        
                    }

                    foreach (DataRow row in found)
                    {
                            dt.ImportRow(row);
                    }

                    count++;
                }
            }

            return dt;
        }
    }
}
