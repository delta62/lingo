using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Lingo.Test
{
	[TestFixture]
	public class CollectionPredicateTest : Expectation
	{
        private ICollection<string> strings;

        [SetUp]
        public void SetUp()
        {
            strings = new[] { "foo", "bar", "baz" };
        }

        [Test]
        public void ShouldTestContainsSuccess()
        {
            Expect(strings).To.Contain("foo");
        }

        [Test]
        [ExpectedException(typeof(ExpectationException))]
        public void ShouldTestContainsFailure()
        {
            Expect(strings).To.Contain("qux");
        }

        [Test]
        public void ShouldTestNotSuccess()
        {
            Expect(strings).Not.To.Contain("qux");
        }

        [Test]
        [ExpectedException(typeof(ExpectationException))]
        public void ShouldTestNotFailure()
        {
            Expect(strings).Not.To.Contain("foo");
        }

        [Test]
        public void ShouldTestEqualsSuccess()
        {
            Expect(strings).To.Equal(new[] { "foo", "bar", "baz" });
        }

        [Test]
        [ExpectedException(typeof(ExpectationException))]
        public void ShouldTestEqualsFailure()
        {
            Expect(strings).To.Equal(new[] { "baz", "bar", "foo" });
        }

        [Test]
        public void ShouldAcceptEmptyCollections()
        {
            Expect(new int[] { }).To.Equal(new int[] { });
        }

        [Test]
        [ExpectedException(typeof(ExpectationException))]
        public void ShouldNotEqualSubset()
        {
            Expect(strings).To.Equal(new [] { "foo", "bar" });
        }

        [Test]
        [ExpectedException(typeof(ExpectationException))]
        public void ShouldNotEqualSuperset()
        {
            Expect(strings).To.Equal(new [] { "foo", "bar", "baz", "qux" });
        }

        [Test]
        public void ShouldTestSubsetSuccess()
        {
            Expect(strings).To.Be.SubsetOf(new[] { "foo", "baz", "qux", "bar" });
        }

        [Test]
        [ExpectedException(typeof(ExpectationException))]
        public void ShouldTestSubsetFailure()
        {
            Expect(strings).To.Be.SubsetOf(new[] { "foo", "foo", "bar" });
        }

        [Test]
        public void ShouldBeSubsetOfSelf()
        {
            Expect(strings).To.Be.SubsetOf(strings);
        }

        [Test]
        public void ShouldTestEquivilanceSuccess()
        {
            Expect(strings).To.Be.EquivilantTo(new[] { "bar", "foo", "baz" });
        }

        [Test]
        [ExpectedException(typeof(ExpectationException))]
        public void SHouldTestEquivilanceFailure()
        {
            Expect(strings).To.Be.EquivilantTo(new[] { "bar", "qux", "baz" });
        }
	}
}

