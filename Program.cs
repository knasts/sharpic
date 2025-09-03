// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
    class Program
    {
        static void Hi()
        {
            Console.WriteLine("bye");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("hello, world");
            Console.Write(2 + 2); //4
            Console.WriteLine(" is four");
            Console.Write("age?...");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("age is " + age);
            Console.WriteLine(11 % 5);
            string name = "Jimin";
            string surname = " Park";
            string fullName = name + surname;
            Console.WriteLine("full name " + fullName);
            fullName = $"full name is: {name} {surname}"; //string interpolation
            Console.WriteLine(fullName);
            string text = "we are called \"ARMY\" fandom";
            Console.WriteLine(text);

            int i = 0;
            while(i < 3)
            {
                Console.WriteLine(i);
                i++;
            }

            string[] vibe = new string[] { "books", "coffee", "candles" };
            Array.Sort(vibe);
            foreach (string thing in vibe ) Console.WriteLine(thing);
            Console.WriteLine(vibe.Length);

            int[] nums = {2, 3, 4 };
            Console.WriteLine(nums.Max());
            Console.WriteLine(nums.Sum());

            int[,] numms = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine(numms[1, 2]); // second row (1), third column (2)

            Hi();
        }
    }
}

