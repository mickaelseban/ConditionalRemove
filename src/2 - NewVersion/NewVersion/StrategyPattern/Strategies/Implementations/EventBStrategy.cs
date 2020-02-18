namespace ConditionalRemove.RefactoredVersion.StrategyPattern.Strategies.Implementations
{
    using ConditionalRemove.RefactoredVersion.StrategyPattern.Events;
    using ConditionalRemove.RefactoredVersion.StrategyPattern.Events.Implementations;
    using Dawn;

    internal class EventBStrategy : IEventStrategy
    {
        public bool CanHandle(IEvent @event)
        {
            return @event?.GetType() == typeof(EventB);
        }

        public void Execute(IEvent @event)
        {
            Guard.Argument(@event, nameof(@event)).Cast<EventB>();

            var eventB = (EventB)@event;

            eventB.MyCustomMethodOnB();
            eventB.SomeAdditionalMethodB();
        }
    }
}
