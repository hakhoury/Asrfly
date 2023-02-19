using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Asrfly.Gui.GuiHome
{
    public partial class HomeUserControl : UserControl
    {
        private static HomeUserControl _HomeUserControl;
        public HomeUserControl()
        {
            InitializeComponent();

        }
        public static HomeUserControl Instance()
        {
            if (_HomeUserControl == null) 
                {return new HomeUserControl();}
            else 
                { return _HomeUserControl;}

             
        }
    }
}
