using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM_PricingBooks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductPriceController
    {
        [HttpGet]
        public IEnumerable<string> GetAll()
        {
            return new string[] { };
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{ProductCode}")]
        public void Put(string ProductCode, [FromBody] string value)
        {
        }

        [HttpDelete]
        public void Delete ()
        {
        }
        
    }
}
