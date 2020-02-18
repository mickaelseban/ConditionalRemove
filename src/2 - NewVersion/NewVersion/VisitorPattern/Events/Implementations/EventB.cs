namespace ConditionalRemove.RefactoredVersion.VisitorPattern.Events.Implementations
{
    using ConditionalRemove.RefactoredVersion.VisitorPattern.Visitor;

    public class EventB : IEvent
    {
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void MyCustomMethodOnB()
        {
            return;
        }

        public void SomeAdditionalMethodB()
        {
            return;
        }
    }
}
