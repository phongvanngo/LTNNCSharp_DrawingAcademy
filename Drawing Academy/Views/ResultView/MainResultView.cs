using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Academy.Views.ResultView
{
    public partial class MainResultView : UserControl
    {
        public event NavigationDelegate ChangePage;

        public MainResultView()
        {
            InitializeComponent();
        }

        private void button1_continue_Click(object sender, EventArgs e)
        {
            ChangePage("MainMapView");

        }
    }
}
