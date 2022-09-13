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
<!-- _footer: '**Covers Chapter 8: "Frameworks and Reuse: Designing with Interfaces and Abstract Classes"' -->

# Object-Oriented Thought Process
**Session 6 - Creating "Frameworks"**

<!-- notes
-->

---

# Overview

OO reusability depends on design & implementation

Interfaces & abstract classes are building blocks for **frameworks**

**"Frameworks"**
- means of code reuse
- enforce a specific usage pattern

<!-- notes
-->

---

# Frameworks

Framework = common system to plug into
> Example: Document editors, UI libraries

<div class="space" />

Developer must use **pre-determined interface** to use a framework

Must follow the framework's rules (in the documentation)

<!-- notes
    Word processing framework includes:
        Creating docs, opening docs, saving, copy/cut/paste, searching, etc
-->

---

# Standardization

Reusability leads to **standardization**

Benefits:
- consistency
- using existing code (already written & tested)

<div class="space" />

Inheritance/composition = reusing small pieces (class)
Frameworks = reusing whole/partial systems


<!-- notes
-->

---

<!-- _class: centered invert -->

# Contracts

<!-- notes
    framework's purpose is to provide contracts to plug into
-->
---

# Contracts

Contract = any mechanism that enforces the framework's rules

**Enforcement is vital**

<div class="space" />

Two ways to implement contracts: Abstract classes & interfaces

<!-- notes
    contract is widely used in many areas, each meaning something slightly different
-->

---

# Abstract Classes

"abstract class" - can't be instantiated (something isn't implemented)

> Leads to: Polymorphism, inheritance responsibility

<div class="space" />

"the abstract methods are the contract"

<!-- notes
    Ex Shape class - draw abstract method
    "if you ask someone to draw a shape, their first question would be 'what kind of shape?'"
-->

---

<!-- _class: centered -->

# Anti-pattern

Using a bunch of switch or if/else statements to implement a method in a superclass

<!-- notes
    Rather should make the method abstract & implement it via subclassing
-->

---

# Interfaces

"interface" - just a signature (no implementation)

Functionally the same as an abstract class with no implemented methods


<!-- notes
    "interface" is widely used, and can mean different things depending on the context

    functionally the same as abstract class (w/no implmented methods),
    but different use case/meaning

    interfaces partially exist because of single inheritance 
-->

---

# Example

**Dog & Mammal:**
- Dog is a Mammal = **abstract class inheritance**.
- Dog implements Nameable = **interface inheritance**.
- Dog has a Head = **composition**.


<!-- notes
-->

---

# Abstract Classes vs Interfaces

**Different Purposes**

Interfaces = describe qualities of implementor
Abstract classes = dictate implementation

<div class="space" />

**Different Spread**

Abstract classes - the subclasses must be related
Interfaces - the classes do not have to be related

<!-- notes
    (spread) Not just abstract classes, but any strict/class inheritance
-->

---

# Compiler Enforcement

Compiler ensures subclasses fulfill abstract class & interface requirements

Allows assigning subclass to a variable declared as the superclass/interface

<!-- notes
-->

---

# Making A Contract

Simple rule - provide an unimplemented method (abstract class or interface)

<div class="space"/>

Contract provides **standardization**

Contracts are opt-in when implementing
But you can require them when using it


<!-- notes
-->

---

# Summary

Contracts are "plug-in points" in your code

Constracts enforce the framework's rules 

Contracts can increase complexity

<!-- notes
-->

---

<!-- _class: centered invert -->

# Framework/Reuse Example
https://github.com/microsoft/Flash_University

<!-- notes
-->


---

<!-- _class: centered invert -->
<!-- _footer: 'Example at https://github.com/microsoft/Flash_University/tree/main/Design_Patterns/Template%20Method' -->

# Design Pattern: Template Method

<!-- notes
-->
