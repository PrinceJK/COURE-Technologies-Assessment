using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace API_Challenge.Data
{
    public class Seeder
    {
        public static Task SeedData()
        {
            var options = new DbContextOptions<ApiContext>()
                .UseInMemoryDatabase(databaseName: "Test")
                .Options;
        }
    }
}
