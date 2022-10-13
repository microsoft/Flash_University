# Interfaces

## Questions from last time
- still have the lingering question about auto properties and Events
- Haven't gotten to it

## Questions I hope to anser
- Interface Defaults
- can an interface inherit an interface
- what does it look like in the CLR
- What are jeffrey's best practices
- when should I use an abstract class vs an interface
- Can you have other things in an interface 
- how do you add properties to an interface?

## Reviews/plan ahead
- I do want to have some dedicated time for going back over chapters 1-3 
- I am planning on putting in some 'review as we go content' if some material repeats
- my 'theory of learning' 
### Schedule
- 10/14 14 Chars and strings and text... oh my
- 10/21 15 Enumerated Types and Bit Flags
- 10/28 16 Arrays
- 11/4 17 Delegates
- 11/11 18 custom attributes
- 11/18 19 Nullable
- 11/25, If you're here, you're responsible for the rest of the book

Depending on the work I have to do (i.e. if i have some Large Object heap/perf stuff), I might throw in 21. 
After that, we'll probably jump to threading 26, 27, 28, 29, and 30. I suspect these chapters will probably be the hardest and Jeffrey will be egging me on while I read them.

And if Flash univeristy still exists after that, we'll finish up part IV core facilities (20, 22, 23, 24 and 25 (seems usless))



## Fundamentals of Interfaces
- a common set of instructions that we can reuse. 
- More concretely, if we know an interface is implemented in an object/type, we know that that object or type can fulfill that function
- If you only remember one thing, the CLR does not support multiple inheritance. Instead, it allows multiple inheritances via Interfaces --> one class can implment n  interfaces.

## Disagreement with Jeffrey
- I think understanding how they work kind of logically answers most of the questions posed.
- See Powerpoint

## Class and Interface Inheritance
- When inheriting a class, we inherit the method signatures
- implementation of the methods
    - Kind fo ties in nicely to what we saw last week with constraints. Constraints didn't modify method signature or implementation so they weren't 'new' or 'different' in the eyes of the CLR
- Jeffrey's definition of an interface = just a set of method signatures
## Defining an Interface
- Interfaces can do a little more than just definte method signatures
- He points us to IDisposable which we saw lastweek --> the method used to dispose of something
- An interface is just like a type definition in the CLR
- Generic interfaces (interfaces that can operate on any type T), exist --> Cannonically Collections or in filestore, ICollections
## Inheriting an Interface
- This is kind of useless
- major takeaways are best seen by example
- what do we think the accessibilities of methods should be
    - remember what private, protected, public etc. mean and what the interface looks like in the CLR
- What modifications, if any, will a method have by default (virtual, partial sealed etc.)
- What happens if we don't use defaults?
    - Example with virtual, virtual sealed

## Calling Interface Methods
- Do you need to voerride methods in base type?
- His code example does this quite well

## Implicit and Explicit Interface Method Implementations

## Generic INterfaces

## Generics and Interface Constants

## Implementing multiple interfaces with same method name and signature

## Improving compile time safety with explicit interface method implementations

## Be careful with explicit interface method implmentations

## base class or interface?

## Definitions

Virtual - Can be overridden by a derived class

Interface - 

Sealed - Can't be overridden by a derived class

EIMI - Explicit Interface Method Implementation