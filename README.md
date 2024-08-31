# G Unit

Trying to generate some C# value types that hold unit of measure information
to allow robust and performant engineering calculations.

This may not be entirely possible but let's have a crack.

The basic idea is that we manually define a set of units for the domain
we are interested in (this will not scale to a large amount that exists). We
then use the relational algebra of these units to generate arithmetic operators 
such that formulas written using these types will always track the correct unit of measure.

```csharp
kg a = (kg)2.5;
g b = (g)1000;
kg c = a + b;
// c.Value should be 3.5
```



## Quickstart
- Run `Program.cs`
- It will generate `Units.g.cs`

## Design Choices
- No implicit casts to/from double
- No implicit casts to/from int
- Must be value types
- Only wrap Double, no other fields
- Generate converters all the way down the "syntax" tree