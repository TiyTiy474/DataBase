using Microsoft.EntityFrameworkCore;


namespace DataBase
{
    public class MusicStoreContext : DbContext
    {
        public DbSet<Disc> Discs { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<DiscountCard> DiscountCards { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Sale> Sales { get; set; }
    }
    
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //{
    //// Подключение к базе данных SQLite
    //  optionsBuilder.UseSqlite("Data Source=bookstore.db");
    //}
}

