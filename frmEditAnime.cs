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
            txtReview.Text = currentAnime.Review;
            cmbYear.Text = currentAnime.Year;
            cmbSeason.Text = currentAnime.Season;
            numEpisodes.Value = currentAnime.Episodes;
            cmbStatus.Text = currentAnime.Status;
            cmbRating.Text = currentAnime.Rating;


            //init animeEpisode data grid

            grdAnimeEpisodes.ColumnCount = 4;
            grdAnimeEpisodes.Columns[0].Name = "Episode Number";
            grdAnimeEpisodes.Columns[1].Name = "Status";
            grdAnimeEpisodes.Columns[2].Name = "id";
            grdAnimeEpisodes.Columns[3].Name = "Animeid";

            DataGridViewButtonColumn watchBtn = new DataGridViewButtonColumn();
            DataGridViewButtonColumn skipBtn = new DataGridViewButtonColumn();
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

            var animeEpisodes = localStorageHandler.GetAnimeEpisodesByAnimeId(currentAnime.Id);

            foreach (var episode in animeEpisodes)
            {
                string[] row = new string[] { episode.EpisodeNumber.ToString(), episode.Status, episode.Id, episode.AnimeId };
                grdAnimeEpisodes.Rows.Add(row);
            }

            grdAnimeEpisodes.Columns[2].Visible = false;
            grdAnimeEpisodes.Columns[3].Visible = false;


            //for (int i = 1; i < grdAnimeEpisodes.Rows.Count; i++)
            //{
            //    if (grdAnimeEpisodes.Rows[i].Cells[1].Value.ToString() == "NotStarted")
            //    {
            //        grdAnimeEpisodes.Rows[i].ReadOnly = true;
            //        grdAnimeEpisodes.Rows[i].Cells[0].Style.BackColor = Color.DimGray;
            //        grdAnimeEpisodes.Rows[i].Cells[0].Style.ForeColor = Color.LightGray;
            //        grdAnimeEpisodes.Rows[i].Cells[1].Style.BackColor = Color.DimGray;
            //        grdAnimeEpisodes.Rows[i].Cells[1].Style.ForeColor = Color.LightGray;
            //        grdAnimeEpisodes.Rows[i].Cells[4].Value = "";
            //        grdAnimeEpisodes.Rows[i].Cells[5].Value = "";
            //        //grdAnimeEpisodes.Rows[i].Visible = false;
            //    }
            //}


        }

        private void grdAnimeEpisodes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grdAnimeEpisodes.Rows[e.RowIndex];
            DataGridViewColumn column = grdAnimeEpisodes.Columns[e.ColumnIndex];
            frmHome home = (frmHome)ActiveForm;


            //if(row.Cells[1].Value.ToString() == "NotStarted" && row.Cells[0].Value.ToString() != "1")
            //{
            //    MessageBox.Show("Mark earlier episodes as 'Watched' or 'Skipped' to mark this episode");
            //}
            //else
            //{
            //MessageBox.Show(row.Cells[2].Value.ToString());
            //MessageBox.Show(column.HeaderText);
            bool canMark = localStorageHandler.CheckAnimeEpisodeCount(row.Cells[2].Value.ToString(), currentAnime.Id);
                if(canMark == false)
                {
                    //MessageBox.Show("Mark earlier episodes as 'Watched' or 'Skipped' to mark this episode");
                    home.newMessage("Mark earlier episode to mark this episode", "fail");
                }
                else
                {
                localStorageHandler.MarkAnimeEpisode(column.HeaderText, row.Cells[2].Value.ToString());
                //MessageBox.Show("Marked");
                home.newMessage("Marked!", "success");
                this.Refresh();
                }
           // }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome formHome = new frmHome();
            this.Close();
            formHome.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmHome home = (frmHome)ActiveForm;
            bool canUpdate = localStorageHandler.UpdateAnime(currentAnime.Id, txtTitle.Text, cmbSeason.Text, cmbYear.Text, (int)numEpisodes.Value, cmbStatus.Text, cmbRating.Text, txtReview.Text);

            if(canUpdate == false)
            {
                //MessageBox.Show("Episodes cannot be decremented, only incremented");
                home.newMessage("Episodes cannot be decremented!", "fail");
            }
            else
            {
                home.newMessage("Anime Updated!", "success");
            }

        }

      

        private void btnRecentWatch_Click(object sender, EventArgs e)
        {
            //MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            //DialogResult result = MessageBox.Show($"Would you like to set this anime as recently watched?", "Set watched", buttons);
            //if (result == DialogResult.Yes)
            //{
            //    localStorageHandler.UpdateRecentlyWatched(currentAnime.Id);
            //}
            //else
            //{

            //}
        }
    }
}
