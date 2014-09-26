using System;

namespace Lingo
{
    public class ComparablePredicate : ObjectPredicate
    {
        private IComparable expected;
        private ComparableIdentityPredicate be;

        public new ComparableIdentityPredicate Be
        {
            get
            {
                if (be == null)
                {
                    be = new ComparableIdentityPredicate(expected, Inverted);
                }
                return be;
            }
        }

        internal ComparablePredicate(IComparable expected) : base(expected)
        {
            this.expected = expected;
        }

        public void Equal(IComparable actual)
        {
            var msg = "equal";
            var eq = expected.CompareTo(actual) == 0;
            Test(eq, msg, expected, actual);
        }
    }
}
