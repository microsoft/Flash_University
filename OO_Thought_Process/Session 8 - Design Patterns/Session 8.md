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
<!-- _footer: '**Covers Chapter 10: "Design Patterns"' -->

# Object-Oriented Thought Process
**Session 8 - Design Patterns**

<!-- notes
-->

---

# Overview

Patterns are everywhere

Patterns go hand-in-hand with code reusability

Design Patterns are closely related to best practices

<!-- notes
-->

---

# What are Design Patterns?

4 Main Elements:
- **Pattern name**: description of the problem/solution (in a word or two)
- **Problem**: the situation the pattern applies to
- **Solution**: the design to handle the problem
- **Consequences**: results & trade-offs of using the pattern

<!-- notes
    "typical solutions to commonly occurring problems in software design"

    Problem: "when to apply the pattern"
    Solution: "what the result is"

    consequences can be:
    - space/time complexity/cost
    - system extensibiliy/flexibility
    etc
-->

---

# Smalltalk & MVC

**Model** - application object
**View** - screen presentation
**Controller** - defines how to respond to input

<div class="space" />

Benefits:
- keeps interfaces separate/single purpose
- makes systems more flexible/robust

<!-- notes
    Smalltalk was the first popular, "real" oo language
    MVC paradigm in Smalltalk was one of the first "patterns"
-->

---

# Types of Design Patterns

3 Categories:
- **Creational**: create objects for you (so you don't instantiate them directly)
- **Structural**: compose groups of objects into larger structures
- **Behavioral**: defines communication/flow between objects

<!-- notes
-->

---

<!-- _class: centered invert -->
<!-- _footer: 'https://github.com/microsoft/Flash_University/tree/main/Design_Patterns/Singleton' -->

# Creational: Singleton
Ensure a class only has one instance, and provide a global point of access to it

<!-- notes
-->

---

<!-- _class: centered invert -->
<!-- _footer: 'https://github.com/microsoft/Flash_University/tree/main/Design_Patterns/Adapter' -->

# Structural: Adapter
Convert the interface of a class into another interface clients expect

<!-- notes
-->

---

<!-- _class: centered invert -->
<!-- _footer: 'https://github.com/microsoft/Flash_University/tree/main/Design_Patterns/State' -->

# Behavioral: State
Allow an object to alter its behavior when its internal state changes

<!-- notes
-->

---

# Antipatterns

Patterns/Practices to avoid

<div class="space" />

2 Parts:
- Bad solution to a problem
- How to get to a good solution

<!-- notes
    similar to "code smell"s
-->

---

# Antipattern Example

**Robust Artifact**
well-documented, tested, and reusable item

**Reuseless Artifact**
must be reworked into a "robust artifact"

<!-- notes
-->
