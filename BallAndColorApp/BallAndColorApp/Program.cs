using System;
using System.Drawing;

namespace BallAndColorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Ball and Color Application!");

            // Create a few Color objects
            Color redColor = new Color(255, 0, 0);
            Color greenColor = new Color(0, 255, 0, 200);

            // Create Ball objects
            Ball redBall = new Ball(10, redColor);
            Ball greenBall = new Ball(15, greenColor);

            // Throw the balls a few times
            redBall.Throw();
            redBall.Throw();
            greenBall.Throw();

            Console.WriteLine($"Red Ball thrown count: {redBall.GetThrowCount()}");
            Console.WriteLine($"Green Ball thrown count: {greenBall.GetThrowCount()}");

            // Pop the red ball
            redBall.Pop();
            Console.WriteLine("Red Ball popped!");

            // Try to throw the popped ball
            redBall.Throw();

            Console.WriteLine($"Red Ball thrown count after popping: {redBall.GetThrowCount()}");

            // Print grayscale value of the colors
            Console.WriteLine($"Red Ball color grayscale value: {redBall.Color.GetGrayscale()}");
            Console.WriteLine($"Green Ball color grayscale value: {greenBall.Color.GetGrayscale()}");
        }
    }
}
