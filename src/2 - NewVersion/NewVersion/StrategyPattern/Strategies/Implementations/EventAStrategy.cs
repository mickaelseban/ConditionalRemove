namespace ConditionalRemove.RefactoredVersion.StrategyPattern.Strategies.Implementations
{
    using ConditionalRemove.RefactoredVersion.StrategyPattern.Events;
    using ConditionalRemove.RefactoredVersion.StrategyPattern.Events.Implementations;
    using Dawn;

    internal class EventAStrategy : IEventStrategy
    {
        public bool CanHandle(IEvent @event)
        {
            return @event?.GetType() == typeof(EventA);
        }

        public void Execute(IEvent @event)
        {
            Guard.Argument(@event, nameof(@event)).Cast<EventA>();

            var eventA = (EventA)@event;
            eventA.MyCustomMethodOnA();
        }
    }
}
