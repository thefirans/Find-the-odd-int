using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Kata
    {
        public static int find_it(int[] seq)
        {
            int result = 0;
            foreach (var item in seq.GroupBy(x => x)) // find dublicates
            {
                int times = item.Count();             // how many times dublicate number repeat
                if (times % 2 != 0)                   // check if number is odd
                {
                    result = item.Key;                // return number which dublicates
                }
            }
            return result;
        }

    }
}
