# Strings

## Questions from last time 
- none I can remember

## Things to look for today
- representations of a string
    - String min/max
- transformations of a string
- hexadecimal basics
- what is a culture
- how are strings represented in the CLR
- Casting/converstions

## three main ways to switch between numeric types and char
1. Casting
2. Convert type
2. Iconvertible

## System.String
- you don't need a new operateor to create a new string 
- It is a primitive type
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