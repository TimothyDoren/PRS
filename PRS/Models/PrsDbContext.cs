using Microsoft.EntityFrameworkCore;

namespace PRS.Models
{
    public class PrsDbContext : DbContext
    {
        public DbSet<User> Users { get; set; } = null!; 
        public DbSet<Vendor> Vendors { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Request> Requests { get; set; } = null!;
        public DbSet<RequestLine> RequestLines { get; set; } = null!;

        public PrsDbContext(DbContextOptions<PrsDbContext> options) : base(options) { }
    }
}
