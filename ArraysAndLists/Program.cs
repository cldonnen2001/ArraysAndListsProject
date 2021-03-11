using System;
using System.Collections.Generic;  //  list will not work without adding this

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
           var numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Array list numbers:");
            foreach (var i in numbers)
            {
                Console.WriteLine($"{i}");
            }

            Console.WriteLine("");  // adds space after arry list of numbers

                 // Create two Lists of type int.
                 // * Name one List "evens"
                 // * Name the other List "odds"

            var evens = new List<int>();
            var odds = new List<int>();

                 //Using either a foreach or for loop,
                 //*nest an if statement to check to see
                 // *  if a number is even or odd.
                 // * Then add those numbers to either the evens List
                 //  *or the odds List

            for (int i = 2; i < 10; i += 2)
            {
                evens.Add(i);
            }

            for (int i = 1; i < 10; i += 2)
            {
                odds.Add(i);
            }
                  //* Now using foeach or for loops,
                  //  * display each List of even and odd numbers
                  //   * Try to be creative in your display
           
            Console.WriteLine("Here are the Even Numbers: ");
                foreach (var num in evens)
                {
                  Console.WriteLine(num);
                }

            Console.WriteLine(""); // adds space after evens list of numbers

            Console.WriteLine("The remaining are the Odd Numbers: ");
               foreach (var num in odds)
               {
                Console.WriteLine(num);
               }


        // other stuffs

            //Console.WriteLine("Array1 list: ");

            //int[] array1 = { 11, 12, 13, 14, 15 };
            //foreach (var item in array1)
            //{
            //    Console.WriteLine(item);
            //}

            //var evenNumbers = new List<int>();
            //var oddsNumbers = new List<int>();

            //Console.WriteLine("Here are the Even Numbers: ");
            //foreach (int i in evenNumbers)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine($"{i}");
            //    }
            //}

            //Console.WriteLine("The remaining are the Odd Numbers: ");
            //foreach (int i in oddsNumbers)
            //{
            //    if (i % 2 == 1)
            //    {
            //        Console.WriteLine($"{i}");
            //    }
           // }
        }


    }
}
