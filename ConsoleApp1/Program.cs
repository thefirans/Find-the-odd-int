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
            foreach (var item in seq.GroupBy(x => x))
            {
                int times = item.Count();
                if (times % 2 != 0)
                {
                    result = item.Key;
                }
            }
            return result;
        }

    }
}
