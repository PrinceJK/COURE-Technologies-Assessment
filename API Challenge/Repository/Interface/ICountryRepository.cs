using System.Threading.Tasks;
using API_Challenge.Models;
using API_Challenge.Models.DTOs;

namespace API_Challenge.Repository.Interface
{
    public interface ICountryRepository
    {
        Task<Response> GetCountryByNumber(string number);
    }
}
