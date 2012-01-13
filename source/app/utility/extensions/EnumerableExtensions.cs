using System;
using System.Collections.Generic;

namespace app.utility.extensions
{
    public static class EnumerableExtensions
    {
        public static void each<T>(this IEnumerable<T> collection,Action<T> action)
        {
            foreach (var item in collection)
            {
                action(item);
            }
        }
    }
}