using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hooray_loops
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    for (int i = 0; i < 11; i++)
        //    {
        //        Console.WriteLine("i equals: " + i);
        //    }
        //    string[] fruit = { "Apples", "Bananas", "Oranges" };

        //    for (int i = 0; i < fruit.Length; i++)
        //    {
        //        Console.WriteLine("the fruit of the day is: " + fruit[i]);
        //    }
        //}
        static void Main(string[] args)
        {
            int counter = 1;
            int max = 10;

            while (counter <= max)
            {
                Console.WriteLine("Loop number: " + counter);
                counter++;
            }
        }
    }
}
