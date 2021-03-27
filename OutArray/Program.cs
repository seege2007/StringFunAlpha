using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutArray
{
    class Program
    {
        static void Main(string[] args)
        {
            bool x = true;
            string[] links;

            myArray(out x, out links);

            Console.WriteLine("Array elements are:");
            for (int i = 0; i < links.Length; i++)
                Console.WriteLine(links[i]);

            Console.ReadKey();
        }

        static public void myArray(out bool x, out string[] links)
        {
            string[] empty = new string[3];

            //bool y = true;

            x = false;

            links = empty; 

            if (x == true)
            {
                links = new string[3] { "A", "B", "C" };
            }
            else
            {
                links = new string[3] { "AA", "AB", "AC" };
            }
        }
    }
}
