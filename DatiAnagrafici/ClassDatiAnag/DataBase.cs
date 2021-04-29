using Microsoft.EntityFrameworkCore;

namespace DatiAnagrafici.ClassDatiAnag
{
    public class DataBase : DbContext
    {
        public DbSet<DatiAnag> dati { get; set; }

        public DataBase(DbContextOptions options) : base(options) { }
    }
}
