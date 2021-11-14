using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Addition objAddition = new Addition();
            var result = objAddition.Sum(10, 20);
            Console.WriteLine(result);
        }
    }
}
