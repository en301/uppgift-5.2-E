using System;

namespace uppgift_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[3] { 1, 2, 0 };
            Console.WriteLine("Skriv in ett tal");
            tal[2] = int.Parse(Console.ReadLine());
            Console.WriteLine(tal[0] +" " + tal[1] +" " + tal[2]);
            Console.ReadKey();
        }
    }
}