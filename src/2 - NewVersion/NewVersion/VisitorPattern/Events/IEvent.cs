namespace ConditionalRemove.RefactoredVersion.VisitorPattern.Events
{
    using ConditionalRemove.RefactoredVersion.VisitorPattern.Visitor;

    public interface IEvent
    {
        void Accept(IVisitor visitor);
    }
}
