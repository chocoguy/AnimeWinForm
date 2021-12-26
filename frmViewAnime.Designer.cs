
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
            this.lblAnimeTitle = new System.Windows.Forms.Label();
            this.lblShortTitle = new System.Windows.Forms.Label();
            this.lblSeason = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblEpisodes = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.lblStartWatch = new System.Windows.Forms.Label();
            this.lblStopWatch = new System.Windows.Forms.Label();
            this.lblEpisodeOn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnIncrement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAnimeTitle
            // 
            this.lblAnimeTitle.AutoSize = true;
            this.lblAnimeTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAnimeTitle.ForeColor = System.Drawing.Color.Black;
            this.lblAnimeTitle.Location = new System.Drawing.Point(24, 24);
            this.lblAnimeTitle.Name = "lblAnimeTitle";
            this.lblAnimeTitle.Size = new System.Drawing.Size(54, 30);
            this.lblAnimeTitle.TabIndex = 0;
            this.lblAnimeTitle.Text = "Title";
            // 
            // lblShortTitle
            // 
            this.lblShortTitle.AutoSize = true;
            this.lblShortTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShortTitle.Location = new System.Drawing.Point(24, 66);
            this.lblShortTitle.Name = "lblShortTitle";
            this.lblShortTitle.Size = new System.Drawing.Size(91, 21);
            this.lblShortTitle.TabIndex = 1;
            this.lblShortTitle.Text = "(Short Title)";
            // 
            // lblSeason
            // 
            this.lblSeason.AutoSize = true;
            this.lblSeason.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSeason.Location = new System.Drawing.Point(24, 100);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(33, 21);
            this.lblSeason.TabIndex = 2;
            this.lblSeason.Text = "Fall";
            this.lblSeason.Click += new System.EventHandler(this.lblSeason_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(92, 100);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(46, 21);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "2020";
            this.lblYear.Click += new System.EventHandler(this.lblYear_Click);
            // 
            // lblEpisodes
            // 
            this.lblEpisodes.AutoSize = true;
            this.lblEpisodes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEpisodes.Location = new System.Drawing.Point(24, 131);
            this.lblEpisodes.Name = "lblEpisodes";
            this.lblEpisodes.Size = new System.Drawing.Size(93, 21);
            this.lblEpisodes.TabIndex = 4;
            this.lblEpisodes.Text = "12 Episodes";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(713, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(75, 21);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Watching";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRating.Location = new System.Drawing.Point(713, 33);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(58, 21);
            this.lblRating.TabIndex = 6;
            this.lblRating.Text = "Light 7";
            // 
            // lblStartWatch
            // 
            this.lblStartWatch.AutoSize = true;
            this.lblStartWatch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStartWatch.Location = new System.Drawing.Point(114, 197);
            this.lblStartWatch.Name = "lblStartWatch";
            this.lblStartWatch.Size = new System.Drawing.Size(109, 21);
            this.lblStartWatch.TabIndex = 7;
            this.lblStartWatch.Text = "June 6th 2021";
            // 
            // lblStopWatch
            // 
            this.lblStopWatch.AutoSize = true;
            this.lblStopWatch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStopWatch.Location = new System.Drawing.Point(123, 230);
            this.lblStopWatch.Name = "lblStopWatch";
            this.lblStopWatch.Size = new System.Drawing.Size(104, 21);
            this.lblStopWatch.TabIndex = 8;
            this.lblStopWatch.Text = "July 7th 2021";
            // 
            // lblEpisodeOn
            // 
            this.lblEpisodeOn.AutoSize = true;
            this.lblEpisodeOn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEpisodeOn.Location = new System.Drawing.Point(188, 165);
            this.lblEpisodeOn.Name = "lblEpisodeOn";
            this.lblEpisodeOn.Size = new System.Drawing.Size(19, 21);
            this.lblEpisodeOn.TabIndex = 9;
            this.lblEpisodeOn.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(652, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(652, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Rating:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Currently on episode:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(24, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Started on:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(24, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 21);
            this.label5.TabIndex = 14;
            this.label5.Text = "Finished on:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(635, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(716, 415);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnIncrement
            // 
            this.btnIncrement.Location = new System.Drawing.Point(497, 415);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(132, 23);
            this.btnIncrement.TabIndex = 17;
            this.btnIncrement.Text = "Increment Episode";
            this.btnIncrement.UseVisualStyleBackColor = true;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
            // 
            // frmViewAnime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIncrement);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEpisodeOn);
            this.Controls.Add(this.lblStopWatch);
            this.Controls.Add(this.lblStartWatch);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblEpisodes);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblSeason);
            this.Controls.Add(this.lblShortTitle);
            this.Controls.Add(this.lblAnimeTitle);
            this.Name = "frmViewAnime";
            this.Text = "AnimeWinForm - Anime";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnimeTitle;
        private System.Windows.Forms.Label lblShortTitle;
        private System.Windows.Forms.Label lblSeason;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblEpisodes;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label lblStartWatch;
        private System.Windows.Forms.Label lblStopWatch;
        private System.Windows.Forms.Label lblEpisodeOn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnIncrement;
    }
}