using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace MobileStore.Models
{
    public class MobileContext: DbContext
    {
        public System.Data.Entity.DbSet<Phone> Phones { get; set; }
        public System.Data.Entity.DbSet<Order> Orders { get; set; }
        public MobileContext(DbContextOptions<MobileContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

    }
}