# Nullable Value Types
## Goals
- Understand the structure
- Null Coalescing
- CLR support

## Why do you think this is called Nullable Value Types?
- basically we want to be able to set structs to null which is or isn't supported?
- Let's look at the Nullable Class
- Notation

## Little bit of trivia
- Wrapping on top of something that isn't working is apparently the only solution
- This reminded me heavily of the java Optional class where in order to deal with nulls better, they basically wrap a class around it and have "type safe methods"

## Null Coalescing
- one of the few things Jeffrey considers to be an improvement
- Really easy way to set a default value

## Conversions
- They work

## Special Support in the CLR
- Boxing and unboxing
- Get Type on a nullable type
- Interface Methods

