using System;
using System.Collections.Generic;
using System.Text;

namespace Lingo
{
    public class ComparableExpectation
    {
        public ComparablePredicate To
        {
            get;
            private set;
        }

        public ComparableExpectation Not
        {
            get
            {
                To.Inverted = !To.Inverted;
                return this;
            }
        }

        internal ComparableExpectation(IComparable expected)
        {
            To = new ComparablePredicate(expected);
        }
    }
}
