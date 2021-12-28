
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
            this.btnBack = new System.Windows.Forms.Button();
            this.grdAnime = new System.Windows.Forms.DataGridView();
            this.btnAddAnime = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdAnime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(640, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // grdAnime
            // 
            this.grdAnime.AllowUserToAddRows = false;
            this.grdAnime.AllowUserToDeleteRows = false;
            this.grdAnime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAnime.Location = new System.Drawing.Point(60, 56);
            this.grdAnime.Name = "grdAnime";
            this.grdAnime.ReadOnly = true;
            this.grdAnime.RowTemplate.Height = 25;
            this.grdAnime.Size = new System.Drawing.Size(703, 306);
            this.grdAnime.TabIndex = 1;
            this.grdAnime.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAnime_CellClick);
            // 
            // btnAddAnime
            // 
            this.btnAddAnime.Location = new System.Drawing.Point(721, 415);
            this.btnAddAnime.Name = "btnAddAnime";
            this.btnAddAnime.Size = new System.Drawing.Size(75, 23);
            this.btnAddAnime.TabIndex = 2;
            this.btnAddAnime.Text = "Add Anime";
            this.btnAddAnime.UseVisualStyleBackColor = true;
            this.btnAddAnime.Click += new System.EventHandler(this.btnAddAnime_Click);
            // 
            // frmViewAllAnime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddAnime);
            this.Controls.Add(this.grdAnime);
            this.Controls.Add(this.btnBack);
            this.Name = "frmViewAllAnime";
            this.Text = "AnimeWinForm - Anime";
            ((System.ComponentModel.ISupportInitialize)(this.grdAnime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView grdAnime;
        private System.Windows.Forms.Button btnAddAnime;
    }
}