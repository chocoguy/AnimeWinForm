
namespace AnimeWinForm
{
    partial class frmViewAnime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewAnime));
            this.lblAnimeTitle = new System.Windows.Forms.Label();
            this.lblSeason = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblEpisodes = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblEpisodeOn = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnIncrement = new System.Windows.Forms.Button();
            this.txtReview = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblAnimeTitle
            // 
            this.lblAnimeTitle.AutoSize = true;
            this.lblAnimeTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnimeTitle.ForeColor = System.Drawing.Color.Black;
            this.lblAnimeTitle.Location = new System.Drawing.Point(99, 35);
            this.lblAnimeTitle.Name = "lblAnimeTitle";
            this.lblAnimeTitle.Size = new System.Drawing.Size(48, 25);
            this.lblAnimeTitle.TabIndex = 0;
            this.lblAnimeTitle.Text = "Title";
            // 
            // lblSeason
            // 
            this.lblSeason.AutoSize = true;
            this.lblSeason.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSeason.Location = new System.Drawing.Point(99, 109);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(40, 25);
            this.lblSeason.TabIndex = 2;
            this.lblSeason.Text = "Fall";
            this.lblSeason.Click += new System.EventHandler(this.lblSeason_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(99, 73);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(52, 25);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "2020";
            this.lblYear.Click += new System.EventHandler(this.lblYear_Click);
            // 
            // lblEpisodes
            // 
            this.lblEpisodes.AutoSize = true;
            this.lblEpisodes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEpisodes.Location = new System.Drawing.Point(99, 147);
            this.lblEpisodes.Name = "lblEpisodes";
            this.lblEpisodes.Size = new System.Drawing.Size(32, 25);
            this.lblEpisodes.TabIndex = 4;
            this.lblEpisodes.Text = "12";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblStatus.Location = new System.Drawing.Point(82, 219);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(92, 25);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Watching";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRating.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblRating.Location = new System.Drawing.Point(82, 252);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(69, 25);
            this.lblRating.TabIndex = 6;
            this.lblRating.Text = "Light 7";
            // 
            // lblEpisodeOn
            // 
            this.lblEpisodeOn.AutoSize = true;
            this.lblEpisodeOn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEpisodeOn.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblEpisodeOn.Location = new System.Drawing.Point(149, 184);
            this.lblEpisodeOn.Name = "lblEpisodeOn";
            this.lblEpisodeOn.Size = new System.Drawing.Size(22, 25);
            this.lblEpisodeOn.TabIndex = 9;
            this.lblEpisodeOn.Text = "3";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(797, 364);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 35);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnIncrement
            // 
            this.btnIncrement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIncrement.Location = new System.Drawing.Point(610, 364);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(181, 35);
            this.btnIncrement.TabIndex = 17;
            this.btnIncrement.Text = "Increment Episode";
            this.btnIncrement.UseVisualStyleBackColor = true;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
            // 
            // txtReview
            // 
            this.txtReview.Location = new System.Drawing.Point(83, 288);
            this.txtReview.Multiline = true;
            this.txtReview.Name = "txtReview";
            this.txtReview.Size = new System.Drawing.Size(276, 98);
            this.txtReview.TabIndex = 20;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(9, 35);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel1.TabIndex = 21;
            this.metroLabel1.Text = "Title:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(9, 109);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 25);
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "Season:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(9, 73);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(49, 25);
            this.metroLabel3.TabIndex = 23;
            this.metroLabel3.Text = "Year:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(9, 147);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(82, 25);
            this.metroLabel4.TabIndex = 24;
            this.metroLabel4.Text = "Episodes:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(9, 187);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(134, 19);
            this.metroLabel5.TabIndex = 25;
            this.metroLabel5.Text = "Currently on Episode:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(9, 219);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(61, 25);
            this.metroLabel6.TabIndex = 26;
            this.metroLabel6.Text = "Status:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.Location = new System.Drawing.Point(9, 252);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(64, 25);
            this.metroLabel7.TabIndex = 27;
            this.metroLabel7.Text = "Rating:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel8.Location = new System.Drawing.Point(9, 288);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(68, 25);
            this.metroLabel8.TabIndex = 28;
            this.metroLabel8.Text = "Review:";
            // 
            // frmViewAnime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtReview);
            this.Controls.Add(this.btnIncrement);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lblEpisodeOn);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblEpisodes);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblSeason);
            this.Controls.Add(this.lblAnimeTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 450);
            this.MinimumSize = new System.Drawing.Size(900, 450);
            this.Name = "frmViewAnime";
            this.Text = "AnimeWinForm - Anime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnimeTitle;
        private System.Windows.Forms.Label lblSeason;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblEpisodes;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblEpisodeOn;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnIncrement;
        private System.Windows.Forms.TextBox txtReview;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
    }
}