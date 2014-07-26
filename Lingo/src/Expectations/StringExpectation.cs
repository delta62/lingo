using System;

namespace Lingo
{
	public class StringExpectation
	{
		public StringPredicate To
		{
			get;
			private set;
		}

		public StringExpectation Not
		{
			get
			{
				To.Inverted = !To.Inverted;
				return this;
			}
		}

		internal StringExpectation(string expected)
		{
			To = new StringPredicate(expected);
		}
	}
}

