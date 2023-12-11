using Messaging.Contracts;

namespace Commands.Handlers.Champagne
{
    public class CreateChampagneCommand(string name) : ICommand<IdResponse>
    {
        public string Name { get; private set; } = name;
    }
}