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

            #region Delegate1 Exercises 4-7
            #endregion

            #region Delegate1 Exercises 8-9
            #endregion

            #region Delegate1 Exercises 10-11
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


