﻿using System;

namespace sampleproject
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}.");
        }
    }
}