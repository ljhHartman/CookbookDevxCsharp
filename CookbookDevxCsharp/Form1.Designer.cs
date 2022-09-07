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
            this.tileViewKanbanBoardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dockManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kanbanBoardToolStripMenuItem,
            this.docksToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1091, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kanbanBoardToolStripMenuItem
            // 
            this.kanbanBoardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tileViewKanbanBoardToolStripMenuItem});
            this.kanbanBoardToolStripMenuItem.Name = "kanbanBoardToolStripMenuItem";
            this.kanbanBoardToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.kanbanBoardToolStripMenuItem.Text = "DevExpress";
            // 
            // tileViewKanbanBoardToolStripMenuItem
            // 
            this.tileViewKanbanBoardToolStripMenuItem.Name = "tileViewKanbanBoardToolStripMenuItem";
            this.tileViewKanbanBoardToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.tileViewKanbanBoardToolStripMenuItem.Text = "Tile View Kanban Board";
            this.tileViewKanbanBoardToolStripMenuItem.Click += new System.EventHandler(this.tileViewKanbanBoardToolStripMenuItem_Click);
            // 
            // docksToolStripMenuItem
            // 
            this.docksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dockManagerToolStripMenuItem});
            this.docksToolStripMenuItem.Name = "docksToolStripMenuItem";
            this.docksToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.docksToolStripMenuItem.Text = "Docks";
            // 
            // dockManagerToolStripMenuItem
            // 
            this.dockManagerToolStripMenuItem.Name = "dockManagerToolStripMenuItem";
            this.dockManagerToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.dockManagerToolStripMenuItem.Text = "DockManager";
            this.dockManagerToolStripMenuItem.Click += new System.EventHandler(this.dockManagerToolStripMenuItem_Click);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kanbanBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileViewKanbanBoardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dockManagerToolStripMenuItem;
    }
}

