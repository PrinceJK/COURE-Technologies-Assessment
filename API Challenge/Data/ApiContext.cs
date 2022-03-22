using API_Challenge.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Challenge.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }

        public DbSet<Country> Countries {get; set;}
        public DbSet<CountryDetail> CountryDetails { get; set; }

    }
}
