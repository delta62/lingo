using NUnit.Framework;
using Lingo;
using System;

namespace Lingo.Test
{
	[TestFixture()]
	public class ObjectPredicateTest : Expectation
	{
		private object obj;
		private object obj2;
		private object clone;

		[SetUp]
		public void SetUp()
		{
			obj = new object();
			obj2 = new object();
			clone = obj;
		}

		[Test()]
		public void ShouldTestEqualitySuccess()
		{
			Expect(clone).To.Equal(obj);
		}

		[Test]
		[ExpectedException(typeof(ExpectationException))]
		public void ShouldTestEqualityFailure()
		{
			Expect(obj).To.Equal(obj2);
		}

		[Test]
		public void ShouldTestReferenceEqualitySuccess()
		{
			Expect(clone).To.EqualRef(obj);
		}

		[Test]
		[ExpectedException(typeof(ExpectationException))]
		public void ShouldTestReferenceEqualityFailure()
		{
			Expect(obj).To.EqualRef(obj2);
		}

		[Test]
		public void ShouldTestNullSuccess()
		{
			object n = null;
			Expect(n).To.Be.Null();
		}

		[Test]
		[ExpectedException(typeof(ExpectationException))]
		public void ShouldTestNullFailure()
		{
			Expect(obj).To.Be.Null();
		}

		[Test]
		public void ShouldTestInstanceOfSuccess()
		{
			Expect(obj).To.Be.InstanceOf(typeof(object));
		}

		[Test]
		[ExpectedException(typeof(ExpectationException))]
		public void ShouldTestInstanceOfFailure()
		{
			Expect(obj).To.Be.InstanceOf(typeof(string));
		}
	}
}

