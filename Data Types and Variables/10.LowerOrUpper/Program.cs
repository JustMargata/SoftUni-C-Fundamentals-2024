﻿namespace _10.LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine());

            if (Char.IsUpper(input))
            {
                Console.WriteLine("upper-case");
            }
            else if (Char.IsLower(input))
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
