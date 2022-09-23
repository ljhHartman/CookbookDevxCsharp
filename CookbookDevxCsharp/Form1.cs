using CookbookDevxCsharp.lib.gridControl;
using DevExpress.XtraBars.Docking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CookbookDevxCsharp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //this.IsMdiContainer = true;

            // Create DockPanel
            //DockManager dockManager1 = new DockManager(this);
            //DockPanel panel1 = dockManager1.AddPanel(DockingStyle.Top);
            //panel1.Text = "Panel 1";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void gridControlToolStripMenuItem1_Click(object sender, EventArgs e)
        { 
            DockManager dockManager1 = new DockManager(this);
            DockPanel panelGridControl = dockManager1.AddPanel(DockingStyle.Top);

            ucGridControl gc = new ucGridControl();
            panelGridControl.Text = "Grid Control";
            panelGridControl.ControlContainer.Controls.Add(gc);
        }

        private void simpleChartToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DockManager dockManager1 = new DockManager(this);
            DockPanel panelChart = dockManager1.AddPanel(DockingStyle.Top);

            panelChart.Text = "Chart";
            lib2.chart.ucChart ucChart = new lib2.chart.ucChart();
            panelChart.ControlContainer.Controls.Add(ucChart);
        }

        private void subRowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DockManager dockManager1 = new DockManager(this);
            DockPanel panelGridControl = dockManager1.AddPanel(DockingStyle.Top);

            panelGridControl.Text = "Sub Rows";
            lib.gridControl.ucSubRows subRows = new lib.gridControl.ucSubRows();
            panelGridControl.ControlContainer.Controls.Add(subRows);
        }

        private void masterDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DockManager dockManager1 = new DockManager(this);
            //DockPanel panelGridControl = dockManager1.AddPanel(DockingStyle.Top);

            //panelGridControl.Text = "Master-Detail";
            //lib.gridControl.ucMasterDetail md = new lib.gridControl.ucMasterDetail();
            //panelGridControl.ControlContainer.Controls.Add(md);
        }

        private void masterDetail1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DockManager dockManager1 = new DockManager(this);
            //DockPanel panelGridControl = dockManager1.AddPanel(DockingStyle.Top);

            //panelGridControl.Text = "Master-Detail";
            //lib.gridControl.ucMasterDetail1 md = new lib.gridControl.ucMasterDetail1();
            //panelGridControl.ControlContainer.Controls.Add(md);
        }

        private void readDataSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DockManager dockManager1 = new DockManager(this);
            DockPanel panelGridControl = dockManager1.AddPanel(DockingStyle.Top);

            panelGridControl.Text = "Read DataSet";
            lib.gridControl.ucReadDataSet md = new lib.gridControl.ucReadDataSet();
            panelGridControl.ControlContainer.Controls.Add(md);
        }
    }
}
