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

            int[] myArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var newArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */

            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            var evensList = new List<int>();
            var oddsList = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            //myArray; odds/evens example
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] % 2 == 0)
                {
                    evens.Add(myArray[i]);
                }
                else
                {
                    odds.Add(myArray[i]);
                }
            }

            //newArray; evensList/oddsList example
            for (int i = 0; i < newArray.Length; i++)
            {
                if (newArray[i] % 2 == 0)
                {
                    evensList.Add(newArray[i]);
                }
                else
                {
                    oddsList.Add(newArray[i]);
                }
            }

            //myArray; odds/evens example
            foreach (int i in myArray)
            {
                if (i % 2 == 0)
                {
                    evens.Add(i);
                }
                else
                {
                    odds.Add(i);
                }
            }

            //newArray; evensList/oddsList example
            foreach (int i in newArray)
            {
                if (i % 2 == 0)
                {
                    evensList.Add(i);
                }
                else
                {
                    oddsList.Add(i);
                }
            }

            /* Now using foreach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */

            //myArray; odds/evens example
            for (int i = 0; i < odds.Count; i++)
            {
                Console.WriteLine(odds[i]);
            }
            for (int i = 0; i < evens.Count; i++)
            {
                Console.WriteLine(evens[i]);
            }

            //newArray; evensList/oddsList example
            for (int i = 0; i<oddsList.Count; i++)
            {
                Console.WriteLine(oddsList[i]);
            }
            for (int i = 0; i<evensList.Count; i++)
            {
                Console.WriteLine(evensList[i]);
            }

            //myArray; odds/evens example
            foreach (var item in evens)
            {
                Console.WriteLine($"{item} is an even number");
            }
            foreach (var item in odds)
            {
                Console.WriteLine($"{item} is an odd number");
            }

            //newArray; evensList/oddsList example
            foreach (var item in evensList)
            {
                Console.WriteLine($"{item} is an even number");
            }
            foreach (var item in oddsList)
            {
                Console.WriteLine($"{item} is an odd number");
            }
        }
    }
}
