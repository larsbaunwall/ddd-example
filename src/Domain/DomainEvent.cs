using System;

namespace Domain
{
    public abstract record DomainEvent(AggregateId Id) :
    IDomainEvent;
}