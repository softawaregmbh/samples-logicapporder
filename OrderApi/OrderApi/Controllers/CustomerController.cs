using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderApi.Models;
using SwashBuckle.AspNetCore.MicrosoftExtensions.Attributes;

namespace OrderApi.Controllers
{
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpGet]
        [Route("api/customer/{customerNumber}")]
        [Metadata("Get Customer Details", "Gets details of the customer")]
        public Task<Customer> GetCustomerById([Metadata("Customer number")]string customerNumber)
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