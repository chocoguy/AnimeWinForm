
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
            this.lblBorder = new System.Windows.Forms.Label();
            this.btnAddAnime = new System.Windows.Forms.Button();
            this.btnViewAnime = new System.Windows.Forms.Button();
            this.grdRecentWatch = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecentWatch)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBorder
            // 
            this.lblBorder.AutoSize = true;
            this.lblBorder.BackColor = System.Drawing.Color.Black;
            this.lblBorder.Location = new System.Drawing.Point(-4, 42);
            this.lblBorder.MinimumSize = new System.Drawing.Size(1040, 0);
            this.lblBorder.Name = "lblBorder";
            this.lblBorder.Size = new System.Drawing.Size(1040, 15);
            this.lblBorder.TabIndex = 1;
            this.lblBorder.Text = "label1";
            this.lblBorder.Click += new System.EventHandler(this.lblBorder_Click);
            // 
            // btnAddAnime
            // 
            this.btnAddAnime.Location = new System.Drawing.Point(12, 12);
            this.btnAddAnime.Name = "btnAddAnime";
            this.btnAddAnime.Size = new System.Drawing.Size(75, 23);
            this.btnAddAnime.TabIndex = 2;
            this.btnAddAnime.Text = "Add Anime";
            this.btnAddAnime.UseVisualStyleBackColor = true;
            this.btnAddAnime.Click += new System.EventHandler(this.btnAddAnime_Click);
            // 
            // btnViewAnime
            // 
            this.btnViewAnime.Location = new System.Drawing.Point(110, 12);
            this.btnViewAnime.Name = "btnViewAnime";
            this.btnViewAnime.Size = new System.Drawing.Size(88, 23);
            this.btnViewAnime.TabIndex = 3;
            this.btnViewAnime.Text = "View Anime";
            this.btnViewAnime.UseVisualStyleBackColor = true;
            this.btnViewAnime.Click += new System.EventHandler(this.btnViewAnime_Click);
            // 
            // grdRecentWatch
            // 
            this.grdRecentWatch.AllowUserToAddRows = false;
            this.grdRecentWatch.AllowUserToDeleteRows = false;
            this.grdRecentWatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRecentWatch.Location = new System.Drawing.Point(39, 105);
            this.grdRecentWatch.Name = "grdRecentWatch";
            this.grdRecentWatch.ReadOnly = true;
            this.grdRecentWatch.RowTemplate.Height = 25;
            this.grdRecentWatch.Size = new System.Drawing.Size(950, 426);
            this.grdRecentWatch.TabIndex = 4;
            this.grdRecentWatch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdRecentWatch_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Recently Watched";
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdRecentWatch);
            this.Controls.Add(this.btnViewAnime);
            this.Controls.Add(this.btnAddAnime);
            this.Controls.Add(this.lblBorder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1050, 600);
            this.MinimumSize = new System.Drawing.Size(1050, 600);
            this.Name = "frmHome";
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHome_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.grdRecentWatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBorder;
        private System.Windows.Forms.Button btnAddAnime;
        private System.Windows.Forms.Button btnViewAnime;
        private System.Windows.Forms.DataGridView grdRecentWatch;
        private System.Windows.Forms.Label label1;
    }
}