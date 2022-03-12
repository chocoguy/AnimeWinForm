using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace AnimeWinForm.Data.AnimeTables
{
    public class Anime
    {
        [PrimaryKey, NotNull]
        [Column("id")]
        public string Id { get; set; }
        [NotNull]
        [Column("title")]
        public string Title { get; set; }
        
        [Column("season")]
        public string Season { get; set; }

        [Column("year")]
        public string Year { get; set; }

        [NotNull]
        [Column("episodes")]
        public int Episodes { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("rating")]
        public string Rating { get; set; }

        [Column("lastWatched")]
        public int LastWatched { get; set; }

        [Column("review")]
        public string Review { get; set; }
    }
}
