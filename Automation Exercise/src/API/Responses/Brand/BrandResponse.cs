using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Exercise.src.API.Responses.Brand
{
    public class BrandResponse
    {
        public int ResponseCode { get; set; }
        public List<Brands> Brands { get; set; }
    }
}
