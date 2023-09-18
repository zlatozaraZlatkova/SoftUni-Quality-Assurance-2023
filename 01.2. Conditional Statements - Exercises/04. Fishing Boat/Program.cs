namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermenCount = int.Parse(Console.ReadLine());

            double costs
                = 0.00;

            switch (season)
            {
                case "Spring": 
                    costs = 3000;
                    break;
                case "Summer":
                case "Autumn": costs = 4200;
                    break;
                case "Winter": costs = 2600; 
                    break;
            }
            if (fishermenCount <= 6)
            {
                costs *= 0.90;
            }
            else if (fishermenCount <= 11)
            {
                costs *= 0.85;
            }
            else if (fishermenCount >= 12)
            {
                costs *= 0.75;
            }

            if (fishermenCount % 2 == 0 && season != "Autumn")
            {
                costs *= 0.95;
            }

            double diff = Math.Abs(budget - costs);

            if (budget >= costs)
            {
                Console.WriteLine($"Yes! You have {diff:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {diff:F2} leva.");
            }
        }
    }
}