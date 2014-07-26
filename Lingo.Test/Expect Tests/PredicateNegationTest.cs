using NUnit.Framework;
using Lingo;
using System;

namespace Lingo.Test
{
	[TestFixture]
	public class PredicateNegationTest : Expectation
	{
		[Test]
		public void ShouldNegateSuccessfulTask()
		{
			Expect(0).Not.To.Equal(8);
		}

		[Test]
		[ExpectedException(typeof(ExpectationException))]
		public void ShouldNegateFailingTask()
		{
			Expect(0).Not.To.Equal(0);
		}

		[Test]
		public void ShouldAllowDoubleNegation()
		{
			Expect(0).Not.Not.To.Equal(0);
		}
	}
}

