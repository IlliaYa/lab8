using System;
using System.Linq;

public class Program
{
    public static void Main()
    {
        var the_List = new Box<string>();

        var count = int.Parse(Console.ReadLine());
        for (int i = 0; i < count; i++)
        {
            var input = Console.ReadLine();
            the_List.Add(input);
        }

        var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
        the_List.Swap(indexes[0], indexes[1]);

        Console.WriteLine(the_List);
    }
}

