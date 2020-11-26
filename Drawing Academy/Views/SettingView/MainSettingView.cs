using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Academy.Views.SettingView
{
    public partial class MainSettingView : UserControl
    {
        public event NavigationDelegate ChangePage;
        public MainSettingView()
        {
            InitializeComponent();
        }

        private void button1_back_Click(object sender, EventArgs e)
        {
            ChangePage("MainStartView");
        }
    }
}
