﻿using System;
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
            this.IsMdiContainer = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tileViewKanbanBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lib.Kanban obj = new Lib.Kanban();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
