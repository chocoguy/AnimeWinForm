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
            lblShortTitle.Text = currentAnime.ShortTitle;
            lblStartWatch.Text = currentAnime.StartWatch.ToString();
            lblStatus.Text = currentAnime.Status;
            lblStopWatch.Text = currentAnime.StopWatch.ToString();
            lblYear.Text = currentAnime.Year;
            
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
            int currentEpisode = localStorageHandler.GetEpisodeCurrentlyOn(currentAnime.Id);
            if (currentEpisode == currentAnime.Episodes)
            {
                MessageBox.Show("Anime has been finished, Can't increment!");
                return;
            }
            localStorageHandler.IncrementAnimeEpisodeByOne(currentAnime.Id);
            this.Refresh();
        }

        private void lblYear_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditAnime formEditAnime = new frmEditAnime(currentAnime.Id);
            formEditAnime.Show();
        }
    }
}
