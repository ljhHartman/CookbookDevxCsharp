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
    public class Test
    {

        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("hallo");

            var dsInslag = new dsInslagColli.InslagDataTable();
            var tbaInslag = new gridControl.ds.dsInslagColliTableAdapters.InslagTableAdapter();

            var dsColli = new dsInslagColli.ColliDataTable();
            var tbaColli = new gridControl.ds.dsInslagColliTableAdapters.ColliTableAdapter();
        }


        [TestMethod]
        public void GetTabaleAdapterData()
        {
            // Get SqlTable
            dsInslagColli.InslagDataTable ds = new dsInslagColli.InslagDataTable();
            var tba = new gridControl.ds.dsInslagColliTableAdapters.InslagTableAdapter();
            tba.FillBy(ds, 8500);

            // Get Column Names
            var colNames = new ArrayList();
            foreach (DataColumn column in ds.Columns)
            {
                Console.WriteLine($"Column Name: {column.ColumnName}");
                colNames.Add(column);
            }
        }

    }
}



