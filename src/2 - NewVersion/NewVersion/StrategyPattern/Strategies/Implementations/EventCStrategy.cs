namespace ConditionalRemove.RefactoredVersion.StrategyPattern.Strategies.Implementations
{
    using ConditionalRemove.RefactoredVersion.StrategyPattern.Events;
    using ConditionalRemove.RefactoredVersion.StrategyPattern.Events.Implementations;
    using Dawn;

    internal class EventCStrategy : IEventStrategy
    {
        public bool CanHandle(IEvent @event)
        {
            return @event?.GetType() == typeof(EventC);
        }

        public void Execute(IEvent @event)
        {
            Guard.Argument(@event, nameof(@event)).Cast<EventC>();

            var eventC = (EventC)@event;

            eventC.MyCustomMethodOnC();
        }
    }
}
