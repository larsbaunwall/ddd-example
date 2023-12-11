using Lamar;
using Marten.Events;
using Messaging.Contracts;

namespace Messaging
{
    public class LamarEventHandlerFactory(IServiceContext context) : IEventHandlerFactory
    {
        public IEventHandler<TEvent> GetEventHandler<TEvent>()
        {
            return context.GetInstance<IEventHandler<TEvent>>();
        }
    }
}