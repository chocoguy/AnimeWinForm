﻿using System;
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

            grdAnime.ColumnCount = 6;
            grdAnime.Columns[0].Name = "Title";
            grdAnime.Columns[1].Name = "Season";
            grdAnime.Columns[2].Name = "Year";
            grdAnime.Columns[3].Name = "Episode";
            grdAnime.Columns[4].Name = "Status";
            grdAnime.Columns[5].Name = "id";

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            grdAnime.Columns.Add(btn);
            btn.HeaderText = "";
            btn.Text = "View";
            btn.Name = "btn";
            btn.UseColumnTextForButtonValue = true;


            var animes = localStorageHandler.GetAllAnime();

            foreach (var anime in animes)
            {
                var currentEpisodeOnAnime = localStorageHandler.GetEpisodeCurrentlyOn(anime.Id);
                string[] row = new string[] { anime.Title, anime.Season, anime.Year, currentEpisodeOnAnime.ToString() + "/" + anime.Episodes, anime.Status, anime.Id };
                grdAnime.Rows.Add(row);
            }

            grdAnime.Columns[5].Visible = false;


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



        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Main formMain = new Main();
            //this.Hide();
            //formMain.Show();
            Application.Exit();
        }

        private void grdAnime_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = grdAnime.Rows[e.RowIndex];

            frmViewAnime formViewAnime = new frmViewAnime(row.Cells[5].Value.ToString());
            formViewAnime.Show();
        }
    }
}
