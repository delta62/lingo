using NUnit.Framework;
using System;

namespace Lingo.Test
{
    [TestFixture]
    class ComparablePredicateTest : Expectation
    {
        private DateTime now;
        private DateTime before;
        private DateTime after;

        [SetUp]
        public void SetUp()
        {
            now = DateTime.Now;
            before = now.AddDays(-1);
            after = now.AddDays(1);
        }

        [Test]
        public void ShouldTestEqualitySuccess()
        {
            var eq = new DateTime(now.Ticks);
            Expect(eq).To.Equal(now);
        }

        [Test]
        [ExpectedException(typeof(ExpectationException))]
        public void ShouldTestEqualityFailure()
        {
            Expect(before).To.Equal(now);
        }

        [Test]
        public void ShouldTestLessThanSuccess()
        {
            Expect(before).To.Be.LessThan(after);
        }

        [Test]
        [ExpectedException(typeof(ExpectationException))]
        public void ShouldTestLessThanFailure()
        {
            Expect(after).To.Be.LessThan(before);
        }

        [Test]
        public void ShouldTestGreaterThanSuccess()
        {
            Expect(after).To.Be.GreaterThan(before);
        }

        [Test]
        [ExpectedException(typeof(ExpectationException))]
        public void ShouldTestGreaterThanFailure()
        {
            Expect(before).To.Be.GreaterThan(after);
        }
    }
}
