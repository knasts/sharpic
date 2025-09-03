// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
    class Program
    {
        static void Name()
        {
            string name = "Jimin";
            string surname = " Park";
            string fullName = name + surname;
            Console.WriteLine("full name " + fullName);
            fullName = $"full name is: {name} {surname}"; //string interpolation
            Console.WriteLine(fullName);
            string text = "we are called \"ARMY\" fandom";
            Console.WriteLine(text);
        }

        static void Loop(int i)
        {
            while (i < 3)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        static void Age()
        {
            Console.Write(2 + 2); //4
            Console.WriteLine(" is four");
            Console.Write("age?...");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("age is " + age);
        }

        static void Hi(string str)
        {
            Console.WriteLine(str);
        }

        static void Arrays()
        {
            string[] vibe = new string[] { "books", "coffee", "candles" };
            Array.Sort(vibe);
            foreach (string thing in vibe) Console.WriteLine(thing);
            Console.WriteLine(vibe.Length);

            int[] nums = { 2, 3, 4 };
            Console.WriteLine(nums.Max());
            Console.WriteLine(nums.Sum());

            int[,] numms = { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine(numms[1, 2]); // second row (1), third column (2)
        }

        static void Country(string str = "Australia") //default parameter value
        {
            Console.WriteLine(str);
        }

        static void Children(string child1, string child2)
        {
            Console.WriteLine("the youngest child is " + child2);
        }

        static void Main(string[] args)
        {
            Name();
            Loop(3);
            Age();
            
            Arrays(); 

            Hi("bye");

            Country("Ukraine");
            Country(); // will print Australia

            Children(child1: "John", child2: "Bob"); //named arguments
        }
    }
}

