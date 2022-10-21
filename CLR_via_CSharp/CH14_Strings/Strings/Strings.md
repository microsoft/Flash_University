# Strings

## Questions from last time 
- none I can remember

## Things to look for today
- representations of a string
    - String min/max
- transformations of a string
- hexadecimal basics
- how are strings represented in the CLR
- Casting/converstions

## three main ways to switch between numeric types and char
1. Casting
2. Convert type
2. IConvertible

## System.String
- you don't need a new operator to create a new string 
- It is a primitive type
- Reference type w/ value type properties
- in il, you'll see a ldstr rather than a newobj ctor for construction\
- There's some important stuff on unsafe strings/concatenation/escapes
    - \ is the default escape character
    - + is how you add strings
- Strings are immutable. Meaning that operations on a string create a new string
- Comparisons are case and culture sensitive
    - Jeffrey word of advice, always use case sensitive comparisons when comparing

## String Interning
- checking strings for equality is very bad for performance.
1. Checks for number of characters
2. Compare each char individually /ordinally
- interning is creating a hash table where k = string and value = string object references in the heap

## String pooling
- using each unique string literal only once

## String Methods
- length, chars, GetEnumerator, ToCharArray,Contains,IndexOf,lastindexof,indexofany,lastindexofany
- also get clone, copy, copyto, substring, and to string

## Stringbuilder
- recommended way to build strings as strings are immutable 

## parse (opposite of tostring)
- take a string and get it's object representation
- classic example today is probably parsing a json into an object
- everyone's favorite step in building a website.
- Jeffrey's note, "parse in date time wasn't specific enough --> see example"

## encodings
- basically converting between chars and bytes
- as strings are always 16 bit unicode values, this is relatively easy
- fundamentally, as seen above, every char will have a corresponding unicode value
- This is a little bit out of my ball park, so we're just going to use Jeffrey's Examples

## Secure String
- remember that strings stay in memory until GC'd 
- How do we handle this 
    - give a wrapper class with a dispose?? hooray

## String Interpolations
- https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated