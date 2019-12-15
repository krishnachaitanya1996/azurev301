using Microsoft.Azure.EventHubs;
using MyStay.Core.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStayAPI.AzureServices
{
    public class EventHubPost
    {
        private static EventHubClient eventHubClient;
        private const string  EventHubConnectionString = "Endpoint=sb://mystayeventhub.servicebus.windows.net/;SharedAccessKeyName=MyStayEventHubPolicy;SharedAccessKey=f2zM2uzu6TeLbgI3yU/DeLrTfyYUltJE5jIvHGuGDvc=;EntityPath=mystaycreateeventhub";
        private const string EventHubName = "mystaycreateeventhub";

        public static async Task PostToEventHub(Booking booking)
        {
            // Creates an EventHubsConnectionStringBuilder object from the connection string, and sets the EntityPath.
            // Typically, the connection string should have the entity path in it, but this simple scenario
            // uses the connection string from the namespace.
            var connectionstringBuilder = new EventHubsConnectionStringBuilder(EventHubConnectionString)
            {
                EntityPath = EventHubName
            };

            eventHubClient = EventHubClient.CreateFromConnectionString(connectionstringBuilder.ToString());

            await SendMessagesToEventHub(booking);

            await eventHubClient.CloseAsync();

        }

        // Creates an event hub client and sends 100 messages to the event hub.
        private static async Task SendMessagesToEventHub(Booking booking)
        {
                try
                {
                    await eventHubClient.SendAsync(new EventData(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(booking))));
                }
                catch (Exception exception)
                {
                    
                }
        }

    }
}
