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


        LocalStorageHandler _localStorageHandler = new();
        frmHome _frmHome;

        public frmAddAnime()
        {
            InitializeComponent();
            _frmHome = (frmHome)ActiveForm;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                _frmHome.newMessage("Title is required", "fail");
                return;
            }
            else if(cmbSeason.Text == "")
            {
                _frmHome.newMessage("Season is required", "fail");
                return;
            }
            else if(cmbYear.Text == "")
            {
                _frmHome.newMessage("Year is required", "fail");
                return;
            }
            else if(numEpisodes.Value == 0)
            {
                _frmHome.newMessage("at least 1 episode is required", "fail");
                return;
            }

            _localStorageHandler.SaveNewAnime(txtTitle.Text, cmbSeason.Text, cmbYear.Text, (int)numEpisodes.Value, "Not Started");


            _frmHome.newMessage("Anime Saved!", "success");
            
            txtTitle.Clear();
            numEpisodes.Value = 0;

        }

    }
}
