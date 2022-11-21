using System;

public class Startup
{
    public static void Main()
    {
            var element = new Box<string>(Console.ReadLine());
            Console.WriteLine(element);
    }
}

