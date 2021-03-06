using System;
using System.Collections.Generic;
using System.Data;
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

namespace MoikaStatistic
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetScores();
            SetEmployers();
            SetServices();
        }
        private void SetServices()
        {
            DataTable dt = SqlDB.Select("select * from Services");
            List<string> services = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                services.Add(dr["name"].ToString());
            }
            Service.ItemsSource = services;
        }
        private void SetScores()
        {
            DataTable dt = SqlDB.Select("select * from Scores");
            List<string> scores = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                scores.Add(dr["value"].ToString());
            }
            Scores.ItemsSource = scores;
        }

        private void SetEmployers()
        {
            DataTable dt = SqlDB.Select("select * from Employers");
            List<string> employers = new List<string>();
            foreach (DataRow dr in dt.Rows)
            {
                employers.Add(dr["surname"].ToString());
            }
            Employers.ItemsSource = employers;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string text = Text.Text;
            int id_score = SqlDB.GetId($"select id from Scores where [value]={Scores.SelectedItem}");
            int id_employer = SqlDB.GetId($"select id from Employers where surname = '{Employers.SelectedItem}'");
            int id_service = SqlDB.GetId($"select id from Services where name = '{Service.SelectedItem}'");
            if (SqlDB.Command($"insert into Reviews values ({id_score}, {SqlDB.UserID}, {id_employer}, {id_service}, '{text}', '{Date.SelectedDate}')"))
            {
                MessageBox.Show("Отзыв успешно отправлен");
            }
            else
            {
                MessageBox.Show("Проверьте правильность выбранных и введенных данных");
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Login window = new Login();
            window.Show();
            Close();
        }
    }
}
