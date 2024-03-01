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

namespace TicTacToe_WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        Game game = new Game();
        public MainWindow()
        {
            InitializeComponent();
            game.step = random.Next(2 + 0);
            textFields.Text = game.Step();
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            one.IsEnabled = false;
            //one.Content = 
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {

        }

        private void three_Click(object sender, RoutedEventArgs e)
        {

        }

        private void four_Click(object sender, RoutedEventArgs e)
        {

        }

        private void five_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sex_Click(object sender, RoutedEventArgs e)
        {

        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {

        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {

        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
