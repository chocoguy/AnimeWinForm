using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace AnimeWinForm.Data.AnimeTables
{
    public class AnimeEpisode
    {
        [PrimaryKey]
        [Column("id")]
        public string Id { get; set; }

        [Indexed]
        [Column("Animeid")]
        public string AnimeId { get; set; }

        [Column("episodeNumber")]
        public int EpisodeNumber { get; set; }

        [Column("status")]
        public string Status { get; set; }
    }
}
