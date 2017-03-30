using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LogicAppOrder.DeliveryNotification.Models
{
    public class SubscriptionData
    {
        public string CallbackUrl { get; set; }

        public string OrderId { get; set; }
    }
}