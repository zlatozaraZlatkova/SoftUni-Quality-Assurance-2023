namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string movieType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double price = 0.00;

            switch (movieType)
            {
                case "Premiere":
                    price = 12.00;
                    break;
                case "Normal":
                    price = 7.50;
                    break;
                case "Discount":
                    price = 5.00;
                    break;

            }

            double totalRevenue = rows * columns * price;

            Console.WriteLine($"{totalRevenue:F2} leva");
        }
    }
}
