using MoikaStatistic.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
    /// Логика взаимодействия для ServicesWindow.xaml
    /// </summary>
    public partial class ServicesWindow : Window
    {
        public ServicesWindow()
        {
            InitializeComponent();
            SetServices();
        }
        private void SetServices()
        {
            DataTable dt = SqlDB.Select("select * from Services");
            List<Service> services = new List<Service>();
            foreach (DataRow dr in dt.Rows)
            {
                services.Add( new Service { Name = dr["name"].ToString(), Price = dr["price"].ToString() });
            }
            Table.ItemsSource = services;
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9.]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string name = Name.Text;
            string price = Price.Text;
            if (SqlDB.Command($"insert into Services values('{name}', {price})"))
            {
                SetServices();
                MessageBox.Show("Успешно создан");
            }
            else
            {
                MessageBox.Show("Проверьте правильность введенных данных");
            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            string name = Name.Text;
            if (SqlDB.Command($"delete from Services where [name] = '{name}'"))
            {
                SetServices();
                MessageBox.Show("Успешно удален");
            }
            else
            {
                MessageBox.Show("Проверьте правильность введенных данных");
            }
        }
    }
}
