using System;

namespace Lingo
{
	public class ObjectPredicate : Predicate
	{
		private object expected;

		public ObjectIdentityPredicate Be
		{
			get;
			private set;
		}

		internal ObjectPredicate(object expected)
		{
			this.expected = expected;
			Be = new ObjectIdentityPredicate(expected);
		}

		public void Equal(object actual)
		{
			var msg = "equal";
			Test(expected.Equals(actual), msg, expected, actual);
		}

		public void EqualRef(object actual)
		{
			var msg = "refer to the same object as";
			Test(object.ReferenceEquals(expected, actual), msg, expected, actual);
		}
	}
}

