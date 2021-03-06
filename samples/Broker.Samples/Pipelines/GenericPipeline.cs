using System;
using System.Threading.Tasks;

namespace Broker.Samples.Pipelines
{
    public class GenericPipeline<TMessage> : IPipeline<TMessage>
    {
        public async Task ExecuteAsync(TMessage message, Func<Task> next)
        {
            Console.WriteLine("Before generic");
            await next().ConfigureAwait(false);
            Console.WriteLine("After generic");
        }
    }
}
