using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stringList = new List<string> { "diamond", "sapphire", "diamond", "diamond", "tanzanite", "emerald" };
            var integerList = new List<int> { 7, 4, 6, 6, 5, 2, 4 };
            var characterList = new List<char> { 'd', 's', 'd', 'd', 't', 'e' };

            Console.WriteLine("Frequency of each string on list:");
            CountItems(stringList);

            Console.WriteLine("\nFrequency of each integer on list:");
            CountItems(integerList);

            Console.WriteLine("\nFrequency of each character on list:");
            CountItems(characterList);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        public static void CountItems<T>(IEnumerable<T> items)
        {
            var itemCounts = new Dictionary<T, int>();

            foreach (var item in items)
            {
                if (itemCounts.ContainsKey(item))
                {
                    itemCounts[item]++;
                }
                else
                {
                    itemCounts[item] = 1;
                }
            }



        }
    }
}
