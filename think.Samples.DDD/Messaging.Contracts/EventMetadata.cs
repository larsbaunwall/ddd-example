using System;

namespace Messaging.Contracts
{
    public class EventMetadata(DateTimeOffset eventDate, Guid correlationId, int sequence)
    {
        public DateTimeOffset EventDate { get; } = eventDate;
        public Guid CorrelationId { get; } = correlationId;
        public int Sequence { get; } = sequence;
    }
}