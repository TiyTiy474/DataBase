using Microsoft.EntityFrameworkCore;

namespace DataBase
{
    // Контекст базы данных для музыкального магазина
    public class MusicStoreContext : DbContext
    {
        // Набор данных для дисков
        public DbSet<Disc> Discs { get; set; }
        
        // Набор данных для артистов
        public DbSet<Artist> Artists { get; set; }
        
        // Набор данных для дисконтных карт
        public DbSet<DiscountCard> DiscountCards { get; set; }
        
        // Набор данных для работодателей
        public DbSet<Employer> Employers { get; set; }
        
        // Набор данных для продаж
        public DbSet<Sale> Sales { get; set; }

        // Метод настройки подключения к базе данных
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // строка подключения к бд
        }

    }
}