using LogicAppOrder.DeliveryNotification.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace LogicAppOrder.DeliveryNotification.Controllers
{
    public class DeliveryController : ApiController
    {
        [HttpPost]
        [Route("api/delivery/subscribe")]
        public HttpResponseMessage Subscribe([FromBody]SubscriptionData subscriptionData)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpPost]
        [Route("api/delivery/unsubscribe")]
        public HttpResponseMessage Unsubscribe([FromBody]SubscriptionData subscriptionData)
        {
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
