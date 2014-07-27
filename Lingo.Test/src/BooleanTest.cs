using NUnit.Framework;
using System;

namespace Lingo.Test
{
    [TestFixture]
    public class BooleanTest : Expectation
    {
        [Test]
        public void ShouldTestFalseSuccess()
        {
            Expect(false).To.Be.False();
        }

        [Test]
        [ExpectedException(typeof(ExpectationException))]
        public void ShouldTestFalseFailure()
        {
            Expect(true).To.Be.False();
        }

        [Test]
        public void ShouldTestTrueSuccess()
        {
            Expect(true).To.Be.True();
        }

        [Test]
        [ExpectedException(typeof(ExpectationException))]
        public void ShouldTestTrueFailure()
        {
            Expect(false).To.Be.True();
        }
    }
}

