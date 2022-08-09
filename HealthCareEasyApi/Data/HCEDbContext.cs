using HealthCareEasyApi.Models;
using Microsoft.EntityFrameworkCore;
namespace HealthCareEasyApi.Data
{
    public class HCEDbContext : DbContext
    {
        public HCEDbContext(DbContextOptions<HCEDbContext> opt) : base(opt)
        {

        }
        public DbSet<Benhvien> Benhvien { get; set; }
        public DbSet<Dichvu> Dichvu { get; set; }
    }
}
