using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderApi.Models;

namespace OrderApi.Controllers
{
    [ApiController]
    public class DeliveryController : ControllerBase
    {
        [HttpPost]
        [Route("api/delivery/subscribe")]
        public IActionResult Subscribe([FromBody]SubscriptionData subscriptionData)
        {
            return this.Ok();
        }

        [HttpPost]
        [Route("api/delivery/unsubscribe")]
        public IActionResult Unsubscribe([FromBody]SubscriptionData subscriptionData)
        {
            return this.Ok();
        }
    }
}