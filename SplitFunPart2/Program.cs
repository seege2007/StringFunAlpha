using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SplitFunPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "(01) 2005 SCION TC";
            string output = input.Split('(', ')')[1];

            var star = output.Replace("*", "");


            var x = Convert.ToInt32(star);

         /*   //is this a V2 or greater
            if(x >= 2)
            {   //is this a 99?
                if(x == 99)
                {
                    //return true;
                }
                else
                {
                   // return false;
                }
            }
            else
            {
                return false;
            }*/

            //string input = "1812 Prairie View Dr.,Dallas,Tx 75235";
            //Console.WriteLine($"Input: {input}");

            // Part 1: split on a single character.
            //string[] array = input.Split(',').Select(x => x.Trim()).ToArray();

            //for (int x = 0; x < array.Length; x++)
            // {
            //   Console.WriteLine(String.Format("array{0}: {1}", x, array[x]));

            //}

            /*  string state = "";

              //add switch case

              if (state == "TX")
              {
                  //return "Texas";
              }
              else if (state == "FL")
              {
                  //return "Florida";
              }*/

            Console.ReadKey();
            
        }
    }
}
