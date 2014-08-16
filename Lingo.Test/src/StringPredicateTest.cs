using NUnit.Framework;
using Lingo;
using System;
using System.Text.RegularExpressions;

namespace Lingo.Test
{
	[TestFixture()]
	public class StringPredicateTest : Expectation
	{
		[Test()]
		public void ShouldTestEqualitySuccess()
		{
			Expect("foo").To.Equal("foo");
		}

		[Test]
		[ExpectedException(typeof(ExpectationException))]
		public void ShouldTestEqualityFailure()
		{
			Expect("foo").To.Equal("bar");
		}

		[Test]
		public void ShouldTestContainsSuccess()
		{
			Expect("foo").To.Contain("oo");
		}

		[Test]
		[ExpectedException(typeof(ExpectationException))]
		public void ShouldTestContainsFailure()
		{
			Expect("foo").To.Contain("bar");
		}

		[Test]
		public void ShouldTestStartsWithSuccess()
		{
			Expect("foo").To.StartWith("f");
		}

		[Test]
		[ExpectedException(typeof(ExpectationException))]
		public void ShouldTestStartsWithFailure()
		{
			Expect("foo").To.StartWith("b");
		}

		[Test]
		public void ShouldTestEndsWithSuccess()
		{
			Expect("foo").To.EndWith("o");
		}

		[Test]
		[ExpectedException(typeof(ExpectationException))]
		public void ShouldTestEndsWithFailure()
		{
			Expect("foo").To.EndWith("r");
		}

		[Test]
		public void ShouldTestMatchSuccess()
		{
			var re = new Regex(@"\w{3}");
			Expect("foo").To.Match(re);
		}

		[Test]
		[ExpectedException(typeof(ExpectationException))]
		public void ShouldTestMatchFailure()
		{
			var re = new Regex(@"\d+");
			Expect("foo").To.Match(re);
		}

		[Test]
		public void ShouldTestStringMatchSuccess()
		{
			Expect("foo").To.Match(@"\w{3}");
		}

		[Test]
		[ExpectedException(typeof(ExpectationException))]
		public void ShouldTestStringMatchFailure()
		{
			Expect("foo").To.Match(@"\d+");
		}

		[Test]
		public void ShouldTestEmptyStringSuccess()
		{
			Expect("").To.Be.Empty();
		}

		[Test]
		[ExpectedException(typeof(ExpectationException))]
		public void ShouldTestEmptyStringFailure()
		{
			Expect("foo").To.Be.Empty();
		}

		[Test]
		public void ShouldInheritObjectTests()
		{
			var foo = "foo";
			var bar = foo;
			Expect(foo).To.EqualRef(bar);
		}

        [Test]
        public void ShouldInheritObjectIdentityTests()
        {
            string foo = null;
            Expect(foo).To.Be.Null();
        }
	}
}

