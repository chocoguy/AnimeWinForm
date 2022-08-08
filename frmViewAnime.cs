using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimeWinForm.Data;
using AnimeWinForm.Data.AnimeTables;

namespace AnimeWinForm
{
    public partial class frmViewAnime : Form
    {
        Anime currentAnime = new Anime();
        LocalStorageHandler localStorageHandler = new LocalStorageHandler();

        public frmViewAnime(string AnimeId)
        {
            InitializeComponent();

            currentAnime = localStorageHandler.GetAnimeById(AnimeId);
            int currentEpisode = localStorageHandler.GetEpisodeCurrentlyOn(AnimeId);

            lblAnimeTitle.Text = currentAnime.Title;
            this.Text = "AnimeWinForm - " + currentAnime.Title;
            lblEpisodeOn.Text = currentEpisode.ToString();
            lblEpisodes.Text = currentAnime.Episodes.ToString();
            lblRating.Text = currentAnime.Rating;
            lblSeason.Text = currentAnime.Season;
            lblYear.Text = currentAnime.Year;
            txtReview.Text = currentAnime.Review;

            switch (currentAnime.Status)
            {
                case "Watching":
                    lblStatus.Text = currentAnime.Status;
                    lblStatus.ForeColor = Color.LawnGreen;
                    break;

                case "Finished":
                    lblStatus.Text = currentAnime.Status;
                    lblStatus.ForeColor = Color.LawnGreen;
                    break;

                case "Dropped":
                    lblStatus.Text = currentAnime.Status;
                    lblStatus.ForeColor = Color.Crimson;
                    break;

                case "Stalled":
                    lblStatus.Text = currentAnime.Status;
                    lblStatus.ForeColor = Color.Yellow;
                    break;

                case "Not Started":
                    lblStatus.Text = currentAnime.Status;
                    lblStatus.ForeColor = Color.DodgerBlue;
                    break;

                default:
                    lblStatus.Text = "Unknown";
                    lblStatus.ForeColor = Color.Crimson;
                    break;
            }

        }

        private void lblSeason_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome formHome = new frmHome();
            this.Hide();
            formHome.Show();
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            frmHome home = (frmHome)ActiveForm;
            int currentEpisode = localStorageHandler.GetEpisodeCurrentlyOn(currentAnime.Id);
            if (currentEpisode == currentAnime.Episodes)
            {
                //MessageBox.Show("Anime has been finished, Can't increment!");
                home.newMessage("Anime finished, Can't increment!", "fail");
                return;
            }
            localStorageHandler.IncrementAnimeEpisodeByOne(currentAnime.Id);
            home.newMessage("Episode Incremented!", "success");
            this.Refresh();
        }

        private void lblYear_Click(object sender, EventArgs e)
        {

        }

        private List<string> InterviewQuestion(string inputt)
        {
            string useless = inputt;
            List<string> myArray = new List<string>();
            myArray.Add("('a', 4)");
            myArray.Add("('b', 3)");
            myArray.Add("('c', 2)");
            myArray.Add("('a', 1)");
            return myArray;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmHome home = (frmHome)ActiveForm;
            home.editSingleAnime(currentAnime.Id);
            //frmEditAnime formEditAnime = new frmEditAnime(currentAnime.Id);
            //formEditAnime.Show();
        }
    }
}
