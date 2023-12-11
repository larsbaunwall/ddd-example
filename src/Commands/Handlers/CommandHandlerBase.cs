using Domain.Persistence;

namespace Commands.Handlers
{
    public abstract class CommandHandlerBase(IPublishingAggregateRepository aggregateRepo)
    {
        protected readonly IPublishingAggregateRepository AggregateRepo = aggregateRepo;
    }
}