using Microsoft.EntityFrameworkCore;


namespace DoctorWho.Db
{
    public class DoctorWhoCoreDbContext : DbContext
    {
        public DoctorWhoCoreDbContext()
        {

        }
        public DbSet<Companion> Companions { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Enemy> Enemies { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        public DbSet<EnemyEpisode> EnemyEpisodes { get; set; }
        public DbSet<CompanionEpisode> CompanionsEpisodes { get; set; }
        public DbSet<EpisodesView> viewEpisodes { get; set; }
        public string FnCompanions(int EpisodeId) => throw new NotSupportedException();
        public string FnEnemies(int EpisodeId) => throw new NotSupportedException();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-6PEJGCB;Initial Catalog=DoctorWhoCore;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EpisodesView>(v => v.ToView("viewEpisodes"));

            modelBuilder.HasDbFunction(typeof(DoctorWhoCoreDbContext)
              .GetMethod(nameof(FnCompanions), new[] { typeof(int) }))
              .HasName("fnCompanions");

            modelBuilder.HasDbFunction(typeof(DoctorWhoCoreDbContext)
             .GetMethod(nameof(FnEnemies), new[] { typeof(int) }))
             .HasName("fnEnemies");

            modelBuilder.Entity<EnemyEpisode>().HasKey(ee => new { ee.EnemyId, ee.EpisodeId });
            modelBuilder.Entity<CompanionEpisode>().HasKey(ce => new { ce.CompanionId, ce.EpisodeId });

            DateTime birthDate = new DateTime(2000, 1, 1);
            modelBuilder.Entity<Doctor>().HasData(
                new {DoctorId =1 , DoctorName = "doctor1", DoctorNumber = 11, BirthDate = birthDate },
                new { DoctorId = 2, DoctorName = "doctor2", DoctorNumber = 22, BirthDate = birthDate.AddYears(1) },
                new { DoctorId = 3, DoctorName = "doctor3", DoctorNumber = 33, BirthDate = birthDate.AddYears(2) },
                new { DoctorId = 4, DoctorName = "doctor4", DoctorNumber = 44, BirthDate = birthDate.AddYears(3) },
                new { DoctorId = 5, DoctorName = "doctor5", DoctorNumber = 55, BirthDate = birthDate.AddYears(4) }
                );

            modelBuilder.Entity<Author>().HasData(
                new {AuthorId = 1, AuthorName = "Author1" },
                new {AuthorId = 2, AuthorName = "Author2" },
                new {AuthorId = 3, AuthorName = "Author3" },
                new {AuthorId = 4, AuthorName = "Author4" },
                new {AuthorId = 5, AuthorName = "Author5" }

                );

            modelBuilder.Entity<Enemy>().HasData(
                new {EnemyId = 1 , EnemyName = "Enemy1" , Describtion = "o" },
                new {EnemyId = 2, EnemyName = "Enemy2"  , Describtion = "o" },
                new {EnemyId = 3, EnemyName = "Enemy3"  , Describtion = "o" },
                new {EnemyId = 4, EnemyName = "Enemy4"  , Describtion = "o" },
                new {EnemyId = 5, EnemyName = "Enemy5"  , Describtion = "o" }
                );

            modelBuilder.Entity<Companion>().HasData(
                new {CompanionId = 1, CompanionName = "Companion1", WhoPayed = "Payer1" },
                new {CompanionId = 2, CompanionName = "Companion1", WhoPayed = "Payer2" },
                new {CompanionId = 3, CompanionName = "Companion1", WhoPayed = "Payer3" },
                new {CompanionId = 4, CompanionName = "Companion1", WhoPayed = "Payer4" },
                new {CompanionId = 5, CompanionName = "Companion1", WhoPayed = "Payer5" }
                );
            modelBuilder.Entity<Episode>().HasData(
                new {EpisodeId = 1, Title = "1", SeriesNumber = 1, EpisodeNumber = 1, EpisodeDate = birthDate, AuthorId = 1, DoctorId = 1, EpisodeType ="o", Notes = "oo" },
                new {EpisodeId = 2, Title = "1", SeriesNumber = 2, EpisodeNumber = 1, EpisodeDate = birthDate, AuthorId = 2, DoctorId = 2, EpisodeType = "o", Notes = "oo" },
                new {EpisodeId = 3, Title = "1", SeriesNumber = 3, EpisodeNumber = 1, EpisodeDate = birthDate, AuthorId = 3, DoctorId = 3, EpisodeType = "o", Notes = "oo" },
                new {EpisodeId = 4, Title = "1", SeriesNumber = 4, EpisodeNumber = 1, EpisodeDate = birthDate, AuthorId = 4, DoctorId = 4, EpisodeType = "o", Notes = "oo" },
                new {EpisodeId = 5, Title = "1", SeriesNumber = 5, EpisodeNumber = 1, EpisodeDate = birthDate, AuthorId = 5, DoctorId = 5, EpisodeType = "o", Notes = "oo" }
                );
            modelBuilder.Entity<EnemyEpisode>().HasData(
                new {EnemyId = 1 , EpisodeId = 1 },
                new { EnemyId = 2, EpisodeId = 2 },
                new { EnemyId = 3, EpisodeId = 3 },
                new { EnemyId = 4, EpisodeId = 4 },
                new { EnemyId = 5, EpisodeId = 5 }
                );
            modelBuilder.Entity<CompanionEpisode>().HasData(
                new { CompanionId = 1, EpisodeId = 1 },
                new { CompanionId = 2, EpisodeId = 2 },
                new { CompanionId = 3, EpisodeId = 3 },
                new { CompanionId = 4, EpisodeId = 4 },
                new { CompanionId = 5, EpisodeId = 5 }
                );
        }
    }

}
