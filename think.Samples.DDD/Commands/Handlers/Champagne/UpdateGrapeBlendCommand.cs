using System;
using System.Collections.Generic;
using Messaging.Contracts;

namespace Commands.Handlers.Champagne
{
    public class UpdateGrapeBlendCommand(Guid champagneId, IEnumerable<(double Percentage, string GrapeVariety)> grapes)
        : ICommand<Response>
    {
        public Guid ChampagneId { get; private set; } = champagneId;
        public IEnumerable<(double Percentage, string GrapeVariety)> Grapes { get; private set; } = grapes;
    }
}