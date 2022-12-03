namespace AdventOfCode_01
{
    class Elf
    {
        public List<int> Calories = new List<int>();
        public int TotalCalories
        {
            get
            {
                int total = 0;
                foreach (int calorie in Calories)
                {
                    total += calorie;
                }
                return total;
            }
        }
    }
}