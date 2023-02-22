using Asrfly.Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Asrfly
{
    public partial class Main : Form
    {
        private readonly PageManager pageManager;

        public Main()
        {
            InitializeComponent();
             pageManager = new PageManager(this);
            // Load HomePage
            pageManager.LoadPage(Gui.GuiHome.HomeUserControl.Instance());

        }
        #region Events
        private void buttonHome_Click(object sender, EventArgs e)
        {
            //Load HomePage
            pageManager.LoadPage(Gui.GuiHome.HomeUserControl.Instance());
        }
        #endregion

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            //Load HomePage
            pageManager.LoadPage(Gui.GuiCategories.CategoryUserControl.Instance());
        }
    }
}
