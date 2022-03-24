﻿using API_Challenge.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace API_Challenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        private readonly ICountryRepository _countryRepository;

        public CountryController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string number)
        {
            var response = await _countryRepository.GetCountryByNumber(number);
            return StatusCode((int)HttpStatusCode.OK, response);
        }
    }
}
