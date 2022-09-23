using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookbookDevxCsharp.lib.gridControl
{
    public partial class ucReadDataSet : UserControl
    {
        public ucReadDataSet()
        {
            InitializeComponent();

            dsTable.ContactpersonenDataTable ds = new dsTable.ContactpersonenDataTable();
            dsTableTableAdapters.ContactpersonenTableAdapter tba = new dsTableTableAdapters.ContactpersonenTableAdapter();
            tba.Fill(ds);

            gridControl1.DataSource = ds; 
        }
    }
}
