using System;
using System.Collections.Generic;
namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foeach or for loops,<----- what's a (foeach)????
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            var numbers = new int[] { 10, 11, 20, 23, 30, 40, 47, 50, 60, 70, 80, 371, 90, 374 };
            var evens = new List<int>();
            var odds = new List<int>();
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                    // Console.WriteLine(evens);
                }
                else
                {
                    odds.Add(num);
                    //Console.WriteLine(odds);
                }
            }
            foreach (var num in evens)
            {
                Console.WriteLine($"these numbers are even: {num}");

            }
            foreach (var num in odds)
            {
                Console.WriteLine($"these numbers are odd: {num}");
            }
        }

    }
}
