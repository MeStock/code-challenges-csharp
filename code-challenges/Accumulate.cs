using System;
using System.Collections.Generic;

namespace code_challenges
{
    public static class AccumulateExtensions
    {
        public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
        {
            foreach (T item in collection)
            {
                yield return func(item);
            }
        }
    }
}
