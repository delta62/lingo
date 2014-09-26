using System;

namespace Lingo
{
    public class ComparableIdentityPredicate : Predicate
    {
        private IComparable expected;

        internal ComparableIdentityPredicate(IComparable expected, bool negate)
        {
            this.expected = expected;
            Inverted = negate;
        }

        public void LessThan(IComparable actual)
        {
            var msg = "be less than";
            var lt = expected.CompareTo(actual) < 0;
            Test(lt, msg, expected, actual);
        }

        public void GreaterThan(IComparable actual)
        {
            var msg = "be greater than";
            var gt = expected.CompareTo(actual) > 0;
            Test(gt, msg, expected, actual);
        }
    }
}
