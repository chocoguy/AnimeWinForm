using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;
using SQLite;

namespace AnimeWinForm.Data.LocalTables
{
   [Table("localsettings")]
   public class localSettings
    {
        [PrimaryKey]
        [Column("id")]
        public string Id { get; set; }

        [Column("setupDone")]
        public bool SetupDone { get; set; }
        
        [Column("storageLocal")]
        public bool StorageLocal { get; set; }

        [Column("connectionString")]
        public string ConnectionString { get; set; }

        [Column("defaultSeason")]
        public string DefaultSeason { get; set; }

        [Column("defaultYear")]
        public string DefaultYear { get; set; }
    }
}
