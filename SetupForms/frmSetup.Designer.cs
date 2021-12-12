
namespace AnimeWinForm.SetupForms
{
    partial class frmSetup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetup));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.radLocal = new System.Windows.Forms.RadioButton();
            this.radSqlServer = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnColor = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTextColor = new System.Windows.Forms.Button();
            this.txtTextColor = new System.Windows.Forms.TextBox();
            this.btnFinished = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(89, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Storage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(89, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(764, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter a connection string (SQL Server) to use your own database or check the \"Loc" +
    "al\" option for local storage.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(89, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Connection String:";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(262, 80);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(611, 23);
            this.txtConnectionString.TabIndex = 3;
            // 
            // radLocal
            // 
            this.radLocal.AutoSize = true;
            this.radLocal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radLocal.Location = new System.Drawing.Point(94, 104);
            this.radLocal.Name = "radLocal";
            this.radLocal.Size = new System.Drawing.Size(74, 29);
            this.radLocal.TabIndex = 4;
            this.radLocal.TabStop = true;
            this.radLocal.Text = "Local";
            this.radLocal.UseVisualStyleBackColor = true;
            // 
            // radSqlServer
            // 
            this.radSqlServer.AutoSize = true;
            this.radSqlServer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radSqlServer.Location = new System.Drawing.Point(240, 104);
            this.radSqlServer.Name = "radSqlServer";
            this.radSqlServer.Size = new System.Drawing.Size(121, 29);
            this.radSqlServer.TabIndex = 5;
            this.radSqlServer.TabStop = true;
            this.radSqlServer.Text = "SQL Server";
            this.radSqlServer.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(89, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 40);
            this.label4.TabIndex = 6;
            this.label4.Text = "2. Theme";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(89, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Pick a background color:\r\n";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(271, 226);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(24, 23);
            this.btnColor.TabIndex = 8;
            this.btnColor.Text = "...";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(301, 226);
            this.txtColor.Name = "txtColor";
            this.txtColor.ReadOnly = true;
            this.txtColor.Size = new System.Drawing.Size(36, 23);
            this.txtColor.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(89, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Pick a text color:\r\n";
            // 
            // btnTextColor
            // 
            this.btnTextColor.Location = new System.Drawing.Point(216, 193);
            this.btnTextColor.Name = "btnTextColor";
            this.btnTextColor.Size = new System.Drawing.Size(25, 23);
            this.btnTextColor.TabIndex = 11;
            this.btnTextColor.Text = "...";
            this.btnTextColor.UseVisualStyleBackColor = true;
            this.btnTextColor.Click += new System.EventHandler(this.btnTextColor_Click);
            // 
            // txtTextColor
            // 
            this.txtTextColor.Location = new System.Drawing.Point(247, 192);
            this.txtTextColor.Name = "txtTextColor";
            this.txtTextColor.Size = new System.Drawing.Size(36, 23);
            this.txtTextColor.TabIndex = 12;
            this.txtTextColor.TextChanged += new System.EventHandler(this.txtTextColor_TextChanged);
            // 
            // btnFinished
            // 
            this.btnFinished.BackColor = System.Drawing.Color.LightGreen;
            this.btnFinished.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFinished.Location = new System.Drawing.Point(94, 277);
            this.btnFinished.Name = "btnFinished";
            this.btnFinished.Size = new System.Drawing.Size(86, 38);
            this.btnFinished.TabIndex = 13;
            this.btnFinished.Text = "Done!";
            this.btnFinished.UseVisualStyleBackColor = false;
            this.btnFinished.Click += new System.EventHandler(this.btnFinished_Click);
            // 
            // frmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1034, 561);
            this.Controls.Add(this.btnFinished);
            this.Controls.Add(this.txtTextColor);
            this.Controls.Add(this.btnTextColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radSqlServer);
            this.Controls.Add(this.radLocal);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1050, 600);
            this.MinimumSize = new System.Drawing.Size(1050, 600);
            this.Name = "frmSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnimeWinForm - Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.RadioButton radLocal;
        private System.Windows.Forms.RadioButton radSqlServer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnTextColor;
        private System.Windows.Forms.TextBox txtTextColor;
        private System.Windows.Forms.Button btnFinished;
    }
}