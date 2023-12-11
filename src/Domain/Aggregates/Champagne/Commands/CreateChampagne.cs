using Domain.Aggregates.Champagne.ValueObjects;

namespace Domain.Aggregates.Champagne.Commands
{
    public record CreateChampagne(AggregateId Id, ChampagneName Name);
}