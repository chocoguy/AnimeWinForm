using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimeWinForm.Data.AnimeTables;
using AnimeWinForm.Data.LocalTables;
using SQLite;


namespace AnimeWinForm.Data
{
    public class LocalStorageHandler
    {
        private SQLiteConnection LocalDb;

        public LocalStorageHandler()
        {
            LocalDb = new SQLiteConnection("./localstorage.sqlite3");
            LocalDb.CreateTable<localSettings>();
            LocalDb.CreateTable<userSettings>();
            LocalDb.CreateTable<Anime>();
            LocalDb.CreateTable<AnimeEpisode>();
            LocalDb.CreateTable<localSettings>();
            LocalDb.CreateTable<AnimeSchedule>();
        }

        public void initLocalSettings()
        {
            var options = new SQLiteConnectionString("./localstorage.sqlite3", false);
            var conn = new SQLiteConnection(options);

            string query = $"INSERT INTO localsettings (id, setupDone, storageLocal) VALUES ('1', true, true)";

            conn.Query<localSettings>(query);

            conn.Close();
        }

        public bool checkAppSetup()
        {
            var options = new SQLiteConnectionString("./localstorage.sqlite3", false);
            var conn = new SQLiteConnection(options);

            string query = $"SELECT setupDone FROM localsettings";

            var results = conn.Query<localSettings>(query);

            if (results == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public List<Anime> GetAllAnime()
        {
            var options = new SQLiteConnectionString("./localstorage.sqlite3", false);
            var conn = new SQLiteConnection(options);

            string query = $"SELECT * FROM Anime";

            var results = conn.Query<Anime>(query);

            conn.Close();

            return results;
        }


        public void SaveNewAnime(string Title, string Season, string Year, int Episodes, string Status)
        {
            string query2;
            Guid animeuuid = Guid.NewGuid();
            string animeuuidString = animeuuid.ToString();

            var options = new SQLiteConnectionString("./localstorage.sqlite3", false);
            var conn = new SQLiteConnection(options);

            string query1 = $"INSERT INTO Anime (id, title, season, year, episodes, status) VALUES ('{animeuuidString}','{Title}', '{Season}', '{Year}', {Episodes}, '{Status}')";

            conn.Query<Anime>(query1);

            for (int i = 1; i <= Episodes; i++)
            {
                Guid newEpisodeUuid = Guid.NewGuid();
                string newEpisodeUuidString = newEpisodeUuid.ToString();
                query2 = $"INSERT INTO AnimeEpisode (id, AnimeId, episodeNumber, status) VALUES ('${newEpisodeUuidString}', '{animeuuidString}', {i}, 'NotStarted')";

                conn.Query<AnimeEpisode>(query2);
            }

            conn.Close();
        }

        //public List<Anime> GetRecentlyWatchedAnime()
        //{
        //    var options = new SQLiteConnectionString("./localstorage.sqlite3", false);
        //    var conn = new SQLiteConnection(options);

        //    string query = $"SELECT * FROM Anime WHERE lastWatched > 0 ORDER BY lastWatched ASC";

        //    var results = conn.Query<Anime>(query);
        //    //maybeeee might not work
        //    conn.Close();
        //    return results;


        //}

        public List<AnimeEpisode> GetAnimeEpisodesByAnimeId(string Animeid)
        {
            var options = new SQLiteConnectionString("./localstorage.sqlite3", false);
            var conn = new SQLiteConnection(options);

            string query = $"SELECT * FROM AnimeEpisode WHERE Animeid = '{Animeid}' ";

            var results = conn.Query<AnimeEpisode>(query);

            conn.Close();
            return results;


        }
        

        public int GetEpisodeCurrentlyOn(string Animeid)
        {
            var options = new SQLiteConnectionString("./localstorage.sqlite3", false);
            var conn = new SQLiteConnection(options);

            string query = $"SELECT COUNT(episodeNumber) AS EpisodeNumber FROM AnimeEpisode WHERE Animeid = '{Animeid}' AND Status = 'Watched' OR Animeid = '{Animeid}' AND Status = 'Skipped'";
            var number = conn.Query<AnimeEpisode>(query);

            conn.Close();

            return number[0].EpisodeNumber;
        }


        public Anime GetAnimeById(string Animeid)
        {
            var options = new SQLiteConnectionString("./localstorage.sqlite3", false);
            var conn = new SQLiteConnection(options);

            string query = $"SELECT * FROM Anime WHERE id = '{Animeid}'";

            var anime = conn.Query<Anime>(query);

            conn.Close();

            return anime[0];



        }


        public void IncrementAnimeEpisodeByOne(string Animeid)
        {
            var options = new SQLiteConnectionString("./localstorage.sqlite3", false);
            var conn = new SQLiteConnection(options);

            string query = $"SELECT id FROM AnimeEpisode WHERE Animeid = '{Animeid}' AND status = 'NotStarted' ORDER BY episodeNumber ASC";

            var animeEpisode = conn.Query<AnimeEpisode>(query);

            string query2 = $"UPDATE AnimeEpisode SET status = 'Watched' WHERE Animeid = '{Animeid}' AND id = '{animeEpisode[0].Id}' ";

            var updatedAnimeEpisode = conn.Query<AnimeEpisode>(query2);

            conn.Close();
        }


        public void MarkAnimeEpisode(string Mark, string AnimeEpisodeId)
        {
            var options = new SQLiteConnectionString("./localstorage.sqlite3", false);
            var conn = new SQLiteConnection(options);
            string query;

            if (Mark == "MarkWatched")
            {
                query = $"UPDATE AnimeEpisode SET status = 'Watched' WHERE id = '{AnimeEpisodeId}'";
                var result = conn.Query<AnimeEpisode>(query);
            }
            else if(Mark == "MarkSkipped")
            {
                query = $"UPDATE AnimeEpisode SET status = 'Skipped' WHERE id = '{AnimeEpisodeId}'";
                var result = conn.Query<AnimeEpisode>(query);
            }
            else
            {

            }


            conn.Close();

        }


        public void UnMarkAnimeEpisode(string AnimeEpisodeId)
        {
            var options = new SQLiteConnectionString("./localstorage.sqlite3", false);
            var conn = new SQLiteConnection(options);
            string query;
            query = $"UPDATE AnimeEpisode SET status = 'NotStarted' WHERE id = '{AnimeEpisodeId}'";
            var result = conn.Query<AnimeEpisode>(query);

        }




        public bool CheckAnimeEpisodeCount(string AnimeEpisodeId, string AnimeId)
        {
            var options = new SQLiteConnectionString("./localstorage.sqlite3", false);
            var conn = new SQLiteConnection(options);

            string query = $"SELECT episodeNumber FROM AnimeEpisode WHERE id = '{AnimeEpisodeId}'";

            var episodeNum = conn.Query<AnimeEpisode>(query);

            if (episodeNum[0].EpisodeNumber == 1)
            {
                return true;
            }



            int episodeBefore = episodeNum[0].EpisodeNumber - 1;

            string query2 = $"SELECT status FROM AnimeEpisode WHERE Animeid = '{AnimeId}' AND episodeNumber = {episodeBefore} ";

            var status = conn.Query<AnimeEpisode>(query2);

            if (status[0].Status == "Watched" || status[0].Status == "Skipped")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool UpdateAnime(string AnimeId, string Title, string Season, string Year, int Episodes, string Status, string Rating, string Review)
        {
            var options = new SQLiteConnectionString("./localstorage.sqlite3", false);
            var conn = new SQLiteConnection(options);
            string query2;

            string episodeQuery = $"SELECT episodes FROM Anime WHERE id = '{AnimeId}'";

            var currentEpisodes = conn.Query<Anime>(episodeQuery);

            if (currentEpisodes[0].Episodes > Episodes)
            {
                return false;
            }
            else
            {
                int oldEpisodes = currentEpisodes[0].Episodes + 1;
                for (int i = oldEpisodes; i <= Episodes; i++)
                {
                    Guid newEpisodeUuid = Guid.NewGuid();
                    string newEpisodeUuidString = newEpisodeUuid.ToString();
                    query2 = $"INSERT INTO AnimeEpisode (id, AnimeId, episodeNumber, status) VALUES ('${newEpisodeUuidString}', '{AnimeId}', {i}, 'NotStarted')";

                    conn.Query<AnimeEpisode>(query2);
                }
            }


            string query = $"UPDATE Anime SET title = '{Title}', season = '{Season}', year = '{Year}', episodes = '{Episodes}', status = '{Status}', rating = '{Rating}', review = '{Review}' WHERE id = '{AnimeId}'";

            var result = conn.Query<Anime>(query);

            return true;

            


        }


        public void DeleteAnime(string AnimeId)
        {

            var options = new SQLiteConnectionString("./localstorage.sqlite3", false);
            var conn = new SQLiteConnection(options);
            string query2;

            string deleteAnimeQuery = $"DELETE FROM Anime WHERE id = '{AnimeId}'";
            string deleteAnimeEpisodes = $"DELETE FROM AnimeEpisode WHERE Animeid = '{AnimeId}'";

            conn.Query<Anime>(deleteAnimeQuery);
            conn.Query<AnimeEpisode>(deleteAnimeEpisodes);



        }




        // Anime Schedule Methods

        public AnimeSchedule GetAnimeScheduleById(string ScheduleId)
        {
            var options = new SQLiteConnectionString("./localstorage.sqlite3", false);
            var conn = new SQLiteConnection(options);

            string query = $"SELECT * from AnimeSchedule WHERE id == '{ScheduleId}'";


            var result = conn.FindWithQuery<AnimeSchedule>(query);

            return result;

        }

        //SELECT * FROM Anime WHERE id = (SELECT tuesdayAnime FROM AnimeSchedule WHERE id == '1')

        //public List<Anime> GetAnimeScheduleAnimeById(string ScheduleId)
        //{
        //    AnimeSchedule currentSchedule = GetAnimeScheduleById(ScheduleId);
        //    List<Anime> animeAssignedToSchedule 
        //    var options = new SQLiteConnectionString("./localstorage.sqlite3", false);
        //    var conn = new SQLiteConnection(options);



        //}

        //public List<AnimeSchedule> GetAllAnimeSchedules()
        //{

        //}




    }
}
