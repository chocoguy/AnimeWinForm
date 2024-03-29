﻿using System;
using System.Collections.Generic;
using AnimeWinForm.Data.AnimeTables;
using AnimeWinForm.Data.LocalTables;
using SQLite;


namespace AnimeWinForm.Data
{
    public class LocalStorageHandler
    {
        private SQLiteConnection LocalDb;
        private SQLiteConnectionString connectionString = new SQLiteConnectionString("./localstorage.sqlite3", false);
        private SQLiteConnection conn;

        public LocalStorageHandler()
        {
            LocalDb = new SQLiteConnection("./localstorage.sqlite3");
            LocalDb.CreateTable<localSettings>();
            LocalDb.CreateTable<userSettings>();
            LocalDb.CreateTable<Anime>();
            LocalDb.CreateTable<AnimeEpisode>();
            LocalDb.CreateTable<localSettings>();
            LocalDb.CreateTable<AnimeSchedule>();
            conn = new SQLiteConnection(connectionString);
        }

        public void initLocalSettings()
        {
            string query = $"INSERT INTO localsettings (id, setupDone, storageLocal) VALUES ('1', true, true)";
            conn.Query<localSettings>(query);
        }

        public bool checkAppSetup()
        {
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

            string query = $"SELECT * FROM Anime";

            var results = conn.Query<Anime>(query);

            return results;
        }


        public void SaveNewAnime(string Title, string Season, string Year, int Episodes, string Status)
        {
            string query2;
            Guid animeuuid = Guid.NewGuid();
            string animeuuidString = animeuuid.ToString();

            string query1 = $"INSERT INTO Anime (id, title, season, year, episodes, status) VALUES ('{animeuuidString}','{Title}', '{Season}', '{Year}', {Episodes}, '{Status}')";

            conn.Query<Anime>(query1);

            for (int i = 1; i <= Episodes; i++)
            {
                Guid newEpisodeUuid = Guid.NewGuid();
                string newEpisodeUuidString = newEpisodeUuid.ToString();
                query2 = $"INSERT INTO AnimeEpisode (id, AnimeId, episodeNumber, status) VALUES ('${newEpisodeUuidString}', '{animeuuidString}', {i}, 'NotStarted')";

                conn.Query<AnimeEpisode>(query2);
            }
        }

        public List<AnimeEpisode> GetAnimeEpisodesByAnimeId(string Animeid)
        {
            string query = $"SELECT * FROM AnimeEpisode WHERE Animeid = '{Animeid}' ";

            var results = conn.Query<AnimeEpisode>(query);
            return results;
        }
        

        public int GetEpisodeCurrentlyOn(string Animeid)
        {
            string query = $"SELECT COUNT(episodeNumber) AS EpisodeNumber FROM AnimeEpisode WHERE Animeid = '{Animeid}' AND Status = 'Watched' OR Animeid = '{Animeid}' AND Status = 'Skipped'";
            var number = conn.Query<AnimeEpisode>(query);

            return number[0].EpisodeNumber;
        }


        public Anime GetAnimeById(string Animeid)
        {
            if(string.IsNullOrEmpty(Animeid))
            {
                return new Anime();
            }

            string query = $"SELECT * FROM Anime WHERE id = '{Animeid}'";

            var anime = conn.Query<Anime>(query);

            return anime[0];
        }


        public void IncrementAnimeEpisodeByOne(string Animeid)
        {
            string query = $"SELECT id FROM AnimeEpisode WHERE Animeid = '{Animeid}' AND status = 'NotStarted' ORDER BY episodeNumber ASC";

            var animeEpisode = conn.Query<AnimeEpisode>(query);

            string query2 = $"UPDATE AnimeEpisode SET status = 'Watched' WHERE Animeid = '{Animeid}' AND id = '{animeEpisode[0].Id}' ";

            var updatedAnimeEpisode = conn.Query<AnimeEpisode>(query2);
        }


        public void MarkAnimeEpisode(string Mark, string AnimeEpisodeId)
        {
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
        }


        public void UnMarkAnimeEpisode(string AnimeEpisodeId)
        {
            string query;
            query = $"UPDATE AnimeEpisode SET status = 'NotStarted' WHERE id = '{AnimeEpisodeId}'";
            var result = conn.Query<AnimeEpisode>(query);

        }




