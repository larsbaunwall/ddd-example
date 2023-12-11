using System.Threading.Tasks;
using Confluent.Kafka;
using Domain;
using Messaging.Contracts;
using Microsoft.Extensions.Options;

namespace Messaging.Kafka
{
    public class KafkaPublisher(ISerializingProducer<Null, object> producer, IOptions<MessagingConfig> config)
        : IEventPublisher
    {
        private readonly MessagingConfig _config = config.Value;

        public async Task PublishAsync<TEvent>(TEvent @event, EventMetadata metadata) where TEvent : IDomainEvent
        {
            var envelope = new MessageEnvelope(@event, metadata);
            var topic = Convention.TopicName(_config.BoundedContext, @event.GetType().Name);
            
            var res = await producer.ProduceAsync(topic, null, envelope);

            if (res.Error.HasError)
                throw new PublishingException(res.Error.Reason);
        }
    }
}