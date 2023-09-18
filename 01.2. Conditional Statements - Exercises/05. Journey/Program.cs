namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double costs = budget;
            string destination = "";
            string holidayType = "";


            switch (season)
            {
                case "summer":
                    if (budget <= 100)
                    {
                        costs *= 0.30;
                        destination = "Bulgaria";
                        holidayType = "Camp";

                    } else if (budget <= 1000)
                    {
                        costs *= 0.40;
                        destination = "Balkans";
                        holidayType = "Camp";
                    }
                    else
                    {
                        costs *= 0.90;
                        destination = "Europe";
                        holidayType = "Hotel";
                    }

                    break;
                case "winter":
                    if (budget <= 100)
                    {
                        costs *= 0.70;
                        destination = "Bulgaria";
                        holidayType = "Hotel";

                    }
                    else if (budget <= 1000)
                    {
                        costs *= 0.80;
                        destination = "Balkans";
                        holidayType = "Hotel";
                    }
                    else
                    {
                        costs *= 0.90;
                        destination = "Europe";
                        holidayType = "Hotel";
                    }
                    break;

            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{holidayType} - {costs:F2}");

        }
    }
}