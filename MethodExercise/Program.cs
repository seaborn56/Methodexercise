﻿using System;

namespace MethodExercise
{
    class Program
    {
        static void Main(string[] args)
        {
        //Name: Cole
        //Favorite Color: Blue
        //Favorite Animal: Dog
        //Favorite Band: Coldplay

            Console.WriteLine("Hello - What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName} What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($" {color} is an awesome color. What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"Great! Now, what is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks, {userName}; Here is your profile");

            Console.WriteLine($"Name: {userName}");
            Console.WriteLine($"Favorite Color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");


        }
    }
}
