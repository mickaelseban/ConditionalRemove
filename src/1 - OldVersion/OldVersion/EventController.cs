namespace ConditionalRemove.OldVersion
{
    using ConditionalRemove.OldVersion.Events;

    public class EventController
    {
        public void Process(object @event)
        {
            if (@event is EventA)
            {
                var eventA = @event as EventA;
                eventA?.MyCustomMethodOnA();
            }
            else if (@event is EventB)
            {
                var eventB = @event as EventB;
                eventB?.MyCustomMethodOnB();
            }
            if (@event is EventC)
            {
                var eventC = @event as EventC;
                eventC?.MyCustomMethodOnC();
            }
        }
    }
}
