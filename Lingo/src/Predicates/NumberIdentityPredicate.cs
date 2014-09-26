using System;

namespace Lingo
{
	public class NumberIdentityPredicate : Predicate
	{
		private int expected;

		internal NumberIdentityPredicate(int expected, bool negate)
		{
			this.expected = expected;
			Inverted = negate;
		}

		public void LessThan(int actual)
		{
			var msg = "be less than";
			Test(expected < actual, msg, expected, actual);
		}

		public void GreaterThan(int actual)
		{
			var msg = "be greater than";
			Test(expected > actual, msg, expected, actual);
		}

        [Obsolete("Please use .Equal instead.")]
		public void Zero()
		{
			var msg = "equal";
			Test(expected == 0, msg, expected, 0);
		}
	}
}

