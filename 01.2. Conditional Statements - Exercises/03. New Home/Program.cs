namespace _03._New_Home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double result = 0.00;

            switch (flowers) 
            {
                case "Roses": result = count * 5.00;
                    if (count > 80)
                    {
                        result *= 0.90;
                    }
                    break;
                case "Dahlias": result = count * 3.80;
                    if (count > 90)
                    {
                        result *= 0.85;
                    }
                    break;
                case "Tulips": result = count * 2.80;
                    if (count > 80)
                    {
                        result *= 0.85;
                    }
                    break;
                case "Narcissus": result = count * 3.00;
                    if (count < 120)
                    {
                        result *= 1.15;
                    }
                    break;
                case "Gladiolus": result = count * 2.50;
                    if (count < 80)
                    {
                        result *= 1.2;
                    }
                    break;
            }

            double diff = Math.Abs(budget - result);

            if (budget >= result)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {flowers} and {diff:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {diff:F2} leva more.");
            }


        }
    }
}