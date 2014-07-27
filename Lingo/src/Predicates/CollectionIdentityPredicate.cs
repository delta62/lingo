﻿using System;
using System.Collections.Generic;

namespace Lingo
{
    public class CollectionIdentityPredicate<T> : Predicate
    {
        private ICollection<T> expected;

        public CollectionIdentityPredicate(ICollection<T> expected)
        {
            this.expected = expected;
        }

        public void SubsetOf(ICollection<T> actual)
        {
            var msg = "a subset of";
            var actualCopy = new List<T>(actual);
            var expEnum = expected.GetEnumerator();

            while (expEnum.MoveNext())
            {
                var actualItem = actualCopy.Find(item =>
                {
                    return item.Equals(expEnum.Current);
                });
                Test(actualItem != null, msg, expected, actual);
                actualCopy.Remove(actualItem);
            }
        }
    }
}

