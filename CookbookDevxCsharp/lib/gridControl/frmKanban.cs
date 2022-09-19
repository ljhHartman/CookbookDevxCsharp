using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

/*
Source:                         https://docs.devexpress.com/WindowsForms/117616/controls-and-libraries/data-grid/views/tile-view/kanban-board?v=17.2

1. Create GridControl:          Toolbox > GridControl
2. Set TileView:                GridControl > Chick here to change view > Conver to > TileView
3. Set DataSource               GridControl > Top/Right- Icon > Choose DataSource > Select Table from Database
4. Set Columns:                 GridControl > Run Design > Columns > Select Field (create new column)
5. Group Columns:               GridControl > tileView1 > Propeties > ColumnSet > GroupColumn
6. Set Layout Type:             GridControl > tileView1 > Properties > OptionsTiles > LayoutMode: Kanban
                                                                                    > Orientation: Vertical
                                                                                    > VerticalContentAlignment: Top
                                                                                    > HorizontalContentAlignment: Near
7. Deign Tile                   GridControl > Run Design > Tile Template
8. Set Drag-and-Drop            GridControl > tileView1 > OptionsDragDrop > AllowDrag = True
*/

namespace CookbookDevxCsharp.Lib
{
    public partial class Kanban : DevExpress.XtraEditors.XtraForm
    {
        public Kanban()
        {
            InitializeComponent();
        }

        private void Kanban_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sSLTESTDataSet.Relatie' table. You can move, or remove it, as needed.
            this.relatieTableAdapter.Fill(this.sSLTESTDataSet.Relatie);
        }
    }
}