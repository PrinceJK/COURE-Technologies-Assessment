﻿namespace API_Challenge.Data.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string CountryIso { get; set; }
        public CountryDetail CountryDetail { get; set; }
    }
}