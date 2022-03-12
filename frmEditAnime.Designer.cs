
namespace AnimeWinForm
{
    partial class frmEditAnime
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditAnime));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.dsadsa = new System.Windows.Forms.Label();
            this.cmbSeason = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numEpisodes = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbRating = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.grdAnimeEpisodes = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReview = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numEpisodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAnimeEpisodes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(102, 94);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(208, 23);
            this.txtTitle.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(18, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Year:";
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "1895",
            "1896",
            "1897",
            "1898",
            "1899",
            "1900",
            "1901",
            "1902",
            "1903",
            "1904",
            "1905",
            "1906",
            "1907",
            "1908",
            "1909",
            "1910",
            "1911",
            "1912",
            "1913",
            "1914",
            "1915",
            "1916",
            "1917",
            "1918",
            "1919",
            "1920",
            "1921",
            "1922",
            "1923",
            "1924",
            "1925",
            "1926",
            "1927",
            "1928",
            "1929",
            "1930",
            "1931",
            "1932",
            "1933",
            "1934",
            "1935",
            "1936",
            "1937",
            "1938",
            "1939",
            "1940",
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2050",
            "2051",
            "2052",
            "2053",
            "2054",
            "2055",
            "2056",
            "2057",
            "2058",
            "2059",
            "2060",
            "2061",
            "2062",
            "2063",
            "2064",
            "2065",
            "2066",
            "2067",
            "2068",
            "2069",
            "2070",
            "2071",
            "2072",
            "2073",
            "2074",
            "2075",
            "2076",
            "2077",
            "2078",
            "2079",
            "2080",
            "2081",
            "2082",
            "2083",
            "2084",
            "2085",
            "2086",
            "2087",
            "2088",
            "2089",
            "2090",
            "2091",
            "2092",
            "2093",
            "2094",
            "2095",
            "2096",
            "2097",
            "2098",
            "2099",
            "2100",
            "2101",
            "2102",
            "2103",
            "2104",
            "2105",
            "2106",
            "2107",
            "2108",
            "2109",
            "2110",
            "2111",
            "2112",
            "2113",
            "2114",
            "2115",
            "2116",
            "2117",
            "2118",
            "2119",
            "2120",
            "2121",
            "2122",
            "2123",
            "2124",
            "2125",
            "2126",
            "2127",
            "2128",
            "2129",
            "2130",
            "2131",
            "2132",
            "2133",
            "2134",
            "2135",
            "2136",
            "2137",
            "2138",
            "2139",
            "2140",
            "2141",
            "2142",
            "2143",
            "2144",
            "2145",
            "2146",
            "2147",
            "2148",
            "2149",
            "2150"});
            this.cmbYear.Location = new System.Drawing.Point(102, 124);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(208, 23);
            this.cmbYear.TabIndex = 5;
            // 
            // dsadsa
            // 
            this.dsadsa.AutoSize = true;
            this.dsadsa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dsadsa.Location = new System.Drawing.Point(18, 153);
            this.dsadsa.Name = "dsadsa";
            this.dsadsa.Size = new System.Drawing.Size(63, 21);
            this.dsadsa.TabIndex = 6;
            this.dsadsa.Text = "Season:";
            // 
            // cmbSeason
            // 
            this.cmbSeason.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSeason.FormattingEnabled = true;
            this.cmbSeason.Items.AddRange(new object[] {
            "Winter",
            "Spring",
            "Summer",
            "Fall"});
            this.cmbSeason.Location = new System.Drawing.Point(102, 155);
            this.cmbSeason.Name = "cmbSeason";
            this.cmbSeason.Size = new System.Drawing.Size(208, 23);
            this.cmbSeason.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(18, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Episodes:";
            // 
            // numEpisodes
            // 
            this.numEpisodes.Location = new System.Drawing.Point(104, 188);
            this.numEpisodes.Name = "numEpisodes";
            this.numEpisodes.Size = new System.Drawing.Size(208, 23);
            this.numEpisodes.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(20, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Status:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Watching",
            "Watched",
            "Dropped",
            "Stalled",
            "NotStarted"});
            this.cmbStatus.Location = new System.Drawing.Point(104, 221);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(208, 23);
            this.cmbStatus.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(20, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 21);
            this.label8.TabIndex = 20;
            this.label8.Text = "Rating:";
            // 
            // cmbRating
            // 
            this.cmbRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRating.FormattingEnabled = true;
            this.cmbRating.Items.AddRange(new object[] {
            "WTF",
            "No Rating",
            "Light 0",
            "0",
            "Decent 0",
            "Strong 0",
            "Light 1",
            "1",
            "Decent 1",
            "Strong 1",
            "Light 2",
            "2",
            "Decent 2",
            "Strong 2",
            "Light 3",
            "3",
            "Decent 3",
            "Strong 3",
            "Light 4",
            "4",
            "Decent 4",
            "Strong 4",
            "Light 5",
            "5",
            "Decent 5",
            "Strong 5",
            "Light 6",
            "6",
            "Decent 6",
            "Strong 6",
            "Light 7",
            "7",
            "Decent7",
            "Strong 7",
            "Light 8",
            "8",
            "Decent 8",
            "Strong 8",
            "Light 9",
            "9",
            "Decent 9",
            "Strong 9",
            "Light 10",
            "10",
            "Decent 10",
            "Strong 10",
            "11",
            "Masterpiece",
            "Magnum Opus"});
            this.cmbRating.Location = new System.Drawing.Point(104, 256);
            this.cmbRating.Name = "cmbRating";
            this.cmbRating.Size = new System.Drawing.Size(208, 23);
            this.cmbRating.TabIndex = 21;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(780, 368);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 33);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(491, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 21);
            this.label9.TabIndex = 24;
            this.label9.Text = "Episode Editor";
            // 
            // grdAnimeEpisodes
            // 
            this.grdAnimeEpisodes.AllowUserToAddRows = false;
            this.grdAnimeEpisodes.AllowUserToDeleteRows = false;
            this.grdAnimeEpisodes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAnimeEpisodes.Location = new System.Drawing.Point(316, 66);
            this.grdAnimeEpisodes.Name = "grdAnimeEpisodes";
            this.grdAnimeEpisodes.ReadOnly = true;
            this.grdAnimeEpisodes.RowTemplate.Height = 25;
            this.grdAnimeEpisodes.Size = new System.Drawing.Size(470, 297);
            this.grdAnimeEpisodes.TabIndex = 25;
            this.grdAnimeEpisodes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAnimeEpisodes_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "Review:";
            // 
            // txtReview
            // 
            this.txtReview.Location = new System.Drawing.Point(104, 294);
            this.txtReview.Name = "txtReview";
            this.txtReview.Size = new System.Drawing.Size(208, 23);
            this.txtReview.TabIndex = 30;
            // 
            // frmEditAnime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 411);
            this.Controls.Add(this.txtReview);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grdAnimeEpisodes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbRating);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numEpisodes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbSeason);
            this.Controls.Add(this.dsadsa);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 450);
            this.MinimumSize = new System.Drawing.Size(900, 450);
            this.Name = "frmEditAnime";
            this.Text = "AnimeWinForm - Edit balls";
            ((System.ComponentModel.ISupportInitialize)(this.numEpisodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdAnimeEpisodes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label dsadsa;
        private System.Windows.Forms.ComboBox cmbSeason;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numEpisodes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbRating;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView grdAnimeEpisodes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReview;
    }
}