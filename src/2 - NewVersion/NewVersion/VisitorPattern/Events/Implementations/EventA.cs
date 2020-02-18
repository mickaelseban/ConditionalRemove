namespace ConditionalRemove.RefactoredVersion.VisitorPattern.Events.Implementations
{
    using ConditionalRemove.RefactoredVersion.VisitorPattern.Visitor;

    public class EventA : IEvent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void MyCustomMethodOnA()
        {
        }
    }
}
