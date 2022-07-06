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
        opacity: .75;
        /* color - slate blue? */
    }

    section.centered * {
        text-align: center;
    }

---

<!-- _class: invert -->
<!-- _footer: '**Covers Chapter 1: "Introduction"**' -->

# Object-Oriented Thought Process
**Session 1 - Introduction**


<!-- notes
    questions/discussion welcome throughout
    focus on conceptual things & design
-->

---


# Paradigms

Many programming paradigms
> Procedural, Object-Oriented, Functional, Logic, etc

<div class="space" />
OO compliments other paradigms

<p class="questions">What makes a paradigm?</p>

<!-- notes
    paradigm is a way of thinking/modeling
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
-->


---


# Objects

Building block of an OO program
 - **Data** (attributes) represents its state
 - **Behavior** (methods) represents what it can do

<div class="space" />

Objects control access to contained data

Calling a method = "sending a message to the object"

<p class="questions">What benefits/power come from building with objects?</p>

<!-- notes
-->


---


# Classes

Class = Object Blueprint

A class defines the attributes & behaviors for its objects

Classes are pieces of code

<!-- notes
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

<p class="questions">What are the benefits of this Rule of Thumb?</p>

<!-- notes
    attributes are part of the implementation (they are the state)
    exposing attributes ties the interface to the implementation
-->


---


# Inheritance

Allows abstracting out behavior from a class

**"is-a relationship"**

<div class="space" />

Inheritance cascades

Can be difficult to tell how much abstraction is required

<p class="questions">How do you think about when to abstract?</p>

<!-- notes
-->


---


# Polymorphism

Multiple different objects having a common interface

Same code can use different objects without any modification

<div class="space" />

Polymorphism is typically implemented via inheritance

> Example - Shapes

<p class="questions">Anyone know any other kinds of Polymorphism?</p>

<!-- notes
    different objects have different implementations

    inheritance = "subtype polymorphism"

    2 components
     - use subclass as superclass
     - and invoke method which invoke's the subclass's method
        ("abstract" or "virtual")
-->


---


# Composition

Objects can contain other objects

Another means of abstraction

**"has-a relationship"**

<p class="questions"></p>

<!-- notes
-->


---


<!-- _class: centered -->

# Questions/Discussion


