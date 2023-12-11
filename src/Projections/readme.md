# The projections (readmodels)

The Projections assembly contains separate readmodels (`projections`) that can be build, deployed, and operated, independently of the write model (the aggregate data store).

The project contains:

**Event handlers** responsible for processing domain events and building readmodels or other form of projections.

**Queries** that encapsulate (and possibly orchestrate) any necessary query logic on top of the projections.


[Event handlers](EventHandlers) in this project are invoked by a [Kafka consumer](../Messaging/Kafka/KafkaConsumer.cs) via the [IEventhandlerFactory](../Messaging.Contracts/IEventHandlerFactory.cs). 

The readmodels are [eventually consistent](https://en.wikipedia.org/wiki/Eventual_consistency). This is an important concept to be aware of, but also unlocks massive scalability in terms of complete free choice of data stores, technology stacks, geographic distribution, etc., for read queries that support support modern and instant experiences ([reactive](https://www.reactivemanifesto.org/) architectures).