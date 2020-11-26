using Drawing_Academy.Views.GameView;
using Drawing_Academy.Views.MapView;
using Drawing_Academy.Views.RankView;
using Drawing_Academy.Views.ResultView;
using Drawing_Academy.Views.SettingView;
using Drawing_Academy.Views.StartView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drawing_Academy
{
    public partial class MainForm : Form
    {
        MainGameView gameView = new MainGameView();
        MainMapView mapView = new MainMapView();
        MainResultView resultView = new MainResultView();
        MainStartView startView = new MainStartView();
        MainSettingView settingView = new MainSettingView();
        MainRankView rankView = new MainRankView();
        public MainForm()
        {
            InitializeComponent();
            gameView.Dock = DockStyle.Fill;
            mapView.Dock = DockStyle.Fill;
            resultView.Dock = DockStyle.Fill;
            startView.Dock = DockStyle.Fill;
            settingView.Dock = DockStyle.Fill;
            rankView.Dock = DockStyle.Fill;
            

            startView.ChangePage += ChangePageRequest;
            mapView.ChangePage += ChangePageRequest;
            resultView.ChangePage += ChangePageRequest;
            startView.ChangePage += ChangePageRequest;
            settingView.ChangePage += ChangePageRequest;
            gameView.ChangePage += ChangePageRequest;
            rankView.ChangePage += ChangePageRequest;


            panel_container.Controls.Add(gameView);
            panel_container.Controls.Add(resultView);
            panel_container.Controls.Add(mapView);
            panel_container.Controls.Add(startView);
            panel_container.Controls.Add(settingView);
            panel_container.Controls.Add(rankView);

            panel_container.Controls["MainStartView"].BringToFront();
        }

        private void ChangePageRequest(string namePage)
        {
            panel_container.Controls[namePage].BringToFront();
        }
    }
}
