using System;
using System.Collections.Generic;

namespace Lingo
{
    public class CollectionPredicate<T> : ObjectPredicate
	{
        private ICollection<T> expected;
        private CollectionIdentityPredicate<T> be;

        public CollectionPredicate(ICollection<T> expected) : base(expected)
		{
            this.expected = expected;
		}

        public new CollectionIdentityPredicate<T> Be
        {
            get
            {
                if (be == null)
                {
                    be = new CollectionIdentityPredicate<T>(expected);
                }
                return be;
            }
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

