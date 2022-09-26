namespace CookbookDevxCsharp.lib.gridControl
{
    partial class ucMasterDetail2
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
            this.grvMain = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gctMain = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.grvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctMain)).BeginInit();
            this.SuspendLayout();
            // 
            // grvDetail
            // 
            this.grvDetail.GridControl = this.gctMain;
            this.grvDetail.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.grvDetail.Name = "grvDetail";
            this.grvDetail.OptionsView.ColumnAutoWidth = false;
            // 
            // grvMain
            // 
            this.grvMain.GridControl = this.gctMain;
            this.grvMain.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.grvMain.Name = "grvMain";
            this.grvMain.OptionsBehavior.Editable = false;
            this.grvMain.OptionsDetail.ShowDetailTabs = false;
            this.grvMain.OptionsView.ColumnAutoWidth = false;
            this.grvMain.MasterRowEmpty += new DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventHandler(this.grvMain_MasterRowEmpty);
            this.grvMain.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.grvMain_MasterRowGetChildList);
            this.grvMain.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.grvMain_MasterRowGetRelationName);
            this.grvMain.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.grvMain_MasterRowGetRelationCount);
            // 
            // gctMain
            // 
            this.gctMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.gctMain.Location = new System.Drawing.Point(0, 0);
            this.gctMain.MainView = this.grvMain;
            this.gctMain.Name = "gctMain";
            this.gctMain.Size = new System.Drawing.Size(1202, 427);
            this.gctMain.TabIndex = 0;
            this.gctMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvMain,
            this.grvDetail});
            // 
            // ucMasterDetail2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gctMain);
            this.Name = "ucMasterDetail2";
            this.Size = new System.Drawing.Size(1202, 510);
            ((System.ComponentModel.ISupportInitialize)(this.grvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gctMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView grvDetail;
        private DevExpress.XtraGrid.GridControl gctMain;
        private DevExpress.XtraGrid.Views.Grid.GridView grvMain;
    }
}
