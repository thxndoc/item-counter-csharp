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

            Console.WriteLine("Count occurence of each string on list:");
            CountItems(stringList);

            Console.WriteLine("\nInteger list count:");
            CountItems(integerList);

            Console.WriteLine("\nCharacter list count:");
            CountItems(characterList);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }

        public static void CountItems<T>(IEnumerable<T> items)
        {
            
        }
    }
}
