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


namespace AnimeWinForm.SetupForms
{
    public partial class frmWelcome : Form
    {
        LocalStorageHandler localStorageHandler = new LocalStorageHandler();

        public frmWelcome()
        {
            InitializeComponent();
            bool checkSetup = localStorageHandler.checkAppSetup();

            if (checkSetup == true)
            {
                frmHome home = new frmHome();
                this.Close();
                home.Show();
            }
            else
            {
                localStorageHandler.GetAllAnime();
                localStorageHandler.initLocalSettings();
                frmHome home = new frmHome();
                this.Close();
                home.Show();
            }
        }


    }
}
