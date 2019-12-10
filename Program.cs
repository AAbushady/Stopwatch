﻿using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            Console.WriteLine("Welcome to Stopwatch!");

            while (true)
            {
                Console.WriteLine("Press any key to begin the stopwatch.");

                Console.ReadKey(true);
                stopwatch.Start();

                Console.WriteLine("Press any key to stop the stopwatch.");

                Console.ReadKey(true);

                Console.WriteLine("{0} has elapsed.", stopwatch.Stop());

                Console.WriteLine("Would you like to use the stop watch again?");
                Console.Write("Type \"Quit\" to quit or press enter to use the stopwatch again: ");
                var input = Console.ReadLine();

                if (input.ToLower() == "quit") { break; }

                Console.Clear();
            }
        }
    }
}