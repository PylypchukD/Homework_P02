using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Используя класс SortedList, создайте небольшую коллекцию и выведите на экран значения пар «ключ-значение» сначала в алфавитном порядке, а затем в обратном.
             */

            SortedList<int, string> sortedList = new SortedList<int, string>();
            sortedList.Add(1, "Бiлий");
            sortedList.Add(7, "Сiрий");
            sortedList.Add(3, "Чорний");
            sortedList.Add(4, "Фiолетовий");
            sortedList.Add(6, "Зеленiй");
            sortedList.Add(2, "Синiй");
            sortedList.Add(5, "Червоний");

            Console.WriteLine("Сортований список: ");
            foreach (var item in sortedList)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            var newSortedList = sortedList.Reverse();


            Console.WriteLine("Зворотньосортований список: ");
            foreach (var item in newSortedList)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            Console.ReadKey();
        }
    }
}
