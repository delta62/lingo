using System;
using System.Text.RegularExpressions;

namespace Lingo
{
	public class StringPredicate : ObjectPredicate
	{
		private string expected;
		private StringIdentityPredicate be;

		public new StringIdentityPredicate Be
		{
			get
			{
				if (be == null)
				{
					be = new StringIdentityPredicate(expected, Inverted);
				}
				return be;
			}
		}

		internal StringPredicate(string expected) : base(expected)
		{
			this.expected = expected;
		}

		public void Equal(string actual)
		{
			var msg = "equal";
			Test(actual == expected, msg, expected, actual);
		}

		public void Contain(string substring)
		{
			var msg = "contain";
			Test(expected.Contains(substring), msg, expected, substring);
		}

		public void StartWith(string substring)
		{
			var msg = "start with";
			Test(expected.StartsWith(substring), msg, expected, substring);
		}

		public void EndWith(string substring)
		{
			var msg = "end with";
			Test(expected.EndsWith(substring), msg, expected, substring);
		}

		public void Match(Regex regex)
		{
			var msg = "match";
			Test(regex.IsMatch(expected), msg, expected, regex.ToString());
		}

		public void Match(string regex)
		{
			var msg = "match";
			var re = new Regex(regex);
			Test(re.IsMatch(expected), msg, expected, regex);
		}
	}
}

