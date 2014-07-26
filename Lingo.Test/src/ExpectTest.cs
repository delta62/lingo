using NUnit.Framework;
using Lingo;
using System;

namespace Lingo.Test
{
	[TestFixture]
	public class ExpectTest : Expectation
	{
		[Test]
		public void ShouldAcceptObjects()
		{
			var expectation = Expect(new object());
			Assert.IsInstanceOfType(typeof(ObjectExpectation), expectation);
		}

		[Test]
		public void ShouldAcceptStrings()
		{
			var expectation = Expect("foo");
			Assert.IsInstanceOfType(typeof(StringExpectation), expectation);
		}

		[Test]
		public void ShouldAcceptIntegers()
		{
			var expectation = Expect(2);
			Assert.IsInstanceOfType(typeof(NumberExpectation), expectation);
		}

		[Test]
		public void ShouldAcceptCollections()
		{
			var expectation = Expect(new[] { "foo" });
            Assert.IsInstanceOfType(typeof(CollectionExpectation<string>), expectation);
		}
	}

	[TestFixture]
	public class ExpectNoInheritance
	{
		[Test]
		public void ShouldWorkWithoutInheriting()
		{
			var expectation = I.Expect(new object());
			Assert.IsInstanceOfType(typeof(ObjectExpectation), expectation);
		}

		[Test]
		public void ShouldAcceptStringsWithoutInheriting()
		{
			var expectation = I.Expect("foo");
			Assert.IsInstanceOfType(typeof(StringExpectation), expectation);
		}

		[Test]
		public void ShouldAcceptIntegersWithoutInheriting()
		{
			var expectation = I.Expect(2);
			Assert.IsInstanceOfType(typeof(NumberExpectation), expectation);
		}
	}

	[TestFixture]
	public class MixedImplementations : Expectation
	{
		[Test]
		public void ShouldAllowInheritedForm()
		{
			Expect(0).To.Equal(0);
		}

		[Test]
		public void ShouldAllowDeclarativeForm()
		{
			I.Expect(0).To.Equal(0);
		}
	}
}

