using System;
using System.Collections.Generic;

namespace code_challenges
{
    public static class Strain
    {
        public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            List<T> result = new List<T>();

            foreach (T item in collection)
            {
                if (predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

        public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            List<T> result = new List<T>();

            foreach (T item in collection)
            {
                if (!predicate(item))
                {
                    result.Add(item);
                }
            }
            return result;
        }

    }
}
