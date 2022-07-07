# Week 1
## Goals for Today
- understand why C# and the CLR exist/the problems that led to the solutions described
- How a C# application works (execution model, ch1)
- Barebones of what is needed to understand a C# file

## Brief History of Computing
### Common Occurrence in Science 
    - Something gets discovered (!1820 Lithium discovered)
    - takes until ~1970 to get used as a Bipolar drug
    - 150 years until application of discovery
    - Number Theory (specifically primes) is almost as old as math
        - first major use in cryptography is in the last 100 years
### Boolean Algebra
    - 1850 ish
    - venn diagrams
    - a whole category of math based on 0s and 1s
    - If we get a system that can compute 0's and 1s efficiently, all of Boolean Algebra becomes impossibly useful
### Bit of a time skip
### Computers are born in 1948
    - 1956 first use of transistors at MIT
    - 1975 Altair BASIC -- Microsoft's first product 
 At some level, a computer is simply a that can read instructions written in a specfic way, very efficiently
- 01101000 01100101 01101100 01101100 01101111 00100000 01110111 01101111 01110010 01101100 01100100

    - (first number, right to left) 
    -  0* 2 ^ 0  + 0 * 2 ^ 1 + 0 * 2 ^ 2 + 1 * 2 ^ 3 + 0 * 2 ^ 4 + 1 * 2 ^ 5 +  1 * 2 ^ 6 + 0 * 2 ^ 7
     = 0 + 0 + 8+ 0 + 32+ 64 = 104 --> ascii value of 'H'
    - If you've never seen binary, some fun problems are 11 + 11; 11 * 11
    - There's more to it, but at the end of the day, this is what the computer/processor understands
### Pretty common problem in life/translation in a foreign country
    - You're trying to have one person who is fluent in one language communicate with another person who fluent in another
    - What are your options?
        - Can have one try to learn the other language
        - Create a setup where there's something in the middle
### Why don't we write everything in Binary?/Speedy History of languages
- Functionally useless to people
- Assembly added some syntax/meaning to the code before it was read by the computer
        - It is called "assembly" because it is assembled into machine code (see code sample)
        - Still not really readable, but more workable than just numbers
- Human Language (English for now) <-7-6-5-4-3-2-1-> Computer Language (Binary)
    - arbitrary numbers
        - anything low  is easy for the computer to read/faster for computer
        - anything high is easy for a human to write/understand, slower for a computer to read/execute
- C
    - Create a language based off of assembly that humans can write, have it compile into something that a program on the computer can execute
    - Eseentially give full control of the computer to the User
    - have functions
- C++
    - superset of C with classes
    - what's the potenial problem with 'perfectlyFine.cpp'
### What if there's more than 1 type of computer
    - We write a program, how do we ensure it runs on Windows, Mac, Linux etc?
    - solution is still the same translation problem, just scaled up a level
- Java
    - Created the Java Runtime Environment 
    - Basically if a program was written in Java and said program ran on the JRE, it could be run the same way wherever the JRE could run
    - "write once, run anywhere"
    - Solved the Memory Management problem w/ garbage collector
    - .java compiles into bytecode and executes on the JRE 
- C#
    - Microsoft's answer to Java
    - .cs -C#complier-> intermediate language (IL) -CLR> result
    - .cs compiles into IL and executes on the CLR (common language runtime)
    - also has a garbage collector

### Common Language Runtime grab bag
- Any language that can be converted into IL can run on it.
    - IronPython, Iron Ruby and a whole bunch of other stuff exist to be able to run "non C# stuff" on the CLR
        - Would like to add a easy way to show this later/ wasn't able to get it so far
- Managed vs Unmanaged Code
    - simply put, if an application runs on the CLR, it's managed (logic I'm using is "it is running on something w/ a garbage collector therefore it is memory managed")

### Modules and Assemblies
For our purposes, a module has a PE32 header, a CLR header, metadata, and the acutal IL code. 
For more detail, see chart on page 5
A module is not the smallest indepenendt unit.
An Assembly is the smallest unit of reuse; contains one or more modules.

Module(s) + Resource(s) --> Compiler --> Assembly (Manifest saying whats in here) + [Module]

#### CLR via c# = tour of the CLR using C# as the language to explore

### I'm assuming we're relatively good on types, classes, etc. The last bit is kind of just prepping/undertstanding how certain things work
