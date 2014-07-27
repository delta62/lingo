using System;
using System.Collections.Generic;

namespace Lingo
{
	public static class I
	{
		public static NumberExpectation Expect(int expected)
		{
			return new NumberExpectation(expected);
		}

		public static StringExpectation Expect(string expected)
		{
			return new StringExpectation(expected);
		}

		public static ObjectExpectation Expect(object expected)
		{
			return new ObjectExpectation(expected);
		}

        public static CollectionExpectation<T> Expect<T>(ICollection<T> expected)
		{
            return new CollectionExpectation<T>(expected);
		}

        public static BooleanExpectation Expect(bool expected)
        {
            return new BooleanExpectation(expected);
        }
	}
}

