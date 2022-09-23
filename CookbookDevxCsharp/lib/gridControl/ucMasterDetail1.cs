using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
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
            lstCategories = new List<Category>();
            lstProducts = new List<Product>();

            lstCategories.Add(new Category() { KeytID = 1, Name = "Adventure", City = "Amsterdam" });
            lstCategories.Add(new Category() { KeytID = 2, Name = "Children", City = "Rotterdam" });
            lstCategories.Add(new Category() { KeytID = 3, Name = "Computer", City = "Breda" });

            lstProducts.Add(new Product() { KeyID = 1, Name = "The Secret Of The Druids", Author = "Christopher C. Doyle", IDCategory = 1  });
            lstProducts.Add(new Product() { KeyID = 2, Name = "The Secret Of The Druids", Author = "Christopher C. Doyle", IDCategory = 1 });
            lstProducts.Add(new Product() { KeyID = 3, Name = "The Secret Of The Druids", Author = "Christopher C. Doyle", IDCategory = 2 });
            lstProducts.Add(new Product() { KeyID = 4, Name = "The Secret Of The Druids", Author = "Christopher C. Doyle", IDCategory = 3 });

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
