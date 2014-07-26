using NUnit.Framework;
using Lingo;
using System;

namespace Lingo.Test
{
	[TestFixture()]
	public class NumberPredicateTest : Expectation
	{
		[Test()]
		public void ShouldTestEqualitySuccess()
		{
			Expect(8).To.Equal(8);
		}

		[Test]
		[ExpectedException(typeof(ExpectationException))]
		public void ShouldTestEqualityFailure()
		{
			Expect(8).To.Equal(9);
		}

		[Test]
		public void ShouldTestLessThanSuccess()
		{
			Expect(8).To.Be.LessThan(42);
		}

		[Test]
		[ExpectedException(typeof(ExpectationException))]
		public void ShouldTestLessThanFailure()
		{
			Expect(8).To.Be.LessThan(0);
		}

		[Test]
		public void ShouldTestGreaterThanSuccess()
		{
			Expect(8).To.Be.GreaterThan(0);
		}

		[Test]
		[ExpectedException(typeof(ExpectationException))]
		public void ShouldTestGreaterThanFailure()
		{
			Expect(8).To.Be.GreaterThan(42);
		}

		[Test]
		public void ShouldTestZeroSuccess()
		{
			Expect(0).To.Be.Zero();
		}

		[Test]
		[ExpectedException(typeof(ExpectationException))]
		public void ShouldTestZeroFailure()
		{
			Expect(42).To.Be.Zero();
		}
	}
}

