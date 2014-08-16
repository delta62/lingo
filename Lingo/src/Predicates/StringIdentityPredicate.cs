using System;

namespace Lingo
{
    public class StringIdentityPredicate : ObjectIdentityPredicate
	{
		private string expected;

        internal StringIdentityPredicate(string expected, bool negate) : base(expected)
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

