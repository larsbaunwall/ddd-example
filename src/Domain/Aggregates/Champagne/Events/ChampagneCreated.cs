using System;
using Domain.Aggregates.Champagne.ValueObjects;

namespace Domain.Aggregates.Champagne.Events
{
    public record ChampagneCreated(AggregateId Id, ChampagneName Name) : DomainEvent(Id);
}