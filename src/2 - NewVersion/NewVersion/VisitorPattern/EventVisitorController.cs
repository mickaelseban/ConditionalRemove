namespace ConditionalRemove.RefactoredVersion.VisitorPattern
{
    using ConditionalRemove.RefactoredVersion.VisitorPattern.Events;
    using ConditionalRemove.RefactoredVersion.VisitorPattern.Visitor;
    using Dawn;
    using System.Collections.Generic;

    public class EventVisitorController
    {
        private readonly IVisitor _visitor;

        public EventVisitorController(IVisitor visitor)
        {
            Guard.Argument(visitor, nameof(visitor)).NotNull();

            this._visitor = visitor;
        }

        public void Process(IEvent @event)
        {
            @event.Accept(this._visitor);
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
