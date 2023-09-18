﻿using System.Transactions;

namespace _09._Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double capacity = length * width * height;
            double liters = capacity / 1000;
            double occupied = percentage / 100;

            double litersNeeded = liters * (1 - occupied);

            Console.WriteLine($"{litersNeeded:F2}");
           
        }
    }
}