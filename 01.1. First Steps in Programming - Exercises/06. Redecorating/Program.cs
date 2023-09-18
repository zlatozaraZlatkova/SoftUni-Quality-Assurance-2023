namespace _06._Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylonInM = int.Parse(Console.ReadLine());
            int paintInLiter = int.Parse(Console.ReadLine());
            int thinnerInLitter = int.Parse(Console.ReadLine());
            int craftsmanHrs = int.Parse(Console.ReadLine());

            double priceNylon = (nylonInM + 2) * 1.50;
            double pricePaint = paintInLiter * 14.50;
            double priceThinner = thinnerInLitter * 5.00;

            double sumMaterials = priceNylon + (pricePaint + (pricePaint * 0.1)) + priceThinner + 0.40;
            double sumCraftsmen = craftsmanHrs * (sumMaterials * 0.3);
            double totalSum = sumMaterials + sumCraftsmen;

            Console.WriteLine(totalSum);

        }
    }
}