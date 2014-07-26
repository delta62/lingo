using System;

namespace Lingo
{
	public class ObjectIdentityPredicate : Predicate
	{
		private object expected;

		internal ObjectIdentityPredicate(object expected)
		{
			this.expected = expected;
		}

		public void Null()
		{
			var msg = "be null";
			Test(expected == null, msg, expected, null);
		}

		public void InstanceOf(Type actual)
		{
			var msg = "be an instance of";
			Test(actual.IsInstanceOfType(expected), msg, expected, actual);
		}
	}
}

