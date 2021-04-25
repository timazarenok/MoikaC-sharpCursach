using MoikaStatistic.Models;
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

namespace MoikaStatistic
{
    /// <summary>
    /// Логика взаимодействия для EmployersWindow.xaml
    /// </summary>
    public partial class EmployersWindow : Window
    {
        public List<Employer> employers = new List<Employer>();
        public EmployersWindow()
        {
            InitializeComponent();
            SetEmployers();
        }
        private void SetEmployers()
        {
            DataTable dt = SqlDB.Select("select surname, employer_number, telephone, [name], (select Count(*) from Reviews where employe_id = Employers.id) as amount from Employers join Professions on Professions.id = profession_id");
            employers = new List<Employer>();
            foreach(DataRow dr in dt.Rows)
            {
                employers.Add(new Employer
                {
                    Number = dr["employer_number"].ToString(),
                    Surname = dr["surname"].ToString(),
                    Telephone = dr["telephone"].ToString(),
                    Profession = dr["name"].ToString(),
                    Amount = dr["amount"].ToString()
                });
            }
            Table.ItemsSource = employers;
        }
        private void Surname_TextChanged(object sender, EventArgs e)
        {
            string currentText = this.Surname.Text;
            List<Employer> filtered = employers.FindAll(item => item.Surname.Contains(currentText));
            Table.ItemsSource = filtered;
        }
    }
}
