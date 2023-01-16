namespace AnimeWinForm
{
    partial class frmAddEditAnimeSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEditAnimeSchedule));
            this.btnSaveSchedule = new System.Windows.Forms.Button();
            this.btnDeleteSchedule = new System.Windows.Forms.Button();
            this.cmbAnimeMon = new System.Windows.Forms.ComboBox();
            this.lblSeason = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAnimeTue = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAnimeWed = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbAnimeThu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbAnimeFri = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAnimeSat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbAnimeSun = new System.Windows.Forms.ComboBox();
            this.txtScheduleTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkIsCurrent = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSaveSchedule
            // 
            this.btnSaveSchedule.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSaveSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveSchedule.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveSchedule.ForeColor = System.Drawing.Color.White;
            this.btnSaveSchedule.Location = new System.Drawing.Point(731, 364);
            this.btnSaveSchedule.Name = "btnSaveSchedule";
            this.btnSaveSchedule.Size = new System.Drawing.Size(141, 35);
            this.btnSaveSchedule.TabIndex = 18;
            this.btnSaveSchedule.Text = "Save Schedule";
            this.btnSaveSchedule.UseVisualStyleBackColor = false;
            this.btnSaveSchedule.Click += new System.EventHandler(this.btnSaveSchedule_Click);
            // 
            // btnDeleteSchedule
            // 
            this.btnDeleteSchedule.BackColor = System.Drawing.Color.Crimson;
            this.btnDeleteSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteSchedule.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteSchedule.ForeColor = System.Drawing.Color.White;
            this.btnDeleteSchedule.Location = new System.Drawing.Point(565, 364);
            this.btnDeleteSchedule.Name = "btnDeleteSchedule";
            this.btnDeleteSchedule.Size = new System.Drawing.Size(160, 35);
            this.btnDeleteSchedule.TabIndex = 21;
            this.btnDeleteSchedule.Text = "Delete Schedule";
            this.btnDeleteSchedule.UseVisualStyleBackColor = false;
            this.btnDeleteSchedule.Click += new System.EventHandler(this.btnDeleteSchedule_Click);
            // 
            // cmbAnimeMon
            // 
            this.cmbAnimeMon.FormattingEnabled = true;
            this.cmbAnimeMon.Items.AddRange(new object[] {
            ""});
            this.cmbAnimeMon.Location = new System.Drawing.Point(153, 131);
            this.cmbAnimeMon.Name = "cmbAnimeMon";
            this.cmbAnimeMon.Size = new System.Drawing.Size(173, 23);
            this.cmbAnimeMon.TabIndex = 22;
            // 
            // lblSeason
            // 
            this.lblSeason.AutoSize = true;
            this.lblSeason.BackColor = System.Drawing.Color.Transparent;
            this.lblSeason.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSeason.ForeColor = System.Drawing.Color.White;
            this.lblSeason.Location = new System.Drawing.Point(332, 131);
            this.lblSeason.Name = "lblSeason";
            this.lblSeason.Size = new System.Drawing.Size(86, 25);
            this.lblSeason.TabIndex = 23;
            this.lblSeason.Text = "Monday";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(332, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "Tuesday";
            // 
            // cmbAnimeTue
            // 
            this.cmbAnimeTue.FormattingEnabled = true;
            this.cmbAnimeTue.Location = new System.Drawing.Point(153, 169);
            this.cmbAnimeTue.Name = "cmbAnimeTue";
            this.cmbAnimeTue.Size = new System.Drawing.Size(173, 23);
            this.cmbAnimeTue.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(333, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Wednesday";
            // 
            // cmbAnimeWed
            // 
            this.cmbAnimeWed.FormattingEnabled = true;
            this.cmbAnimeWed.Location = new System.Drawing.Point(153, 209);
            this.cmbAnimeWed.Name = "cmbAnimeWed";
            this.cmbAnimeWed.Size = new System.Drawing.Size(173, 23);
            this.cmbAnimeWed.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(332, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Thursday";
            // 
            // cmbAnimeThu
            // 
            this.cmbAnimeThu.FormattingEnabled = true;
            this.cmbAnimeThu.Location = new System.Drawing.Point(153, 253);
            this.cmbAnimeThu.Name = "cmbAnimeThu";
            this.cmbAnimeThu.Size = new System.Drawing.Size(173, 23);
            this.cmbAnimeThu.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(643, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Friday";
            // 
            // cmbAnimeFri
            // 
            this.cmbAnimeFri.FormattingEnabled = true;
            this.cmbAnimeFri.Location = new System.Drawing.Point(464, 136);
            this.cmbAnimeFri.Name = "cmbAnimeFri";
            this.cmbAnimeFri.Size = new System.Drawing.Size(173, 23);
            this.cmbAnimeFri.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(643, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Saturday";
            // 
            // cmbAnimeSat
            // 
            this.cmbAnimeSat.FormattingEnabled = true;
            this.cmbAnimeSat.Location = new System.Drawing.Point(464, 174);
            this.cmbAnimeSat.Name = "cmbAnimeSat";
            this.cmbAnimeSat.Size = new System.Drawing.Size(173, 23);
            this.cmbAnimeSat.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(643, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Sunday";
            // 
            // cmbAnimeSun
            // 
            this.cmbAnimeSun.FormattingEnabled = true;
            this.cmbAnimeSun.Location = new System.Drawing.Point(464, 214);
            this.cmbAnimeSun.Name = "cmbAnimeSun";
            this.cmbAnimeSun.Size = new System.Drawing.Size(173, 23);
            this.cmbAnimeSun.TabIndex = 34;
            // 
            // txtScheduleTitle
            // 
            this.txtScheduleTitle.Location = new System.Drawing.Point(177, 57);
            this.txtScheduleTitle.Name = "txtScheduleTitle";
            this.txtScheduleTitle.Size = new System.Drawing.Size(225, 23);
            this.txtScheduleTitle.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(408, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 25);
            this.label7.TabIndex = 37;
            this.label7.Text = "Title";
            // 
            // chkIsCurrent
            // 
            this.chkIsCurrent.AutoSize = true;
            this.chkIsCurrent.BackColor = System.Drawing.Color.Transparent;
            this.chkIsCurrent.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkIsCurrent.ForeColor = System.Drawing.Color.White;
            this.chkIsCurrent.Location = new System.Drawing.Point(508, 57);
            this.chkIsCurrent.Name = "chkIsCurrent";
            this.chkIsCurrent.Size = new System.Drawing.Size(119, 29);
            this.chkIsCurrent.TabIndex = 38;
            this.chkIsCurrent.Text = "Is Current";
            this.chkIsCurrent.UseVisualStyleBackColor = false;
            // 
            // frmAddEditAnimeSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.chkIsCurrent);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtScheduleTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbAnimeSun);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAnimeSat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbAnimeFri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbAnimeThu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAnimeWed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAnimeTue);
            this.Controls.Add(this.lblSeason);
            this.Controls.Add(this.cmbAnimeMon);
            this.Controls.Add(this.btnDeleteSchedule);
            this.Controls.Add(this.btnSaveSchedule);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 450);
            this.MinimumSize = new System.Drawing.Size(900, 450);
            this.Name = "frmAddEditAnimeSchedule";
            this.Text = "AnimeWinForm - AddEdit Schedule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveSchedule;
        private System.Windows.Forms.Button btnDeleteSchedule;
        private System.Windows.Forms.ComboBox cmbAnimeMon;
        private System.Windows.Forms.Label lblSeason;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAnimeTue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAnimeWed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbAnimeThu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbAnimeFri;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAnimeSat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbAnimeSun;
        private System.Windows.Forms.TextBox txtScheduleTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkIsCurrent;
    }
}