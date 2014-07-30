---
layout: default
title: Documentation
toc:
    -
        name: Negating Tests
        link: toc_1
    -
        name: Test Failures
        link: toc_2
    -
        name: Objects
        link: toc_3
    -
        name: Booleans
        link: toc_8
    -
        name: Strings
        link: toc_11
    -
        name: Integers
        link: toc_18
    -
        name: Collections
        link: toc_23
---

## Negating tests

You can negate any test in Lingo's API by prepending `.Not` right after the
`Expect(...)` call.

``` csharp
Expect("foo").Not.To.Equal("bar")
```

## Test Failures

Any failed test will throw an `ExpectationException` with the message containing
both what was expected and what was given.

## Object expectations

Expectations defined on `object`s are inherited by all other `Expect`
derivitaves, although they may be overridden for class-specific logic.

### .Equal(object)

Test equality between two objects using `.Equals()`

``` csharp
Expect(new object()).To.Equal(new object());
```

### .EqualRef(object)

Test referential equality between two objects. That is, expects both objects to
point to the same location in memory.

``` csharp
var foo = new object();
var bar = foo;
Expect(bar).To.EqualRef(foo);
```

### .Be.Null()

Test that an object is null.

``` csharp
object[] things = null;
Expect(things).To.Be.Null();
```

### .Be.InstanceOf(Type)

Test than an object is of a certain type. This test will pass if the object
under test is a subclass of the passed type, or if the object under test
implements the interface `Type`.

``` csharp
Expect("foo").To.Be.InstanceOf(typeof(IComparable));
```

## Boolean expectations

### .Be.True()

Test that a value is true.

``` csharp
Expect(1 == 1).To.Be.True();
```

### .Be.False()

Test that a value is false.

``` csharp
Expect(1 == 2).To.Be.False();
```

## String expectations

All string assertions are case-sensitive.

### .Equal(string)

Overrides the default `.Equal(object)` to utilize string comparison. Will throw
an exception if the two strings are not equivilant.

``` csharp
Expect("redundancy").To.Equal("redundancy");
```

### .Contain(string)

Test that one string contains another. A string will always contain itself.

``` csharp
Expect("foobar").To.Contain("ooba");
```

### .StartWith(string)

Test that one string begins with another. A string will always start with
itself.

``` csharp
Expect("fat pants").To.StartWith("f");
```

### .EndWith(string)

Test that one string ends with another. A string will always end with
itself.

``` csharp
Expect("techno").To.EndWith("no");
```

### .Match(Regex), .Match(string)

Test that the string under test matches a regular expression.

``` csharp
// Match against Regex objects
var re = new Regex(@"\d+$");
Expect("abc123").To.Match(re);

// Match against strings
Expect("foobar").To.Match(@"\w{3}");
```

### .Be.Empty()

Test that the string under test is empty.

``` csharp
var comments = "";
Expect(comments).To.Be.Empty();
```

## int expectations

### .Equal(int)

Overrides the default `.Equal(object)` for integer comparison.

``` csharp
Expect(2 + 2).To.Equal(4);
```

### .Be.LessThan(int)

Test that an integer is smaller than a certain value

``` csharp
Expect(3).To.Be.LessThan(4);
```

### .Be.GreaterThan(int)

Test that an integer is larger than a certain value

``` csharp
Expect(9).To.Be.GreaterThan(-45);
```

### .Be.Zero()

Test that an integer is equal to 0

``` csharp
Expect(5 - 5).To.Be.Zero();
```

## Collection&lt;T&gt; expectations

All expectations utilize generics, and will Lingo will expect you to compare
collections with the same types.

### .Contain(T)

Test that a collection contains a given element.

``` csharp
var ints = new[] { 1, 2, 4 };
Expect(ints).To.Contain(4);
```

### .Equal(ICollection&lt;T&gt;)

Test that two collections are equal. Collections are considred equal when they
contain the same elements in exactly the same order.

``` csharp
var ints = new[] { 1, 2, 4 };
var mints = new [] { 1, 2, 4 };
Expect(ints).To.Equal(mints);
```

### .Be.EquivilantTo(ICollection&lt;T&gt;)

Test that the two collections are equivilant. Collections are considered
equivilant when they contain the same elements (including duplicates), but are
not necessarily in the same order.

``` csharp
var ints = new[] { 1, 2, 4 };
var backwards = new { 4, 2, 1 };
Expect(backwards).To.Be.EquivilantTo(ints);
```

### .Be.SubsetOf(ICollection&lt;T&gt;)

Test that a collection is a subset of another.

``` csharp
var ints = new[] { 1, 2, 4 };
var firstTwo = new[] { 1, 2 };
Expect(firstTwo).To.Be.SubsetOf(ints);
```
