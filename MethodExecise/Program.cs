using System;

namespace MethodExecise
{
    class Program
    {

        public static int Sum(int num1, int num2)

{
    var answer = num1 + num2;
    return answer;
}


        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        static void Main(string[] args)
        {
            // ----------------Exercise 2 ---------------
            var amountOfCars = Sum(2, 6);
            var blah = Multiply(60, 2, 4);

            // ----------------Exercise 1 ---------------
            // Name: Michael
            // color:blue
            // animal: Walrus   
            // Band: The Beatles

            Console.WriteLine("Hello, What is your first name ?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}, What is your favolrite colour ?");
            var color = Console.ReadLine();

            Console.WriteLine($" {color} is awesome color! What's your favourite animal ?");
            var animal = Console.ReadLine();

            Console.WriteLine("Great, What is your favorite band ?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks {userName} ! Here is your profile.");
            Console.WriteLine("----------------------------------------");


            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");

        }
    }
}
