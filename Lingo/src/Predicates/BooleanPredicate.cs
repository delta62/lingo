using System;

namespace Lingo
{
    public class BooleanPredicate : Predicate
    {
        private bool expected;
        private BooleanIdentityPredicate be;

        public BooleanIdentityPredicate Be
        {
            get
            {
                if (be == null)
                {
                    be = new BooleanIdentityPredicate(expected);
                }
                return be;
            }
        }

        public BooleanPredicate(bool expected)
        {
            this.expected = expected;
        }
    }
}

