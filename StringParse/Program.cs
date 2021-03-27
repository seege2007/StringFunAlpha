using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[2] {"0988", "9999"};

          List<int> myInts = arr.Select(int.Parse).ToList();

            foreach(var x in myInts)
            {
                Console.WriteLine(x);
            }

            int result = myInts.Min();

            Console.WriteLine("Min Value is: {0}", result);

            Console.WriteLine();
        }
    }
}
