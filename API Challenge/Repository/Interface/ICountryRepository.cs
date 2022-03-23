using System.Threading.Tasks;
using API_Challenge.Models;

namespace API_Challenge.Repository.Interface
{
    public interface ICountryRepository
    {
        Task<Country> GetCountryByNumber(string phoneNumber);
    }
}
