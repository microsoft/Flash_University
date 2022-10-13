# Interfaces

## Questions from last time
- still have the lingering question about auto properties and Events
- Haven't gotten to it

## Lingering Questions I have while reading
- can an interface inherit an interface
- what is the scope of an interface
- what does it look like in the CLR
- What are jeffrey's best practices
- when should I use an abstract class vs an interface
- Can you have other things in an interface 
- What is reflection

## Reviews?

## Fundamentals of Interfaces
- a common set of instructions that we can reuse. 
- More concretely, if we know an interface is implemented in an object/type, we know that that object or type can fulfill that function
- If you only remember one thing, the CLR does not support multiple inheritance. Instead, it allows multiple inheritances via Interfaces --> one class can implment n  interfaces.
## Class and Interface Inheritance
- When inheriting a class, we inherit the method signatures
- implementation of the methods
    - Kind fo ties in nicely to what we saw last week with constraints. Constraints didn't modify method signature or implementation so they weren't 'new' or 'different' in the eyes of the CLR
- Jeffrey's definition of an interface = just a set of method signatures
## Defining an Interface
- Interfaces can do a little more than just definte method signatures
- He points us to IDisposable which we saw lastweek --> the method used to dispose of something
- An interface is just like a type definition in the CLR
- 
## Inheriting an Interface

## Calling Interface Methods

## Implicit and Explicit Interface Method Implementations

## Generic INterfaces

## Generics and Interface Constants

## Implementing multiple interfaces with same method name and signature

## Improving compile time safety with explicit interface method implementations

## Be careful with explicit interface method implmentations

## base class or interface?