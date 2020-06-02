using System;

namespace Lesson2Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the circle radius.");
            string userInput1 = Console.ReadLine();
            double radius = double.Parse(userInput1);
            double pi = MathF.PI;
            double radiusP = Math.Pow(radius, 2);
            double area = pi * radiusP;
            double circumference = 2 * pi * radius;
            double diameter = 2 * radius;
            Console.WriteLine($"The area of the circle of radius {radius} is: {area}.");
            Console.WriteLine($"The circumference of the circle is {circumference}, the diameter of the circle is {diameter}");
            Console.WriteLine("Please enter your mpg.");
            string userInput2= Console.ReadLine();
            int mpg = int.Parse(userInput2);
            double gasGoRound = circumference / mpg;
            Console.WriteLine($"You will use {gasGoRound} gallons of gas to go around the circle.");


        }
    }
}
