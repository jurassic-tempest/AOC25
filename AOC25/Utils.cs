namespace AOC25;

public static class Utils
{
    public static string[] ReadInput(int day)
    {
        var path = $"Inputs/day{day:00}.txt";
        return File.ReadAllLines(path);
    }

    public static string? ReadLastLine(int day)
    {
        var path = $"Inputs/day{day:00}.txt";
        return File.ReadLines(path).LastOrDefault();
    }

    public static int GetLinesCount(int day)
    {
        var path = $"Inputs/day{day:00}.txt";
        return File.ReadLines(path).Count();
    }

    public static string ReadInputRaw(int day)
    {
        var path = $"Inputs/day{day:00}.txt";
        return File.ReadAllText(path);
    }
}