namespace ConditionalRemove.RefactoredVersion.StrategyPattern
{
    using ConditionalRemove.RefactoredVersion.StrategyPattern.Events;
    using ConditionalRemove.RefactoredVersion.StrategyPattern.Strategies;
    using Dawn;
    using System.Collections.Generic;

    public class EventStrategyController
    {
        private readonly IEventStrategy[] _eventStrategies;

        public EventStrategyController(IEventStrategy[] eventStrategies)
        {
            Guard.Argument(eventStrategies, nameof(eventStrategies))
                .NotNull()
                .NotEmpty();

            this._eventStrategies = eventStrategies;
        }

        public void Process(IEvent @event)
        {
            foreach (var messageStrategy in this._eventStrategies)
            {
                if (messageStrategy.CanHandle(@event))
                {
                    messageStrategy.Execute(@event);
                }
            }
        }

        public void Process(IEnumerable<IEvent> events)
        {
            foreach (var message in events)
            {
                this.Process(message);
            }
        }
    }
}
