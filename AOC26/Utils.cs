namespace AOC26;

public static class Utils
{
    public static string[] ReadInput(int day)
    {
        var path = $"Inputs/day{day:00}.txt";
        return File.ReadAllLines(path);
    }

    public static string ReadInputRaw(int day)
    {
        var path = $"Inputs/day{day:00}.txt";
        return File.ReadAllText(path);
    }
}