using System;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine().Split();
        var name = $"{input[0]} {input[1]}";
        var address = input[2];

        Console.WriteLine(new Tuple<string, string>(name, address));

        input = Console.ReadLine().Split();
        name = input[0];
        var liters = int.Parse(input[1]);

        Console.WriteLine(new Tuple<string, int>(name, liters));

        input = Console.ReadLine().Split();
        var integer = int.Parse(input[0]);
        var double_value = double.Parse(input[1]);

        Console.WriteLine(new Tuple<int, double>(integer, double_value));
    }
}
