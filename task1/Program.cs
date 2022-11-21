using System;

public class Startup
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var element = new Box<string>(Console.ReadLine());
            Console.WriteLine(element);
        }
    }
}