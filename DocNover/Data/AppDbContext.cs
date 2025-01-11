using DocNover.Domain.Models;
using DocNover.Domain.Models.Authentication;
using Microsoft.EntityFrameworkCore;


namespace DocNover.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topic>().Ignore(c => c.IsExpanded);
            modelBuilder.Entity<Topic>().Ignore(c => c.Topics);
            modelBuilder.Entity<Document>().Ignore(c => c.IsSelected);
        }

        public DbSet<Topic> Topics { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }


    }
}
