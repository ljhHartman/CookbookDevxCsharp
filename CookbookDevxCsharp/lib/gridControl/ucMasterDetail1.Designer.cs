namespace CookbookDevxCsharp.lib.gridControl
{
    partial class ucMasterDetail1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grvDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAuthor1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gctMain = new DevExpress.XtraGrid.GridControl();
            this.grvMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName2 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // grvDetail
            // 
            this.grvDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName1,
            this.colAuthor1});
            this.grvDetail.GridControl = this.gctMain;
            this.grvDetail.Name = "grvDetail";
            // 
            // colName1
            // 
            this.colName1.Caption = "Name";
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.OptionsColumn.AllowEdit = false;
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 0;
            // 
            // colAuthor1
            // 
            this.colAuthor1.Caption = "Author";
            this.colAuthor1.FieldName = "Author";
            this.colAuthor1.Name = "colAuthor1";
            this.colAuthor1.OptionsColumn.AllowEdit = false;
            this.colAuthor1.Visible = true;
            this.colAuthor1.VisibleIndex = 1;
            // 
            // gctMain
            // 
            this.gctMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gctMain.Location = new System.Drawing.Point(0, 0);
            this.gctMain.MainView = this.grvMain;
            this.gctMain.Name = "gctMain";
            this.gctMain.Size = new System.Drawing.Size(1202, 510);
            this.gctMain.TabIndex = 0;
            this.gctMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvMain,
            this.grvDetail});
            // 
            // grvMain
            // 
            this.grvMain.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colName2});
            this.grvMain.GridControl = this.gctMain;
            this.grvMain.Name = "grvMain";
            this.grvMain.OptionsDetail.ShowDetailTabs = false;
            this.grvMain.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.grvMain_MasterRowEmpty);
            this.grvMain.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.grvMain_MasterRowGetChildList);
            this.grvMain.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.grvMain_MasterRowGetRelationName);
            this.grvMain.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.grvMain_MasterRowGetRelationCount);
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.OptionsColumn.AllowEdit = false;
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colName2
            // 
            this.colName2.Caption = "colName2";
            this.colName2.FieldName = "City";
            this.colName2.Name = "colName2";
            this.colName2.OptionsColumn.AllowEdit = false;
            this.colName2.Visible = true;
            this.colName2.VisibleIndex = 1;
            // 
            // ucMasterDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gctMain);
            this.Name = "ucMasterDetail";
            this.Size = new System.Drawing.Size(1202, 510);
            ((System.ComponentModel.ISupportInitialize)(this.grvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gctMain;
        private DevExpress.XtraGrid.Views.Grid.GridView grvMain;
        private DevExpress.XtraGrid.Views.Grid.GridView grvDetail;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colName1;
        private DevExpress.XtraGrid.Columns.GridColumn colAuthor1;
        private DevExpress.XtraGrid.Columns.GridColumn colName2;
    }
}
