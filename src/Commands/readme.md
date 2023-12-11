# Command support

A `command` is a self-contained instruction for the domain to atomically execute. Commands always mutate state. All Commands are routed via the [ICommandRouter](../Messaging.Contracts/ICommandRouter.cs) to an appropriate [ICommandHandler<>](../Messaging.Contracts/ICommandHandler.cs).

The `command handler` is solely responsible for orchestrating the infrastructure around fetching, mutating, and persisting, the domain.

As the command handler is working directly with the [domain model](../Domain), the language of the domain language is also involved here.

The command handler _can_ (if necessary) validate any required precondition before handling an event.