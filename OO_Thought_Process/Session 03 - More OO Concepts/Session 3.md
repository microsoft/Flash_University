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
<!-- _footer: '**Covers Chapter 3: "More Object-Oriented Concepts" & Chapter 4: "The Anatomy of a Class"**' -->

# Object-Oriented Thought Process
**Session 3 - More OO Concepts**

<!-- notes
-->

---

# Overview

- Constructors
- Scope
- Operator Overloading
- Multiple Inheritance
- Complex Object Operations
- Error Handling Strategies

<!-- notes
    first 5 are really simple/might not be new
    couple of good tidbits

    I'll skim very quickly basic things
    ask questions if you have them, no matter how basic
-->

---

# Constructors

Allocates & initializes memory
Can have multiple constructors

**Purpose is to get object into "safe"/"stable" state**

<!-- notes
    generally recommended to only do data initialization, no other logic
-->

---

# Scope

3 attributes scopes: Local, Object, Class

**Keep attributes at as low a scope as possible**


<!-- notes
    local - scoped to a code block (aka a method)
    object - scoped to the object instance
    class - scoped to the class itself
        (shared by all objects, accessible through the class directly)
-->

---

# Operator Overloading

Changes the behavior of an operator for certain types

**Powerful, but very rarely needed**

<!-- notes
    just like method overloading, but for operators

    C# allows this

    can very easily be a huge source of confusion
    generally, only use for well-defined operations in a clearly defined subdomain
    eg matrix multiplication
-->

---

# Multiple Inheritance

C# doesn't support this

<div class="space" />

Interface = Behavioral Inheritance
Class = Implementation Inheritance

<!-- notes
-->

---

# Working with Complex Objects

Foundational object operations can become complicated
> copying, comparing, etc


<!-- notes
    For a demo, see CLR via C# Week 2 & 3
-->

---

# Error Handling

Several Approaches:
- Ignore it
- Abort
- Attempt to recover
- Pass the error back

**Use whatever error solution(s) that best matches the situation**

<!-- notes
    example - demo

    Ignore it
        don't do this - data corruption, ungraceful termination, etc
    Abort
        not a good user experience
        allows outside systems to try to cleanup/recover
    Attempt to recover
        often not a clear way to recover
        often not guaranteed to work (eg retry)
    Pass the error back
        eg, exceptions, returning an error/flag
        doesn't handle the error, just passes the responsibility
        let caller decide what to do
-->

---

<!-- _class: centered invert -->

# Questions/Discussion
Examples: https://github.com/microsoft/Flash_University


<!-- notes
-->

