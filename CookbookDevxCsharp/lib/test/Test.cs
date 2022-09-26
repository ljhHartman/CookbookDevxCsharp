using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CookbookDevxCsharp.lib.ds;
using CookbookDevxCsharp.lib.gridControl;

namespace CookbookDevxCsharp.lib.test
{
    [TestClass]
    public class Test
    {

        [TestMethod]
        public void checkNull()
        {
             string s = null;






        }


        [TestMethod]
        public void GetTabaleAdapterData()
        {
            // Get SqlTable "Catergory"
            var dsCat = new dsCategory.CategoryDataTable();
            var tbaCat = new ds.dsCategoryTableAdapters.CategoryTableAdapter();
            tbaCat.Fill(dsCat);
            // Row Values
            foreach (DataRow row in dsCat.Rows)
            {
                Console.WriteLine($"Catergory: {row[0]}, {row[1]}, {row[2]}");
            }


            // Get SqlTable "Product"
            var dsPro = new dsCategory.ProductDataTable();
            var tbaPro = new ds.dsCategoryTableAdapters.ProductTableAdapter();
            tbaPro.Fill(dsPro);
            // Row Values
            foreach (DataRow row in dsPro.Rows)
            {
                Console.WriteLine($"Product: {row[0]}, {row[1]}, {row[2]}, {row[3]}");
            }
        }


        [TestMethod]
        public void SQLTableToList()
        {
            // Get SqlTable "Catergory"
            var dsCat = new dsCategory.CategoryDataTable();
            var tbaCat = new ds.dsCategoryTableAdapters.CategoryTableAdapter();
            tbaCat.Fill(dsCat);

            // Get SqlTable "Product"
            var dsPro = new dsCategory.ProductDataTable();
            var tbaPro = new ds.dsCategoryTableAdapters.ProductTableAdapter();
            tbaPro.Fill(dsPro);

            // Declare List
            List<Product> lstProducts;
            List<Category> lstCategories;
            lstCategories = new List<Category>();
            lstProducts = new List<Product>();

            // Dataset to List "lstCategories"
            foreach (DataRow row in dsCat.Rows)
            {  
                lstCategories.Add(new Category()
                {
                    KeytID = (int)row["KeytID"],
                    Name = (string)row["Name"],
                    City = (string)row["City"]
                });
            }

            // Print List "lstCategories"
            for (int i = 0; i < lstCategories.Count; i++)
            {
                Console.WriteLine($"listCatergory: { lstCategories[i].KeytID }, { lstCategories[i].Name }, { lstCategories[i].City }");
            }

            // Dataset to List "lstProducts"
            foreach (DataRow row in dsPro.Rows)
            {
                lstProducts.Add(new Product()
                {
                    KeyID = (int)row["KeytID"],
                    Name = (string)row["Name"],
                    Author = (string)row["Author"],
                    IDCategory = (int)row["IDCategory"]
                });
            }

            // Print List "lstProducts"
            for (int i = 0; i < lstProducts.Count; i++)
            {
                Console.WriteLine($"lstProducts: { lstProducts[i].KeyID }, { lstProducts[i].Name }, { lstProducts[i].Author }, { lstProducts[i].IDCategory }");
            }

        }










    }
}



