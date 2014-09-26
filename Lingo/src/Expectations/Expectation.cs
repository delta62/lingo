using System;
using System.Collections.Generic;

namespace Lingo
{
	public class Expectation
	{
		public NumberExpectation Expect(int expected)
		{
			return new NumberExpectation(expected);
		}

		public StringExpectation Expect(string expected)
		{
			return new StringExpectation(expected);
		}

		public ObjectExpectation Expect(object expected)
		{
			return new ObjectExpectation(expected);
		}

        public CollectionExpectation<T> Expect<T>(ICollection<T> expected)
		{
            return new CollectionExpectation<T>(expected);
		}

        public ComparableExpectation Expect(IComparable expected)
        {
            return new ComparableExpectation(expected);
        }

        public BooleanExpectation Expect(bool expected)
        {
            return new BooleanExpectation(expected);
        }
	}
}

