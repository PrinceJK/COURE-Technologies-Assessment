using API_Challenge.Data;
using API_Challenge.Models;
using API_Challenge.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

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
            var countryIso = new char[3] { '0', '0', '0' };
            for (var i = 0; i < phoneNumber.Length; i++)
            {
                if (i == 3)
                {
                    break;
                }

                countryIso[i] = phoneNumber[i];
                continue;

            }

            var countryIsoToString = new string(countryIso);

            var country = await _dbSet.Where(c => c.CountryCode == countryIsoToString).Include(c => c.CountryDetails)
                .FirstOrDefaultAsync();
            return country;
        }
    }
}
