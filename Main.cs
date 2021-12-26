using AnimeWinForm.SetupForms;
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
    public partial class Main : Form
    {

        
        public Main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSetup_Click(object sender, EventArgs e)
        {
            frmWelcome formWelcome = new frmWelcome();
            this.Hide();
            formWelcome.ShowDialog();
        }

        private void btnLocalDB_Click(object sender, EventArgs e)
        {
            LocalStorageHandler localStorageHandler = new LocalStorageHandler();

            localStorageHandler.GetAllAnime();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmHome formHome = new frmHome();
            this.Hide();
            formHome.Show();
        }
    }
}
