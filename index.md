---
layout: default
title: Home
toc:
    -
        name: What is Lingo?
        link: toc_0
    -
        name: With Inheritance
        link: toc_1
    -
        name: Without Inheritance
        link: toc_2
    -
        name: Test Cases
        link: toc_3
---

## What is Lingo?

Lingo is an expressive and simple assertion library for your test code. It can be used alongside any testing framework you are already using, such as NUnit or MSTest.

``` csharp
var foo = "foobar";
Expect(foo).To.Contain("bar");
```

## Using Lingo with inheritance

If you are using a test framework that allows you to inherit in your test classes, you can get a very clean syntax by extending the `Lingo.Expectation` class:

``` csharp
using Lingo;

[TestClass]
public class StringTest : Expectation
{
    [Test]
    public void ShouldOverloadPlus()
    {
        var concat = "foo" + "bar";
        Expect(concat).To.Equal("foobar");
    }
}
```


## Using Lingo without inheritance

If you're using a test framework that doesn't like your test classes inheriting things (such as Visual Studio's built-in unit test project type) or if you prefer not to inherit for some reason, simply prefix your expectations with `I`.

``` csharp
using Lingo;

[TestClass]
public class StringTest
{
    [TestMethod]
    public void ShouldOverloadPlus()
    {
        var concat = "foo" + "bar";
        I.Expect(concat).To.Equal("foobar");
    }
}
```

## Supported test cases

Lingo has built-in support for:

* ints
* strings
* bools
* collections
* objects

Each type has its own overloaded version of the `Expect` method.

``` csharp
Expect(new[] { "test" }).To.Contain("test");

Expect(!false).To.Be.True();
```


All tests inherit the test methods of `object` tests like you would expect.

``` csharp
var meat = "ham";
var meatRef = meat;
Expect(meatRef).To.EqualRef(meat);
```


You can negate the expectation of any test by using the `Not` property.

``` csharp
var seattleWeather = "rainy";
Expect(seattleWeather).Not.To.Equal("sunny");
```

