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
    public partial class frmEditAnime : Form
    {

        Anime currentAnime = new Anime();
        LocalStorageHandler localStorageHandler = new LocalStorageHandler();


        public frmEditAnime(string Animeid)
        {
            InitializeComponent();

            currentAnime = localStorageHandler.GetAnimeById(Animeid);
            this.Text = "AnimeWinForm - " + "Edit " + currentAnime.Title;
            txtTitle.Text = currentAnime.Title;
            txtShortTitle.Text = currentAnime.ShortTitle;
            cmbYear.Text = currentAnime.Year;
            cmbSeason.Text = currentAnime.Season;
            numEpisodes.Value = currentAnime.Episodes;
            if(currentAnime.StartWatch.Year == 0001 )
            {
                dtStartDate.Value = DateTime.Now;

            }
            else
            {
                dtStartDate.Value = currentAnime.StartWatch;
            }
            if(currentAnime.StopWatch.Year == 0001)
            {
                dtEndDate.Value = DateTime.Now;
            }
            else
            {
                dtEndDate.Value = currentAnime.StopWatch;
            }
            cmbStatus.Text = currentAnime.Status;
            cmbRating.Text = currentAnime.Rating;
        }
    }
}
