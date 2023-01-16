using AnimeWinForm.Data;
using AnimeWinForm.Data.AnimeTables;
using System;
using System.CodeDom;
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
    public partial class frmViewAnimeSchedule : Form
    {

        LocalStorageHandler _localStorageHandler;
        frmHome _frmHome;
        List<AnimeSchedule> _animeSchedules;
        AnimeSchedule _currentSchedule;


        public frmViewAnimeSchedule()
        {
            InitializeComponent();
            _localStorageHandler = new();
            _frmHome = (frmHome)ActiveForm;
            _frmHome.Text = "AnimeWinForm - Schedules";

            InitForm();

        }

        private void InitForm()
        {
            _animeSchedules = _localStorageHandler.GetAnimeSchedules();

            foreach (var schedule in _animeSchedules)
            {
                cmbAnimeSchedules.Items.Add(schedule);
                cmbAnimeSchedules.DisplayMember = "title";
                cmbAnimeSchedules.ValueMember = "id";
                if (schedule.IsCurrentSchedule)
                {
                    _currentSchedule = schedule;
                    cmbAnimeSchedules.SelectedItem = schedule;
                }
            }

            if(_animeSchedules.Count < 1)
            {
                btnEditSchedule.Hide();
            }

        }

        private void cmbAnimeSchedules_DisplayMemberChanged(object sender, EventArgs e)
        {

        }

        private void cmbAnimeSchedules_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cmbAnimeSchedules.SelectedIndex != -1)
            {
                listViewAnimeSchedule.Items.Clear();
                var res = cmbAnimeSchedules.Items[cmbAnimeSchedules.SelectedIndex];
                AnimeSchedule resAnime = (AnimeSchedule)res;
                listViewAnimeSchedule.Items.Add(_localStorageHandler.GetAnimeById(resAnime.MondayAnime).Title).Group = listViewAnimeSchedule.Groups[0];
                listViewAnimeSchedule.Items.Add(_localStorageHandler.GetAnimeById(resAnime.TuesdayAnime).Title).Group = listViewAnimeSchedule.Groups[1];
                listViewAnimeSchedule.Items.Add(_localStorageHandler.GetAnimeById(resAnime.WednesdayAnime).Title).Group = listViewAnimeSchedule.Groups[2];
                listViewAnimeSchedule.Items.Add(_localStorageHandler.GetAnimeById(resAnime.ThursdayAnime).Title).Group = listViewAnimeSchedule.Groups[3];
                listViewAnimeSchedule.Items.Add(_localStorageHandler.GetAnimeById(resAnime.FridayAnime).Title).Group = listViewAnimeSchedule.Groups[4];
                listViewAnimeSchedule.Items.Add(_localStorageHandler.GetAnimeById(resAnime.SaturdayAnime).Title).Group = listViewAnimeSchedule.Groups[5];
                listViewAnimeSchedule.Items.Add(_localStorageHandler.GetAnimeById(resAnime.SundayAnime).Title).Group = listViewAnimeSchedule.Groups[6];
            }
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            _frmHome.AddEditAnimeSchedule("-1");
        }

        private void btnEditSchedule_Click(object sender, EventArgs e)
        {
            var res = cmbAnimeSchedules.Items[cmbAnimeSchedules.SelectedIndex];
            AnimeSchedule resAnime = (AnimeSchedule)res;
            _frmHome.AddEditAnimeSchedule(resAnime.Id);
        }
    }
}
