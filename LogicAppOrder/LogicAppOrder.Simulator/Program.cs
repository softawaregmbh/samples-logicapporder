using Microsoft.ServiceBus.Messaging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicAppOrder.Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = QueueClient.CreateFromConnectionString("Endpoint=sb://logicapporder.servicebus.windows.net/;SharedAccessKeyName=SendKey;SharedAccessKey=lLDlSLxC9Cox2YfG7G0qAmsNpFFWTCTyIJd8FKY1L/Q=;EntityPath=orders");

            var messages = client.ReceiveBatch(10, TimeSpan.FromSeconds(1));
            foreach (var m in messages)
            {
                Console.WriteLine("Deleting message...");
                m.Complete();
            }

            var order = new
            {
                customerNumber = "1234",
                articleNumber = "A300",
                pricePerItem = 12.50,
                amount = 100
            };

            var json = JsonConvert.SerializeObject(order);

            var message = new BrokeredMessage(new MemoryStream(Encoding.UTF8.GetBytes(json)));
            
            client.Send(message);
            Console.WriteLine("Sent message:");
            Console.WriteLine(json);

            Console.ReadKey();
        }
    }
}
