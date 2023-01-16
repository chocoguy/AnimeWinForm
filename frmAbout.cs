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
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            frmHome frmHome;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            frmHome home = (frmHome)ActiveForm;
            home.viewAllAnime();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
