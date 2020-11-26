using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Academy.Views.StartView
{
    public partial class MainStartView : UserControl
    {
        public event NavigationDelegate ChangePage;
        public MainStartView()
        {
            InitializeComponent();
        }

        private void button1_start_Click(object sender, EventArgs e)
        {
            ChangePage("MainMapView");
        }

        private void button2_setting_Click(object sender, EventArgs e)
        {
            ChangePage("MainSettingView");
        }

        private void button3_exit_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangePage("MainRankView");

        }
    }
}
