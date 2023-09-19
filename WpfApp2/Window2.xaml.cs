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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

      
 private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            Registration page = new Registration();
            MainFrame.Navigate(page);
        }

        private void CatsButton_Click(object sender, RoutedEventArgs e)
        {
            CastPage page = new CastPage();
            MainFrame.Navigate(page);
        }

        private void GoogleButton_Click(object sender, RoutedEventArgs e)
        {
            Uri google = new Uri("https://yandex.com");
            MainFrame.Navigate(google);
        }
       
        private void GoBackk()
        {
            MainFrame.GoBack();
        }
    }
}
