using System;

namespace CSharp_Course_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
        static void IncrementDecrement()
        {
            Console.WriteLine("Increments example");
            Console.WriteLine("");

            int x = 1;
            int j = 0;

            Console.WriteLine($"X state is {x}");
            Console.WriteLine($"J state is {j}");
            Console.WriteLine("");
            j = x++;

            Console.WriteLine($"Now J state is {j}");
            Console.WriteLine($"Now X state is {x}");
            Console.WriteLine("");

            j = ++x;
            Console.WriteLine($"And now X state is {x}");
            Console.WriteLine($"And now J state is {j}");
            Console.WriteLine("");
        }
    }
}
