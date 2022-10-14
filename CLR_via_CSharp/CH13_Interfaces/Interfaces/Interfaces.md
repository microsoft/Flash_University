# Interfaces

## Questions from last time
- still have the lingering question about auto properties and Events
- Haven't gotten to it

## Questions I hope to answer
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
### Schedule
- 10/14 14 Chars and strings and text... oh my (seriously, this thing is 50 pages)
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
- If you remember one more thing, it's how Interfaces Work. The rest of this is almost completely derivable from that.

## Disagreement with Jeffrey
- I think understanding how they work kind of logically answers most of the questions posed.
- See Powerpoint

## Class and Interface Inheritance
- When inheriting a class, we inherit the method signatures
- implementation of the methods
    - Kind of ties in nicely to what we saw last week with constraints. Constraints didn't modify method signature or implementation so they weren't 'new' or 'different' in the eyes of the CLR
## Defining an Interface
- Interfaces can do a little more than just definte method signatures
- He points us to IDisposable which we saw lastweek --> the method used to dispose of something
- An interface is just like a type definition in the CLR
- Generic interfaces (interfaces that can operate on any type T), exist --> Cannonically Collections or in filestore, ICollections
## Inheriting an Interface
- what do we think the accessibilities of methods should be
    - remember what private, protected, public etc. mean and what the interface looks like in the CLR
- What modifications, if any, will a method have by default (virtual, partial sealed etc.)
- What happens if we don't use defaults?
    - Example with virtual, virtual sealed

## Calling Interface Methods
- Do you need to voerride methods in base type?
- His code example does this quite well

## Implicit and Explicit Interface Method Implementations
- he spends way, way too long on EIMI's esp when he starts off the secion about them with "they are rare"

## Generic Interfaces
- The exist, use em
- help prevent boxing, if we remember last week, boxing was pretty expensive
- Compile time safety
- can implement same interface multiple times as long as different type parameters are used

## Generics and Interface Constraints
-

## Be careful with explicit interface method implmentations
- EIMIs are rare, use sparingly.
- Classic ish example of what happens is my first attempt at dot chess

## base class or interface?
### IS A vs Can-do
- If is a, use base type; definitely don't use interface
### Ease of use
- generally easier to define a new type rather than reimplement. Can help limit modifications
- beware of the telescope 
### Consistency
- maintaining fewer types across the board will make things more consistent
### Versioning 
- if you have a base type, all you ever have to update is the base type for the inherited types to automatically update

You have a class sponge and you want to create a class spongebob that can talk, should you add an interface to sponge into a new class or derive a the old class and explicitly add the method?

## Definitions

Virtual - Can be overridden by a derived class

Interface - Per Jeffrey, 'just a set of methods

Sealed - Can't be overridden by a derived class

EIMI - Explicit Interface Method Implementation