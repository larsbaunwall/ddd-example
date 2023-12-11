using Domain;

namespace Messaging.Contracts
{
    public class MessageEnvelope(object payload, EventMetadata metadata)
    {
        public object Payload { get; private set; } = payload;
        public string PayloadType { get; private set; } = payload.GetType().Name;
        public EventMetadata Metadata { get; private set; } = metadata;
    }
}