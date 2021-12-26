using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace AnimeWinForm.Data.LocalTables
{
    class userSettings
    {
        [PrimaryKey]
        [Column("id")]
        public string Id { get; set; }

        [Column("user")]
        public string User { get; set; }

        [Column("theme")]
        public bool Color { get; set; }

        [Column("backgroundColor")]
        public bool BackgroundColor { get; set; }
    }
}
