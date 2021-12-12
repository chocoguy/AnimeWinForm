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
        [PrimaryKey, AutoIncrement]
        [Column("id")]
        public int Id { get; set; }
    }
}
