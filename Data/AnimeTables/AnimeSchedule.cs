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

        [Column("animeCount")]
        public int AnimeCount { get; set; }

        [Column("isCurrentSchedule")]
        public bool IsCurrentSchedule { get; set; }

        [Indexed]
        [Column("mondayAnime")]
        public string MondayAnime { get; set; }

        [Indexed]
        [Column("tuesdayAnime")]
        public string TuesdayAnime { get; set;}

        [Indexed]
        [Column("wednesdayAnime")]
        public string WednesdayAnime { get; set; }

        [Indexed]
        [Column("thursdayAnime")]
        public string ThursdayAnime { get; set; }

        [Indexed]
        [Column("fridayAnime")]
        public string FridayAnime { get; set; }

        [Indexed]
        [Column("saturdayAnime")]
        public string SaturdayAnime { get; set; }

        [Indexed]
        [Column("sundayAnime")]
        public string SundayAnime { get; set; }
    }
}
