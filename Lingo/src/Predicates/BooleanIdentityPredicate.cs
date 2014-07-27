using System;

namespace Lingo
{
    public class BooleanIdentityPredicate : Predicate
    {
        private bool expected;

        public BooleanIdentityPredicate(bool expected)
        {
            this.expected = expected;
        }

        public void False()
        {
            Test(!expected, "false", expected, null);
        }

        public void True()
        {
            Test(expected, "true", expected, null);
        }
    }
}

