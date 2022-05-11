using System;

namespace MyDelegate1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[] numbers = new int[20]; //1
            string[] citeis = new string[20]; //2
            var names = "Gävle, Stockholm, Malmö, Umeå, Piteå, Göteborg, Öland".Split(",");
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(100, 1000 + 1);
                citeis[i] = names[rand.Next(0, names.Length)].Trim();
            }
            Ex3(numbers, citeis); //3

            Array.ForEach(numbers, Ex4); //4 with Delegate
            Array.ForEach(citeis, Ex5); //5 With Delegate

            Array.ForEach(numbers, x => System.Console.WriteLine(x)); // 4 with Lambda
            Array.ForEach(citeis, c => System.Console.WriteLine(c)); // 5 with Lambda

            var evens = Array.FindAll(numbers, n => n% 2 == 0);// 8
            Array.ForEach(evens, e => System.Console.WriteLine("Even numbers " + e));

            var longCities = Array.FindAll(citeis, c => c.Length > 5);// 9
            Array.ForEach(longCities, x => System.Console.WriteLine("LongNames " + x));

            System.Console.WriteLine(Array.FindLast(citeis, c => c.Length > 8));// 11


            int sum = 0;
            Array.ForEach(numbers, n => sum += n);// 12
            System.Console.WriteLine($"the sum of all numbers are {sum}");
        }



        static void Ex5(string name) => System.Console.WriteLine(name);
        static void Ex4(int item) => System.Console.WriteLine(item);

        static void Ex3(int[] numbers, string[]cities) //3
        {
            foreach (var item in numbers)
            {
                System.Console.WriteLine(item);
            }
            foreach (var item in cities)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}