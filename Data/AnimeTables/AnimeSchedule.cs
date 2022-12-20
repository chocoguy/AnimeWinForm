using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimeWinForm.Data.AnimeTables
{
    public class AnimeSchedule
    {
        [PrimaryKey, NotNull]
        [Column("id")]
        public string Id { get; set; }

        [NotNull]
        [Column("title")]
        public string Title { get; set; }

        [Column("status")]
        public string Status { get; set; }

        [Column("animeCount")]
        public int AnimeCount { get; set; }

        [Column("isCurrentSchedule")]
        public bool IsCurrentSchedule { get; set; }

        [Indexed]
        [Column("mondayAnime")]
        public int MondayAnime { get; set; }

        [Indexed]
        [Column("tuesdayAnime")]
        public int TuesdayAnime { get; set;}

        [Indexed]
        [Column("wednesdayAnime")]
        public int WednesdayAnime { get; set; }

        [Indexed]
        [Column("thursdayAnime")]
        public int ThursdayAnime { get; set; }

        [Indexed]
        [Column("fridayAnime")]
        public int FridayAnime { get; set; }

        [Indexed]
        [Column("saturdayAnime")]
        public int SaturdayAnime { get; set; }

        [Indexed]
        [Column("sundayAnime")]
        public int SundayAnime { get; set; }
    }
}
