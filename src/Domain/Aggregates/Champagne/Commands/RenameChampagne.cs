using Domain.Aggregates.Champagne.ValueObjects;

namespace Domain.Aggregates.Champagne.Commands
{
    public record RenameChampagne(AggregateId Id, ChampagneName NewName);
}