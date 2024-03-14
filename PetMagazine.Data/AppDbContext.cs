namespace PetMagazine.Data
{
    using Microsoft.EntityFrameworkCore;
    using PetMagazine.Data.Models;
    public class AppDbContext:DbContext
    {
        private const string ConnectionString = @"Server=DESKTOP-G43Q1LS; Database=PetDb; Trusted_Connection=True; TrustServerCertificate=True";

        public DbSet<Pet> MyProperty { get; set; }

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
