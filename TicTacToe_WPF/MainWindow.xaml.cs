using System;
using System.Windows;
using System.Windows.Controls;

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
            try
            {
                InitializeComponent();
                step = random.Next(2);
                textFields.Text = step == 0 ? msg[1] : msg[0];

                foreach (UIElement el in GameFields.Children)
                {
                    if (el is Button)
                    {
                        ((Button)el).Click += Click_Button;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("MainWindow" + ex.Message);
            }
        }

        //
        private void Click_Button(object sender, RoutedEventArgs e)
        {
            try
            {
                textFields.Text = msg[step];
                ((Button)e.OriginalSource).Content = Step();
                ((Button)e.OriginalSource).IsEnabled = false;

                if (Is_Winner())
                {
                    MessageBox.Show(win[step]);
                    Environment.Exit(0);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Click_Button " + ex.Message);
            }
        }

        //private bool Is_Draw(object sender, RoutedEventArgs e)
        //{
        //    bool value = true;
        //    try
        //    {
        //        foreach (UIElement el in GameFields.Children)
        //        {
        //            if (el is Button)
        //            {
        //                if (((Button)el).Content.ToString() == "")
        //                    value = false;
        //            }
        //        }
        //    }
        //    catch(Exception ex)
        //    {
        //        MessageBox.Show("Is_Draw " + ex.Message);
        //    }
        //    return value;
        //}

        //
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

        ////
        //private void ComLogic(object sender, RoutedEventArgs e)
        //{
        //    textFields.Text = msg[step];
        //    ((Button)e.OriginalSource).Content = Step();
        //    ((Button)e.OriginalSource).IsEnabled = false;
        //}

       //Метод проверяет выигрышные ситуации.
       private bool Is_Winner()
        {
            // 1 == 2 == 3
            if (one.Content == two.Content && two.Content == three.Content && (string)three.Content == cross || one.Content == two.Content && two.Content == three.Content && (string)three.Content == zero)
            {
                textFields.Text = win[step];               
                return true;
            }

            // 4 == 5 == 6
            if (four.Content == five.Content && five.Content == six.Content && (string)six.Content == cross || four.Content == five.Content && five.Content == six.Content && (string)six.Content == zero)
            {
                textFields.Text = win[step];
                return true;
            }

            // 7 == 8 == 9
            if (seven.Content == eight.Content && eight.Content == nine.Content && (string)nine.Content == cross || seven.Content == eight.Content && eight.Content == nine.Content && (string)nine.Content == zero)
            {
                textFields.Text = win[step];
                return true;
            }

            // 1 == 5 == 9
            if (one.Content == five.Content && five.Content == nine.Content && (string)nine.Content == cross || one.Content == five.Content && five.Content == nine.Content && (string)nine.Content == zero)
            {
                textFields.Text = win[step];
                return true;
            }

            // 3 == 5 == 7
            if (three.Content == five.Content && five.Content == seven.Content && (string)seven.Content == cross || three.Content == five.Content && five.Content == seven.Content && (string)seven.Content == zero)
            {
                textFields.Text = win[step];
                return true;
            }

            // 1 == 4 == 7
            if (one.Content == four.Content && four.Content == seven.Content && (string)seven.Content == cross || one.Content == four.Content && four.Content == seven.Content && (string)seven.Content == zero)
            {
                textFields.Text = win[step];
                return true;
            }

            // 2 == 5 == 8
            if (two.Content == five.Content && five.Content == eight.Content && (string)eight.Content == cross || two.Content == five.Content && five.Content == eight.Content && (string)eight.Content == zero)
            {
                textFields.Text = win[step];
                return true;
            }

            // 3 == 6 == 9
            if (three.Content == six.Content && six.Content == nine.Content && (string)nine.Content == cross || three.Content == six.Content && six.Content == nine.Content && (string)nine.Content == zero)
            {
                textFields.Text = win[step];
                return true;
            }
            return false;
        }

    }
}
