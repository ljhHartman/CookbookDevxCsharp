using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CookbookDevxCsharp.lib.gridControl;
using CookbookDevxCsharp.lib.ds;

namespace CookbookDevxCsharp.lib.test
{



    [TestClass]
    public class Test1
    {



        [TestMethod]
        public void SQLTableToList()
        {
            // Get SqlTable "Catergory"
            var dsCat = new dsCategory.CategoryDataTable();
            var tbaCat = new ds.dsCategoryTableAdapters.CategoryTableAdapter();
            tbaCat.Fill(dsCat);
            
            // Dataset to List
            List<Category> lstCategories;
            lstCategories = new List<Category>();
            foreach (DataRow row in dsCat.Rows)
            {
                lstCategories.Add(new Category()
                {
                    KeytID = (int)row["KeytID"],
                    Name = (string)row["Name"],
                    City = (string)row["City"]
                });
            }

            // Print
            for (int i = 0; i < lstCategories.Count; i++)
            {
                Console.WriteLine($"listCatergory: { lstCategories[i].KeytID }, { lstCategories[i].Name }, { lstCategories[i].City }");
            }
        }











}
}



