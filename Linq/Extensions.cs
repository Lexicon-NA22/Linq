using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal static class Extensions
    {
        internal static void IntExt(this int x) => Console.WriteLine(x);

        internal static string Add(this string str, string newWord) => str + " " + newWord;

        public static string Add(this string str, params string[] words)
        {
            return $"{str} {String.Join(" ", words)}";
        }

        public static IEnumerable<T> ReturnIfTrue<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            if(source == null) throw new ArgumentNullException(nameof(source));
            if(predicate == null) throw new ArgumentNullException(nameof(predicate));

            foreach (var item in source)
            {
                if(predicate(item)) yield return item;
            }
        }
    }
}
