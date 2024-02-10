using System;

class MalwareAnalysis
{
    public static int[] Simulate(int[] entries)
    {
        return entries;
    }

    public static void Main(string[] args)
    {
        int[] records = new int[] { 1, 2, 0, 5, 0, 2, 4, 3, 3, 3 };
        var result = Simulate(records);
        Console.WriteLine(string.Join(", ", result));
    }
}