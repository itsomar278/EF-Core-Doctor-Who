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
    }
}