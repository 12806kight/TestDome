using System;

class MalwareAnalysis
{
    public static int[] Simulate(int[] entries)
    {
        for (int i = 1; i < entries.Length; i++)
        {
            entries[i] = i + 2;
        }
        return entries;
    }

    public static void Main(string[] args)
    {
        int[] records = new int[] { 1, 2, 0, 5, 0, 2, 4, 3, 3, 3 };
        var result = Simulate(records);
        Console.WriteLine(string.Join(", ", result));
    }
}