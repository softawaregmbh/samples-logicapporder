using LogicAppOrder.CRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TRex.Metadata;

namespace LogicAppOrder.CRM.Controllers
{
    public class CustomerController : ApiController
    {
        [HttpGet]
        [Route("api/customer/{customerNumber}")]
        [Metadata("Get Customer Details", "Gets details of the customer")]
        public Task<Customer> GetCustomerById(
            [Metadata("Customer number")]string customerNumber)
        {
            return Task.FromResult(new Customer()
            {
                CustomerName = "Roman Schacherl",
                Email = "roman.schacherl@softaware.at",
                PhoneNumber = "+436644633397"
            });
        }
    }
}
