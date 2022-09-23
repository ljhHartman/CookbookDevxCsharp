using System;
using System.Data;
using System.Windows.Forms;
using System.Collections;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace CookbookDevxCsharp.lib.gridControl
{
    public partial class ucSubRows : UserControl
    {
        public ucSubRows()
        {
            InitializeComponent();
            Fill_GridControl(gridControl1);
            Show_HorizontalScrolbar(gridView1);
            Show_SearchBar(gridView1);
            Set_CellsReadOnly(gridView1);

            //// multi-select feature is enabled
            //gridView1.OptionsSelection.MultiSelect = false;
            //// whether multiple cells or rows can be selected
            //gridView1.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
            //// Click outside to clear selection
            //gridView1.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = false;
            ////
            //gridView1.OptionsView.ShowGroupPanelColumnsAsSingleRow = false;




        }



        private void Fill_GridControl(DevExpress.XtraGrid.GridControl gridControl)
        {
            // Get SqlTable
            dsInslagColli.InslagDataTable ds = new dsInslagColli.InslagDataTable();
            dsInslagColliTableAdapters.InslagTableAdapter tba = new dsInslagColliTableAdapters.InslagTableAdapter();
            tba.FillBy(ds, 8500);

            // Get Column Names
            var colNames = new ArrayList();
            foreach (DataColumn column in ds.Columns)
            {
                Console.WriteLine($"Column Name: {column.ColumnName}");
                colNames.Add(column);
            }

            // Get Column Type
            var colTypes = new ArrayList();
            foreach (DataColumn column in ds.Columns)
            {
                Console.WriteLine($"Column Type: {column.DataType}");
                colTypes.Add(column);
            }

            // Create Table
            DataTable table = new DataTable("Table1");

            // Add Columns, with names
            foreach (DataColumn column in ds.Columns)
            {
                table.Columns.Add(column.ColumnName, column.DataType);
            }

            // Add Rows, with data
            foreach (DataRow row in ds)
            {
                DataRow newRow;
                newRow = table.NewRow();

                foreach (DataColumn column in ds.Columns)
                {
                    String columnName = column.ColumnName;
                    int index = row.Table.Columns[columnName].Ordinal;
                    Console.WriteLine($"{row[index]}");

                    // Add value to row index
                    newRow[columnName] = row[index];
                }
                // add row to table
                table.Rows.Add(newRow);
            }

            // table to gridView
            gridControl.DataSource = table;
        }



        private void Set_CellsReadOnly(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            // Make the grid read-only.
            gridView1.OptionsBehavior.Editable = false;
            // Prevent the focused cell from being highlighted.
            gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            // Draw a dotted focus rectangle around the entire row.
            gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
  
        }



        private void Show_SearchBar(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            gridView.ShowFindPanel();
        }



        private void Show_HorizontalScrolbar(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            // Show Horizontal ScrollBar
            gridView.OptionsView.ColumnAutoWidth = false;
            gridView.HorzScrollVisibility = ScrollVisibility.Always;
        }


        
        private void gridControl1_Click(object sender, EventArgs e)
        {

            //// Get Select row
            //int rowSelect = gridView1.GetSelectedRows()[0];
            //Console.WriteLine($"selected row: {rowSelect}");

            //// Get Select row value
            //DataRow row = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
            //Console.WriteLine($"selected row value: {row[0]}");

            //// Remove Selected Row
            ////gridView1.DeleteSelectedRows();
        }
    }
}