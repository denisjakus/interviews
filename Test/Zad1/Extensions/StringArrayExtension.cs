using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zad1.Extensions
{
    public static class StringArrayExtensions
    {
        public static List<int> ConvertArrayOfStringsToListOfIntegers(this string[] array)
        {
            return Array.ConvertAll(array, int.Parse).ToList();
        }
    }
}
