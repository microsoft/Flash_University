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
<!-- _footer: '**Covers Chapter 7: "Mastering Inheritance and Composition"' -->

# Object-Oriented Thought Process
**Session 5 - Mastering Inheritance & Composition**

<!-- notes
-->

---

# Overview

Both inheritance & compositions are mechanisms for reuse

<div class="space" />

**Inheritance** = "is-a" relationship
**Composition** = "has-a" relationship

<div class="space" />

Overlap in functionality, but differ in meaning

<!-- notes
    I&C are also abstraction mechanisms (not just reuse)

    Inheritance - inheriting attributes & behaviors from other classes (parent/child)
    Composition - building objects by using other object

    inheritance implementation varies between languages
    basic principle is the same, but sometimes is restricted
-->

---

<!-- _class: invert centered -->

# Inheritance

<!-- notes
-->

---

# Inheritance

All superclass behavior must be applicable to **all** subclasses

Examples of when this is not the case
> Birds can fly, but Penguins can not

<!-- notes
    Also the Rectangle/Square issue from a few weeks ago
    (Often called Circle/Oval problem)
    **mutablility** is the issue here
-->

---

# Generalization & Specialization

Higher in the inheritance tree = more general
Lower in the inheritance tree = more specialized

<div class="space" />

Move common behavior to a superclass
Move specialized behavior to a subclass (or intermediate class)

<!-- notes
    Dogs example - barking, yodeling
-->

---

# Design Decisions

More factoring out = more complex hierarchy = more complex system

<div class="space" />

**Primary goal**: build a system that is flexible w/o so much complexity that it is unstable


<!-- notes
    Computers aren't great at modeling real-world situations with high accuracy
        - gets really complex

    (in large systems) Opt for simplicity where possible

    There are always trade-offs 
    Complexity now vs work to change it later
-->

---

<!-- _class: invert centered -->

# Composition

<!-- notes
-->

---

# Composition

In the real world, objects are made up of other objects

<div class="space" />

Can have multiple layers of composition (just like inheritance)

Composition granularity increases complexity

<!-- notes
    classic example - car

    composition is more explicit
    inheritance is more implicit
-->

---

<!-- _class: invert centered -->

# Considerations

<!-- notes
    OO revolves around the question:
    "what should be exposed, and what should not?"
    (interface vs implementation)
-->

---

# Inheritance Weakens Encapsulation

Changes to the superclass implementation also change the subclass

**Stick to "is-a" relationships for inheritance**

<!-- notes
    Inheritance weakens encapsulation between superclass & subclass

    Access modifiers = range of encapsulation/protection
    public/private - strict interface/implementation separation
    internal, protected - loosens separation
-->

---

# Object Responsibility

Objects should be independent and responsible for itself

Methods may be present in the superclass, but implemented in the subclasses
> abstract methods

<!-- notes
    aka "an object should be able to answer all the important questions about itself"
-->

---

# Kinds of Inheritance

- Concretization
- Refinement
- Extension

<!-- notes
    These are not in the book - I came up with them

    Concretization - provides a real implementation to an abstract concept
        eg Shapes, Streams
    Refinement - provides more specific results or operations
        eg Calculator/Rounding Calculator
    Extension - provides additional functionality
        eg Bank Account/Investment Bank Account

    You can use multiple kinds at the same time
-->

---

<!-- _class: centered invert -->
<!-- _footer: 'Example at https://github.com/microsoft/Flash_University/tree/main/Design_Patterns/Command' -->

# Design Pattern: Command

<!-- notes
-->
