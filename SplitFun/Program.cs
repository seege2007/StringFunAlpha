using System;

namespace SplitFun
{
    class Program
    {
        static void Main(string[] args)
        {
            // Contains a semicolon delimiter.
            string input = "Alabama,Alaska,American Samoa,Arizona,Arkansas,California,Colorado,Connecticut,Delaware,District of Columbia,Florida,Georgia,Guam,Hawaii,Idaho,Illinois,Indiana,Iowa,Kansas,Kentucky,Louisiana,Maine,Maryland,Massachusetts,Michigan,Minnesota,Minor Outlying Islands,Mississippi,Missouri,Montana,Nebraska,Nevada,New Hampshire,New Jersey,New Mexico,New York,North Carolina,North Dakota,Northern Mariana Islands,Ohio,Oklahoma,Oregon,Pennsylvania,Puerto Rico,Rhode Island,South Carolina,South Dakota,Tennessee,Texas,U.S. Virgin Islands,Utah,Vermont,Virginia,Washington,West Virginia,Wisconsin,Wyoming";
            Console.WriteLine($"Input: {input}");

            // Part 1: split on a single character.
            string[] array = input.Split(',');

            // Part 2: use a foreach-loop.
            // ... Print each value in the array.
            foreach (string value in array)
            {
                Console.WriteLine($"Part: {value}");
            }

            for(int x = 0; x < array.Length; x++)
            {
                Console.WriteLine(array[x]);
            }
           

            Console.ReadKey();

        }
    }
}
