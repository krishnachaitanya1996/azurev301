using Microsoft.Azure.ServiceBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyStayAPI.AzureServices
{
    public class ServiceBusQueue
    {
        //Connecstring to the namespace can be obtained from the Azure portal under the 'Shared Access policies' section
        const string ServiceBusConnectionString = "Endpoint=sb://mystayservicebust.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=taWP+x6QHoxlOttRniMPzNKyCFG1b0jha365mRo3fzc=";
        const string QueueName = "mystayqueue";
        static IQueueClient queueClient;

        public static async Task AzureServiceBusQueue()
        {
            queueClient = new QueueClient(ServiceBusConnectionString, QueueName);

            //// Register QueueClient's MessageHandler and receive messages in a loop
            //RegisterOnMessageHandlerAndReceiveMessages();

            //Send messages
            await SendMessageAsync();

            await queueClient.CloseAsync();

        }
        static async Task SendMessageAsync()
        {
            try
            {
                string messageBody = $"Send Email";
                var message = new Message(Encoding.UTF8.GetBytes(messageBody));
                await queueClient.SendAsync(message);

            }
            catch (Exception ex)
            {

            }
        }

        //static void RegisterOnMessageHandlerAndReceiveMessages()
        //{
        //    // Configure the MessageHandler Options in terms of exception handling, number of concurrent messages to deliver etc.
        //    var messageHandlerOptions = new MessageHandlerOptions(ExceptionReceivedHandler)
        //    {
        //        // Maximum number of Concurrent calls to the callback `ProcessMessagesAsync`, set to 1 for simplicity.
        //        // Set it according to how many messages the application wants to process in parallel.
        //        MaxConcurrentCalls = 1,

        //        // Indicates whether MessagePump should automatically complete the messages after returning from User Callback.
        //        // False below indicates the Complete will be handled by the User Callback as in `ProcessMessagesAsync` below.
        //        AutoComplete = false
        //    };

        //    // Register the function that will process messages
        //    queueClient.RegisterMessageHandler(ProcessMessagesAsync, messageHandlerOptions);
        //}
        //static async Task ProcessMessagesAsync(Message message, CancellationToken token)
        //{
        //    // Process the message
        //    await SendGridEmail.AzureSendGridEmail();

        //    // Complete the message so that it is not received again.
        //    // This can be done only if the queueClient is created in ReceiveMode.PeekLock mode (which is default).
        //    await queueClient.CompleteAsync(message.SystemProperties.LockToken);

        //    // Note: Use the cancellationToken passed as necessary to determine if the queueClient has already been closed.
        //    // If queueClient has already been Closed, you may chose to not call CompleteAsync() or AbandonAsync() etc. calls 
        //    // to avoid unnecessary exceptions.
        //}

        //static Task ExceptionReceivedHandler(ExceptionReceivedEventArgs exceptionReceivedEventArgs)
        //{
        //    var context = exceptionReceivedEventArgs.ExceptionReceivedContext;
        //    return Task.CompletedTask;
        //}
    }
}
