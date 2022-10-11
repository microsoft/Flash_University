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
<!-- _footer: '**Covers Chapter 5: "Class Design Guidelines" & Chapter 6: "Designing with Objects"**' -->

# Object-Oriented Thought Process
**Session 4 - Design Guidelines**

<!-- notes
    suggestion: keeping a list of design tips & guidlines
-->

---

# Overview

Design for:
- Robustness
- Reuse
- Extensibility
- Maintainability

<!-- notes
-->

---

# Modeling Real-World Systems

**Design classes in a way that represents the true behavior of the object**


<!-- notes
    Not so applicable to classes that don't have real-world counterparts
    "real-world" means anything outside of your system
-->

---

<!-- _class: centered invert -->
# Robustness

---

# Constructors & Destructors

Constructor: initialize object into a safe state
Destructor: clean up (memory, release resources, etc)

<p class="questions">When should you use Destructors in C#?</p>

<!-- notes
    Constructor Injection
        service classes are passed into the constructor rather than created in the constructor

    Destructors = Finalizer in C#
    also the IDisposable interface

    my answer:
        destructors are highly useful when object has a lifecycle
        and when ephemeral obj is associated with a long-lived system resource
        eg file handle (open/close), socket (attach/detach), scope monitor (start/stop)
-->

---

# Error Handling

Anticipate potiential errors and handle them appropriately

**Application should never crash**


<!-- notes
    At the very least, applications should exit gracefully
-->

---

# Documentation

Balance between too little & too much

**Be concise and to the point**

Well-written code is the best documentation

<p class="questions">What are your views on documentation?</p>

<!-- notes
    subjective topic

    my answer: doc comments are good for
      - providing quick/high-level view (for IDEs),
      - listing behavior/assumptions not in the signature
      - providing rationale (why it exists, why it was done like it was)
            (also inline comments)
-->

---

# Object Persistance

Persistance = saving the state of an object

Different targets:
> file system, DB, etc

Serialization & deserialization/marshalling must be in sync

<!-- notes
    must be backwards compatible when old versions possibly still exist

    serialization: converting obj to/from sequence of bits
    marshalling: transferring obj between program boundaries
-->

---

<!-- _class: centered invert -->
# Reuse

Design so that a class can be extended/updated as the need arises

<!-- notes
    cannot predict the future and how an object/class might be needed
    best thing to do is to make a class easily extendable/updateable
-->

---

<!-- _class: centered invert -->
# Extensibility

<!-- notes
    extensibility = any updating/adding/refining behavior inside a system:
	- Extending a class
	- Adding new methods/behaviors to an existing class
    - Modifying the behavior
-->

---

# Extensibility & Separation

Classes should only contain the data/behavior specific to it/what it represents
> Classes should have a well-defined boundary

<!-- notes
-->

---

# Statics

Statics are tied to the class (not part of OO flow)

Static methods should not produce side-effects
> helper methods

<div class="space" />

Static fields should only relate to the application/thread as a whole

<p class="questions">What are some examples of valid uses of statics?</p>

<!-- notes
-->

---

# Naming

Be consistent with naming conventions

Names should be descriptive of thier use

**Name things to be understood by other people**

<!-- notes
    Name should naturally give as much information about the nature & behavior of what it belongs to
    Names should be descriptive of their use, not their implementation
-->

---

# Object Wrapping

Can use classes to wrap other classes
> non-portable code, dependencies, technology specific modules

**Separate functionality into layers based on abstraction level**

<!-- notes
-->

---

<!-- _class: centered invert -->
# Maintainability

<!-- notes
-->

---

# Code Organization

Smaller, less interconnected pieces tend to be more maintainable

Reduce interdependent/coupled code

Iterative process - design & code in small pieces


<!-- notes
    less-coupled code
        helps minimize work & risk when you have to modify an interface

    TLDR - keep your code organized
-->

---

# Testing the Interface

Stub = minimal implementation of an interface
Can use stubs to test interfaces without writing real code

Keep stubs around (hidden) so you can reuse them later

<p class="questions">Do you agree with this?</p>

<!-- notes
    kind of TDD like
    
    not sure I agree with keeping stubs around - maybe in a separate classes
    so they don't pollute the main class?
-->

---

<!-- _class: centered invert -->
# System Design


<!-- notes
-->

---

# System Design Process

1. Analyze the problem/scenario
2. Create Statement of Work
3. Get Requirements from SoW
4. Develop prototype UI
5. Identify Classes
6. Determine responsibilities of each class
7. Determine how classes will interact
8. Create high-level model that describes the system

<!-- notes
    1. Research - including "is it worth it"
    2. High-level description of the proposed system
    3. Details specific needs & behavior - design is crafted from this 
    4. Simulated/Wireframes - missing functionality, focused on look & feel
    5. Rough list of all Classes (eg nouns) - refined later
    6. Record data & operations for each class
    7. Record how classes will interact
    8. Build class model based on steps 5-7
        use UML (or similar)
-->

---

<!-- _class: centered invert -->

# Questions/Discussion
Examples: https://github.com/microsoft/Flash_University


<!-- notes
    review: https://github.com/rakirs2/CSharpChess
    (at commit 45f1615 - main as of 8/4/2022)
-->

