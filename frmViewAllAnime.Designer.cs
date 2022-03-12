
namespace AnimeWinForm
{
    partial class frmViewAllAnime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewAllAnime));
            this.grdAnime = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdAnime)).BeginInit();
            this.SuspendLayout();
            // 
            // grdAnime
            // 
            this.grdAnime.AllowUserToAddRows = false;
            this.grdAnime.AllowUserToDeleteRows = false;
            this.grdAnime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAnime.Location = new System.Drawing.Point(101, 56);
            this.grdAnime.Name = "grdAnime";
            this.grdAnime.ReadOnly = true;
            this.grdAnime.RowTemplate.Height = 25;
            this.grdAnime.Size = new System.Drawing.Size(703, 306);
            this.grdAnime.TabIndex = 1;
            this.grdAnime.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAnime_CellClick);
            // 
            // frmViewAllAnime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.grdAnime);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 450);
            this.MinimumSize = new System.Drawing.Size(900, 450);
            this.Name = "frmViewAllAnime";
            this.Text = "AnimeWinForm - Anime";
            ((System.ComponentModel.ISupportInitialize)(this.grdAnime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView grdAnime;
    }
}