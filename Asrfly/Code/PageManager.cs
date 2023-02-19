using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Forms;

namespace Asrfly.Code
{
    public class PageManager
    {
        private readonly Main main;

        public PageManager(Main main)
        {
            this.main = main;
        }
        public void LoadPage(UserControl PageUserControl)
        {
            // load Old Page
            var oldPage=main.panelContainer.Controls.OfType<UserControl>().FirstOrDefault();
            if (oldPage != null)
            {
                main.panelContainer.Controls.Remove(oldPage);   
                oldPage.Dispose();  
                                }
            // Load new page
            PageUserControl.Dock= DockStyle.Fill;

            main.panelContainer.Controls.Add(PageUserControl);

        }

    }
}
    