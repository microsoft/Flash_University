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


## hexadecimal primer
Our usual numbers are in base 10. One way to thing of it is that every single place holder in a single number can hold up to 10 values

My Number theory is, at best, awful but maybe you could think of each potential value of 0-9 as a unique value in a set. 



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

## Enumeration Manipulation
* Can you change the base type of an enum?
* In our code base (filestore), we do use this, look up enum and uint
* Can you set a value of an enum?

## What if we have more values than the base type allows?
* See example

## Jeffrey, you need to be more epxlicit
* "The compiler treates enumerated types as primitve types meaning you can use most operators with it.



## Iterating over enum set
* Options in the code base
    - Get Values (Type enumType)
	- GetEnumValues()
    	- they both return an array
* Jeffrey's Preference

## Can you parse an enum?
* See example


## Bitflags/field understanding
* [complicated ex in code base](https://onedrive.visualstudio.com/DefaultCollection/SharePoint%20Online/_git/SPO.Core?path=/sts/stsom/Cobalt/SPHostBlobStoreTypes.cs&version=GBmain&line=142&lineEnd=160&lineStartColumn=4&lineEndColumn=64&lineStyle=plain&_a=contents)
* How bitflags work in general
* Note the 'flags' attribute
* Fundamentally, we represnet a value in binary, and then use operations to determine whether or not the complex attribute has a specified value
```
001 = 1
010 = 2
100 = 4
```

1 reprensents an object is a school supply, 2 represents the object is made of wood and 3 represents the object can write

a pencil would be 

```
111 = 7
```

A backpack would be?
A Pen?


Best way to 'learn this' is look at a really hard example

## Extensions
* see example, from book
## glossary
* enum : enumerated type, the purpose of this entire chapter
* '\x' : Might remember this from strings as a 'hexadecimal'