        public bool CheckAnimeEpisodeCount(string AnimeEpisodeId, string AnimeId)
        {
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
            string deleteAnimeQuery = $"DELETE FROM Anime WHERE id = '{AnimeId}'";
            string deleteAnimeEpisodes = $"DELETE FROM AnimeEpisode WHERE Animeid = '{AnimeId}'";
            
            List<AnimeSchedule> schedules = GetAnimeSchedules();

            #region Not proud of this
            //not the best implementation but it should work
            foreach (AnimeSchedule schedule in schedules)
            {
                if(schedule.MondayAnime == AnimeId)
                {
                    conn.Query<AnimeSchedule>($"UPDATE AnimeSchedule SET mondayAnime = '' WHERE id = '{schedule.Id}'");
                }
                else if(schedule.TuesdayAnime == AnimeId)
                {
                    conn.Query<AnimeSchedule>($"UPDATE AnimeSchedule SET tuesdayAnime = '' WHERE id = '{schedule.Id}'");
                }
                else if(schedule.WednesdayAnime == AnimeId)
                {
                    conn.Query<AnimeSchedule>($"UPDATE AnimeSchedule SET wednesdayAnime = '' WHERE id = '{schedule.Id}'");
                }
                else if(schedule.ThursdayAnime == AnimeId)
                {
                    conn.Query<AnimeSchedule>($"UPDATE AnimeSchedule SET thursdayAnime = '' WHERE id = '{schedule.Id}'");
                }
                else if(schedule.FridayAnime== AnimeId)
                {
                    conn.Query<AnimeSchedule>($"UPDATE AnimeSchedule SET fridayAnime = '' WHERE id = '{schedule.Id}'");
                }
                else if (schedule.SaturdayAnime == AnimeId)
                {
                    conn.Query<AnimeSchedule>($"UPDATE AnimeSchedule SET saturdayAnime = '' WHERE id = '{schedule.Id}'");
                }
                else if (schedule.SundayAnime == AnimeId)
                {
                    conn.Query<AnimeSchedule>($"UPDATE AnimeSchedule SET sundayAnime = '' WHERE id = '{schedule.Id}'");
                }
            }
            #endregion

            conn.Query<Anime>(deleteAnimeQuery);
            conn.Query<AnimeEpisode>(deleteAnimeEpisodes);
        }


        public AnimeSchedule GetAnimeScheduleById(string ScheduleId)
        {
            string query = $"SELECT * from AnimeSchedule WHERE id == '{ScheduleId}'";

            var result = conn.FindWithQuery<AnimeSchedule>(query);

            return result;
        }

        public List<AnimeSchedule> GetAnimeSchedules()
        {
            string query = $"SELECT * from AnimeSchedule";

            return conn.Query<AnimeSchedule>(query);
        }

        public bool UpdateAnimeSchedule(AnimeSchedule schedule)
        {
            int dbBool = 0;

            if(schedule.IsCurrentSchedule) { dbBool = 1; }

            string query = $"UPDATE AnimeSchedule SET title = '{schedule.Title}', animeCount = 1, isCurrentSchedule = {dbBool}, mondayAnime =  '{schedule.MondayAnime}', tuesdayAnime = '{schedule.TuesdayAnime}', wednesdayAnime = '{schedule.WednesdayAnime}', thursdayAnime = '{schedule.ThursdayAnime}', fridayAnime = '{schedule.FridayAnime}', saturdayAnime = '{schedule.SaturdayAnime}', sundayAnime = '{schedule.SundayAnime}' WHERE Id = '{schedule.Id}' ";

            if(schedule.IsCurrentSchedule)
            {
                string query2 = $"UPDATE AnimeSchedule SET isCurrentSchedule = 0 WHERE id != '{schedule.Id}' ";
                conn.Query<AnimeSchedule>(query2);
            }

            conn.Query<AnimeSchedule>(query);

            return true;
        }

        public void SaveNewAnimeSchedule(AnimeSchedule schedule)
        {
            Guid scheduleGuid = Guid.NewGuid();

            int dbBool = 0;

            if (schedule.IsCurrentSchedule) { dbBool = 1; }

            string query = $"INSERT INTO AnimeSchedule (id, title, animeCount, isCurrentSchedule, mondayAnime, tuesdayAnime, wednesdayAnime, thursdayAnime, fridayAnime, saturdayAnime, sundayAnime) VALUES ( '{scheduleGuid}', '{schedule.Title}', 3,  {dbBool}, '{schedule.MondayAnime}', '{schedule.TuesdayAnime}', '{schedule.WednesdayAnime}', '{schedule.ThursdayAnime}', '{schedule.FridayAnime}', '{schedule.SaturdayAnime}', '{schedule.SundayAnime}' )";

            if (schedule.IsCurrentSchedule)
            {
                string query2 = $"UPDATE AnimeSchedule SET isCurrentSchedule = 0 WHERE id != '{schedule.Id}' ";
                conn.Query<AnimeSchedule>(query2);
            }

            conn.Query<AnimeSchedule>(query);

        }

        public void DeleteAnimeSchedule(string AnimeScheduleId)
        {
            string query = $"DELETE FROM AnimeSchedule WHERE id = '{AnimeScheduleId}'";
            conn.Query<AnimeSchedule>(query);
        }
    }
}
