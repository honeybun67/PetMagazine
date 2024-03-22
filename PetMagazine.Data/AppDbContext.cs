namespace PetMagazine.Data
{
    using Microsoft.EntityFrameworkCore;
    using PetMagazine.Data.Models;
    public class AppDbContext:DbContext
    {
        //private const string ConnectionString = @"Server=DESKTOP-IMH7B1C\MSSQLSERVER02; Database=PetDb; Trusted_Connection=True; TrustServerCertificate=True";
        private const string ConnectionString = @"Server=.; Database=PetDb; Trusted_Connection=True; TrustServerCertificate=True";

        public DbSet<Pet> Pets { get; set; }

        public DbSet<PetCategory> PetCategories { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(ConnectionString)
                    .UseLazyLoadingProxies();
            }
        }
    }
}
