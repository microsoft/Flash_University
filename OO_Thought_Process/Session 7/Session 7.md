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
<!-- _footer: '**Covers Chapter 9: "Building Objects and Object-Oriented Design"' -->

# Object-Oriented Thought Process
**Session 7 - Building with Composition**

<!-- notes
-->

---

# Overview

Interitance & Composition - both ways objects interact

**Inheritance:** class incorporates behavior & attributes of superclass
**Composition:** class uses other classes as building blocks

<!-- notes
    Inheritance - merges classes together
    Composition - nests other classes inside class
-->

---

# Composition

Composition is a natural concept

<div class="space" />

Composition enables interchangeable parts

<!-- notes
    composition is everywhere in the real-world
-->

---

# Sub-Systems

Stable, complex systems are:
- A hierarchy of sub-systems
- Nearly decomposable
- Composed of only a few different kinds of subsystems
- Evolved from simple systems

<!-- notes
    Subsystems can be built/maintained independently

    hierarchy - system composed of layers of simpler and simpler sub-systems
	decomposable - fewer links between components than inside components
    composed of others - arranged in different combinations
-->

---

# Language Support

"Decoupling design" - only recompiling part of the application that needs it

In .NET, assemblies are dynamically loaded

Can also reuse libraries/assemblies between teams (or even use 3rd party)

<!-- notes
-->

---

# Subsystems vs Frameworks

**Framework:** Generalized system with unimplemented "plug-in points"
To use, you specialize it by implementing the "plug-in points"

<div class="space" />

**Subsystem:** Self-contained system that focuses on a specific domain
Can use as-is, but does not cover all functionality

<!-- notes
-->

---

# Types of Composition

**Aggregation** - only see the object as a whole

**Association** - also see the parts that make up the object

<!-- notes
    Aggregation
    See a single unit - other parts are hidden inside
    Ex a TV, Car

    Association
    See both the whole, and the parts
    Ex stereo system, computer

    sub-objects are hidden from interface? Aggregation
    sub-objects are visible in interface? Association
-->

---

# Using Them Together

Association/Aggregation is a blurry line

Using one or the other is a design decision

<div class="space" />

**No single, always correct answer**

<!-- notes
-->

---

# Avoiding Dependencies

Avoid:
- making objects highly dependent on one another
- mixing domains

<div class="space" />

Can fix both by using interfaces instead of concrete classes

<!-- notes
    Mixing domains is more convenient, but less stable
-->

---

# Cardinality

Cardinality is:
- \# of objects (single or multiple)
- if it's mandatory (optional or required)

<div class="space" />

Multiple object associations = arrays
Optional associations = check for nulls

<!-- notes
    Ex: Employee
	- Division; mandatory, single - 1
	- JobDescription; mandatory, multiple - 1..n
	- Spouse; optional, single - 0..1
    - Child; optional, multiple - 0..n
-->

---

<!-- _class: centered invert -->

# Composition/Cardinality Example
https://github.com/microsoft/Flash_University

<!-- notes
-->


---

<!-- _class: centered invert -->
<!-- _footer: 'Example at https://github.com/microsoft/Flash_University/tree/main/Design_Patterns/State' -->

# Design Pattern: State

<!-- notes
-->
