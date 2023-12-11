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
                    puzzle = new Day01();
                    break;
                case "2":
                    puzzle = new Day02();
                    break;
                case "3":
                    puzzle = new Day03();
                    break;
                case "4":
                    puzzle = new Day04();
                    break;
                case "5":
                    puzzle = new Day05();
                    break;
                case "6":
                    puzzle = new Day06();
                    break;
                case "7":
                    puzzle = new Day07();
                    break;
                case "8":
                    puzzle = new Day08();
                    break;
                case "9":
                    puzzle = new Day09();
                    break;
                default:
                    Console.WriteLine("No puzzle solution has been created for day " + dayNo);
                    break;
            }
        }
    }
}
