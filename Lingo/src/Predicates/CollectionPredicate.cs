using System;
using System.Collections.Generic;

namespace Lingo
{
	public class CollectionPredicate<T> : Predicate
	{
        private ICollection<T> expected;

        public CollectionPredicate(ICollection<T> expected)
		{
            this.expected = expected;
		}

        public void Contain(T actual)
        {
            var msg = "contain";
            Test(expected.Contains(actual), msg, expected, actual);
        }

        public void Equal(ICollection<T> actual)
        {
            var msg = "equal";

            Test(expected.Count == actual.Count, msg, expected, actual);

            var expEnum = expected.GetEnumerator();
            var actEnum = actual.GetEnumerator();

            while (expEnum.MoveNext())
            {
                actEnum.MoveNext();
                var equal = actEnum.Current.Equals(expEnum.Current);
                Test(equal, msg, expected, actual);
            }
        }
	}
}

