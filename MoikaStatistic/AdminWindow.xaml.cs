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

namespace MoikaStatistic
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
        }

        private void Employers_Click(object sender, RoutedEventArgs e)
        {
            EmployersWindow window = new EmployersWindow();
            window.Show();
        }

        private void Reviews_Click(object sender, RoutedEventArgs e)
        {
            ReviewsWindow window = new ReviewsWindow();
            window.Show();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            Close();
        }

        private void Services_Click(object sender, RoutedEventArgs e)
        {
            ServicesWindow categories = new ServicesWindow();
            categories.Show();
        }

        private void NewEmployer_Click(object sender, RoutedEventArgs e)
        {
            CreateEmployerWindow window = new CreateEmployerWindow();
            window.Show();
        }

        private void Otchet_Click(object sender, RoutedEventArgs e)
        {
            OtchetWindow window = new OtchetWindow();
            window.Show();
        }
    }
}
