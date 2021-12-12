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
        [PrimaryKey, AutoIncrement]
        [Column("id")]
        public int Id { get; set; }

        [Column("setupdone")]
        public bool SetupDone { get; set; }
        
        [Column("storagelocal")]
        public bool StorageLocal { get; set; }

        [Column("connectionstring")]
        public string ConnectionString { get; set; }

        [Column("defaultseason")]
        public string DefaultSeason { get; set; }

        [Column("defaultyear")]
        public string DefaultYear { get; set; }
    }
}
