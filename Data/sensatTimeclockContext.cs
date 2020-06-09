using Microsoft.EntityFrameworkCore;

namespace sendsatTimeclock.Data
{
    public class sendsatTimeclockContext : DbContext
    {
        public sendsatTimeclockContext (
            DbContextOptions<sendsatTimeclockContext> options)
            : base(options)
        {
        }

        public DbSet<sendsatTimeclock.Models.User> User { get; set; }
    }
}