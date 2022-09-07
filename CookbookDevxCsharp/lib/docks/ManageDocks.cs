using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
1. Create DocumentManager:          Toolbox > DocumentManager > drop it onto your form
2. Choose type:                     documentManager1 (below the from design)> top/right-icon > choose = tabbedView1                                                                                                                             
3. Set Documents:                   documentManager1 > Run Design > Document > Add Document
                                    -  Docuement is a container for control and user controls, etc.
                                    -  In the designer you can add or remove Documents and modify their properties
4. Set User Control                 Solution Explorer > Add New Item > User Control
5. Set User Cotrnol to Documment:   documentManager1 > Run Design > Document > Design > Name = UserControlName > Populate Button

6. Add new DockManager             ToolBox > DockManager
7. Add Panel                       DockManager > smart tag > Add Right Panel

8. Add BarManager                   ToolBox > BarManager
                                    - Three bars are created: main menu, status bar and regular toolbar.
9. 
*/

namespace CookbookDevxCsharp.lib.docks
{
    public partial class ManageDocks : Form
    {
        public ManageDocks()
        {
            InitializeComponent();
            // Handling the QueryControl event that will populate all automatically generated Documents
            this.tabbedView1.QueryControl += tabbedView1_QueryControl;
        }

        // Assigning a required content for each auto generated Document
        void tabbedView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e)
        {

            if (e.Document == userControlExampleDocument)
                e.Control = new CookbookDevxCsharp.lib.userControls.UserControlExample();
            if (e.Control == null)
                e.Control = new System.Windows.Forms.Control();
        }

        private void ManageDocks_Load(object sender, EventArgs e)
        {

        }

        private void dockPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
