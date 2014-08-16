using NUnit.Framework;
using Lingo;
using System;

namespace Lingo.Test
{
    [TestFixture]
    public class ExceptionTest : Expectation
    {
        [Test]
        public void ShouldExpandPredicateNullInErrorMessages()
        {
            try
            {
                Expect(null).To.Equal("foo");
            }
            catch (ExpectationException ex)
            {
                StringAssert.Contains("null", ex.Message);
                return;
            }

            throw new Exception();
        }

        [Test]
        public void ShouldExpandExpectationNullInErrorMessages()
        {
            try
            {
                Expect("foo").To.Equal(null);
            }
            catch (ExpectationException ex)
            {
                StringAssert.Contains("null", ex.Message);
                return;
            }

            throw new Exception();
        }

        [Test]
        public void ShouldQuoteStringExpectations()
        {
            try
            {
                Expect("foo").To.Equal("bar");
            }
            catch (ExpectationException ex)
            {
                StringAssert.Contains(@"""foo""", ex.Message);
                return;
            }

            throw new Exception();
        }
    }
}

