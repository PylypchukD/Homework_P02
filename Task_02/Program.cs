using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Несколькими способами создайте коллекцию, в которой можно хранить только целочисленные и вещественные значения, по типу «счет предприятия – доступная сумма» соответственно. 
             */
            Console.WriteLine("Использование Hashtable: ");

            Hashtable hashtable = new Hashtable()
            {
                { 4444333322221111, 234234.54 },
                { 1234567812345678, 977858.33 },
                { 2468135792468135, 128563423.32 },
                { 4444333322221112, 234234.54 },
                { 9045690732752035, 0.01 },
            };
            foreach (DictionaryEntry item in hashtable)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.WriteLine("\nИспользование Dictionary: ");

            Dictionary<long, double> dict = new Dictionary<long, double>()
            {
                { 4444333322221111, 234234.54 },
                { 1234567812345678, 977858.33 },
                { 2468135792468135, 128563423.32 },
                { 4444333322221112, 234234.54 },
                { 9045690732752035, 0.01 },
            };
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.WriteLine("\nИспользование SortedList: ");
            SortedList<long, double> list = new SortedList<long, double>()
            {
                { 4444333322221111, 234234.54 },
                { 1234567812345678, 977858.33 },
                { 2468135792468135, 128563423.32 },
                { 4444333322221112, 234234.54 },
                { 9045690732752035, 0.01 },
            };
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            Console.ReadKey();
        }
    }
}
