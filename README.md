# DDD Sample for Marten and Kafka
For now, I have a working structure for command handlers, eventsourced domain model and one eventhandler for updating a readmodel.


## Getting started
Dive into the [/src](src) folder for the first bit. I've written helping notes and tips in the major project root folders.

## Technologies used
I'm playing a bit around with these technologies for now:
* [Marten](http://jasperfx.github.io/marten/) (a really clever document store abstraction over Postgres). It's used for storing the eventstream from the domain events
* [Kafka](https://github.com/confluentinc/confluent-kafka-dotnet/) for distributing events in a distributed way. My local Kafka is running on docker using the wurstmeister/kafka image. Please know that I am completely new to Kafka, so this is a very preliminar implementation.
* [Lamar](https://jasperfx.github.io/lamar/) (the new beginning of StructureMap) for IoC

## Roadmap
I'm still working out the structure of this project, but eventually, I'm hoping to have a good starter template with some pluggable infrastructure for a DDD application (a bounded context)

For now, I'm definately working on:
* Polishing the last bits
* An example of a query handler infrastructure using the readmodel (the Q side in CQRS)
* Tests, tests, tests

## I love champagne!
If you've been looking a bit at the code, you've probably stumbled upon a nice little champagne domain! The champagne comes from a personal hobby of mine - and from applying it at a startup working on champagne experiences (the startup failed, but the ideas survived).

## Contributing
I would love some help along the way - feel free to reach out to me here @GitHub or catch me @ larslb@thinkability.dk.

Cheers!
Lars
