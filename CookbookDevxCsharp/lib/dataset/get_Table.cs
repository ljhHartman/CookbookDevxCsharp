using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CookbookDevxCsharp.lib.gridControl.ds;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CookbookDevxCsharp.lib.gridControl.ds;

namespace CookbookDevxCsharp.lib.test
{
    [TestClass]
    public class Get_Table1
    {


        [TestMethod]
        public void GetTabaleAdapterData()
        {
            // Get SqlTable
            var ds = new dsInslagColli.InslagDataTable();
            var tba = new gridControl.ds.dsInslagColliTableAdapters.InslagTableAdapter();
            tba.FillBy(ds, 8500);

            // Get Column Names
            var colNames = new ArrayList();
            foreach (DataColumn column in ds.Columns)
            {
                //Console.WriteLine($"Column Name: {column.ColumnName}");
                colNames.Add(column);
            }

            foreach (DataRow row in ds.Rows)
            {
                Console.WriteLine($"{row[0]}, {row[1]}, {row[2]}");
            }
        }











    }
}



