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
        Anime _currentAnime;
        LocalStorageHandler _localStorageHandler;
        frmHome _frmHome;
        int currentEpisode;

        public frmViewAnime(string AnimeId)
        {
            InitializeComponent();
            _localStorageHandler = new();
            _frmHome = (frmHome)ActiveForm;
            _currentAnime = _localStorageHandler.GetAnimeById(AnimeId);
            currentEpisode = _localStorageHandler.GetEpisodeCurrentlyOn(AnimeId);
            _frmHome.Text = "AnimeWinForm - " + _currentAnime.Title;

            InitForm();


        }

        private void InitForm()
        {
            lblAnimeTitle.Text = _currentAnime.Title;
            lblEpisodeOn.Text = currentEpisode.ToString();
            lblEpisodes.Text = _currentAnime.Episodes.ToString();
            lblRating.Text = _currentAnime.Rating;
            lblSeason.Text = _currentAnime.Season;
            lblYear.Text = _currentAnime.Year;
            txtReview.Text = _currentAnime.Review;

            switch (_currentAnime.Status)
            {
                case "Watching":
                    lblStatus.Text = _currentAnime.Status;
                    lblStatus.ForeColor = Color.LawnGreen;
                    break;

                case "Finished":
                    lblStatus.Text = _currentAnime.Status;
                    lblStatus.ForeColor = Color.LawnGreen;
                    break;

                case "Dropped":
                    lblStatus.Text = _currentAnime.Status;
                    lblStatus.ForeColor = Color.Crimson;
                    break;

                case "Stalled":
                    lblStatus.Text = _currentAnime.Status;
                    lblStatus.ForeColor = Color.Yellow;
                    break;

                case "Not Started":
                    lblStatus.Text = _currentAnime.Status;
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
            frmHome formHome = new();
            this.Hide();
            formHome.Show();
        }

        private void btnIncrement_Click(object sender, EventArgs e)
        {
            if (currentEpisode == _currentAnime.Episodes)
            {
                _frmHome.newMessage("Anime finished, Can't increment!", "fail");
                return;
            }
            _localStorageHandler.IncrementAnimeEpisodeByOne(_currentAnime.Id);
            _frmHome.newMessage("Episode Incremented!", "success");
            this.Refresh();
        }

        private void lblYear_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmHome home = (frmHome)ActiveForm;
            home.editSingleAnime(_currentAnime.Id);
            //frmEditAnime formEditAnime = new frmEditAnime(currentAnime.Id);
            //formEditAnime.Show();
        }
    }
}
