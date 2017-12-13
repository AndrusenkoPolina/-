using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tetris
{
    /// <summary>
    /// Логика взаимодействия для MainPageView.xaml
    /// </summary>
    public partial class MainPageView : Page
    {
        public MainPageView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GameViewPage gvp = new GameViewPage();
            this.NavigationService.Navigate(gvp);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ScoreViewPage svp = new ScoreViewPage();
            this.NavigationService.Navigate(svp);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SettingViewPage stvp = new SettingViewPage();
           this.NavigationService.Navigate(stvp);
        }
    }
}
