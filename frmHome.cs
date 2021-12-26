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

namespace AnimeWinForm
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();

            LocalStorageHandler localStorageHandler = new LocalStorageHandler();


            //add columns manually for more control

            grdRecentWatch.ColumnCount = 6;
            grdRecentWatch.Columns[0].Name = "Title";
            grdRecentWatch.Columns[1].Name = "Season";
            grdRecentWatch.Columns[2].Name = "Year";
            grdRecentWatch.Columns[3].Name = "Episode";
            grdRecentWatch.Columns[4].Name = "Status";
            grdRecentWatch.Columns[5].Name = "id";

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            grdRecentWatch.Columns.Add(btn);
            btn.HeaderText = "";
            btn.Text = "Edit";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;

            //string[] row = new string[] { "1", "product1" };
            //grdRecentWatch.Rows.Add(row);
            var animes = localStorageHandler.GetRecentlyWatchedAnime();
            

            foreach (var anime in animes)
            {
                var currentEpisodeOnAnime = localStorageHandler.GetEpisodeCurrentlyOn(anime.Id);
                string[] row = new string[] { anime.Title, anime.Season, anime.Year, currentEpisodeOnAnime.ToString() + "/" + anime.Episodes, anime.Status, anime.Id };

                grdRecentWatch.Rows.Add(row);


               


            }

            grdRecentWatch.Columns[5].Visible = false;

            //grdRecentWatch.DataSource = animes;
            

 
            

        }

        private void lblBorder_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAnime_Click(object sender, EventArgs e)
        {
            frmAddAnime formAnime = new frmAddAnime();
            this.Hide();
            formAnime.Show();
        }

        private void grdRecentWatch_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow row = grdRecentWatch.Rows[e.RowIndex];
           // MessageBox.Show(row.Cells[5].Value.ToString());

            frmViewAnime formViewAnime = new frmViewAnime(row.Cells[5].Value.ToString());
            formViewAnime.Show();


            //MessageBox.Show(grdRecentWatch.SelectedRows[0].Index.ToString());
            //int currentRowIndex = e.RowIndex;
            //DataGridView row = this.grdRecentWatch.SelectedRows[2];
            //MessageBox.Show(row.Cells["id"].Value.ToString());
           // MessageBox.Show(e.RowIndex.ToString());
        }
    }
}
