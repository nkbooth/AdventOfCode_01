using System.IO;
using System.Collections.Generic;

namespace AdventOfCode_01
{
    class Program
    {
        public static void Main(string[] args)
        {
            string inputFile = "input.txt";
            Elves elflist = new Elves();
            elflist.elves.Add(new Elf());

            Console.WriteLine("Reading input file...");
            string[] lines = elflist.LoadInputFile(inputFile);
            
            
            Console.WriteLine("Parsing input file...");
            elflist.BuildElfList(lines);

            Console.WriteLine("Highest Calories: " + elflist.elves.MaxBy(e => e.TotalCalories).TotalCalories);
            List<int> topThree = elflist.TopThreeCalories;
            
            Console.WriteLine("Top Three Calories: " + topThree[0] + ", " + topThree[1] + ", " + topThree[2]);
            Console.WriteLine("Calories for top 3 elves: " + topThree.Sum());

        }
    }
}