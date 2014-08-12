using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapDataMaper;
using System.Data;

namespace BusinessLayer
{
    public class Category
    {
        public DataTable getCategoryPickList()
        {
            DataTable dt = new DataTable();
            MapDataMaper.CategoryMapper categoryMap = new CategoryMapper();

            dt = categoryMap.getCategoryPickList();

            return dt;
        }
    }
}
