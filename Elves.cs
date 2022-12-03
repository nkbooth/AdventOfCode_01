namespace AdventOfCode_01
{
    class Elves
    {
        public List<Elf> elves = new List<Elf>();

        public string[] LoadInputFile(string filename)
        {
            return File.ReadAllLines(filename);
        }

        public void BuildElfList(string[] lines)
        {
            foreach (string line in lines)
            {
                if (line == "")
                {
                    Console.WriteLine(string.Format("Finished elf {0} with {1} total calories", elves.Count, elves.Last().TotalCalories));
                    elves.Add(new Elf());
                    Console.WriteLine(string.Format("Added new elf #{0}", elves.Count));
                } else
                {
                    if(elves.Count == 1)
                    {
                        elves[0].Calories.Add(int.Parse(line));
                    } else
                    {
                        elves[elves.Count - 1].Calories.Add(int.Parse(line));
                    }
                }
            }
        }
        public List<int> TopThreeCalories
        {
            get
            {
                List<int> topThree = new List<int>();
                foreach (Elf elf in elves)
                {
                    topThree.Add(elf.TotalCalories);
                }
                return topThree.OrderByDescending(x => x).Take(3).ToList();
            }
        }
    }
}