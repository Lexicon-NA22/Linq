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
        
    }
}
