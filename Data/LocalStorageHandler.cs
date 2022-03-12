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
            LocalDb.CreateTable<AnimeEpisodes>();
            LocalDb.CreateTable<localSettings>();
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
                query2 = $"INSERT INTO AnimeEpisodes (id, AnimeId, episodeNumber, status) VALUES ('${newEpisodeUuidString}', '{animeuuidString}', {i}, 'NotStarted')";

                conn.Query<AnimeEpisodes>(query2);
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

        public List<AnimeEpisodes> GetAnimeEpisodesByAnimeId(string Animeid)
        {
            var options = new SQLiteConnectionString("./localstorage.sqlite3", false);
            var conn = new SQLiteConnection(options);

            string query = $"SELECT * FROM AnimeEpisodes WHERE Animeid = '{Animeid}' ";

            var results = conn.Query<AnimeEpisodes>(query);

            conn.Close();
            return results;


        }
        

        public int GetEpisodeCurrentlyOn(string Animeid)
        {
            var options = new SQLiteConnectionString("./localstorage.sqlite3", false);
            var conn = new SQLiteConnection(options);

            string query = $"SELECT COUNT(episodeNumber) AS EpisodeNumber FROM AnimeEpisodes WHERE Animeid = '{Animeid}' AND Status = 'Watched' OR Animeid = '{Animeid}' AND Status = 'Skipped'";
            var number = conn.Query<AnimeEpisodes>(query);

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

            string query = $"SELECT id FROM AnimeEpisodes WHERE Animeid = '{Animeid}' AND status = 'NotStarted' ORDER BY episodeNumber ASC";

            var animeEpisode = conn.Query<AnimeEpisodes>(query);

            string query2 = $"UPDATE AnimeEpisodes SET status = 'Watched' WHERE Animeid = '{Animeid}' AND id = '{animeEpisode[0].Id}' ";

            var updatedAnimeEpisode = conn.Query<AnimeEpisodes>(query2);

            conn.Close();
        }


        public void MarkAnimeEpisode(string Mark, string AnimeEpisodeId)
        {
            var options = new SQLiteConnectionString("./localstorage.sqlite3", false);
            var conn = new SQLiteConnection(options);
            string query;

            if (Mark == "MarkWatched")
            {
                query = $"UPDATE AnimeEpisodes SET status = 'Watched' WHERE id = '{AnimeEpisodeId}'";
            }
            else
            {
                query = $"UPDATE AnimeEpisodes SET status = 'Skipped' WHERE id = '{AnimeEpisodeId}'";
            }

            var result = conn.Query<AnimeEpisodes>(query);

            conn.Close();

        }



        public bool CheckAnimeEpisodeCount(string AnimeEpisodeId, string AnimeId)
        {
            var options = new SQLiteConnectionString("./localstorage.sqlite3", false);
            var conn = new SQLiteConnection(options);

            string query = $"SELECT episodeNumber FROM AnimeEpisodes WHERE id = '{AnimeEpisodeId}'";

            var episodeNum = conn.Query<AnimeEpisodes>(query);

            if (episodeNum[0].EpisodeNumber == 1)
            {
                return true;
            }



            int episodeBefore = episodeNum[0].EpisodeNumber - 1;

            string query2 = $"SELECT status FROM AnimeEpisodes WHERE Animeid = '{AnimeId}' AND episodeNumber = {episodeBefore} ";

            var status = conn.Query<AnimeEpisodes>(query2);

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
                    query2 = $"INSERT INTO AnimeEpisodes (id, AnimeId, episodeNumber, status) VALUES ('${newEpisodeUuidString}', '{AnimeId}', {i}, 'NotStarted')";

                    conn.Query<AnimeEpisodes>(query2);
                }
            }


            string query = $"UPDATE Anime SET title = '{Title}', season = '{Season}', year = '{Year}', episodes = '{Episodes}', status = '{Status}', rating = '{Rating}', review = '{Review}' WHERE id = '{AnimeId}'";

            var result = conn.Query<Anime>(query);

            return true;

            


        }


        //public void SetAnimeWatching(string Animeid)
        //{
        //    var options = new SQLiteConnectionString("./localstorage.sqlite3", false);
        //    var conn = new SQLiteConnection(options);

        //    string query = $"UPDATE Anime SET startWatch = {DateTime.Now} WHERE id = '{Animeid}' ";

        //    var result = conn.Query<Anime>(query);
        //}


        //public void SetAnimeWatched(string Animeid)
        //{
        //    var options = new SQLiteConnectionString("./localstorage.sqlite3", false);
        //    var conn = new SQLiteConnection(options);

        //    string query = $"UPDATE Anime SET stopWatch = {DateTime.Now} WHERE id = '{Animeid}' ";

        //    var result = conn.Query<Anime>(query);


        //}


        //public void UpdateRecentlyWatched(string Animeid)
        //{
        //    var options = new SQLiteConnectionString("./localstorage.sqlite3", false);
        //    var conn = new SQLiteConnection(options);

        //    string query1 = "SELECT * FROM Anime WHERE lastWatched > 0";

        //    var currentAnimes = conn.Query<Anime>(query1);

        //    foreach (var anime in currentAnimes)
        //    {
        //        int newLastWatchedValue;
        //        string tempQuery;
        //        switch (anime.LastWatched)
        //        {

        //            case 1:
        //                newLastWatchedValue = 2;
        //                break;
        //            case 2:
        //                newLastWatchedValue = 3;
        //                break;
        //            case 3:
        //                newLastWatchedValue = 4;
        //                break;
        //            case 5:
        //                newLastWatchedValue = 0;
        //                break;
        //            default:
        //                newLastWatchedValue = 0;
        //                break;
        //        }
        //        tempQuery = $"UPDATE Anime SET lastWatched = {newLastWatchedValue} WHERE id = '{anime.Id}' ";
        //        conn.Query<Anime>(tempQuery);
        //    }

        //    string query2 = $"UPDATE Anime SET lastWatched = 1 WHERE id = '{Animeid}' ";
        //    conn.Query<Anime>(query2);

        //    conn.Close();

        //}







    }
}
