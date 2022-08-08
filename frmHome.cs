using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            //initQuotes();

        }




        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Main formMain = new Main();
            //this.Hide();
            //formMain.Show();
            Application.Exit();
        }

        //private void metroButton1_Click(object sender, EventArgs e)
        //{
        //    this.mainPanel.Controls.Clear();
        //    frmViewAllAnime frm = new frmViewAllAnime() { TopLevel = false, TopMost = true };
        //    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        //    frm.Dock = DockStyle.Fill;
        //    this.mainPanel.Controls.Add(frm);
        //    frm.Show();
        //}

        private void btnAddAnime_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            frmAddAnime frmAnime = new frmAddAnime() { TopLevel = false, TopMost = true };
            frmAnime.FormBorderStyle = FormBorderStyle.None;
            frmAnime.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(frmAnime);
            frmAnime.Show();
        }

        public void viewSingleAnime(string AnimeID)
        {
            this.mainPanel.Controls.Clear();
            frmViewAnime frmAnime = new frmViewAnime(AnimeID) { TopLevel = false, TopMost = true };
            frmAnime.FormBorderStyle = FormBorderStyle.None;
            frmAnime.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(frmAnime);
            frmAnime.Show();


        }

        public void editSingleAnime(string AnimeID)
        {
            this.mainPanel.Controls.Clear();
            frmEditAnime frmAnime = new frmEditAnime(AnimeID) { TopLevel = false, TopMost = true };
            frmAnime.FormBorderStyle = FormBorderStyle.None;
            frmAnime.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(frmAnime);
            frmAnime.Show();

        }

        public void viewAllAnime()
        {
            this.mainPanel.Controls.Clear();
            frmViewAllAnime frm = new frmViewAllAnime() { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(frm);
            frm.Show();
        }

        public async void newMessage(string Message, string Type)
        {
            if(Type == "success")
            {
                infoQuotelbl.Text = Message;
                infoQuotelbl.ForeColor = Color.SpringGreen;
            }else if(Type == "fail")
            {
                infoQuotelbl.Text = Message;
                infoQuotelbl.ForeColor = Color.Crimson;
            }
            else
            {
                infoQuotelbl.Text = Message;
                infoQuotelbl.ForeColor = Color.DarkTurquoise;
            }
            await Task.Delay(2000);
            infoQuotelbl.Text = "";
        }

       

        private void initQuotes()
        {
            var rand = new Random();
            List<string> quotes = new List<string>();

            quotes.Add("\"Mann I hate fish\"");
            quotes.Add("\"Enjoy right now, today...\"");
            quotes.Add("\"I spent $1000+ on Anime Figures\"");
            quotes.Add("\"STUTUTUTUTU\"");
            quotes.Add("\"4Chan rotted my brain\"");
            quotes.Add("\"2007 Toyota Camry\"");
            quotes.Add("\"Change the Future!!!\"");
            quotes.Add("\"103.5 Dawn FM!!!\"");
            quotes.Add("\"Call me if you get lost\"");
            quotes.Add("\"I spent 3 months on this...\"");
            quotes.Add("\"I aint got TIMEEEEE!!!\"");
            quotes.Add("\"Decahex.com comming soon...\"");
            quotes.Add("\"Decahex 2022\"");
            quotes.Add("\"Created by Chocoguy\"");
            quotes.Add("\"Usagi Chan best Girl!\"");
            quotes.Add("\"I hate Ads\"");
            quotes.Add("\"sure\"");

            int randQuoteNum = rand.Next(17);

            infoQuotelbl.Text = quotes[randQuoteNum];

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            frmAbout frmabout = new frmAbout { TopLevel = false, TopMost = true };
            frmabout.FormBorderStyle = FormBorderStyle.None;
            frmabout.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(frmabout);
            frmabout.Show();
        }

        private void btnViewAnime_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            frmViewAllAnime frm = new frmViewAllAnime() { TopLevel = false, TopMost = true };
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(frm);
            frm.Show();
        }


    }



}
