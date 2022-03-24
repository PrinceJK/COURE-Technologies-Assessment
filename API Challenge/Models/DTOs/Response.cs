using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_Challenge.Models.DTOs
{
    public class Response<T>
    {
        public T Parameter { get; set; }
        public T Data { get; set; }

    }
}
