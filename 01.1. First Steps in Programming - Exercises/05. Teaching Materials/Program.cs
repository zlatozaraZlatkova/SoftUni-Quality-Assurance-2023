namespace _05._Teaching_Materials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int boardCleaner = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double pricePen = pens * 5.80;
            double priceMarkers = markers * 7.20;
            double priceBoardCleaner = boardCleaner * 1.20;

            double sum = pricePen + priceMarkers + priceBoardCleaner;

            double totalDiscountSum = (sum * discount) /100;
            double total = sum - totalDiscountSum;

            Console.WriteLine(total);


        }
    }
}