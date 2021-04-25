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
            DataTable dt = SqlDB.Select("select [value] as score, [text] from Reviews join Scores on Scores.id = score_id");
            reviews = new List<Review>();
            foreach(DataRow dr in dt.Rows)
            {
                reviews.Add(new Review { Score = dr["score"].ToString(), Text = dr["text"].ToString() });
            }
            Reviews.ItemsSource = reviews;
        }
        private void FindEmploer_Click(object sender, RoutedEventArgs e)
        {
            string currentText = this.Surname.Text;
            int employer_id = SqlDB.GetId($"select * from Employers where employer_number={currentText}");
            DataTable dt = SqlDB.Select($"select [value] as score, [text] from Reviews join Scores on Scores.id = score_id where employe_id={employer_id}");
            List<Review> filtered = new List<Review>();
            foreach (DataRow dr in dt.Rows)
            {
                filtered.Add(new Review { Score = dr["score"].ToString(), Text = dr["text"].ToString() });
            }
            Reviews.ItemsSource = filtered;
        }

        private void GetAll_Click(object sender, RoutedEventArgs e)
        {
            SetReviews();
        }
    }
}
