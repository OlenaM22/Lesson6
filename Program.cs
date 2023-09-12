using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(MaxValue(1, 2, 3, 4, 5));  
        Console.WriteLine(MaxValue(10, 20, 30));     
    }

    public static int MaxValue(params int[] numbers)
    {
        return numbers.Max();
    }
}