# Enums

## Questions From last week
* Still no answer on the auto properties in events
* TODO.Srikar --> Check ch 14 sln

## This is a relatively short/easy chapter for usages. 
I was thinking of combining the two chapters but, well, after strings, I needed a break and I think there are some smaller points in CS/C# that we can hit here.

## What is an enum or enumerated type?
- If I've only leared one things at this job, it's that it all boils down to 0s and ones and sometimes your team's job is to store the groups of 0s and 1s...
- Let's create a string array of 4 people and a very anthropomorphic puppy

```
ScoobySquad = [ "Shaggy", "Scooby", "Fred", "Daphne", "Velma"]
```

The computer effectively knows that ScoobySquad[0] = "Shaggy", ScoobySquad [1] = "Scooby" etc.

We are, in a sense, mapping 0 &rarr; 'Shaggy' as equivalent. More mathematically, 
```
0 == 'Shaggy' && 'Shaggy' == 0
```

From a computer's point of view, storing things like this has literally 0 impact. Each of these is a constant/immediate look up and generates the designated value
But from a human's point of view, reading is this:

```
if (person.name == ScoobySquad[1]){
	person.revealVillain();
}
```

is a little worse than reading 

```
if (person.name == Scooby){
	person.revealVillain();
}
```

So how can we prove this has some sort of enumeration?

3 proofs:
1. By Conversion
2. By looking at the inheritance path
3. By Ildasm


## hexadecimal for those who haven't seen it
Our usual numbers are in base 10. One way to thing of it is that every single place holder in a single number can hold up to 10 values

My Number theory is rusty/shit but maybe you could think of each potential value of 0-9 as a unique value in a set. 



Computers are built  on a system where the options for any digit are 0 or 1, true or false; Base 2.

What if we add 6 letters to our set of 10 numbers

So a bit is a 0 or a 1, a byte has 8 bits. If you remember, by default, every integer in C# is defaulted to an Int32 or a 32 bit value. 

## Guid fun
A Guid will always looks something like 0-9+ a-f so 16 options in any given slot

```
"12345678-BBBb-cCCCC-0000-123456789012"
```

this gives us 2^128 numbers, very, very low likelihoood of duplicates anywhere.

## So what are enums, actually?
- A literal?
- A type with hard coded values?
- A class the extends object?
- A value or a reference type?

### Enums are a type, just like everything else
Object &rarr; ValueType &rarr; Enum
* So will enums be stored on the stack or the heap?
* Will enums need the 'new' keyword?
* Will there be one version or multiple versions of the enum when starting the program?

### Why use them?
1. Make things easier to read
2. they are types that can be "extended"


## Can we prove that they are representations of numbers?
## glossary
* enum : enumerated type, the purpose of this entire chapter
* '\x' : Might remember this from strings as a 'hexadecimal'

