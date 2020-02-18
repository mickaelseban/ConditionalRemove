namespace ConditionalRemove.RefactoredVersion.StrategyPattern.Strategies
{
    using ConditionalRemove.RefactoredVersion.StrategyPattern.Events;

    public interface IEventStrategy
    {
        bool CanHandle(IEvent @event);

        void Execute(IEvent @event);
    }
}
