using System;

namespace Lingo
{
    public class BooleanExpectation
    {
        public BooleanPredicate To
        {
            get;
            private set;
        }

        public BooleanExpectation Not
        {
            get
            {
                To.Inverted = !To.Inverted;
                return this;
            }
        }

        public BooleanExpectation(bool expected)
        {
            To = new BooleanPredicate(expected);
        }
    }
}

