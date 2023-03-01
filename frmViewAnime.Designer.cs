
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAnimeTitle
            // 
            this.lblAnimeTitle.AutoSize = true;
            this.lblAnimeTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblAnimeTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAnimeTitle.ForeColor = System.Drawing.Color.White;
            this.lblAnimeTitle.Location = new System.Drawing.Point(8, 22);
            this.lblAnimeTitle.Name = "lblAnimeTitle";
            this.lblAnimeTitle.Size = new System.Drawing.Size(75, 37);
            this.lblAnimeTitle.TabIndex = 0;
            this.lblAnimeTitle.Text = "Title";
            // 
            // lblSeason
            // 
            this.lblSeason.AutoSize = true;
            this.lblSeason.BackColor = System.Drawing.Color.Transparent;
            this.lblSeason.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeason.ForeColor = System.Drawing.Color.White;
            this.lblSeason.Location = new System.Drawing.Point(11, 70);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(41, 25);
            this.lblSeason.TabIndex = 2;
            this.lblSeason.Text = "Fall";
            this.lblSeason.Click += new System.EventHandler(this.lblSeason_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.Transparent;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYear.ForeColor = System.Drawing.Color.White;
            this.lblYear.Location = new System.Drawing.Point(11, 108);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(56, 25);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "2020";
            this.lblYear.Click += new System.EventHandler(this.lblYear_Click);
            // 
            // lblEpisodes
            // 
            this.lblEpisodes.AutoSize = true;
            this.lblEpisodes.BackColor = System.Drawing.Color.Transparent;
            this.lblEpisodes.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEpisodes.ForeColor = System.Drawing.Color.White;
            this.lblEpisodes.Location = new System.Drawing.Point(287, 147);
            this.lblEpisodes.Name = "lblEpisodes";
            this.lblEpisodes.Size = new System.Drawing.Size(34, 25);
            this.lblEpisodes.TabIndex = 4;
            this.lblEpisodes.Text = "99";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblStatus.Location = new System.Drawing.Point(112, 180);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(96, 25);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Watching";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.BackColor = System.Drawing.Color.Transparent;
            this.lblRating.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRating.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lblRating.Location = new System.Drawing.Point(160, 217);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(73, 25);
            this.lblRating.TabIndex = 6;
            this.lblRating.Text = "Light 7";
            // 
            // lblEpisodeOn
            // 
            this.lblEpisodeOn.AutoSize = true;
            this.lblEpisodeOn.BackColor = System.Drawing.Color.Transparent;
            this.lblEpisodeOn.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblEpisodeOn.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblEpisodeOn.Location = new System.Drawing.Point(221, 146);
            this.lblEpisodeOn.Name = "lblEpisodeOn";
            this.lblEpisodeOn.Size = new System.Drawing.Size(34, 25);
            this.lblEpisodeOn.TabIndex = 9;
            this.lblEpisodeOn.Text = "99";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(797, 364);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 35);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnIncrement
            // 
            this.btnIncrement.BackColor = System.Drawing.Color.ForestGreen;
            this.btnIncrement.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIncrement.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIncrement.ForeColor = System.Drawing.Color.White;
            this.btnIncrement.Location = new System.Drawing.Point(610, 364);
            this.btnIncrement.Name = "btnIncrement";
            this.btnIncrement.Size = new System.Drawing.Size(181, 35);
            this.btnIncrement.TabIndex = 17;
            this.btnIncrement.Text = "Increment Episode";
            this.btnIncrement.UseVisualStyleBackColor = false;
            this.btnIncrement.Click += new System.EventHandler(this.btnIncrement_Click);
            // 
            // txtReview
            // 
            this.txtReview.Location = new System.Drawing.Point(10, 294);
            this.txtReview.Multiline = true;
            this.txtReview.Name = "txtReview";
            this.txtReview.Size = new System.Drawing.Size(276, 98);
            this.txtReview.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Last episode watched:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 30;
            this.label2.Text = "Currently";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "You gave this a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(261, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(9, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Review";
            // 
            // frmViewAnime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(93)))), ((int)(((byte)(108)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}