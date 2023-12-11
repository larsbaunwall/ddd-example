# The domain: The core of software

The `Domain` is the core of our software, which fully encapsulate and contain all data concepts, invariants, and requirements, that is valid within our bounded context.

The domain is the innermost layer in our bounded context and thus have no dependencies outside of the domain. It is self-contained. Persisting state changes are done by the [Domain.Persistence](../Domain.Persistence) layer, orchestrated by the commandhandler.

The domain is organized around two central concepts: `Aggregates` and `Domain events`.

**Aggregates** are the [composition roots](https://microservices.io/patterns/data/aggregate.html) for our domain entities. E.g. the root for any `Champagne` property (including embedded types/sub-graphs) belongs in the [Champagne aggegate](Aggregates/Champagne/Champagne.cs). The heavy lifting of implementing an internal event-driven model in the domain model is handled in the [Aggregate baseclass](Aggregates/Aggregate.cs).

**Domain events** are the direct result of a mutation on the domain model. These are emitted through raising events via the aggregate whenever state is mutated in the model. The events are later used for persisting the final state of the write model, for building a number of [projections](../Projections), or converting to and emitting external `integration events`. Read more about the Domain Event pattern [here](https://microservices.io/patterns/data/domain-event.html).