using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{   
    class Program
    {
        static void print(string arg)
        {
            Console.WriteLine($"{arg}, this is how you call a method in C#.\n");
        }

        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World!";
            Console.WriteLine($"{hello} {world} My name is Jakob!");
            Console.WriteLine($"The variable {hello} has {hello.Length} letters.");
            Console.WriteLine($"The variable {world} has {world.Length} letters.");

            if (hello.Length <= 5)
            {
                Console.WriteLine("\nThis is in an if statement!");
                Console.WriteLine("Pretty similar to C++, awesome :) \n");
            }

            print("Wow");
        }
    } 
}
