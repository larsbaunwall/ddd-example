using System;
using System.Collections.Generic;
using Domain.Aggregates.Champagne.ValueObjects;

namespace Domain.Aggregates.Champagne.Events
{
    public record GrapeBlendUpdated(AggregateId Id, IEnumerable<GrapeBlend> UpdatedBlend) : DomainEvent(Id);
}