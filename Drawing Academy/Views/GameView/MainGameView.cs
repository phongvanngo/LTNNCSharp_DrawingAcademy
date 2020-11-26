using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Academy.Views.GameView
{
    public partial class MainGameView : UserControl
    {
        public event NavigationDelegate ChangePage;
        public MainGameView()
        {
            InitializeComponent();
        }

        private void button1_back_Click(object sender, EventArgs e)
        {
            ChangePage("MainMapView");
        }

        private void button2_result_Click(object sender, EventArgs e)
        {
            ChangePage("MainResultView");
        }
    }
}
