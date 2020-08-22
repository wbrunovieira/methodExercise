using System;

namespace MethodExecise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, What is your first name ?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}, What is your favolrite colour ?");
            var color = Console.ReadLine();

            Console.WriteLine($" {color} is awesome color! What's your favourite animal ?");
            var animal = Console.ReadLine();

            Console.WriteLine("Great, What is your favorite band ?");
            var band = Console.ReadLine();
        }
    }
}
