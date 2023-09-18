namespace _01._Console_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            double exchangeRate = 1.79549;
            double convertToBGN = usd * exchangeRate;
            Console.WriteLine(convertToBGN);
        }
    }
}