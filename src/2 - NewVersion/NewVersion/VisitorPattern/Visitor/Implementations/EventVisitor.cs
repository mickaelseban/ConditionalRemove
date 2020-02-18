namespace ConditionalRemove.RefactoredVersion.VisitorPattern.Visitor.Implementations
{
    using ConditionalRemove.RefactoredVersion.VisitorPattern.Events.Implementations;

    public class EventVisitor : IVisitor
    {
        public void Visit(EventA @event)
        {
            @event.MyCustomMethodOnA();
        }

        public void Visit(EventB @event)
        {
            @event.MyCustomMethodOnB();
            @event.SomeAdditionalMethodB();
        }

        public void Visit(EventC @event)
        {
            @event.MyCustomMethodOnC();
        }
    }
}
