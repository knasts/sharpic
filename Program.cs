// See https://aka.ms/new-console-template for more information
using System;

namespace HelloWorld
{
    class Program
    {
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
        }
    }
}

