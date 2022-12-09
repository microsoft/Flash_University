---
marp: true
---

# CLR via C# Overview
## Srikar Mylavarapu
---
## Long Term Goals
- Have fun
- Focus on retention and "why"
- 1-2 chapters per session
---
## Materials covered
- Book is really long and really dense
- There is no feasible way for me to get through all of it
- rationale for skips at bottom of this doc
- Expect about 1-2 chapters a week depending on difficulty of chapters, generalized notes/ideas for that week from me on the repo, and code examples/problems we can work through.
- Ideally, the only place you should have to check is the public FLASH_University Repo in github.com/microsoft/FLASH_University/CLR_Via_CSharp
---
## My Goals
- Make it useful

## Philosophy
- There are no stupid questions.
- I hate powerpoints. Especially outlines translated into powerpoints. But they have their use.
---

## Expectations
- If you want to make the most of it, a copy of the book (available as an ebook via oreilly or physical) is probably a good idea (It is the source of truth)
- Have fun, let me know if things are working/not working
    - I am beginner (was a chemist [not sure how long I can keep using that])
    - I will make mistakes, feel free to correct me/ask questions at just about any time
---

## Looking Forward

I'm writing this after finishing up chapter 19. For the most part, I'm happy with how things have come along. But due to reality constraints and a generalized need for not reading Jeffrey Richter for a bit, I think the plan is to do something like this

### Core Facilities
20. Exceptions and State management (probably worth reading)
21. Garbage Collection (definitely doing)
22. CLR hosting and App Domains (quick read)
23. Assembly Loading and Reflection (I want to do something with this and the GAC)
24. Runtime Serialization (Maybe a quick read)
25. Interop with Win RT (NO)

### Threading
This section is completely new to me. I kind of want to read some other material on multithreading before diving into it.

26. Thread Basics (THis is all text, no code). I think it's worth doing in parts
27. Compute-Bound Async Operations
28. I/O-Bound Asynchronous Operations
29. Primitive Thread Synchronization Constructs
30. Hybrid Thread Synchronization Constructs

I think that the priority order will be 20, 21, Threading, 23, 24
#### Srikar's Opinions on why certain things are skipped:
- Chapter 2,3 
    - A little more advanced/not as hands on for teaching a "C# course"
- Chapter 5 
    - boxing and unboxing 
    - dynamic primitive types
        I Want to get back to these, I think i'm ready to get this one this time around
- Chapter 8 
    - missed type constructors on 187
- Chapter 17
    - Delegate Chaining
        - wanted a simpler chapter after a while (want to make a pass through again)

