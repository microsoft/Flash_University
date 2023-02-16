# Garbage Collection

## Goals
- Understand the mechanics/algorithms of garbage collection
  - Ideally, see this visually 
- See some proof that it's happening
- Understand Mark, Sweep, and compact
- Understand the rationale for each one
- How to manually call the GC in our code?
- Understand Michael's notes
  - Native code vs managed code example
- Understanding framentation
- Pinning
- Almost all code is native code at some level

## Managed Heap Basics

1. Allocate memory for the type being represented by the resource ('new')
2. Initialize Memory set to initial state of the resource ('ctor')
3. Use the resource
4. Teardown state of a resource toc lean up
5. Free the memory


// TODO program with unsafe

// TODO why is it called managed heap?

// Native heap vs managed heap

### Allocating resources (new)
1. Calculate number of bytes required for type fields and inherited base types
2. Add bytes required to objects overhead (type object pointer, sync block index). These should be  the word size of the application (64 bits for a 64 bit application)
3. Checks that we have enough space at the next obj pointer

* In the managed heap, allocating an object just means adding a value to a pointer
*
// TODO look at 507 for better notes
// What is the fundamental flaw of this? -- Memory ain't infinite.

## Generations: Improving perf

### Gen 0
Objects added to hep that have never been exampined
Examined every time

### Gen 1 
Objects added to heap that have survived > 0 and < 2 marks

### Gen 2 
Objects added to heap that have survived >=2 marks.


// TODO GC.collect example of changing memory locations of a type

## Pinning
