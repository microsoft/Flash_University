# Custom Attributes
## Goals
- Understand What Custom Attributes Are
- How to create them
- What they look like in a CLR
- Matching
- Detection
- Conditional Attribute Classes

## What are custom attributes
We have seen Attributes before. 
<details>
  <summary>Can you think of some examples?</summary>
  - Bit Flags
  - Serializable
</details>

Jeffrey goes into a few different definitions of an attribute.

```
If you could create something that assigns properties like 'static', 'private' and 'public' do, that would be an attribute
```
> Case in point, let's just look at what happens if we have "public"

> Look at w/ and w/out serializable

Jeffrey's second definition is  that an attribute is "an instance of a class."

## Limitations around attributes

Are 

 Does that make