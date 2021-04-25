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
    /// Логика взаимодействия для EmployerLogin.xaml
    /// </summary>
    public partial class EmployerLogin : Window
    {
        public EmployerLogin()
        {
            InitializeComponent();
        }
        public bool RegexLogin(string login)
        {
            return new Regex("[0-9]{4,30}").IsMatch(login); 
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
                DataTable find = SqlDB.Select($"select * from [Employers] where employer_number={LoginBox.Text}");
                if (find.Rows.Count > 0)
                {
                    ReviewsWindow rw = new ReviewsWindow();
                    SqlDB.UserID = Convert.ToInt32(find.Rows[0]["id"]);
                    rw.Show();
                    Close();
                    MessageBox.Show("Пользователь авторизовался");
                }
                else
                {
                    MessageBox.Show("Такой сотрудник не найден, обратитесь к администратору");
                    Close();
                }
            }
            else MessageBox.Show("Введите номер сотрудника");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Login window = new Login();
            window.Show();
            Close();
        }
    }
}
