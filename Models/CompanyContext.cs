using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using ReactMakeMyTripApp.Models;

namespace ReactMakeMyTripApp.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> options) : base(options) { }
        public DbSet<ReactMakeMyTrip> Makemytrip { get; set; }
    }
}