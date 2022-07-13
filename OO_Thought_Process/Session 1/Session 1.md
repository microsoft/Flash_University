---
marp: true
theme: default
style: |
    .space {
        margin-top: 1rem
    }

    .questions {
        position: absolute;
        bottom: 2rem;
        font-weight: bold;
        color: #5a626c;
    }

    section.centered * {
        text-align: center;
    }

---

<!-- _class: invert -->
<!-- _footer: '**Covers Chapter 1: "Introduction"**' -->

# Object-Oriented Thought Process
**Session 1 - Fundamental OO Concepts**

<!-- notes
-->

---


# Overview

Course is all about Object-Oriented Programming
Conceptual rather than technical

<div class="space" />

Course is language agnostic, but examples will be in C#
Materials (eg code) in https://github.com/microsoft/Flash_University


<!-- notes
    questions/discussion highly encouraged
    focus on conceptual things & design rather than implementation
    but questions on how it works in C# - ask!
-->

---


# Paradigms

Many programming paradigms
> Procedural, Object-Oriented, Functional, Logic, etc

<div class="space" />
OO compliments other paradigms

<p class="questions">What makes a paradigm? When to use one or another></p>

<!-- notes
    my answer: paradigm is a way of thinking/modeling
    
    language != paradigm
    most languages have aspects of multiple paradigms
        (C# has delegates, LINQ)
-->


---


# Fundamental Concepts of OO

1. Encapsulation
2. Inheritance
3. Polymorphism
4. Composition

<!-- notes
-->


---


# Comparison with Procedural Programming

**Procedural Programming**
 - data & behavior are split
 - data is often global with unpredictable access
 - pure data is passed to procedure

<div class="space" />

**Object-Oriented Programming**
 - data & behavior are stored together in Objects
 - objects control access to contained data
 - data & behavior are passed together

<!-- notes
    agree? disagree?
-->


---


# Objects

Building block of an OO program
 - **Data** (attributes) represents its state
 - **Behavior** (methods) represents what it can do

<div class="space" />

Objects control access to contained members

Calling a method = "sending a message to the object"

<p class="questions">Is thinking in terms of objects natural for you?</p>

<!-- notes
-->


---


# Classes

Class = Object Blueprint

A class defines the attributes & behaviors for its objects

Classes are pieces of code

<!-- notes
    Objects are runtime instantiations/manifestations of a class
-->


---


# Encapsulation

Interface - what is exposed to other objects
Implementation - all of the internal details not exposed in the interface

**Can change the implementation without affecting the interface**

<!-- notes
    can see this on a micro & macro level
    (object interfaces, library APIs, web APIs, etc)
-->


---


# Encapsulation

Interface = the fundamental means of communication between objects
Ideally, only what is necessary for interaction is exposed

<div class="space" />

**Rule of Thumb:** Don't expose attributes directly
> Security, testing, maintenance, etc

<p class="questions">What's the reason for this Rule of Thumb?</p>

<!-- notes
    my answer:
    attributes are part of the implementation (they are the state)
    exposing attributes ties the interface to the implementation

    example: https://github.com/microsoft/Flash_University/tree/main/OO_Thought_Process/Session%201/Encapsulation
-->


---


# Inheritance

Enables class to inherit attributes & methods of another class

Allows abstracting out behavior from a class

**"is-a relationship"**

<div class="space" />

Can be difficult to tell how much abstraction is required

<p class="questions">How do you think about when to abstract?</p>

<!-- notes
    some languages have multiple inheritance (not C#)

    example: https://github.com/microsoft/Flash_University/tree/main/OO_Thought_Process/Session%201/Inheritance
-->


---


# Polymorphism

Multiple different objects having a common interface

Same code can use different objects without any modification

<div class="space" />

Polymorphism is typically implemented via inheritance

> Example - Shapes

<p class="questions"></p>

<!-- notes
    different implementations of the same interface

    2 components
     - use subclass as superclass
     - and invoke method which invoke's the subclass's method
        ("abstract" or "virtual")

    example: https://github.com/microsoft/Flash_University/tree/main/OO_Thought_Process/Session%201/Polymorphism
-->


---


# Composition

Objects can contain other objects

Another means of abstraction

**"has-a relationship"**

<p class="questions">When should you use Composition? When should you use Inheritance?</p>

<!-- notes
    my answer:
        both means of abstraction
        "is-a" vs "has-a"
        if you don't want to expose some parts of the base class - composition
        if you only want to refine behavior - inheritance

    Shape > Rectangle > Square

    example: https://github.com/microsoft/Flash_University/tree/main/OO_Thought_Process/Session%201/Composition
-->


---


<!-- _class: centered invert -->

# Additional Questions/Discussion
Examples: https://github.com/microsoft/Flash_University


<!-- notes
    These concepts are not easy to separate from each other
    They also provide multiple ways of doing things
-->

