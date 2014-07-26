using System;
using System.Collections.Generic;

namespace Lingo
{
	public class CollectionExpectation<T>
	{
        public CollectionPredicate<T> To
        {
            get;
            private set;
        }

        public CollectionExpectation<T> Not
        {
            get
            {
                To.Inverted = !To.Inverted;
                return this;
            }
        }

        public CollectionExpectation(ICollection<T> expected)
        {
            To = new CollectionPredicate<T>(expected);
        }
	}
}

