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


        public void SaveNewAnime(string Title, string ShortTitle, string Season, string Year, int Episodes, string Status)
        {
            string query2;
            Guid animeuuid = Guid.NewGuid();
            string animeuuidString = animeuuid.ToString();

            var options = new SQLiteConnectionString("./localstorage.sqlite3", false);
            var conn = new SQLiteConnection(options);

            string query1 = $"INSERT INTO Anime (id, title, shortTitle, season, year, episodes, status) VALUES ('{animeuuidString}','{Title}', '{ShortTitle}', '{Season}', '{Year}', {Episodes}, '{Status}')";

            conn.Query<Anime>(query1);

            for (int i = 1; i < Episodes; i++)
            {
                Guid newEpisodeUuid = Guid.NewGuid();
                string newEpisodeUuidString = newEpisodeUuid.ToString();
                query2 = $"INSERT INTO AnimeEpisodes (id, AnimeId, episodeNumber, status) VALUES ('${newEpisodeUuidString}', '{animeuuidString}', {i}, 'NotStarted')";

                conn.Query<AnimeEpisodes>(query2);
            }

            conn.Close();
        }

        public List<Anime> GetRecentlyWatchedAnime()
        {
            var options = new SQLiteConnectionString("./localstorage.sqlite3", false);
            var conn = new SQLiteConnection(options);

            string query = $"SELECT * FROM Anime WHERE lastWatched > 0 ORDER BY lastWatched ASC";

            var results = conn.Query<Anime>(query);
            //maybeeee might not work
            conn.Close();
            return results;


        }

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



    }
}
