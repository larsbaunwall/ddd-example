using System.Collections.Generic;
using Domain.Aggregates.Champagne.ValueObjects;

namespace Domain.Aggregates.Champagne.Commands
{
    public record UpdateGrapeBlend(AggregateId Id, IEnumerable<GrapeBlend> Grapes);
}