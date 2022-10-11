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
<!-- _footer: '**Covers Chapter 11: "Avoiding Dependencies and Highly Coupled Classes"' -->

# Object-Oriented Thought Process
**Session 9 - Dependency Injection**

<!-- notes
-->

---

# Overview

**Coupling**: the degree of interdependence between modules.

**Dependency Injection** (DI) is one way to reduce coupling.

<div class="space" />

<p class="questions">How do Inheritance and Composition affect coupling?</p>

<!-- notes
    Coupling represents the degree to which a single unit is independent from others

    typically, less coupling = more flexibile, robust system
-->

---

# Amounts of Coupling

Typically this is the order of coupling (high to low):
- Inheritance
- Composition (aggregation)
- Composition with Dependency Injection


<!-- notes
    composition example: stereo = aggregation vs association
-->

---

<!-- _class: centered invert -->

# Coupling Example
[UML](./notes/example-uml.md) <span class="pad">**&middot;**</span> [Code](../OO%20Materials.sln)

<!-- notes
-->

---

# Dependency Injection

Outside code is responsible for passing in required objects

Class only has references to the required interface, not a concrete class

<div class="space" />

**DI is frequently managed by frameworks**

<!-- notes
-->

---

# DI Variations

**Injection by Constructor**: object is passed into the constructor

> This is the most common pattern

<div class="space" />

**Injection by Setter**: object is passed to a "set" method

> Helpful if object may need to be "reset"


<!-- notes
-->

---

<!-- _class: centered invert -->
<!-- _footer: 'Example at https://github.com/microsoft/Flash_University/tree/main/Design_Patterns/Strategy' -->

# Design Pattern: Strategy

<!-- notes
-->
