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

namespace todo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private void EmailTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            // Убираем текст placeholder при фокусе
            if (EmailTextBox.Text == "Введите почту")
            {
                EmailTextBox.Text = "";
            }

            // Делаем вводимый текст черным
            EmailTextBox.Foreground = Brushes.Black;
            EmailTextBox.Opacity = 1.0;
        }

        private void EmailTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            // Возвращаем текст placeholder при потере фокуса, если поле пустое
            if (string.IsNullOrWhiteSpace(EmailTextBox.Text))
            {
                EmailTextBox.Text = "Введите почту";
                EmailTextBox.Foreground = Brushes.Gray;

            }
        }
        private void TextBoxWithPlaceholder_GotFocus(object sender, RoutedEventArgs e)
        {

            // Убираем текст placeholder при фокусе
            if (TextBoxWithPlaceholder.Text == "Введите пароль")
            {
                TextBoxWithPlaceholder.Text = "";
            }

            // Делаем вводимый текст черным
            TextBoxWithPlaceholder.Foreground = Brushes.Black;
            TextBoxWithPlaceholder.Opacity = 1.0;
        }

        private void TextBoxWithPlaceholder_LostFocus(object sender, RoutedEventArgs e)
        {
            // Возвращаем текст placeholder при потере фокуса, если поле пустое
            if (string.IsNullOrWhiteSpace(TextBoxWithPlaceholder.Text))
            {
                TextBoxWithPlaceholder.Text = "Введите пароль";
                TextBoxWithPlaceholder.Foreground = Brushes.Gray;
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {


            this.Hide();

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void parol_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
