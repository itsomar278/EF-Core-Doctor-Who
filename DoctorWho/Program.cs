using DoctorWho.Db;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho
{
    public class Program
    {
        DoctorWhoCoreDbContext db = new DoctorWhoCoreDbContext();
        static void Main()
        {
            viewEpisodes();
        }
        public static void viewEpisodes()
        {

            using (var db = new DoctorWhoCoreDbContext())
            {
                var episodes = db.viewEpisodes;
                foreach (var item in episodes)
                {
                    Console.WriteLine($"AuthorName = {item.AuthorName} , DoctorName = {item.DoctorName}" +
                                      $" , Enemies = {item.Enemies} , Companions = {item.Companions}");
                }
            }
        }
        public static void fnCompanions(int EpisodeId)
        {
            DoctorWhoCoreDbContext db = new DoctorWhoCoreDbContext();

            var result = db.Episodes.Select(e => db.FnCompanions(EpisodeId)).ToList().Distinct();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public static void fnEnemies(int EpisodeId)
        {
            DoctorWhoCoreDbContext db = new DoctorWhoCoreDbContext();
            var result = db.Episodes.Select(e => db.FnEnemies(EpisodeId)).ToList().Distinct();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        public static void ExecueteSP()
        {
            using (var db = new DoctorWhoCoreDbContext())
            {
                var HighestEnemies = new SqlParameter
                {
                    ParameterName = "p1",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Size = -1,
                    Direction = System.Data.ParameterDirection.Output,
                };
                var HighestCompanions = new SqlParameter
                {
                    ParameterName = "p2",
                    SqlDbType = System.Data.SqlDbType.VarChar,
                    Size = -1,
                    Direction = System.Data.ParameterDirection.Output,
                };
                db.Database.ExecuteSqlRaw(@"EXEC dbo.spSummariseEpisodes @HighestEnemies = @P1 OUTPUT 
,                                     @HighestCompanions = @P2 OUTPUT ; ", HighestEnemies, HighestCompanions);

                string[] EnemiesResult = Convert.ToString(HighestEnemies.Value).Trim().Split(",");
                string[] CompanionsResult = Convert.ToString(HighestCompanions.Value).Trim().Split(",");
                Console.WriteLine("Top 3 Enemies :");
                foreach (var item in EnemiesResult)
                {
                    Console.WriteLine(item.Trim());
                }
                Console.WriteLine("Top 3 Companions :");
                foreach (var item in CompanionsResult)
                {
                    Console.WriteLine(item.Trim());
                }
            }
        }
        public static void AddDoctor(Doctor doctor)
        {
            using (var db = new DoctorWhoCoreDbContext())
            {
                db.Doctors.Add(doctor);
                db.SaveChanges();
            }
        }
        public static void DeleteDoctor(Doctor doctor)
        {
            using (var db = new DoctorWhoCoreDbContext())
            {
                db.Doctors.Remove(doctor);
                db.SaveChanges();
            }
        }
        public static void UpdateDoctorName(Doctor doctor, string Name)
        {
            using (var db = new DoctorWhoCoreDbContext())
            {
                doctor.DoctorName = Name;
                db.SaveChanges();
            }
        }
        public static void AddAuthor(Author author)
        {
            using (var db = new DoctorWhoCoreDbContext())
            {
                db.Authors.Add(author);
                db.SaveChanges();
            }
        }
        public static void DeleteAuthor(Author author)
        {
            using (var db = new DoctorWhoCoreDbContext())
            {
                db.Authors.Remove(author);
                db.SaveChanges();
            }
        }
        public static void UpdateAuthorName(Author author, string Name)
        {
            using (var db = new DoctorWhoCoreDbContext())
            {
                author.AuthorName = Name;
                db.SaveChanges();
            }
        }
        public static void AddCompanion(Companion companion)
        {
            using (var db = new DoctorWhoCoreDbContext())
            {
                db.Companions.Add(companion);
                db.SaveChanges();
            }
        }
        public static void DeleteCompanion(Companion companion)
        {
            using (var db = new DoctorWhoCoreDbContext())
            {
                db.Companions.Remove(companion);
                db.SaveChanges();
            }
        }
        public static void UpdateCompanionName(Companion companion, string name)
        {
            using (var db = new DoctorWhoCoreDbContext())
            {
                companion.CompanionName = name;
                db.SaveChanges();
            }
        }
        public static void AddEnemy(Enemy enemy)
        {
            using (var db = new DoctorWhoCoreDbContext())
            {
                db.Enemies.Add(enemy);
                db.SaveChanges();
            }
        }
        public static void DeleteEnemy(Enemy enemy)
        {
            using (var db = new DoctorWhoCoreDbContext())
            {
                db.Enemies.Add(enemy);
                db.SaveChanges();
            }
        }
        public static void UpdateEnemyName(Enemy Enemy, string name)
        {
            using (var db = new DoctorWhoCoreDbContext())
            {
                Enemy.EnemyName = name;
                db.SaveChanges();
            }
        }
        public static void AddEpisode(Episode episode)
        {
            using (var db = new DoctorWhoCoreDbContext())
            {
                db.Episodes.Add(episode);
                db.SaveChanges();
            }
        }
        public static void DeleteEpisode(Episode episode)
        {
            using (var db = new DoctorWhoCoreDbContext())
            {
                db.Episodes.Remove(episode);
                db.SaveChanges();
            }
        }
        public static void UpdateEpisodeTitle(Episode episode , string title)
        {
            using(var db= new DoctorWhoCoreDbContext())
            {
                episode.Title = title;
                db.SaveChanges();
            }
        }
        public static void AddEnemyToEpisode(Enemy enemy , Episode episode)
        {
            using(var db = new DoctorWhoCoreDbContext())
            {
                if (!db.Episodes.Contains(episode))
                    throw new ArgumentException("this episode dosent exist");
                if (db.Enemies.Contains(enemy))
                    throw new ArgumentException("this enemy dosent exist");
                EnemyEpisode enemyEpisode = new EnemyEpisode
                {
                    EnemyId = enemy.EnemyId ,
                    EpisodeId = episode.EpisodeId
                };
                db.EnemyEpisodes.Add(enemyEpisode);
                db.SaveChanges();
            }
        }
        public static void AddCompanionToEpisode(Episode episode , Companion companion)
        {
            using(var db = new DoctorWhoCoreDbContext())
            {
                if (!db.Episodes.Contains(episode))
                    throw new ArgumentException("this episode dosent exist");
                if (db.Companions.Contains(companion))
                    throw new ArgumentException("this companion dosent exist");
                CompanionEpisode companionEpisode = new CompanionEpisode
                {
                    CompanionId = companion.CompanionId,
                    EpisodeId = episode.EpisodeId
                };
                db.CompanionsEpisodes.Add(companionEpisode);
                db.SaveChanges();
            }
        }
        public static Enemy GetEnemyById (int id)
        {
            using (var db = new DoctorWhoCoreDbContext())
            {
               var enemy = db.Enemies.Find(id);
                if(enemy == null)
                {
                    throw new ArgumentException("There is no enemy with such id ");
                }
                return enemy;
            }
        }
        public static Companion GetCompanionById(int id)
        {
            using (var db = new DoctorWhoCoreDbContext())
            {
                var companion = db.Companions.Find(id);
                if (companion == null)
                {
                    throw new ArgumentException("There is no companion with such id ");
                }
                return companion;
            }
        }
        public static ICollection<Doctor> GetAllDoctors()
        {
            using (var db = new DoctorWhoCoreDbContext())
            {
                return db.Doctors.ToList();
            }
        }
    }
}