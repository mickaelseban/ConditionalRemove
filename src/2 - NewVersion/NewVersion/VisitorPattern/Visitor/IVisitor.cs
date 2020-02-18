namespace ConditionalRemove.RefactoredVersion.VisitorPattern.Visitor
{
    using ConditionalRemove.RefactoredVersion.VisitorPattern.Events.Implementations;

    public interface IVisitor
    {
        void Visit(EventA @event);

        void Visit(EventB @event);

        void Visit(EventC @event);
    }
}
