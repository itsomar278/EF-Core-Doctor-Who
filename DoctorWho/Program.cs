using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho
{
    public class Program
    {
        static void Main()
        {
          DoctorWhoCoreDbContext db = new DoctorWhoCoreDbContext();
          fnCompanions(1);
          fnEnemies(1);
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
    }
}