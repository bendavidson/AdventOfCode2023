﻿using static System.Net.Mime.MediaTypeNames;

namespace AdventOfCode2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day you are solving");
            var dayNo = Console.ReadLine();
            Console.WriteLine("You are solving puzzles from day " +  dayNo);
            IPuzzle puzzle;
            
            switch (dayNo)
            {
                case "1":
                    puzzle = new Day1();
                    break;
                case "2":
                    puzzle = new Day2();
                    break;
                default:
                    Console.WriteLine("No puzzle solution has been created for day" + dayNo);
                    break;
            }
        }
    }
}
