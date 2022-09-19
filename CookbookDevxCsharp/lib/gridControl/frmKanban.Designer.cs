namespace CookbookDevxCsharp.Lib
{
    partial class Kanban
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
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement4 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.sSLTESTDataSet = new CookbookDevxCsharp.SSLTESTDataSet();
            this.relatieBindingSource = new System.Windows.Forms.BindingSource();
            this.relatieTableAdapter = new CookbookDevxCsharp.SSLTESTDataSetTableAdapters.RelatieTableAdapter();
            this.colRELATIECODE = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colPLAATS = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colLAND = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colBEDRIJFSNAAM = new DevExpress.XtraGrid.Columns.TileViewColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sSLTESTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatieBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.relatieBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.tileView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1047, 561);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tileView1});
            // 
            // tileView1
            // 
            this.tileView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRELATIECODE,
            this.colBEDRIJFSNAAM,
            this.colPLAATS,
            this.colLAND});
            this.tileView1.ColumnSet.GroupColumn = this.colRELATIECODE;
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.Name = "tileView1";
            this.tileView1.OptionsDragDrop.AllowDrag = true;
            this.tileView1.OptionsTiles.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.Kanban;
            this.tileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileView1.OptionsTiles.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            this.tileView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colRELATIECODE, DevExpress.Data.ColumnSortOrder.Ascending)});
            tileViewItemElement1.Column = this.colRELATIECODE;
            tileViewItemElement1.Text = "colRELATIECODE";
            tileViewItemElement2.Column = this.colBEDRIJFSNAAM;
            tileViewItemElement2.Text = "colBEDRIJFSNAAM";
            tileViewItemElement3.Column = this.colLAND;
            tileViewItemElement3.Text = "colLAND";
            tileViewItemElement4.Column = this.colPLAATS;
            tileViewItemElement4.Text = "colPLAATS";
            this.tileView1.TileTemplate.Add(tileViewItemElement1);
            this.tileView1.TileTemplate.Add(tileViewItemElement2);
            this.tileView1.TileTemplate.Add(tileViewItemElement3);
            this.tileView1.TileTemplate.Add(tileViewItemElement4);
            // 
            // sSLTESTDataSet
            // 
            this.sSLTESTDataSet.DataSetName = "SSLTESTDataSet";
            this.sSLTESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // relatieBindingSource
            // 
            this.relatieBindingSource.DataMember = "Relatie";
            this.relatieBindingSource.DataSource = this.sSLTESTDataSet;
            // 
            // relatieTableAdapter
            // 
            this.relatieTableAdapter.ClearBeforeFill = true;
            // 
            // colRELATIECODE
            // 
            this.colRELATIECODE.FieldName = "RELATIECODE";
            this.colRELATIECODE.Name = "colRELATIECODE";
            this.colRELATIECODE.Visible = true;
            this.colRELATIECODE.VisibleIndex = 0;
            // 
            // colPLAATS
            // 
            this.colPLAATS.FieldName = "PLAATS";
            this.colPLAATS.Name = "colPLAATS";
            this.colPLAATS.Visible = true;
            this.colPLAATS.VisibleIndex = 1;
            // 
            // colLAND
            // 
            this.colLAND.FieldName = "LAND";
            this.colLAND.Name = "colLAND";
            this.colLAND.Visible = true;
            this.colLAND.VisibleIndex = 2;
            // 
            // colBEDRIJFSNAAM
            // 
            this.colBEDRIJFSNAAM.FieldName = "BEDRIJFSNAAM";
            this.colBEDRIJFSNAAM.Name = "colBEDRIJFSNAAM";
            this.colBEDRIJFSNAAM.Visible = true;
            this.colBEDRIJFSNAAM.VisibleIndex = 3;
            // 
            // Kanban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 561);
            this.Controls.Add(this.gridControl1);
            this.Name = "Kanban";
            this.Text = "Kanban";
            this.Load += new System.EventHandler(this.Kanban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sSLTESTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relatieBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private SSLTESTDataSet sSLTESTDataSet;
        private System.Windows.Forms.BindingSource relatieBindingSource;
        private SSLTESTDataSetTableAdapters.RelatieTableAdapter relatieTableAdapter;
        private DevExpress.XtraGrid.Columns.TileViewColumn colRELATIECODE;
        private DevExpress.XtraGrid.Columns.TileViewColumn colBEDRIJFSNAAM;
        private DevExpress.XtraGrid.Columns.TileViewColumn colPLAATS;
        private DevExpress.XtraGrid.Columns.TileViewColumn colLAND;
    }
}