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
using System.Windows.Interop;
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

        private int step = 0;
        private string[] msg = new string[] { "Ход игрока играющего крестиком!", "Ход игрока играющего ноликом!" };
        private string[] win = new string[] { "Победил игрок играющий крестиком!", "Победил игрок играющий ноликом!" };
        private string cross = "X", zero = "O";

        public MainWindow()
        {
            InitializeComponent();
            step = random.Next(2);
            textFields.Text = step == 0 ? msg[1] : msg[0];

            foreach (UIElement el in GameFields.Children)
            {
                if(el is Button)
                {
                    ((Button)el).Click += Click_Button;
                }
            }

            Is_Winner();
                
        }

        private void Click_Button(object sender, RoutedEventArgs e)
        {
            textFields.Text = msg[step];
            ((Button)e.OriginalSource).Content = Step();
            ((Button)e.OriginalSource).IsEnabled = false;
        }

        private void Is_Draw(object sender, RoutedEventArgs e)
        {
            foreach (UIElement el in GameFields.Children)
            {
                if (el is Button)
                {
                    //((Button)el).Click += Click_Button;
                }
            }
        }

        private string Step()
        {
            if (step == 0)
            {
                step = 1;
                return zero;
            }
            else
            {
                step = 0;
                return cross;
            }
        }

        private void ComLogic(object sender, RoutedEventArgs e)
        {
            textFields.Text = msg[step];
            ((Button)e.OriginalSource).Content = Step();
            ((Button)e.OriginalSource).IsEnabled = false;
        }

       //Метод проверяет выигрышные ситуации.
       bool Is_Winner()
        {
            // 1 == 2 == 3
            if (one.Content == two.Content && two.Content == three.Content)
            {
                textFields.Text = win[step];               
                return true;
            }

            // 4 == 5 == 6
            if (four.Content == five.Content && five.Content == six.Content)
            {
                textFields.Text = win[step];
                return true;
            }

            // 7 == 8 == 9
            if (seven.Content == eight.Content && nine.Content == three.Content)
            {
                textFields.Text = win[step];
                return true;
            }

            // 1 == 5 == 9
            if (one.Content == five.Content && five.Content == nine.Content)
            {
                textFields.Text = win[step];
                return true;
            }

            // 3 == 5 == 7
            if (three.Content == five.Content && five.Content == seven.Content)
            {
                textFields.Text = win[step];
                return true;
            }

            // 1 == 4 == 7
            if (one.Content == four.Content && four.Content == seven.Content)
            {
                textFields.Text = win[step];
                return true;
            }

            // 2 == 5 == 8
            if (two.Content == five.Content && five.Content == eight.Content)
            {
                textFields.Text = win[step];
                return true;
            }

            // 3 == 6 == 9
            if (three.Content == six.Content && six.Content == nine.Content)
            {
                textFields.Text = win[step];
                return true;
            }
            return false;
        }

    }
}
