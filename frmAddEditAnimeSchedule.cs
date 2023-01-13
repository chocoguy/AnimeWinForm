using AnimeWinForm.Data;
using AnimeWinForm.Data.AnimeTables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeWinForm
{
    public partial class frmAddEditAnimeSchedule : Form
    {
        LocalStorageHandler _localStorageHandler;
        frmHome _frmHome;
        string _currentAnimeScheduleId = "";
        AnimeSchedule _currentSchedule;
        List<Anime> _Anime;

        public frmAddEditAnimeSchedule(string animeScheduleId)
        {
            InitializeComponent();
            _localStorageHandler = new();
            _frmHome = (frmHome)ActiveForm;
            _currentAnimeScheduleId = animeScheduleId;
            _Anime = _localStorageHandler.GetAllAnime();
            InitForm();
        }

        private void InitForm()
        {
            if (_currentAnimeScheduleId == "-1")
            {
                foreach (Anime anime in _Anime)
                {
                    #region addstuff
                    cmbAnimeMon.Items.Add(anime);
                    cmbAnimeMon.DisplayMember = "title";
                    cmbAnimeMon.ValueMember = "id";
                    cmbAnimeTue.Items.Add(anime);
                    cmbAnimeTue.DisplayMember = "title";
                    cmbAnimeTue.ValueMember = "id";
                    cmbAnimeWed.Items.Add(anime);
                    cmbAnimeWed.DisplayMember = "title";
                    cmbAnimeWed.ValueMember = "id";
                    cmbAnimeThu.Items.Add(anime);
                    cmbAnimeThu.DisplayMember = "title";
                    cmbAnimeThu.ValueMember = "id";
                    cmbAnimeFri.Items.Add(anime);
                    cmbAnimeFri.DisplayMember = "title";
                    cmbAnimeFri.ValueMember = "id";
                    cmbAnimeSat.Items.Add(anime);
                    cmbAnimeSat.DisplayMember = "title";
                    cmbAnimeSat.ValueMember = "id";
                    cmbAnimeSun.Items.Add(anime);
                    cmbAnimeSun.DisplayMember = "title";
                    cmbAnimeSun.ValueMember = "id";
                    #endregion
                }
            }
            else
            {

            }
        }

    }
}
