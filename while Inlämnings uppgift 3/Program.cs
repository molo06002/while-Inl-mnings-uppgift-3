// See https://aka.ms/new-console-template for more information
using System;
namespace while_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 0;
            while (max < 100)
            {
                max++;
                Console.WriteLine(max);
                if (max % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                if (max % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                if (max % 5 == 0 &&  max % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
            }
        }
    }
}