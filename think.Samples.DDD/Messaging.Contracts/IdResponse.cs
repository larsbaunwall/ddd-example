using System;

namespace Messaging.Contracts
{
    public class IdResponse(Guid id)
    {
        public Guid Id { get; private set; } = id;
    }
}