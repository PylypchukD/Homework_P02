using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Создайте коллекцию типа OrderedDictionary и реализуйте в ней возможность сравнения значений. 
             */
            
            var emailLookup1 = new OrderedDictionary(new EqualityComparer())
                                  {
                                      {"bbbb", "Bishop, Scott"},
                                      {"aaaa", "Hell, Christian"},
                                      {"cccc", "Jump, Dan"}
                                  };

            foreach (DictionaryEntry entry in emailLookup1)
            {
                Console.WriteLine(entry.Value);
            }
            

            // Delay
            Console.ReadKey();

        }
    }
    public class EqualityComparer : IEqualityComparer
    {
        public new bool Equals(object x, object y)
        {

            if (ReferenceEquals(x, y)) 
                return true;

            if (ReferenceEquals(x, null)) 
                return false;

            if (ReferenceEquals(y, null)) 
                return false;

            if (x.GetType() != y.GetType()) 
                return false;

            return false;
        }

        public int GetHashCode(object obj)
        {
            return obj.ToString().ToLowerInvariant().GetHashCode();
        }
    }
}
