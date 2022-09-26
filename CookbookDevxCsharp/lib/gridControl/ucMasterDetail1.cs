using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using CookbookDevxCsharp.lib.ds;
using DevExpress.XtraGrid.Views.Grid;

/*
SOURCE:
https://www.youtube.com/watch?v=AdHF6FIYUUc&ab_channel=Ho%C3%A0ngHi%E1%BA%BFu
 */

namespace CookbookDevxCsharp.lib.gridControl
{
    public partial class ucMasterDetail1 : UserControl
    {
        #region Variables
        List<Product> lstProducts;
        List<Category> lstCategories;
        dsCategory.CategoryDataTable dsCat = new dsCategory.CategoryDataTable();
        lib.ds.dsCategoryTableAdapters.CategoryTableAdapter tbaCat = new lib.ds.dsCategoryTableAdapters.CategoryTableAdapter();
        dsCategory.ProductDataTable dsPro = new dsCategory.ProductDataTable();
        lib.ds.dsCategoryTableAdapters.ProductTableAdapter tbaPro = new lib.ds.dsCategoryTableAdapters.ProductTableAdapter();
        #endregion



        #region Constructers
        public ucMasterDetail1()
        {
            InitializeComponent();

            // remove Drag a column header
            grvMain.OptionsDetail.ShowDetailTabs = false;
            // ShowGroupPnel
            grvDetail.OptionsView.ShowGroupPanel = false;
            loadData();
        }
        #endregion



        #region Method
        private void loadData()
        {
            // Get SqlTable "Catergory"
            var dsCat = new dsCategory.CategoryDataTable();
            var tbaCat = new lib.ds.dsCategoryTableAdapters.CategoryTableAdapter();
            tbaCat.Fill(dsCat);

            // Get SqlTable "Product"
            var dsPro = new dsCategory.ProductDataTable();
            var tbaPro = new lib.ds.dsCategoryTableAdapters.ProductTableAdapter();
            tbaPro.Fill(dsPro);

            // Dataset to List "lstCategories"
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

            // Print List "lstCategories"
            for (int i = 0; i < lstCategories.Count; i++)
            {
                Console.WriteLine($"listCatergory: { lstCategories[i].KeytID }, { lstCategories[i].Name }, { lstCategories[i].City }");
            }

            // Dataset to List "lstProducts"
            lstProducts = new List<Product>();
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

            gctMain.DataSource = lstCategories;
        }
        #endregion



        #region Events
        private void frMain_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void grvMain_MasterRowEmpty(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs e)
        {
            //if Category don't have product a plus is enable
            GridView view = sender as GridView;
            Category cat = view.GetRow(e.RowHandle) as Category;
            if (cat != null)
                e.IsEmpty = !lstProducts.Any(x => x.IDCategory == cat.KeytID);
        }

        private void grvMain_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            //Load data to grid detail
            GridView view = sender as GridView;
            Category cat = view.GetRow(e.RowHandle) as Category;
            if (cat != null)
                e.ChildList = lstProducts.Where(x => x.IDCategory == cat.KeytID).ToList(); // Cast IEnumberable to ILIst or List
        }

        private void grvMain_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            // Set 1: Detail
            e.RelationCount = 1;
        }

        private void grvMain_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            e.RelationName = "Detail";
        }
        #endregion
    }
}