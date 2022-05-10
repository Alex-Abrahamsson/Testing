using System;
using System.Collections.Generic;

namespace Lambda0
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercises 1-3
            int[] numbers = new int[20];
            string[] cities = new string[20];

            //Random Initialization
            var rnd = new Random();
            var names = "Stockholm, Copenhagen, Oslo, Helsinki, Berlin, Madrid, Lissabon".Split(',');
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(100, 1000 + 1);
                cities[i] = names[rnd.Next(0, names.Length)].Trim();
            }

            WriteLists(numbers, cities);
            #endregion

            #region Lambda Exercises 4-7
            Console.WriteLine("Delegates I Exercises");
            Console.WriteLine($"\n{nameof(numbers)} output by Lambda");
            Array.ForEach(numbers, myInt => Console.WriteLine(myInt));


            Console.WriteLine($"\n{nameof(cities)} output by Lambda");
            Array.ForEach(cities, (string myString) =>
            {
                Console.WriteLine(myString);
            });

            #endregion

            #region Lambda Exercises 8-9
            Console.WriteLine("\nLambda II Exercises");
            var evenlist = Array.FindAll(numbers, item => item % 2 == 0);
            Array.ForEach(evenlist, item => Console.WriteLine(item));

            Console.WriteLine();
            Array.ForEach(
                Array.FindAll(cities, (string item) => item.Length > 6),
                item => Console.WriteLine(item));
            #endregion

            #region Lambda Exercises 10-11
            Console.WriteLine("\nLambda III Exercises");
            Console.WriteLine(Array.Find(numbers, (int item) => item > 500));
            Console.WriteLine(Array.FindLast(cities, (string item) => item.Length > 8));

            var list = Array.FindAll(numbers, (int item) => item > 500);
            Console.WriteLine(list);
            #endregion

        }

        #region Delegate1 Exercises 1-3
        static void WriteLists(int[] _numbers, string[] _cities)
        {

            Console.WriteLine($"{nameof(_numbers)}:");
            foreach (var item in _numbers)
                Console.WriteLine(item);

            Console.WriteLine($"\n{nameof(_cities)}:");
            foreach (var item in _cities)
                Console.WriteLine(item);

        }
        #endregion
    }
}
//Exercises
//Starting point - together
//1.  Redo Exercises from Project Delegate1 using Lambda Expressions in all Array.ForEach(), Array.FindAll(),
//    Array.Find(), Array.FindLast()
//2.  Use Array.ForEach() and Lambda (with a captured variable count) to calculate the sum of all the
//    elements in the array numbers


