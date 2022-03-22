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
using szgui_lab4.Logic;

namespace szgui_lab4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        GameLogic Game = new GameLogic();
        private void PlayerClick(object sender  ,RoutedEventArgs e)
        {
            var s = (Button)sender;
            if (!String.IsNullOrWhiteSpace(s.Content?.ToString()))
            {
                return;
            }
            s.Content = Game.Player;

            if (Game.Win())
            {
             //   Winscreen.visibility
            }
        }
        
    }
}
