﻿namespace _10._Day_of_the_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string result = "";
            switch(day)
            {
                case 1: result = "Monday";
                    break;
                case 2: result = "Tuesday";
                    break;
                case 3: result = "Wednesday";
                    break;
                case 4: result = "Thursday";
                    break;
                case 5: result = "Friday";
                    break;
                case 6: result = "Saturday";
                    break;
                case 7: result = "Sunday";
                    break;
                default: result = "Error";
                    break;
            }
            Console.WriteLine(result);
        }
    }
}