using System;

namespace Lingo
{
	public class StringIdentityPredicate : Predicate
	{
		private string expected;

		internal StringIdentityPredicate(string expected, bool negate)
		{
			this.expected = expected;
			Inverted = negate;
		}

		public void Empty()
		{
			var msg = "be empty";
			Test(expected == "", msg, expected, null);
		}
	}
}

