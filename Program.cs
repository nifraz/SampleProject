using System;

namespace sampleproject
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Enter your good name: ");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}. Hi there, and Welcome...");
            Console.WriteLine("This is Nifraz!");
            Console.WriteLine($"5 to the power of 3 is: {GetPow(5, 3)}");
        }

        static double GetPow(int b, int e){
            return Math.Pow(b, e);
        }
    }
}
