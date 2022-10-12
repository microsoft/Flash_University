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

    .pad {
        margin-left: .375em;
        margin-right: .375em;
    }

---

<!-- _class: invert -->
<!-- _footer: '**Covers Chapter 12: "The SOLID Principles of Object-Oriented Design"' -->

# Object-Oriented Thought Process
**Session 10 - SOLID**

<!-- notes
-->

---

# Overview

> OO is about managing dependencies by inverting key dependencies to prevent rigid, fragile, and non-reusable code

Forcing inheritance can cause problems

<!-- notes
    OO does not necessarily model the real world well (contrary to common adages)
    real world isn't clean cut
-->

---

# SOLID

3 aspects of non-reusable code
1. **Rigidity** - change to one part of a system can break another part
2. **Fragility** - things break in unrelated places
3. **Immobility** - code cannot be reused outside its original context

<div class="space" />

**SOLID strives to address these issues**

<!-- notes
-->

---

# Single Responsibility Principle

> Classes should only have one reason to change

<div class="space" />

Each class/module should focus on a single task

Well defined boundaries between functionality

<div class="space" />

**Example** <span class="pad">**&middot;**</span> [UML](./notes/single-responsibility-uml.md)

<!-- notes
    If the description of the class includes "and", you might be breaking SRP

    one and only one classes should be responsible for one and only one aspect
-->

---

# Open/Close Principle

> Should be able to extend a class's behavior without modifying it

<div class="space" />

"Open for extension, Closed for modification"

<div class="space" />

**Example** <span class="pad">**&middot;**</span> [UML](./notes/open-close-uml.md)

<!-- notes
-->

---

# Liskov Substitution Principle

> Any instance of a parent class must be able to be replaced with an instance of 
a child class

<div class="space" />

If a parent class can do something, a child class must also be able to do it.

<div class="space" />

**Example** <span class="pad">**&middot;**</span> [UML](./notes/liskov-substitution-uml.md)

<!-- notes
    book says: "When you see a constructor calling another constructor, it might
    not be a proper child class."
    -> not sure I agree with this
-->

---

# Interface Segregation Principle

> Clients should not be forced to depend upon interfaces that they do not use.

<div class="space" />

It is better to have many small interfaces than a few larger ones.

Everything inside an interface should be very closely related. 

<div class="space" />

**Example** <span class="pad">**&middot;**</span> [UML](./notes/interface-segragation-uml.md)

<!-- notes
-->

---

# Dependency Inversion Principle

> A high-level module should not depend on low-level modules. Both should depend on the abstraction.
>
> Abstractions should not depend on details. Details should depend on abstractions.

<div class="space" />

**Goal:** to couple to something abstract, rather than concrete
**Subgoal:** choose objects at runtime, not at compile time

<div class="space" />

**Example** <span class="pad">**&middot;**</span> [UML](./notes/???-uml.md) <span class="pad">**&middot;**</span> [Code](../OO%20Materials.sln)

<!-- notes
-->

---

# Closing

Design is subjective, and all about balance & trade-offs

**There is no one-size-fits-all solution**

<!-- notes
-->

---

<!-- _class: centered invert -->
<!-- _footer: 'Example at https://github.com/microsoft/Flash_University/tree/main/Design_Patterns/???' -->

# Design Pattern: ???

<!-- notes
-->
