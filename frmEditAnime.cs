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

        Anime _currentAnime;
        LocalStorageHandler _localStorageHandler;
        frmHome _frmHome;
        public string CurrentAnimeId;
        public int LastEpisodeMarked;

        public frmEditAnime(string Animeid)
        {
            InitializeComponent();
            CurrentAnimeId = Animeid;
            _localStorageHandler = new();
            _frmHome = (frmHome)ActiveForm;
            InitForm();
        }

        private void InitForm()
        {

            _currentAnime = _localStorageHandler.GetAnimeById(CurrentAnimeId);
            _frmHome.Text = "AnimeWinForm Edit - " + _currentAnime.Title;

            grdAnimeEpisodes.Rows.Clear();
            grdAnimeEpisodes.Columns.Clear();

            txtTitle.Text = _currentAnime.Title;
            txtReview.Text = _currentAnime.Review;
            cmbYear.Text = _currentAnime.Year;
            cmbSeason.Text = _currentAnime.Season;
            numEpisodes.Value = _currentAnime.Episodes;
            cmbStatus.Text = _currentAnime.Status;
            cmbRating.Text = _currentAnime.Rating;

            grdAnimeEpisodes.ColumnCount = 5;
            grdAnimeEpisodes.Columns[0].Name = "Episode";
            grdAnimeEpisodes.Columns[1].Name = "Status";
            grdAnimeEpisodes.Columns[2].Name = "id";
            grdAnimeEpisodes.Columns[3].Name = "Animeid";
            grdAnimeEpisodes.Columns[4].Name = "Unmark";

            grdAnimeEpisodes.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            grdAnimeEpisodes.Columns[1].SortMode = DataGridViewColumnSortMode.Automatic;
            grdAnimeEpisodes.Columns[2].SortMode = DataGridViewColumnSortMode.NotSortable;
            grdAnimeEpisodes.Columns[3].SortMode = DataGridViewColumnSortMode.NotSortable;


            DataGridViewButtonColumn watchBtn = new();
            DataGridViewButtonColumn skipBtn = new();

            watchBtn.DefaultCellStyle.BackColor = Color.ForestGreen;
            watchBtn.DefaultCellStyle.ForeColor = Color.White;
            watchBtn.FlatStyle = FlatStyle.Popup;
            watchBtn.Width = 148;
            watchBtn.SortMode = DataGridViewColumnSortMode.NotSortable;


            skipBtn.DefaultCellStyle.BackColor = Color.RoyalBlue;
            skipBtn.DefaultCellStyle.ForeColor = Color.White;
            skipBtn.FlatStyle = FlatStyle.Popup;
            skipBtn.Width = 148;
            skipBtn.SortMode = DataGridViewColumnSortMode.NotSortable;




            grdAnimeEpisodes.Columns.Add(watchBtn);
            grdAnimeEpisodes.Columns.Add(skipBtn);
            watchBtn.HeaderText = "MarkWatched";
            watchBtn.Text = "Watch";
            watchBtn.Name = "Watch";
            watchBtn.UseColumnTextForButtonValue = true;
            skipBtn.HeaderText = "MarkSkipped";
            skipBtn.Text = "Skip";
            skipBtn.Name = "Skip";
            skipBtn.UseColumnTextForButtonValue = true;

            List<AnimeEpisode> animeEpisodes = _localStorageHandler.GetAnimeEpisodesByAnimeId(_currentAnime.Id);

            foreach (AnimeEpisode episode in animeEpisodes)
            {
                string[] row = new string[] { episode.EpisodeNumber.ToString(), episode.Status, episode.Id, episode.AnimeId };
                grdAnimeEpisodes.Rows.Add(row);
            }

            for (int i = 0; i < grdAnimeEpisodes.Rows.Count; i++)
            {
                switch (grdAnimeEpisodes.Rows[i].Cells[1].Value.ToString())
                {
                    case "NotStarted":
                        grdAnimeEpisodes.Rows[i].Cells[1].Style.ForeColor = Color.White;
                        break;
                    case "Skipped":
                        grdAnimeEpisodes.Rows[i].Cells[1].Style.ForeColor = Color.RoyalBlue;
                        LastEpisodeMarked = i;
                        break;
                    case "Watched":
                        grdAnimeEpisodes.Rows[i].Cells[1].Style.ForeColor = Color.ForestGreen;
                        LastEpisodeMarked = i;
                        break;
                    default:
                        grdAnimeEpisodes.Rows[i].Cells[1].Style.ForeColor = Color.White;
                        break;
                }
            }

            grdAnimeEpisodes.Rows[LastEpisodeMarked].Cells[4].ValueType = typeof(Button);
            grdAnimeEpisodes.Rows[LastEpisodeMarked].Cells[4].Style.BackColor = Color.RebeccaPurple;
            grdAnimeEpisodes.Rows[LastEpisodeMarked].Cells[4].Style.ForeColor = Color.White;
            grdAnimeEpisodes.Rows[LastEpisodeMarked].Cells[4].Value = "Unmark";



            grdAnimeEpisodes.Columns[2].Visible = false;
            grdAnimeEpisodes.Columns[3].Visible = false;
        }

        private void grdAnimeEpisodes_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.ColumnIndex == 4 && e.RowIndex == LastEpisodeMarked)
            {
                DataGridViewRow row = grdAnimeEpisodes.Rows[e.RowIndex];
                _localStorageHandler.UnMarkAnimeEpisode(row.Cells[2].Value.ToString());
                _frmHome.newMessage("Unmarked!", "success");
                InitForm();
                return;
            }


            if (e.RowIndex > -1 && e.ColumnIndex > 4)
            {
                DataGridViewRow row = grdAnimeEpisodes.Rows[e.RowIndex];
                DataGridViewColumn column = grdAnimeEpisodes.Columns[e.ColumnIndex];


                
                bool canMark = _localStorageHandler.CheckAnimeEpisodeCount(row.Cells[2].Value.ToString(), _currentAnime.Id);
                if (canMark == false)
                {
                    _frmHome.newMessage("Mark earlier episode to mark this episode", "fail");
                }
                else
                {
                    _localStorageHandler.MarkAnimeEpisode(column.HeaderText, row.Cells[2].Value.ToString());
                    _frmHome.newMessage("Watched!", "success");
                    InitForm();
                }
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                _frmHome.newMessage("Title is required", "fail");
                return;
            }

            bool canUpdate = _localStorageHandler.UpdateAnime(_currentAnime.Id, txtTitle.Text, cmbSeason.Text, cmbYear.Text, (int)numEpisodes.Value, cmbStatus.Text, cmbRating.Text, txtReview.Text);

            if(canUpdate == false)
            {
                _frmHome.newMessage("Episodes cannot be decremented!", "fail");
            }
            else
            {
                _frmHome.newMessage("Anime Updated!", "success");
            }
            InitForm();

        }

        private void label9_Click(object sender, EventArgs e)
        {
            _frmHome.newMessage("Nice one!", "success");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult deleteResult = MessageBox.Show("Are you sure you want to delete " + _currentAnime.Title + "?", "Delete - " + _currentAnime.Title, MessageBoxButtons.YesNo);
            if(deleteResult == DialogResult.Yes)
            {
                _localStorageHandler.DeleteAnime(_currentAnime.Id);
                _frmHome.newMessage("Anime Deleted!", "success");
                Close();
                _frmHome.viewAllAnime();
            }
        }
    }
}
