namespace CookbookDevxCsharp.lib.gridControl
{
    partial class ucSubRows
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.vGridControl1 = new DevExpress.XtraVerticalGrid.VGridControl();
            this.contactpersonenBindingSource = new System.Windows.Forms.BindingSource();
            this.dsTable = new CookbookDevxCsharp.dsTable();
            this.rowCONTACTID = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowRELATIECODE = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowCONTACTPERSOON = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowEMAILADRES = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowTELEFOON = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowROWOPEN = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.rowROWOPENBY = new DevExpress.XtraVerticalGrid.Rows.EditorRow();
            this.contactpersonenTableAdapter = new CookbookDevxCsharp.dsTableTableAdapters.ContactpersonenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactpersonenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(752, 429);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click_1);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // vGridControl1
            // 
            this.vGridControl1.DataSource = this.contactpersonenBindingSource;
            this.vGridControl1.Location = new System.Drawing.Point(1007, 153);
            this.vGridControl1.Name = "vGridControl1";
            this.vGridControl1.Rows.AddRange(new DevExpress.XtraVerticalGrid.Rows.BaseRow[] {
            this.rowCONTACTID,
            this.rowRELATIECODE,
            this.rowCONTACTPERSOON,
            this.rowEMAILADRES,
            this.rowTELEFOON,
            this.rowROWOPEN,
            this.rowROWOPENBY});
            this.vGridControl1.Size = new System.Drawing.Size(400, 200);
            this.vGridControl1.TabIndex = 3;
            // 
            // contactpersonenBindingSource
            // 
            this.contactpersonenBindingSource.DataMember = "Contactpersonen";
            this.contactpersonenBindingSource.DataSource = this.dsTable;
            // 
            // dsTable
            // 
            this.dsTable.DataSetName = "dsTable";
            this.dsTable.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rowCONTACTID
            // 
            this.rowCONTACTID.Name = "rowCONTACTID";
            this.rowCONTACTID.Properties.Caption = "CONTACTID";
            this.rowCONTACTID.Properties.FieldName = "CONTACTID";
            // 
            // rowRELATIECODE
            // 
            this.rowRELATIECODE.Name = "rowRELATIECODE";
            this.rowRELATIECODE.Properties.Caption = "RELATIECODE";
            this.rowRELATIECODE.Properties.FieldName = "RELATIECODE";
            // 
            // rowCONTACTPERSOON
            // 
            this.rowCONTACTPERSOON.Name = "rowCONTACTPERSOON";
            this.rowCONTACTPERSOON.Properties.Caption = "CONTACTPERSOON";
            this.rowCONTACTPERSOON.Properties.FieldName = "CONTACTPERSOON";
            // 
            // rowEMAILADRES
            // 
            this.rowEMAILADRES.Name = "rowEMAILADRES";
            this.rowEMAILADRES.Properties.Caption = "EMAILADRES";
            this.rowEMAILADRES.Properties.FieldName = "EMAILADRES";
            // 
            // rowTELEFOON
            // 
            this.rowTELEFOON.Name = "rowTELEFOON";
            this.rowTELEFOON.Properties.Caption = "TELEFOON";
            this.rowTELEFOON.Properties.FieldName = "TELEFOON";
            // 
            // rowROWOPEN
            // 
            this.rowROWOPEN.Name = "rowROWOPEN";
            this.rowROWOPEN.Properties.Caption = "ROWOPEN";
            this.rowROWOPEN.Properties.FieldName = "ROWOPEN";
            // 
            // rowROWOPENBY
            // 
            this.rowROWOPENBY.Name = "rowROWOPENBY";
            this.rowROWOPENBY.Properties.Caption = "ROWOPENBY";
            this.rowROWOPENBY.Properties.FieldName = "ROWOPENBY";
            // 
            // contactpersonenTableAdapter
            // 
            this.contactpersonenTableAdapter.ClearBeforeFill = true;
            // 
            // ucSubRows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.vGridControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "ucSubRows";
            this.Size = new System.Drawing.Size(1475, 429);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactpersonenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraVerticalGrid.VGridControl vGridControl1;
        private System.Windows.Forms.BindingSource contactpersonenBindingSource;
        private dsTable dsTable;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCONTACTID;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowRELATIECODE;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowCONTACTPERSOON;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowEMAILADRES;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowTELEFOON;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowROWOPEN;
        private DevExpress.XtraVerticalGrid.Rows.EditorRow rowROWOPENBY;
        private dsTableTableAdapters.ContactpersonenTableAdapter contactpersonenTableAdapter;
    }
}
