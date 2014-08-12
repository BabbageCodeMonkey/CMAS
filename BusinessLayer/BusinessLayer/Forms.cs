using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapDataMaper;
using System.Data;

namespace BusinessLayer
{
    public class Forms
    {
        public DataTable getAllForms()
        {
            DataTable dt = new DataTable();
            MapDataMaper.FormMaper formMap = new FormMaper();

            dt = formMap.getFormList();
            


            return dt;
        }

        public void insertForm(int userID, int categoryID, int FileID, int EventFormID, bool active)
        {
                
        }
    }
}
