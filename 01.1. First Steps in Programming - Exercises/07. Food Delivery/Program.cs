namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int veganMenus = int.Parse(Console.ReadLine());

            double chickenMenusPrice = chickenMenus * 10.35;
            double fishMenusPrice = fishMenus * 12.40;
            double veganMenusPrice = veganMenus * 8.15;

            double totalExcDelivery = chickenMenusPrice + fishMenusPrice + veganMenusPrice;
            double dessertPrice = totalExcDelivery * 0.20;

            double deliveryCost = 2.50;

            double totalSum = totalExcDelivery + dessertPrice + deliveryCost;

            Console.WriteLine(totalSum);

        }
    }
}