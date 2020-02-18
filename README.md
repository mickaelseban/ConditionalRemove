# IF Condition Remove - Demo

In order to remove the IF condition and optimize the followed code block, 
I took two different approachs the GOF - Strategy Pattern and The GOF Visitor Pattern.


For GOF - Strategy Pattern, the definition in the wikipedia is:
In computer programming, the strategy pattern (also known as the policy pattern) 
is a behavioral software design pattern that enables selecting an algorithm at runtime.

For GOF - Visitor Pattern, the definition in the wikipedia is:
In object-oriented programming and software engineering, the visitor design pattern is a way of separating an algorithm from an object structure on which it operates. A practical result of this separation is the ability to add new operations to existing object structures without modifying the structures. It is one way to follow the open/closed principle.

## Original Code

```c#
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
```
