
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
            this.label4 = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnViewAnime = new System.Windows.Forms.Button();
            this.btnAddAnime = new System.Windows.Forms.Button();
            this.infoQuotelbl = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnViewSchedule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(694, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "AnimeWinForm BETA";
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(861, 13);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(24, 23);
            this.btnAbout.TabIndex = 32;
            this.btnAbout.Text = "?";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnViewAnime
            // 
            this.btnViewAnime.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewAnime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewAnime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewAnime.ForeColor = System.Drawing.Color.White;
            this.btnViewAnime.Location = new System.Drawing.Point(12, 12);
            this.btnViewAnime.Name = "btnViewAnime";
            this.btnViewAnime.Size = new System.Drawing.Size(83, 23);
            this.btnViewAnime.TabIndex = 33;
            this.btnViewAnime.Text = "View Anime";
            this.btnViewAnime.UseVisualStyleBackColor = false;
            this.btnViewAnime.Click += new System.EventHandler(this.btnViewAnime_Click);
            // 
            // btnAddAnime
            // 
            this.btnAddAnime.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnAddAnime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAnime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddAnime.ForeColor = System.Drawing.Color.White;
            this.btnAddAnime.Location = new System.Drawing.Point(101, 12);
            this.btnAddAnime.Name = "btnAddAnime";
            this.btnAddAnime.Size = new System.Drawing.Size(83, 23);
            this.btnAddAnime.TabIndex = 33;
            this.btnAddAnime.Text = "Add Anime";
            this.btnAddAnime.UseVisualStyleBackColor = false;
            this.btnAddAnime.Click += new System.EventHandler(this.btnAddAnime_Click);
            this.btnAddAnime.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAddAnime_Click);
            // 
            // infoQuotelbl
            // 
            this.infoQuotelbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.infoQuotelbl.AutoSize = true;
            this.infoQuotelbl.BackColor = System.Drawing.Color.Transparent;
            this.infoQuotelbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.infoQuotelbl.ForeColor = System.Drawing.Color.White;
            this.infoQuotelbl.Location = new System.Drawing.Point(362, 13);
            this.infoQuotelbl.Name = "infoQuotelbl";
            this.infoQuotelbl.Size = new System.Drawing.Size(0, 21);
            this.infoQuotelbl.TabIndex = 34;
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.Location = new System.Drawing.Point(-3, 41);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(903, 444);
            this.mainPanel.TabIndex = 35;
            // 
            // btnViewSchedule
            // 
            this.btnViewSchedule.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnViewSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewSchedule.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnViewSchedule.ForeColor = System.Drawing.Color.White;
            this.btnViewSchedule.Location = new System.Drawing.Point(190, 12);
            this.btnViewSchedule.Name = "btnViewSchedule";
            this.btnViewSchedule.Size = new System.Drawing.Size(83, 23);
            this.btnViewSchedule.TabIndex = 36;
            this.btnViewSchedule.Text = "Schedule";
            this.btnViewSchedule.UseVisualStyleBackColor = false;
            this.btnViewSchedule.Click += new System.EventHandler(this.btnViewSchedule_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(93)))), ((int)(((byte)(108)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(897, 497);
            this.Controls.Add(this.btnViewSchedule);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.infoQuotelbl);
            this.Controls.Add(this.btnAddAnime);
            this.Controls.Add(this.btnViewAnime);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnViewAnime;
        private System.Windows.Forms.Button btnAddAnime;
        private System.Windows.Forms.Label infoQuotelbl;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnViewSchedule;
    }
}