using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create 2 integer variables
            int a = 17;
            int b = 4;

            int sum = a + b;

            int diff = a - b;

            int product = a * b;

            double quotient = a / b;

            int remainder = a % b;

            Console.WriteLine($"{a} + {b} is {sum}");
            Console.WriteLine($"{a} - {b} is {diff}");
            Console.WriteLine($"{a} * {b} is {product}");
            Console.WriteLine($"{a} / {b} is {quotient} remainder is {remainder}");

            Console.WriteLine();
            Console.WriteLine("What is the raidus of your circle?");
            double radius = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * Math.Pow(radius, 2);

            Console.WriteLine($"The Area is: {circleArea}");

            var i = 3;
            var j = 4;
            var k = ++i * j++;

            Console.WriteLine(k); // outputs ?
            Console.WriteLine(j);

















        }
    }
}
