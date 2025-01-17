﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Data;


// Init DataSet            
//DataSet set = lib.list.DataSetExample.MyDataSet();


namespace CookbookDevxCsharp.lib.list
{
    class DataSetExample
    {

        public static DataSet MyDataSet()
        {
            // Create 2 DataTable instances.
            DataTable table1 = new DataTable("patients");
            table1.Columns.Add("name");
            table1.Columns.Add("id");
            table1.Rows.Add("sam", 1);
            table1.Rows.Add("mark", 2);

            DataTable table2 = new DataTable("medications");
            table2.Columns.Add("id");
            table2.Columns.Add("medication");
            table2.Rows.Add(1, "atenolol");
            table2.Rows.Add(2, "amoxicillin");

            // Create a DataSet and put both tables in it.
            DataSet set = new DataSet("office");
            set.Tables.Add(table1);
            set.Tables.Add(table2);

            // Visualize DataSet.
            Console.WriteLine(set.GetXml());
            return set;
        }
    }
}
