namespace AnimeWinForm
{
    partial class frmViewAnimeSchedule
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Monday", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Tuesday", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Wednesday", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Thursday", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Friday", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("Saturday", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("Sunday", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewAnimeSchedule));
            this.listViewAnimeSchedule = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.btnAddSchedule = new System.Windows.Forms.Button();
            this.cmbAnimeSchedules = new System.Windows.Forms.ComboBox();
            this.lblSeason = new System.Windows.Forms.Label();
            this.btnEditSchedule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewAnimeSchedule
            // 
            this.listViewAnimeSchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            listViewGroup1.Header = "Monday";
            listViewGroup1.Name = "listViewGroup1";
            listViewGroup2.Header = "Tuesday";
            listViewGroup2.Name = "listViewGroup2";
            listViewGroup3.Header = "Wednesday";
            listViewGroup3.Name = "listViewGroup3";
            listViewGroup4.Header = "Thursday";
            listViewGroup4.Name = "listViewGroup4";
            listViewGroup5.Header = "Friday";
            listViewGroup5.Name = "listViewGroup5";
            listViewGroup6.Header = "Saturday";
            listViewGroup6.Name = "listViewGroup6";
            listViewGroup7.Header = "Sunday";
            listViewGroup7.Name = "listViewGroup7";
            this.listViewAnimeSchedule.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6,
            listViewGroup7});
            this.listViewAnimeSchedule.Location = new System.Drawing.Point(12, 25);
            this.listViewAnimeSchedule.Name = "listViewAnimeSchedule";
            this.listViewAnimeSchedule.Size = new System.Drawing.Size(594, 311);
            this.listViewAnimeSchedule.TabIndex = 0;
            this.listViewAnimeSchedule.UseCompatibleStateImageBehavior = false;
            this.listViewAnimeSchedule.View = System.Windows.Forms.View.SmallIcon;
            // 
            // btnAddSchedule
            // 
            this.btnAddSchedule.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSchedule.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddSchedule.ForeColor = System.Drawing.Color.White;
            this.btnAddSchedule.Location = new System.Drawing.Point(731, 364);
            this.btnAddSchedule.Name = "btnAddSchedule";
            this.btnAddSchedule.Size = new System.Drawing.Size(141, 35);
            this.btnAddSchedule.TabIndex = 17;
            this.btnAddSchedule.Text = "Add Schedule";
            this.btnAddSchedule.UseVisualStyleBackColor = false;
            this.btnAddSchedule.Click += new System.EventHandler(this.btnAddSchedule_Click);
            // 
            // cmbAnimeSchedules
            // 
            this.cmbAnimeSchedules.FormattingEnabled = true;
            this.cmbAnimeSchedules.Location = new System.Drawing.Point(12, 364);
            this.cmbAnimeSchedules.Name = "cmbAnimeSchedules";
            this.cmbAnimeSchedules.Size = new System.Drawing.Size(121, 23);
            this.cmbAnimeSchedules.TabIndex = 18;
            this.cmbAnimeSchedules.DisplayMemberChanged += new System.EventHandler(this.cmbAnimeSchedules_DisplayMemberChanged);
            this.cmbAnimeSchedules.SelectedValueChanged += new System.EventHandler(this.cmbAnimeSchedules_SelectedValueChanged);
            // 
            // lblSeason
            // 
            this.lblSeason.AutoSize = true;
            this.lblSeason.BackColor = System.Drawing.Color.Transparent;
            this.lblSeason.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeason.ForeColor = System.Drawing.Color.White;
            this.lblSeason.Location = new System.Drawing.Point(149, 362);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(171, 25);
            this.lblSeason.TabIndex = 19;
            this.lblSeason.Text = "Selected Schedule";
            // 
            // btnEditSchedule
            // 
            this.btnEditSchedule.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEditSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditSchedule.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditSchedule.ForeColor = System.Drawing.Color.White;
            this.btnEditSchedule.Location = new System.Drawing.Point(584, 364);
            this.btnEditSchedule.Name = "btnEditSchedule";
            this.btnEditSchedule.Size = new System.Drawing.Size(141, 35);
            this.btnEditSchedule.TabIndex = 20;
            this.btnEditSchedule.Text = "Edit Schedule";
            this.btnEditSchedule.UseVisualStyleBackColor = false;
            this.btnEditSchedule.Click += new System.EventHandler(this.btnEditSchedule_Click);
            // 
            // frmViewAnimeSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.btnEditSchedule);
            this.Controls.Add(this.lblSeason);
            this.Controls.Add(this.cmbAnimeSchedules);
            this.Controls.Add(this.btnAddSchedule);
            this.Controls.Add(this.listViewAnimeSchedule);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 450);
            this.MinimumSize = new System.Drawing.Size(900, 450);
            this.Name = "frmViewAnimeSchedule";
            this.Text = "AnimeWinForm - Schedule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewAnimeSchedule;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnAddSchedule;
        private System.Windows.Forms.ComboBox cmbAnimeSchedules;
        private System.Windows.Forms.Label lblSeason;
        private System.Windows.Forms.Button btnEditSchedule;
    }
}