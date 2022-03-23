using System.Linq;
using System.Runtime.CompilerServices;
using API_Challenge.Models;
using API_Challenge.Repository.Interface;
using System.Threading.Tasks;
using API_Challenge.Data;
using Microsoft.EntityFrameworkCore;

namespace API_Challenge.Repository.Implementation
{
    public class CountryRepository : ICountryRepository
    {
        private readonly ApiContext _context;
        private readonly DbSet<Country> _dbSet;

        public CountryRepository(ApiContext context)
        {
            _context = context;
            _dbSet = _context.Set<Country>();
        }
        public async Task<Country> GetCountryByNumber(string phoneNumber)
        {
            var countryIso = new int[3] {0,0,0 };
            for (int i = 0; i < phoneNumber.Length; i++)
            {
                if (i == 3)
                {
                    break;
                }

                countryIso[i] = phoneNumber[i];
                continue;
                
            }

            var cs =string.Join("", from i in countryIso select i.ToString());

            var country = await _dbSet.Where(c => c.CountryIso == cs).Include(c => c.CountryDetails)
                .FirstOrDefaultAsync();
            return country;
        }
    }
}
