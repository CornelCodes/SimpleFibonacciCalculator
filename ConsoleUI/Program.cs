using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FibonacciLibrary;

namespace ConsoleUI
{
    class Program
    {
        //Write a function that returns the nth number in the fibonacci sequence
        //Fibonacci sequence is constructed by adding the last two numbers of the sequence so far to get the next number in the sequence

        private static bool IsRunning = false;
        private static FibonacciGenerator generator = new FibonacciGenerator(90);

        static void Main(string[] args)
        {
            do
            {
                Start();
            }
            while (IsRunning);

        }

        private static void Start()
        {
            IsRunning = true;
            Console.WriteLine("Enter index to get");
            int index = InputHandler.GetInputAsInt(Console.ReadLine());
            long numberAtIndex = generator.GetNumberAtIndex(index);
            Console.WriteLine($"Fibonacci number at position {index + 1} is {numberAtIndex}");
            Console.WriteLine("Enter another number? \nY/N");
            string input = Console.ReadLine();

            if(input.ToLower() == "n")
            {
                IsRunning = false;
            }
        }
    }
}
