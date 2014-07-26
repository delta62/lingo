using System;

namespace Lingo
{
	public class NumberExpectation
	{
		public NumberPredicate To
		{
			get;
			private set;
		}

		public NumberExpectation Not
		{
			get
			{
				To.Inverted = !To.Inverted;
				return this;
			}
		}

		internal NumberExpectation(int expected)
		{
			To = new NumberPredicate(expected);
		}
	}
}

