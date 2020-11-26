using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Academy.Views.MapView
{
    public partial class MainMapView : UserControl
    {
        public event NavigationDelegate ChangePage;

        public MainMapView()
        {
            InitializeComponent();
        }

        private void button2_back_Click(object sender, EventArgs e)
        {
            ChangePage("MainStartView");
        }

        private void button1_round1_Click(object sender, EventArgs e)
        {
            ChangePage("MainGameView");

        }
    }
}
