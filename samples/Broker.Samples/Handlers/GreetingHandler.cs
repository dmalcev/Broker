using System;
using System.Threading.Tasks;
using Broker.Samples.Messages;

namespace Broker.Samples.Handlers
{
    public class GreetingHandler : IHandle<GreetingMessage>
    {
        public Task HandleAsync(GreetingMessage message)
        {
            Console.WriteLine($"Hello {message.Name}");
            return Task.CompletedTask;
        }
    }
}
