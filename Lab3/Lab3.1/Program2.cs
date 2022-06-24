using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborat3._2
{
    class Program2
    {
        static void ShowDict(Dictionary<int, string> dictionary)
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine($"key: {item.Key} || value: {item.Value}");
            }
            Console.WriteLine("\n");
        }

        static void DictSerialize(Dictionary<int, string> dictionary)
        {
            /*string jsonString = JsonSerializer.Serialize(dictionary);*/
        /*    File.WriteAllText("Serialization1.json ", jsonString);  //serialization
            Console.WriteLine(jsonString);*/

        }
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary1 = new Dictionary<int, string>()
            {
                {1, "key1" },
                {3, "key2" },
                {6, "key3" },
                {5, "key3" },
                {4, "key11" }

            };
            Dictionary<int, string> dictionary2 = new Dictionary<int, string>()
            {
                {5, "key3" },
                {1, "key1" },
                {3, "key4" },
                {4, "key6" },
                {2, "key3" }
            };

            Console.WriteLine($"Словник dictionary1: ");
            ShowDict(dictionary1);
            Console.WriteLine($"Словник dictionary2: ");
            ShowDict(dictionary2);

            Dictionary<int, string> dictionary3 = new Dictionary<int, string>();

            foreach (var item1 in dictionary1)
            {
                if (dictionary2.ContainsKey(item1.Key) && dictionary2.ContainsValue(item1.Value))
                {
                    Console.WriteLine($"key: {item1.Key} || value: {item1.Value} є в обох списках ");
                    dictionary3.Add(item1.Key, item1.Value);
                }

            }

            Console.WriteLine($"\nСформований словник dictionary3 та його данi занесенi до файлу:");
            ShowDict(dictionary3);
            DictSerialize(dictionary3);

        }

    }
}
