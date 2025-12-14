using AOC.Solutions;

class Program
{
    static void Main(string[] args)
    {
        var day = args.Length > 0 ? int.Parse(args[0]) : 1;

        Console.WriteLine($"Running day {day}...");

        var solver = day switch
        {
            //1 => new Day01(),
            //2 => new Day02(),
            //3 => new Day03(),
            //4 => new Day04(),
            //5 => new Day05(),
            //6 => new Day06(),
             7 => new Day07(),
            // 8 => new Day08(),
            // 9 => new Day09(),
            // 10 => new Day10(),
            // 11 => new Day11(),
            // 12 => new Day12(),
            _ => throw new Exception("Day not implemented")
        };

        Console.WriteLine("Part 1: " + solver.Part1());
        Console.WriteLine("Part 2: " + solver.Part2());
    }
}