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
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace MoikaStatistic
{
    /// <summary>
    /// Логика взаимодействия для CreateEmployerWindow.xaml
    /// </summary>
    public partial class CreateEmployerWindow : Window
    {
        public CreateEmployerWindow()
        {
            InitializeComponent();
            SetProfessions();
        }
        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        private void SetProfessions()
        {
            DataTable dt = SqlDB.Select("select * from Professions");
            List<string> proffessions = new List<string>();
            foreach(DataRow dr in dt.Rows)
            {
                proffessions.Add(dr["name"].ToString());
            }
            Professions.ItemsSource = proffessions;
        } 

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            string surname = Surname.Text;
            string telephone_number = Telephone.Text;
            string id = UniquNumber.Text;
            int id_prof = SqlDB.GetId($"select id from Professions where [name] = '{Professions.SelectedItem}'");
            if (SqlDB.Command($"insert into Employers values ({id_prof}, '{surname}', '{telephone_number}', {id})"))
            {
                MessageBox.Show("Успешно создан");
            }
            else
            {
                MessageBox.Show("Проверьте правильность введенных данных");
            }
        }
    }
}
