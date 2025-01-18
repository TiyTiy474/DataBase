namespace DataBase
{
    // Диск
    public class Disc
    {
        public int DiscID { get; set; }
        public string DiscName { get; set; }
        public string ArtistName { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public int ArtistId { get; set; }
        public int GenreId { get; set; }
        public bool isKaraoke { get; set; }
    }

    // Артист(автор)
    public class Artist
    {
        public int ArtistID { get; set; }
        public string Name { get; set; }
        public List<Disc> Discs { get; set; } = new List<Disc>();
    }

    // Дисконтная карта
    public class DiscountCard
    {
        public int CardID { get; set; }
        public string CardNumber { get; set; }
        public decimal DiscountPercentage { get; set; }
    }

    // Работодатель
    public class Employer
    {
        public int EmployerID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
    }

    // Продажи
    public class Sale
    {
        public int SaleID { get; set; }
        public Disc SoldDisc { get; set; }
        public Employer Seller { get; set; }
        public string Location { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal SalePrice { get; set; }
        public int DiscountCardID { get; set; }
        public string DiscoubtCard { get; set; }
    }
}