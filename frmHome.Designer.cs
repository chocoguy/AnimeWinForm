
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
            this.grdAnime = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdAnime)).BeginInit();
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
            // grdAnime
            // 
            this.grdAnime.AllowUserToAddRows = false;
            this.grdAnime.AllowUserToDeleteRows = false;
            this.grdAnime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAnime.Location = new System.Drawing.Point(12, 85);
            this.grdAnime.Name = "grdAnime";
            this.grdAnime.ReadOnly = true;
            this.grdAnime.RowTemplate.Height = 25;
            this.grdAnime.Size = new System.Drawing.Size(660, 244);
            this.grdAnime.TabIndex = 3;
            this.grdAnime.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAnime_CellClick);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.grdAnime);
            this.Controls.Add(this.btnAddAnime);
            this.Controls.Add(this.lblBorder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(700, 400);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "frmHome";
            this.Text = "Home";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmHome_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.grdAnime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBorder;
        private System.Windows.Forms.Button btnAddAnime;
        private System.Windows.Forms.DataGridView grdAnime;
    }
}