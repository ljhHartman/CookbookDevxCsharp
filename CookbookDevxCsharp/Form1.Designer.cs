namespace CookbookDevxCsharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kanbanBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simpleChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridControlToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager();
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView();
            this.simpleChartToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kanbanBoardToolStripMenuItem,
            this.docksToolStripMenuItem,
            this.chartToolStripMenuItem,
            this.gridControlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1091, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kanbanBoardToolStripMenuItem
            // 
            this.kanbanBoardToolStripMenuItem.Name = "kanbanBoardToolStripMenuItem";
            this.kanbanBoardToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.kanbanBoardToolStripMenuItem.Text = "DevExpress";
            // 
            // docksToolStripMenuItem
            // 
            this.docksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDockToolStripMenuItem});
            this.docksToolStripMenuItem.Name = "docksToolStripMenuItem";
            this.docksToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.docksToolStripMenuItem.Text = "Docks";
            // 
            // addDockToolStripMenuItem
            // 
            this.addDockToolStripMenuItem.Name = "addDockToolStripMenuItem";
            this.addDockToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simpleChartToolStripMenuItem,
            this.simpleChartToolStripMenuItem1});
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(56, 24);
            this.chartToolStripMenuItem.Text = "Chart";
            // 
            // simpleChartToolStripMenuItem
            // 
            this.simpleChartToolStripMenuItem.Name = "simpleChartToolStripMenuItem";
            this.simpleChartToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            // 
            // gridControlToolStripMenuItem
            // 
            this.gridControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gridControlToolStripMenuItem1});
            this.gridControlToolStripMenuItem.Name = "gridControlToolStripMenuItem";
            this.gridControlToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.gridControlToolStripMenuItem.Text = "GridControl";
            // 
            // gridControlToolStripMenuItem1
            // 
            this.gridControlToolStripMenuItem1.Name = "gridControlToolStripMenuItem1";
            this.gridControlToolStripMenuItem1.Size = new System.Drawing.Size(161, 26);
            this.gridControlToolStripMenuItem1.Text = "GridControl";
            this.gridControlToolStripMenuItem1.Click += new System.EventHandler(this.gridControlToolStripMenuItem1_Click);
            // 
            // documentManager1
            // 
            this.documentManager1.ContainerControl = this;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // tabbedView1
            // 
            this.tabbedView1.RootContainer.Element = null;
            // 
            // simpleChartToolStripMenuItem1
            // 
            this.simpleChartToolStripMenuItem1.Name = "simpleChartToolStripMenuItem1";
            this.simpleChartToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.simpleChartToolStripMenuItem1.Text = "Simple Chart";
            this.simpleChartToolStripMenuItem1.Click += new System.EventHandler(this.simpleChartToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 581);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kanbanBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simpleChartToolStripMenuItem;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private System.Windows.Forms.ToolStripMenuItem addDockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridControlToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem simpleChartToolStripMenuItem1;
    }
}

