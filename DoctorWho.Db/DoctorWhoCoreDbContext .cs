using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DoctorWho.Db
{
    public class DoctorWhoCoreDbContext:DbContext
    {
        public DoctorWhoCoreDbContext()
        {

        }
        public DbSet<Companion> Companions { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Enemy> Enemies { get; set; }
        public DbSet<Episode> Episodes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-6PEJGCB;Initial Catalog=DoctorWhoCore;Integrated Security=True");
        }
       /* protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }*/
    }
  
}
