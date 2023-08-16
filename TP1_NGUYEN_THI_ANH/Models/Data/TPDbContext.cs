using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;



namespace TP2.Models.Data
{
    public class TPDbContext: DbContext
    {

        public TPDbContext(DbContextOptions<TPDbContext> options) : base(options) 
        { 
        }

        public DbSet<Enfant> Enfants { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.SetEntityRelationships();
            modelBuilder.GenerateData();

            base.OnModelCreating(modelBuilder);
        }
    }
}
