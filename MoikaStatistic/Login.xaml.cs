using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        public bool RegexLogin(string login)
        {
            try
            {
                MailAddress m = new MailAddress(login);
                return true;
            }
            catch(FormatException)
            {
                return false;
            }
        }
        public bool RegexPassword(string password)
        {
            return new Regex("[A-Za-z0-9]{8,20}").IsMatch(password);
        }
        public bool RegexAdmin(string login)
        {
            return new Regex(@"admin").IsMatch(login);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (RegexAdmin(LoginBox.Text))
            {
                AdminWindow admin = new AdminWindow();
                admin.Show();
                Close();
            }
            else if (RegexLogin(LoginBox.Text))
            {
                DataTable find = SqlDB.Select($"select * from [Clients] where login='{LoginBox.Text}'");
                if (find.Rows.Count > 0)
                {
                    MainWindow mw = new MainWindow();
                    SqlDB.UserID = Convert.ToInt32(find.Rows[0]["id"]);
                    mw.Show();
                    Close();
                    MessageBox.Show("Пользователь авторизовался");
                }
                else
                {
                    SqlDB.Command($"insert into [Clients] values ('{LoginBox.Text}')");
                    MainWindow mw = new MainWindow();
                    find = SqlDB.Select($"select * from [Clients] where login='{LoginBox.Text}'");
                    SqlDB.UserID = Convert.ToInt32(find.Rows[0]["id"]);
                    mw.Show();
                    Close();
                }
            }
            else MessageBox.Show("Введите E-mail");
        }

        private void EmployerLogin_Click(object sender, RoutedEventArgs e)
        {
            EmployerLogin window = new EmployerLogin();
            window.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            InfoWindow window = new InfoWindow();
            window.Show();
        }
    }
}
