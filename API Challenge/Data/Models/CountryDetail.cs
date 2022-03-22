using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Challenge.Data.Models
{
    public class CountryDetail
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Operator { get; set; }
        public string OperatorCode { get; set; }
    }
}
