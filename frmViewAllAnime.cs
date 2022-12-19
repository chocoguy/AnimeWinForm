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
    public partial class frmViewAllAnime : Form
    {

        LocalStorageHandler _localStorageHandler;
        frmHome _frmHome;

        public frmViewAllAnime()
        {
            InitializeComponent();
            _localStorageHandler = new();
            _frmHome = (frmHome)ActiveForm;
            _frmHome.Text = "AnimeWinForm - Collection";
            InitTable();
        }

        private void InitTable()
        {
            grdAnime.Rows.Clear();
            grdAnime.Columns.Clear();

            grdAnime.ColumnCount = 6;
            grdAnime.Columns[0].Name = "Title";
            grdAnime.Columns[1].Name = "Season";
            grdAnime.Columns[2].Name = "Year";
            grdAnime.Columns[3].Name = "Episode";
            grdAnime.Columns[4].Name = "Status";
            grdAnime.Columns[5].Name = "id";

            grdAnime.Columns[0].Width = 238;

            DataGridViewButtonColumn viewButton = new();
            grdAnime.Columns.Add(viewButton);
            viewButton.HeaderText = "";
            viewButton.Text = "View";
            viewButton.Name = "ViewButton";
            viewButton.UseColumnTextForButtonValue = true;
            viewButton.DefaultCellStyle.BackColor = Color.RoyalBlue;
            viewButton.DefaultCellStyle.ForeColor = Color.White;
            viewButton.FlatStyle = FlatStyle.Popup;

            DataGridViewButtonColumn incrementEpisodeButton = new();
            grdAnime.Columns.Add(incrementEpisodeButton);
            incrementEpisodeButton.HeaderText = "";
            incrementEpisodeButton.Text = "Increment Ep";
            incrementEpisodeButton.Name = "IncrementEpisodeButton";
            incrementEpisodeButton.UseColumnTextForButtonValue = true;
            incrementEpisodeButton.DefaultCellStyle.BackColor = Color.Purple;
            incrementEpisodeButton.DefaultCellStyle.ForeColor = Color.White;
            incrementEpisodeButton.FlatStyle = FlatStyle.Popup;



            var animes = _localStorageHandler.GetAllAnime();

            foreach (var anime in animes)
            {
                var currentEpisodeOnAnime = _localStorageHandler.GetEpisodeCurrentlyOn(anime.Id);
                string[] row = new string[] { anime.Title, anime.Season, anime.Year, currentEpisodeOnAnime.ToString() + "/" + anime.Episodes, anime.Status, anime.Id };
                grdAnime.Rows.Add(row);
            }

            for (int i = 0; i < grdAnime.Rows.Count; i++)
            {

                grdAnime.Rows[i].Cells[1].Style.ForeColor = Color.SpringGreen;
                grdAnime.Rows[i].Cells[2].Style.ForeColor = Color.Goldenrod;
                grdAnime.Rows[i].Cells[3].Style.ForeColor = Color.MediumVioletRed;

                switch (grdAnime.Rows[i].Cells[4].Value.ToString())
                {
                    case "Watching":
                        grdAnime.Rows[i].Cells[4].Style.ForeColor = Color.RoyalBlue;
                        break;
                    case "Finished":
                        grdAnime.Rows[i].Cells[4].Style.ForeColor = Color.ForestGreen;
                        break;
                    case "Dropped":
                        grdAnime.Rows[i].Cells[4].Style.ForeColor = Color.Crimson;
                        break;
                    case "Stalled":
                        grdAnime.Rows[i].Cells[4].Style.ForeColor = Color.Orange;
                        break;
                    case "Not Started":
                        grdAnime.Rows[i].Cells[4].Style.ForeColor = Color.White;
                        break;
                    default:
                        grdAnime.Rows[i].Cells[4].Style.ForeColor = Color.White;
                        break;
                }

            }

            grdAnime.Columns[5].Visible = false;
        }


        private void grdAnime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex == 6)
            {
                DataGridViewRow row = grdAnime.Rows[e.RowIndex];
                _frmHome.viewSingleAnime(row.Cells[5].Value.ToString());
                // frmViewAnime formViewAnime = new frmViewAnime(row.Cells[5].Value.ToString());
                // formViewAnime.Show();
            }
            else if(e.RowIndex > -1 && e.ColumnIndex == 7)
            {
                DataGridViewRow row = grdAnime.Rows[e.RowIndex];
                int currentEpisode = _localStorageHandler.GetEpisodeCurrentlyOn(row.Cells[5].Value.ToString());
                Anime selectedAnime = _localStorageHandler.GetAnimeById(row.Cells[5].Value.ToString());
                if(currentEpisode == selectedAnime.Episodes)
                {
                    _frmHome.newMessage("Anime finished, Can't increment!", "fail");
                    return;
                }
                _localStorageHandler.IncrementAnimeEpisodeByOne(row.Cells[5].Value.ToString());
                _frmHome.newMessage("Episode Incremented!", "success");
                InitTable();
                this.Refresh();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome formHome = new frmHome();
            this.Close();
            formHome.Show();
        }

        private void btnAddAnime_Click(object sender, EventArgs e)
        {
            frmAddAnime formAnime = new frmAddAnime();
            this.Hide();
            formAnime.Show();
        }
    }
}
