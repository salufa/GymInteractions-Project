using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Interactions.Utilities
{
    public static class EnumerableExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            foreach (var item in enumerable)
            {
                action(item);
            }
        }

        public static void ParallelForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            Parallel.ForEach(enumerable, action);
        }

        public static IEnumerable<V> OrElse<T, V>(this IEnumerable<T> enumerable,
            Func<T, bool> predicate,
            Func<T, V> onTrueAction,
            Func<T, V> onElseAction
            )
        {
            foreach (var item in enumerable)
            {
                if (predicate(item))
                {
                    yield return onTrueAction(item);
                }
                else
                {
                    yield return onElseAction(item);
                }
            }
            yield break;
        }

    }
}
