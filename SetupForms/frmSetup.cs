using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeWinForm.SetupForms
{
    public partial class frmSetup : Form
    {
        public frmSetup()
        {
            InitializeComponent();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog setupColorDialog = new ColorDialog();
            setupColorDialog.AllowFullOpen = false;
            setupColorDialog.Color = txtColor.BackColor;
            //test
            if(setupColorDialog.ShowDialog() == DialogResult.OK)
            {
                txtColor.BackColor = setupColorDialog.Color;
            }
        }

        private void txtTextColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTextColor_Click(object sender, EventArgs e)
        {
            ColorDialog setupColorDialog2 = new ColorDialog();
            setupColorDialog2.AllowFullOpen = false;
            setupColorDialog2.Color = txtTextColor.BackColor;

            if(setupColorDialog2.ShowDialog() == DialogResult.OK)
            {
                txtTextColor.BackColor = setupColorDialog2.Color;
            }

        }

        private void btnFinished_Click(object sender, EventArgs e)
        {
            frmHome formHome = new frmHome();
            this.Hide();
            formHome.Show();
        }
    }
}
