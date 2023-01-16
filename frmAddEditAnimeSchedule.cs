using AnimeWinForm.Data;
using AnimeWinForm.Data.AnimeTables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            Dictionary<string, Anime> aniList = new Dictionary<string, Anime>();
            Anime emptyAnime = new Anime();
            aniList.Add("", emptyAnime);
            foreach (Anime anime in _Anime)
            {
                aniList.Add(anime.Id, anime);
            }
            #region addstuff
            cmbAnimeMon.DataSource = aniList.Values.ToList();
            cmbAnimeMon.DisplayMember = "title";
            cmbAnimeMon.ValueMember = "id";
            cmbAnimeTue.DataSource = aniList.Values.ToList();
            cmbAnimeTue.DisplayMember = "title";
            cmbAnimeTue.ValueMember = "id";
            cmbAnimeWed.DataSource = aniList.Values.ToList();
            cmbAnimeWed.DisplayMember = "title";
            cmbAnimeWed.ValueMember = "id";
            cmbAnimeThu.DataSource = aniList.Values.ToList();
            cmbAnimeThu.DisplayMember = "title";
            cmbAnimeThu.ValueMember = "id";
            cmbAnimeFri.DataSource = aniList.Values.ToList();
            cmbAnimeFri.DisplayMember = "title";
            cmbAnimeFri.ValueMember = "id";
            cmbAnimeSat.DataSource = aniList.Values.ToList();
            cmbAnimeSat.DisplayMember = "title";
            cmbAnimeSat.ValueMember = "id";
            cmbAnimeSun.DataSource = aniList.Values.ToList();
            cmbAnimeSun.DisplayMember = "title";
            cmbAnimeSun.ValueMember = "id";
            #endregion
            InitForm();
        }

        private void InitForm()
        {
            if (_currentAnimeScheduleId != "-1")
            {
                _currentSchedule = _localStorageHandler.GetAnimeScheduleById(_currentAnimeScheduleId);
                _frmHome.Text = "AnimeWinForm - Edit" + _currentSchedule.Title;
                txtScheduleTitle.Text = _currentSchedule.Title;
                chkIsCurrent.Checked = _currentSchedule.IsCurrentSchedule;


                cmbAnimeMon.SelectedValue = _currentSchedule.MondayAnime;
                cmbAnimeTue.SelectedValue = _currentSchedule.TuesdayAnime;
                cmbAnimeWed.SelectedValue = _currentSchedule.WednesdayAnime;
                cmbAnimeThu.SelectedValue = _currentSchedule.ThursdayAnime;
                cmbAnimeFri.SelectedValue = _currentSchedule.FridayAnime;
                cmbAnimeSat.SelectedValue = _currentSchedule.SaturdayAnime;
                cmbAnimeSun.SelectedValue = _currentSchedule.SundayAnime;
            }
            else
            {
                _frmHome.Text = "AnimeWinForm - New Schedule";
                _currentSchedule = new();
                _currentSchedule.Id = "-1";
                _currentSchedule.IsCurrentSchedule = false;
                btnDeleteSchedule.Hide();

                cmbAnimeMon.SelectedValue = "";
                cmbAnimeTue.SelectedValue = "";
                cmbAnimeWed.SelectedValue = "";
                cmbAnimeThu.SelectedValue = "";
                cmbAnimeFri.SelectedValue = "";
                cmbAnimeSat.SelectedValue = "";
                cmbAnimeSun.SelectedValue = "";
            }
        }

        private void btnSaveSchedule_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtScheduleTitle.Text))
            {
                _frmHome.newMessage("Title required!", "fail");
                return;
            }

            _currentSchedule.Title = txtScheduleTitle.Text;
            _currentSchedule.IsCurrentSchedule= chkIsCurrent.Checked;
            _currentSchedule.MondayAnime = (string)cmbAnimeMon.SelectedValue;
            _currentSchedule.TuesdayAnime = (string)cmbAnimeTue.SelectedValue;
            _currentSchedule.WednesdayAnime = (string)cmbAnimeWed.SelectedValue;
            _currentSchedule.ThursdayAnime = (string)cmbAnimeThu.SelectedValue;
            _currentSchedule.FridayAnime = (string)cmbAnimeFri.SelectedValue;
            _currentSchedule.SaturdayAnime = (string)cmbAnimeSat.SelectedValue;
            _currentSchedule.SundayAnime = (string)cmbAnimeSun.SelectedValue;

            if (_currentAnimeScheduleId != "-1")
            {
                bool isUpdateSuccess = _localStorageHandler.UpdateAnimeSchedule(_currentSchedule);
                if(isUpdateSuccess)
                {
                    _frmHome.newMessage("Schedule Updated!", "success");
                    InitForm();
                }
                else
                {
                    _frmHome.newMessage("Error updating!", "fail");
                }
            }
            else
            {
                _localStorageHandler.SaveNewAnimeSchedule(_currentSchedule);
                _frmHome.newMessage("Schedule Added!", "success");
                _frmHome.viewAnimeSchedules();
            }
        }

        private void btnDeleteSchedule_Click(object sender, EventArgs e)
        {
            if (_currentAnimeScheduleId != "-1")
            {
                _localStorageHandler.DeleteAnimeSchedule(_currentSchedule.Id);
                _frmHome.newMessage("Schedule Deleted!", "success");
                _frmHome.viewAnimeSchedules();
            }
        }
    }
}
