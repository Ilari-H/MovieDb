using ML_DB.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace ML_DB.Tabs
{
    public partial class UC_Search : UserControl
    {
        public UC_Search()
        {
            InitializeComponent();
            ApiKeylabel.Text = Properties.Settings.Default.ApiKeySave;
            ApiKey = Properties.Settings.Default.ApiKeySave; //hakee viimeksi käytetyn avaimen
        }

        private void HelpKeyBtn_Click(object sender, EventArgs e)
        {
            string message = "create key at https://www.omdbapi.com/ " +
                "\rpaste key onto: XXXXXXXX";
            string title = "Api Key help";
            MessageBox.Show(message, title);
        }

        private void SaveKeyBtn_Click(object sender, EventArgs e)
        {
            ApiKey = ApiKeyTxtBox.Text;
            ApiKeylabel.Text = ApiKey;

            Properties.Settings.Default.ApiKeySave = ApiKeylabel.Text;
            Properties.Settings.Default.Save(); //tallentaa uuden avaimen!
        } //tallentaa uuden Apikeyn

        string ApiKey = ""; //tää vaan on tässä

        private string RatingToEuropean(string Rating)
        {
            string TrueRating = Rating;
            if (Rating == "G")
            {
                TrueRating = "Everyone";
            }
            if (Rating == "PG")
            {
                TrueRating = "7+";
            }
            if (Rating == "PG-13")
            {
                TrueRating = "13+";
            }
            if (Rating == "R")
            {
                TrueRating = "16+";
            }
            if (Rating == "NC-17")
            {
                TrueRating = "18+";
            }
            if (Rating == "Not Rated")
            {
                TrueRating = "Not Rated";
            }

            return TrueRating;
        } //muuttaa huonot ikärajoituksen paremmiksi

        private async void SearchBtn_Click(object sender, EventArgs e)
        {
            string name = MovieNameTxtBox.Text;
            string key = ApiKey;
            string length = MovieLengthComboBox.Text;
            var values = await Controllers.Movie_Controller.FetchMovieAsync(name, key, length);
            
            if (values != null)
            {
                MovieInfoTxtBox.Text = values.Title + " " + values.Year + "\r" +
                                   "Plot: " + values.Plot + "\r\r" +
                                   "Director: " + values.Director + "\r" +
                                   "Writer: " + values.Writer + "\r" +
                                   "Actors: " + values.Actors + "\r\r" +
                                   "Languages: " + values.Language + "\r" +
                                   "Country: " + values.Country + "\r\r" +
                                   "Awards: " + values.Awards + "\r" +
                                   "Imdb rating: " + values.imdbRating + "\r" +
                                   "Votes: " + values.imdbVotes + "\r" +
                                   "Imdb ID: " + values.imdbID + "\r" +
                                   "Box office: " + values.BoxOffice + "\r\r" +
                                   "DVD release: " + values.DVD + "\r\r";
                MovieInfoTxtBox.Text += "Aditional Ratings: \r";


                if (values.Ratings != null)
                {
                    for (int i = 0; i < values.Ratings.Count; i++)
                    {
                        MovieInfoTxtBox.Text += values.Ratings[i].Source + " - " + values.Ratings[i].Value + "\r";
                    }
                }

                if (RatingStyleComboBox.Text == "European")
                {
                    MovieRatedTxtBox.Text = "Rated: " + RatingToEuropean(values.Rated);
                }
                else
                {
                    MovieRatedTxtBox.Text = "Rated: " + values.Rated;
                }

                GenreTxtBox.Text = values.Genre;

                MoviePictureBox.ImageLocation = values.Poster;

                if (values.Year == 0)
                {
                    MovieInfoTxtBox.Text = "There has been an error finding your movie. Please check ApiKey and/or movie title";
                }

                MoviePanel.Show();
            }


        } //Hakeee tiedot ja kirjoittaa ne


    }
}
