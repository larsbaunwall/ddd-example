using System;
using Domain.Aggregates.Champagne.ValueObjects;

namespace Domain.Aggregates.Champagne.Events
{
    public record ChampagneRenamed(AggregateId Id, ChampagneName OldName, ChampagneName NewName) : DomainEvent(Id);
}