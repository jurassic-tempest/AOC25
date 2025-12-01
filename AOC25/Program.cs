using AOC.Solutions;

class Program
{
    static void Main(string[] args)
    {
        var day = args.Length > 0 ? int.Parse(args[0]) : 1;

        Console.WriteLine($"Running day {day}...");

        var solver = day switch
        {
            1 => new Day01(),
            //2 => new Day02(),
            _ => throw new Exception("Day not implemented")
        };

        Console.WriteLine("Part 1: " + solver.Part1());
        //Console.WriteLine("Part 2: " + solver.Part2());
    }
}