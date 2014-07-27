using System;

namespace Lingo
{
	public class NumberPredicate : ObjectPredicate
	{
		private int expected;
		private NumberIdentityPredicate be;

		public new NumberIdentityPredicate Be
		{
			get
			{
				if (be == null)
				{
					be = new NumberIdentityPredicate(expected, Inverted);
				}
				return be;
			}
		}

        internal NumberPredicate(int expected) : base(expected)
		{
			this.expected = expected;
		}

		public void Equal(int actual)
		{
			var msg = "equal";
			Test(actual == expected, msg, expected, actual);
		}
	}
}

