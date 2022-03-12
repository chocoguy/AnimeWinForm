
namespace AnimeWinForm
{
    partial class frmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.mainPanel = new MetroFramework.Controls.MetroPanel();
            this.btnAddAnime = new MetroFramework.Controls.MetroButton();
            this.lblTitleVer = new MetroFramework.Controls.MetroLabel();
            this.btnAbout = new MetroFramework.Controls.MetroButton();
            this.txtInfoQuote = new System.Windows.Forms.TextBox();
            this.btnViewAnime = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.HorizontalScrollbarBarColor = true;
            this.mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.mainPanel.HorizontalScrollbarSize = 10;
            this.mainPanel.Location = new System.Drawing.Point(-1, 50);
            this.mainPanel.MaximumSize = new System.Drawing.Size(900, 451);
            this.mainPanel.MinimumSize = new System.Drawing.Size(900, 450);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(900, 450);
            this.mainPanel.TabIndex = 4;
            this.mainPanel.VerticalScrollbarBarColor = true;
            this.mainPanel.VerticalScrollbarHighlightOnWheel = false;
            this.mainPanel.VerticalScrollbarSize = 10;
            // 
            // btnAddAnime
            // 
            this.btnAddAnime.Location = new System.Drawing.Point(93, 12);
            this.btnAddAnime.Name = "btnAddAnime";
            this.btnAddAnime.Size = new System.Drawing.Size(75, 23);
            this.btnAddAnime.TabIndex = 6;
            this.btnAddAnime.Text = "Add Anime";
            this.btnAddAnime.UseSelectable = true;
            this.btnAddAnime.Click += new System.EventHandler(this.btnAddAnime_Click);
            // 
            // lblTitleVer
            // 
            this.lblTitleVer.AutoSize = true;
            this.lblTitleVer.Location = new System.Drawing.Point(711, 16);
            this.lblTitleVer.Name = "lblTitleVer";
            this.lblTitleVer.Size = new System.Drawing.Size(147, 19);
            this.lblTitleVer.TabIndex = 7;
            this.lblTitleVer.Text = "AnimeWinForm ALPHA";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(861, 16);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(24, 19);
            this.btnAbout.TabIndex = 8;
            this.btnAbout.Text = "?";
            this.btnAbout.UseSelectable = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // txtInfoQuote
            // 
            this.txtInfoQuote.BackColor = System.Drawing.SystemColors.Control;
            this.txtInfoQuote.ForeColor = System.Drawing.Color.Black;
            this.txtInfoQuote.Location = new System.Drawing.Point(301, 12);
            this.txtInfoQuote.Name = "txtInfoQuote";
            this.txtInfoQuote.ReadOnly = true;
            this.txtInfoQuote.Size = new System.Drawing.Size(299, 23);
            this.txtInfoQuote.TabIndex = 9;
            this.txtInfoQuote.Text = "Info/Quote Center";
            this.txtInfoQuote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnViewAnime
            // 
            this.btnViewAnime.Location = new System.Drawing.Point(12, 12);
            this.btnViewAnime.Name = "btnViewAnime";
            this.btnViewAnime.Size = new System.Drawing.Size(75, 23);
            this.btnViewAnime.TabIndex = 2;
            this.btnViewAnime.Text = "View Anime";
            this.btnViewAnime.UseSelectable = true;
            this.btnViewAnime.Click += new System.EventHandler(this.btnViewAnime_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(897, 497);
            this.Controls.Add(this.btnViewAnime);
            this.Controls.Add(this.txtInfoQuote);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.lblTitleVer);
            this.Controls.Add(this.btnAddAnime);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(913, 536);
            this.MinimumSize = new System.Drawing.Size(913, 536);
            this.Name = "frmHome";
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHome_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroPanel mainPanel;
        private MetroFramework.Controls.MetroButton btnAddAnime;
        private MetroFramework.Controls.MetroLabel lblTitleVer;
        private MetroFramework.Controls.MetroButton btnAbout;
        private System.Windows.Forms.TextBox txtInfoQuote;
        private MetroFramework.Controls.MetroButton btnViewAnime;
    }
}