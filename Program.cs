using System;
using System.Collections.Generic;

/** <remark>
 * Write a program that counts, in a given array of integers, the number of occurrences of each integer.
 * Use Dictionary<TKey,TValue>.
 * Example: array = {3, 4, 4, 2, 3, 3, 4, 3, 2}
 * 2 -> 2 times
 * 3 -> 4 times
 * 4 -> 3 times
</remark> */

namespace _20180315_Task2
{
    internal class Program
    {
        private static void Main()
        {
            Dictionary<int, int> numbers = new Dictionary<int, int>();
            int[] array = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

            try
            {
                Console.Write("Array = { ");
                foreach (int item in array)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("}\n");

                Array.Sort(array);
                CountOfOccurrences(numbers, array);
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Method that counts, in a given array of integers, the number of occurrences of each integer.
        /// </summary>
        /// <param name="dictionary">A collection of keys and values.</param>
        /// <param name="ints">Array of integers.</param>
        private static void CountOfOccurrences(IDictionary<int, int> dictionary, IEnumerable<int> ints)
        {
            if (ints == null)
                throw new ArgumentNullException(nameof(ints));
            if (dictionary == null)
                throw new ArgumentNullException(nameof(dictionary));

            foreach (int values in ints)
            {
                if (dictionary.ContainsKey(values))
                    dictionary[values]++;
                else
                    dictionary.Add(values, 1);
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value} times");
            }
        }
    }
}