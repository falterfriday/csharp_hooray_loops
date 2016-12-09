using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hooray_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("i equals: " + i);
            }
            string[] fruit = { "apples", "bananas", "Oranges" };

            for (int i = 0; i < fruit.Length; i++)
            {
                Console.WriteLine("the fruit of the day is: " + fruit[i]);
            }
        }
    }
}
