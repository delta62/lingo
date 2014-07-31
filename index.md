---
layout: default
title: Home
icon: home
---

* el contento
{:toc}

# {{ site.title }}

### {{ site.tagline }}

## What is Lingo?

Lingo is an expressive and simple assertion library for your test code. It can be used alongside any testing framework you are already using, such as NUnit or MSTest.

```
var foo = "foobar";
Expect(foo).To.Contain("bar");
```

Lingo is lightweight, efficient, and thread safe. 

## Using Lingo with inheritance

If you are using a test framework that allows you to inherit in your test classes, you can get a very clean syntax by extending the `Lingo.Expectation` class:

```
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

```
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

```
Expect(new[] { "test" }).To.Contain("test");

Expect(!false).To.Be.True();
```


All tests inherit the test methods of `object` tests like you would expect.

```
var meat = "ham";
var meatRef = meat;
Expect(meatRef).To.EqualRef(meat);
```


You can negate the expectation of any test by using the `Not` property.

```
var seattleWeather = "rainy";
Expect(seattleWeather).Not.To.Equal("sunny");
```


