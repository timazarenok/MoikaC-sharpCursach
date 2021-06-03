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
using Excel = Microsoft.Office.Interop.Excel;

namespace MoikaStatistic
{
    /// <summary>
    /// Interaction logic for OtchetWindow.xaml
    /// </summary>
    public partial class OtchetWindow : Window
    {
        public OtchetWindow()
        {
            InitializeComponent();
            SetTable();
        }
        public List<ReviewOtchet> reviews = new List<ReviewOtchet>();
        private void SetTable()
        {
            DataTable dt = SqlDB.Select("select [value] as score, [text], [surname], employer_number as number, date, login, Services.name as [service], Services.price from Reviews " +
                "join Scores on Scores.id = score_id " +
                "join Clients on Reviews.client_id = Clients.id " +
                "join Employers on Employers.id = Reviews.employe_id " +
                "join Services on Services.id = Reviews.service_id");
            reviews = new List<ReviewOtchet>();
            foreach (DataRow dr in dt.Rows)
            {
                reviews.Add(new ReviewOtchet
                {
                    Surname = dr["surname"].ToString(),
                    Number = dr["number"].ToString(),
                    Score = dr["score"].ToString(),
                    Text = dr["text"].ToString(),
                    Date = dr["date"].ToString(),
                    Name = dr["login"].ToString(),
                    Service = dr["service"].ToString(),
                    Price = dr["price"].ToString()
                });
            }
            Table.ItemsSource = reviews;
        }
        private void GetAll_Click(object sender, RoutedEventArgs e)
        {
            SetTable();
        }
        private void Excel_Click(object sender, RoutedEventArgs e)
        {
            Excel.Application ExcelApp = new Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);
            ExcelApp.Columns.ColumnWidth = 15;

            ExcelApp.Cells[1, 1] = "Полное имя";
            ExcelApp.Cells[1, 2] = "Номер";
            ExcelApp.Cells[1, 3] = "Оценка";
            ExcelApp.Cells[1, 4] = "Текст";
            ExcelApp.Cells[1, 5] = "Дата";
            ExcelApp.Cells[1, 6] = "Клиент";
            ExcelApp.Cells[1, 7] = "Услуга";
            ExcelApp.Cells[1, 8] = "Цена";

            var list = Table.Items.OfType<ReviewOtchet>().ToList();

            for (int j = 0; j < list.Count; j++)
            {
                ExcelApp.Cells[j + 2, 1] = list[j].Surname;
                ExcelApp.Cells[j + 2, 2] = list[j].Number;
                ExcelApp.Cells[j + 2, 3] = list[j].Score;
                ExcelApp.Cells[j + 2, 4] = list[j].Text;
                ExcelApp.Cells[j + 2, 5] = list[j].Date;
                ExcelApp.Cells[j + 2, 6] = list[j].Name;
                ExcelApp.Cells[j + 2, 7] = list[j].Service;
                ExcelApp.Cells[j + 2, 8] = list[j].Price;
            }
            ExcelApp.Visible = true;
        }
        private void FilteredDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DataTable dt = SqlDB.Select("select [value] as score, [text], [surname], employer_number as number, date, login, Services.name as [service], Services.price from Reviews " +
                "join Scores on Scores.id = score_id " +
                "join Clients on Reviews.client_id = Clients.id " +
                "join Employers on Employers.id = Reviews.employe_id " +
                "join Services on Services.id = Reviews.service_id " +
                $"where date='{FilteredDate.SelectedDate}'");
            reviews = new List<ReviewOtchet>();
            foreach (DataRow dr in dt.Rows)
            {
                reviews.Add(new ReviewOtchet
                {
                    Surname = dr["surname"].ToString(),
                    Number = dr["number"].ToString(),
                    Score = dr["score"].ToString(),
                    Text = dr["text"].ToString(),
                    Date = dr["date"].ToString(),
                    Name = dr["login"].ToString(),
                    Service = dr["service"].ToString(),
                    Price = dr["price"].ToString()
                });
            }
            Table.ItemsSource = reviews;
        }
    }
}
