using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace BarterAppSolution.API.Models
{
    public class ServiceResult<T>
    {
        public HttpStatusCode statusCode { get; set; }
        public bool isSuccess { get; set; }
        public T dataToReturn { get; set; }
        public string explanation { get; set; }
    }
}
