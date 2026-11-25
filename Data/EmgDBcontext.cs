using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using Emergency_R_S.Models;
namespace Emergency_R_S.Data
{
    public class EmgDBcontext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Emergency> Emergencies { get; set; }

        public EmgDBcontext()
        {
        }
        public EmgDBcontext(DbContextOptions<EmgDBcontext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=DESKTOP-6T7E2SL\\SQLEXPRESS;Database=Emergency_R_S;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


        }
    }
}
