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

    public partial class frmAddAnime : Form
    {


        LocalStorageHandler localStorageHandler = new LocalStorageHandler();

        public frmAddAnime()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmHome formHome = new frmHome();
            this.Hide();
            formHome.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            localStorageHandler.SaveNewAnime(txtTitle.Text, txtShortTitle.Text, cmbSeason.Text, cmbYear.Text, (int)numEpisodes.Value, "Not Started");
            MessageBox.Show("Anime Added!");
            txtTitle.Clear();
            txtShortTitle.Clear();
            numEpisodes.Value = 0;

        }

        private void cmbYear_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = false;
        }

        private void cmbSeason_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }

        private void cmbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }

        private void cmbYear_TextChanged(object sender, EventArgs e)
        {
            //e.Handled = false;
        }

        private void cmbSeason_TextChanged(object sender, EventArgs e)
        {
           // e.Handled = false;

        }

        private void cmbSeason_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = false;
        }

        //private void txtEpisodes_TextChanged(object sender, EventArgs e)
        //{

        //}

        //private void txtEpisodes_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (char.IsControl(e.KeyChar) == false && char.IsDigit(e.KeyChar) == false && (e.KeyChar != '.'))
        //    {
        //        e.Handled = true;
        //    }
        //}
    }
}
