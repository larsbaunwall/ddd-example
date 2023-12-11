using System;
using Messaging.Contracts;

namespace Commands.Handlers.Champagne
{
    public class RenameChampagneCommand(Guid champagneId, string newName) : ICommand<Response>
    {
        public Guid ChampagneId { get; private set; } = champagneId;
        public string NewName { get; private set; } = newName;
    }
}