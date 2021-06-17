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
    /// Логика взаимодействия для ReviewsWindow.xaml
    /// </summary>
    public partial class ReviewsWindow : Window
    {
        public List<Review> reviews = new List<Review>();
        public ReviewsWindow()
        {
            InitializeComponent();
            SetReviews();
        }
        private void SetReviews()
        {
            DataTable dt = SqlDB.Select("select [value] as score, [text], [surname], employer_number as number, date, login from Reviews " +
                "join Scores on Scores.id = score_id " +
                "join Clients on Reviews.client_id = Clients.id " +
                "join Employers on Employers.id = Reviews.employe_id");
            reviews = new List<Review>();
            foreach(DataRow dr in dt.Rows)
            {
                reviews.Add(new Review {
                    Surname = dr["surname"].ToString(),
                    Number = dr["number"].ToString(),
                    Score = dr["score"].ToString(), 
                    Text = dr["text"].ToString(),
                    Date = dr["date"].ToString(),
                    Name = dr["login"].ToString()
                });
            }
            Reviews.ItemsSource = reviews;
        }
        private void FindEmploer_Click(object sender, RoutedEventArgs e)
        {
            string currentText = this.Surname.Text;
            int employer_id = SqlDB.GetId($"select * from Employers where employer_number={currentText}");
            DataTable dt = SqlDB.Select($"select [value] as score, [text], [surname], employer_number as number, date, login from Reviews " +
                $"join Scores on Scores.id = score_id " +
                $"join Clients on Reviews.client_id = Clients.id " +
                $"join Employers on Employers.id = Reviews.employe_id " +
                $"where employe_id={employer_id}");
            List<Review> filtered = new List<Review>();
            foreach (DataRow dr in dt.Rows)
            {
                filtered.Add(new Review { 
                    Surname = dr["surname"].ToString(), 
                    Number = dr["number"].ToString(), 
                    Score = dr["score"].ToString(), 
                    Text = dr["text"].ToString(),
                    Date = dr["date"].ToString(),
                    Name = dr["login"].ToString()
                });
            }
            Reviews.ItemsSource = filtered;
        }

        private void GetAll_Click(object sender, RoutedEventArgs e)
        {
            SetReviews();
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

            var list = Reviews.Items.OfType<Review>().ToList();

            for (int j = 0; j < list.Count; j++)
            {
                ExcelApp.Cells[j + 2, 1] = list[j].Surname;
                ExcelApp.Cells[j + 2, 2] = list[j].Number;
                ExcelApp.Cells[j + 2, 3] = list[j].Score;
                ExcelApp.Cells[j + 2, 4] = list[j].Text;
                ExcelApp.Cells[j + 2, 5] = list[j].Date;
                ExcelApp.Cells[j + 2, 6] = list[j].Name;
            }
            ExcelApp.Visible = true;
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            EmployerLogin window = new EmployerLogin();
            window.Show();
            Close();
        }

        private void FilteredDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DataTable dt = SqlDB.Select("select [value] as score, [text], [surname], employer_number as number, date, login from Reviews " +
                "join Scores on Scores.id = score_id " +
                "join Clients on Reviews.client_id = Clients.id " +
                "join Employers on Employers.id = Reviews.employe_id " +
                $"where date='{FilteredDate.SelectedDate}'");
            reviews = new List<Review>();
            foreach (DataRow dr in dt.Rows)
            {
                reviews.Add(new Review
                {
                    Surname = dr["surname"].ToString(),
                    Number = dr["number"].ToString(),
                    Score = dr["score"].ToString(),
                    Text = dr["text"].ToString(),
                    Date = dr["date"].ToString(),
                    Name = dr["login"].ToString()
                });
            }
            Reviews.ItemsSource = reviews;
        }

        private void SortMin_Click(object sender, RoutedEventArgs e)
        {
            var sortedReviews = from r in reviews
                              orderby r.Score
                              select r;
            Reviews.ItemsSource = sortedReviews.ToList();
        }

        private void SortMax_Click(object sender, RoutedEventArgs e)
        {
            var sortedReviews = from r in reviews
                                orderby r.Score descending
                                select r;
            Reviews.ItemsSource = sortedReviews.ToList();
        }
    }
}
