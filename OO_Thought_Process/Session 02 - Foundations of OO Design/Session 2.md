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
<!-- _footer: '**Covers Chapter 2: "How to Think in Terms of Objects"**' -->

# Object-Oriented Thought Process
**Session 2 - Foundations of OO Design**

<!-- notes
-->

---

# OO Design Principles

1. Conceptul analysis & design first
2. Know the difference between interface & implementation
3. Use abstract thinking
4. Minimize the public interface
5. Design from the "user's" perspective
6. Consider external constraints

<!-- notes
    1 - avoid thinking in terms of a specific language first
    2 - really understanding each/the difference is important
    3 - abstraction is a large benefit of OO (more later)
    4 - small interfaces are best (more later)
    5 - users will ultimately be who/what is using it (more later)
    6 - must consider the environment it will be used in (more later)

    applies to all levels (micro & macro)
-->

---

# Interface vs Implementation

**Interface/Implementation separation is key to OO design**

Changing implementation should not affect the behavior included in the interface

<p class="questions">
What <em>exactly</em> does an interface include?
Can it include any behavior?
</p>

<!-- notes
    (book) toaster example

    my answer:
    **Interface can include _some_ observable behavior**

    interface _types_ do not contain everything that's observable
        behavior can leak through
        (exceptions - which & when exactly do they occur)

    some behavior *is* part of interface
        (eg file - open, modify, close)
    often is a gray area
    interface behavior should be explicitly stated
        (in documentation, etc)
-->

---

# Thinking Abstractly

Advantage of OO - classes can be reused

Reusable classes tend to be more abstract

<div class="space" />

Keep in mind the overarching purpose of a class/set of classes

<p class="questions">How can you focus on "thinking abstractly"?</p>

<!-- notes
    my answer: look for patterns of usage/functionality
-->

---

# Minimizing the Interface

Ideally, an interface includes only what is absolutely needed

Better to expand the interface later than to start too big

Aim for "deep" classes

<!-- notes
    exposing too much can hinder maintenance, security, etc
-->

---

# Design From the "User's" Perspective

Not from systems/technoligical viewpoint

Good design should maximize usability

<p class="questions">Who are the "Users"?</p>

<!-- notes
    review design with the people that are going to use it

    my answer: anything/anyone that interacts with the object/class/modules/system
-->

---

# Consider External Constraints

Environment often imposes limitations on what's possible
> No network? Have to work with a specific device?

<p class="questions">What other external factors can impact a design?</p>

<!-- notes
    environment imperfections/fault tolerance - possible failures
    business priorities - eg cost, offline support
    latency/performance
    usage pattern - eg concurrent operations
    full system environment - distributed? cloud?
-->

---

<!-- _class: centered -->
# Not One "Best" Process

<!-- notes
    subjective; everyone has their own process
    design is iterative
-->

---


<!-- _class: centered invert -->

# Questions/Discussion
Examples: https://github.com/microsoft/Flash_University


<!-- notes
-->

